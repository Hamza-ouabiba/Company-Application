using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace RNetApp
{
    public partial class ModificationPrixArticle : Form
    {
        public ModificationPrixArticle()
        {
            InitializeComponent();
        }
        AdoNet ado = new AdoNet();
        List<TextBox> list = new List<TextBox>();
        private void fillCombo()
        {
            comboClt.DataSource = ado.Ds.Tables["client"];
            comboClt.DisplayMember = ado.Ds.Tables["client"].Columns["nom"].ToString();
            comboClt.ValueMember = ado.Ds.Tables["client"].Columns["idclient"].ToString();
        }
        List<TextBox> GetTextBoxes()
        {
            List<TextBox> list = new List<TextBox>();
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    list.Add((TextBox)control);
                }
            }
            return list;
        }
        private bool chercherClientFature(Guid idclient)
        {
            foreach (DataRow dr in ado.Ds.Tables["changer"].Rows)
            {
                if (Guid.Parse(dr["idclient"].ToString()) == idclient)
                {
                    return true;
                }
            }
            return false;
        }
        private void ModificationPrixArticle_Load(object sender, EventArgs e)
        {
           try
            {
                //fill the dataset : 
                int nombre = 0;
                ado.Cmd.CommandText = "PrixMod";
                ado.Cmd.CommandType = CommandType.StoredProcedure;
                ado.Cmd.Connection = ado.Connection;
                ado.Adapter.SelectCommand = ado.Cmd;
                ado.Adapter.Fill(ado.Ds);
                //name each datatable : 
                ado.Ds.Tables[0].TableName = "changer";
                ado.Ds.Tables[1].TableName = "client";
                ado.Ds.Tables[2].TableName = "article";
                list = GetTextBoxes();
                //fill combo
                fillCombo();
                while (nombre != 35)
                {
                    foreach (var te in list)
                    {
                        te.PlaceholderText = ado.Ds.Tables["article"].Rows[nombre]["designation"].ToString();
                        nombre++;
                    }
                }
            } catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }

        private void enreBtn_Click_1(object sender, EventArgs e)
        {
            SqlCommandBuilder sql = new SqlCommandBuilder(ado.Adapter);
            try
            {
                if (!chercherClientFature(Guid.Parse(comboClt.SelectedValue.ToString())))
                {
                    foreach (var te in list)
                    {

                        DataRow dr = ado.Ds.Tables["changer"].NewRow();
                        dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                        dr[0] = te.PlaceholderText;
                        dr[2] = int.Parse(te.Text);
                        ado.Ds.Tables["changer"].Rows.Add(dr);
                    }
                    //mise a jour de la base de donnée : 
                    sql.GetInsertCommand();
                    ado.Adapter.Update(ado.Ds.Tables["changer"]);
                    MessageBox.Show("Prix Insérée avec succées");
                }
                else
                {
                    if (Shared.showMessage("vous avez deja fixé les prix pour ce client Souhaitez Vous changer les anciens prix de ce client", ""))
                    {
                        foreach (DataRow row in ado.Ds.Tables["changer"].Rows)
                        {
                            if (Guid.Parse(row["idclient"].ToString()) == Guid.Parse(comboClt.SelectedValue.ToString()))
                            {
                                row.Delete();
                            }
                        }
                        //update database : 
                        ado.Adapter.Update(ado.Ds.Tables["changer"]);
                        MessageBox.Show("Vous pouvez maintenant inserez des nouveau prix : ");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
