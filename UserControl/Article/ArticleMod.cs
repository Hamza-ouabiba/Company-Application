using System;
using System.Data;
using System.Data.SqlClient;
namespace RNetApp
{
    public partial class ArticleMod : UserControl
    {
        AdoNet ado = new AdoNet();
        public ArticleMod()
        {
            InitializeComponent();
        }
        private void fillCombo()
        {
            comboClt.DataSource = ado.Ds.Tables["client"];
            comboClt.DisplayMember = ado.Ds.Tables["client"].Columns["nom"].ToString();
            comboClt.ValueMember = ado.Ds.Tables["client"].Columns["idclient"].ToString();
        }
        private void ArticleMod_Load(object sender, EventArgs e)
        {
            //fill the dataset : 
            ado.Cmd.CommandText = "PrixMod";
            ado.Cmd.CommandType = CommandType.StoredProcedure;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);
            //name each datatable : 
            ado.Ds.Tables[0].TableName = "changer";
            ado.Ds.Tables[1].TableName = "client";
            //fill combo
            fillCombo();
        }
        private bool chercherClientFature(Guid idclient)
        {
             foreach(DataRow dr in ado.Ds.Tables["changer"].Rows)
            {
                if(Guid.Parse(dr["idclient"].ToString()) == idclient)
                {
                    return true;
                }
            }
            return false;
        }
        private void enreBtn_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder sql = new SqlCommandBuilder(ado.Adapter);
            try
            {
                if (!chercherClientFature(Guid.Parse(comboClt.SelectedValue.ToString())))
                {
                    DataRow dr = ado.Ds.Tables["changer"].NewRow();
                    //insertion des 35 lignes dans la dataTable changer  :
                    //insertion des 35
                    //lignes dans la dataTable changer  :
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "draps_double";
                    dr[2] = int.Parse(textBox1.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "housse_couette_pm";
                    dr[2] = int.Parse(textBox2.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "housse_couette_gm";
                    dr[2] = int.Parse(textBox3.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "draps_housse_pm";
                    dr[2] = int.Parse(textBox4.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "draps_housse_gm";
                    dr[2] = int.Parse(textBox5.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "taie_oreiller_pm";
                    dr[2] = int.Parse(textBox6.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "taie_oreiller_gm";
                    dr[2] = int.Parse(textBox7.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "serviette_eponge";
                    dr[2] = int.Parse(textBox8.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "draps_bain";
                    dr[2] = int.Parse(textBox9.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "serviette_piscine";
                    dr[2] = int.Parse(textBox10.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "tapis_sol";
                    dr[2] = int.Parse(textBox11.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "draps_simple";
                    dr[2] = int.Parse(textBox12.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "tapis_bain";
                    dr[2] = int.Parse(textBox13.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "peignoir";
                    dr[2] = int.Parse(textBox14.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "oreiller";
                    dr[2] = int.Parse(textBox15.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "serviette_toilette_spa";
                    dr[2] = int.Parse(textBox16.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "aleze";
                    dr[2] = int.Parse(textBox17.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "draps_bain_spa";
                    dr[2] = int.Parse(textBox18.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "tapis_m2";
                    dr[2] = int.Parse(textBox19.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "serviette_table";
                    dr[2] = int.Parse(textBox20.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "rideau_gm_m2";
                    dr[2] = int.Parse(textBox21.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "housse_coussin_pm";
                    dr[2] = int.Parse(textBox22.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "housse_coussin_gm";
                    dr[2] = int.Parse(textBox23.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "taie_kiria";
                    dr[2] = int.Parse(textBox24.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "housse_canape";
                    dr[2] = int.Parse(textBox25.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "devant";
                    dr[2] = int.Parse(textBox26.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "chemin_table";
                    dr[2] = int.Parse(textBox27.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "nappe";
                    dr[2] = int.Parse(textBox28.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "chemin_lit";
                    dr[2] = int.Parse(textBox29.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "fouteille";
                    dr[2] = int.Parse(textBox30.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "matlant";
                    dr[2] = int.Parse(textBox31.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "torchon";
                    dr[2] = int.Parse(textBox32.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "couverture";
                    dr[2] = int.Parse(textBox33.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "couette";
                    dr[2] = int.Parse(textBox34.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    dr = ado.Ds.Tables["changer"].NewRow();
                    dr[1] = Guid.Parse(comboClt.SelectedValue.ToString());
                    dr[0] = "lavette";
                    dr[2] = int.Parse(textBox35.Text);
                    ado.Ds.Tables["changer"].Rows.Add(dr);
                    //mise a jour de la base de donnée : 
                    sql.GetInsertCommand();
                    ado.Adapter.Update(ado.Ds.Tables["changer"]);
                    MessageBox.Show("Prix Insérée avec succées");
                }
                else
                {
                    if(Shared.showMessage("vous avez deja fixé les prix pour ce client Souhaitez Vous changer les anciens prix de ce client", ""))
                    {
                        foreach(DataRow row in ado.Ds.Tables["changer"].Rows)
                        {
                            row.Delete();
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
