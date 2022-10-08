using System;
using System.Data;
using System.Windows.Forms;
using RNetApp.Forms;
using System.Data.SqlClient;
namespace RNetApp.Forms
{
    public partial class FactureForm : Form
    {
        private decimal[] prix = new decimal[35];
        private Guid idClient;
        private int idFacture;
        private int position;
        private string nameClient;
        decimal total = 0;
        List<TextBox> list;
        public FactureForm()
        {
            InitializeComponent();
        }
        AdoNet ado = new AdoNet();
        public Guid IdClient { get => idClient; set => idClient = value; }
        public string NameClient { get => nameClient; set => nameClient = value; }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ajustementEcran()
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }
        private void loadData()
        {
            ado.Cmd.CommandText = $"Select * from FACTURE where idClient = '{IdClient}' and fac_n_o = {0};select * from article";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);
            ado.Ds.Tables[0].TableName = "Facture";
            ado.Ds.Tables[1].TableName = "Article";
        }
        List<TextBox> GetTextBoxes()
        {
            List<TextBox> list = new List<TextBox>();
            foreach (Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    list.Add((TextBox)control);
                }
            }
            return list;
        }
        private void FactureForm_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int nombre = 0;
            ajustementEcran();
            loadData();
            list = GetTextBoxes();
            nomCl.Text = nameClient;
            idFacture = int.Parse(ado.Ds.Tables["FACTURE"].Rows[0]["idFacture"].ToString());
            dateNow.Text = $"{date.Day}/{date.Month}/{date.Year}";
            facturNum.Text = $"{ado.Ds.Tables["FACTURE"].Rows[0]["idFacture"].ToString()}/{date.Year}";
                   
            while(nombre != 35)
            {
                foreach (var te in list)
                {
                    te.PlaceholderText = ado.Ds.Tables["article"].Rows[nombre]["designation"].ToString();
                    nombre++;
                }
            }
            tva.Text = $"{20}";
        
        }
        private bool verificationClientPrix(DataSet ds,Guid idclient)
        {
            foreach(DataRow dr in ds.Tables["changer"].Rows)
            {
                if(Guid.Parse(dr["idclient"].ToString()) == idclient)
                {
                    return true;
                }
            }
            return false;
        }
        private bool testFacture(DataTable dt,int idfacture)
        {
            foreach(DataRow row in dt.Rows)
            {
                if(idfacture == int.Parse(row["idfacture"].ToString()))
                {
                    return true;
                }
            }
            return false;
        }
        private void enregistrer_Click(object sender, EventArgs e)
        {
            AdoNet ado2 = new AdoNet();
            try
            {

                ado2.Cmd.CommandText = $"Select * from changer where IDCLIENT = '{IdClient}'";
                ado2.Cmd.Connection = ado2.Connection;
                ado2.Adapter.SelectCommand = ado2.Cmd;
                ado2.Adapter.Fill(ado2.Ds, "changer");
                
                AdoNet ado3 = new AdoNet();
                SqlCommandBuilder sql = new SqlCommandBuilder(ado3.Adapter);
                ado3.Cmd.CommandText = $"Select * from AVOIR";
                ado3.Cmd.Connection = ado3.Connection;
                ado3.Adapter.SelectCommand = ado3.Cmd;
                ado3.Adapter.Fill(ado3.Ds, "avoir");
                /*decimal.Parse(ado2.Ds.Tables["changer"].Rows[i][2].ToString());*/
                
                if (!testFacture(ado3.Ds.Tables["avoir"], idFacture))
                {
                    for (int i = 0; i < ado2.Ds.Tables["changer"].Rows.Count; i++)
                    {
                        if (ado2.Ds.Tables["changer"].Rows[i]["designation"].ToString() == list[i].PlaceholderText)
                        {
                            DataRow dr = ado3.Ds.Tables["avoir"].NewRow();
                            dr[0] = idFacture;
                            dr[1] = list[i].PlaceholderText;
                            dr[2] = int.Parse(list[i].Text);
                            ado3.Ds.Tables["avoir"].Rows.Add(dr);
                            total += decimal.Parse(list[i].Text) * decimal.Parse(ado2.Ds.Tables["changer"].Rows[i]["prix_unitaire"].ToString());
                        }
                    }
                    //mise a jour de la table facture : 
                   
                    decimal tvaCal = (decimal.Parse(tva.Text) / 100);
                    pht.Visible = tva_.Visible = pttc.Visible = true;
                    pht.Text = $"{total}";
                    tva_.Text = $"{total * tvaCal}";
                    pttc.Text = $"{total + (total * tvaCal)}";
                    sql.GetInsertCommand();
                    ado3.Adapter.Update(ado3.Ds.Tables["avoir"]);
                }
                else
                {
                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(ado3.Adapter);
                    if (Shared.showMessage("Facture deja faite pour ce client souhaitez vous la remodifier ?", ""))
                    {
                        foreach (DataRow dataRow in ado3.Ds.Tables["avoir"].Rows)
                        {
                            if (int.Parse(dataRow["idfacture"].ToString()) == idFacture)
                            {
                                dataRow.Delete();
                            }
                        }
                        sqlCommandBuilder.GetDeleteCommand();
                        ado3.Adapter.Update(ado3.Ds.Tables["avoir"]);
                    }
                }
            }
            catch (SqlException ex)
            {
                    MessageBox.Show(ex.Message);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void menuPrBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void remise_TextChanged(object sender, EventArgs e)
        {
            TextBox rem = sender as TextBox;
            string remise = rem.Text;
            decimal tvaCal = decimal.Parse(tva.Text) / 100;
            if(remise != "")
            {
                decimal remiCalc = (decimal.Parse(remise) / 100);
                decimal MontantRemise = (total * remiCalc);
                decimal MontantTotalApresRemiseHt = total - (total * remiCalc);
                decimal MontantTotalApresRemiseTtc =  MontantTotalApresRemiseHt + (MontantTotalApresRemiseHt * tvaCal) ;
                totalRem.Text = $"{MontantRemise}";
                totalHt.Text = $"{MontantTotalApresRemiseHt}";
                totalTtc.Text = $"{MontantTotalApresRemiseTtc}";
            } 
            else
            {
                totalRem.Text = $"{(0 )}";
                totalHt.Text = $"{total}";
                totalTtc.Text = $"{total + total * tvaCal}";
            }
        }

        private void Enregistrement_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(ado.Adapter);
                decimal tvaCal = decimal.Parse(tva.Text) / 100;
                ado.Ds.Tables["FACTURE"].Rows[0]["fac_n_o"] = 1;
                ado.Ds.Tables["FACTURE"].Rows[0]["total_ht"] = decimal.Parse(totalHt.Text);
                ado.Ds.Tables["FACTURE"].Rows[0]["total_ttc"] = decimal.Parse(totalTtc.Text);
                ado.Ds.Tables["FACTURE"].Rows[0]["total_rest"] = decimal.Parse(totalTtc.Text);
                ado.Ds.Tables["FACTURE"].Rows[0]["montantLettre"] = ConvertClasse.ToLettres(double.Parse(totalTtc.Text));
                ado.Adapter.Update(ado.Ds.Tables["FACTURE"]);
                MessageBox.Show($"Facture numéro {facturNum.Text} Ajoutée avec succés", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
