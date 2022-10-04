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
            ado.Cmd.CommandText = $"Select * from FACTURE where idClient = '{IdClient}'";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds, "FACTURE");
        }
        private void FactureForm_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            ajustementEcran();
            loadData();
            nomCl.Text = nameClient;
            for (int i = 0; i < ado.Ds.Tables["FACTURE"].Rows.Count; i++)
            {
                if (ado.Ds.Tables["FACTURE"].Rows[i]["fac_n_o"].ToString() == "0")
                {
                    position = i;
                    idFacture = int.Parse(ado.Ds.Tables["FACTURE"].Rows[i]["idFacture"].ToString());
                    dateNow.Text = $"{date.Day}/{date.Month}/{date.Year}";
                    facturNum.Text = $"{ado.Ds.Tables["FACTURE"].Rows[i]["idFacture"].ToString()}/{date.Year}";
                    break;
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
            SqlCommandBuilder sql = new SqlCommandBuilder(ado.Adapter);
            AdoNet ado2 = new AdoNet();
            try
            {
                ado2.Cmd.CommandText = $"Select * from changer where IDCLIENT = '{IdClient}'";
                ado2.Cmd.Connection = ado2.Connection;
                ado2.Adapter.SelectCommand = ado2.Cmd;
                ado2.Adapter.Fill(ado2.Ds, "changer");
                for (int i = 0; i < ado2.Ds.Tables["changer"].Rows.Count; i++)
                {
                    prix[i] = decimal.Parse(ado2.Ds.Tables["changer"].Rows[i][2].ToString());
                }
                AdoNet ado3 = new AdoNet();
                ado3.Cmd.CommandText = $"Select * from AVOIR";
                ado3.Cmd.Connection = ado3.Connection;
                ado3.Adapter.SelectCommand = ado3.Cmd;
                ado3.Adapter.Fill(ado3.Ds, "avoir");
                if (!testFacture(ado3.Ds.Tables["avoir"],idFacture))
                {
                    DataRow dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "draps_double";
                    dr[2] = int.Parse(textBox1.Text);
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    total += int.Parse(textBox1.Text) * prix[0];
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "housse_couette_pm";
                    dr[2] = int.Parse(textBox2.Text);
                    total += int.Parse(textBox2.Text) * prix[1];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "housse_couette_gm";
                    dr[2] = int.Parse(textBox3.Text);
                    total += int.Parse(textBox3.Text) * prix[2];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "draps_housse_pm";
                    dr[2] = int.Parse(textBox4.Text);
                    total += int.Parse(textBox4.Text) * prix[3];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "draps_housse_gm";
                    dr[2] = int.Parse(textBox5.Text);
                    total += int.Parse(textBox5.Text) * prix[4];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "taie_oreiller_pm";
                    dr[2] = int.Parse(textBox6.Text);
                    total += int.Parse(textBox6.Text) * prix[5];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "taie_oreiller_gm";
                    dr[2] = int.Parse(textBox7.Text);
                    total += int.Parse(textBox7.Text) * prix[6];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "serviette_eponge";
                    dr[2] = int.Parse(textBox8.Text);
                    total += int.Parse(textBox8.Text) * prix[7];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "draps_bain";
                    dr[2] = int.Parse(textBox9.Text);
                    total += int.Parse(textBox9.Text) * prix[8];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "serviette_piscine";
                    dr[2] = int.Parse(textBox10.Text);
                    total += int.Parse(textBox10.Text) * prix[9];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "tapis_sol";
                    dr[2] = int.Parse(textBox11.Text);
                    total += int.Parse(textBox11.Text) * prix[10];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "draps_simple";
                    dr[2] = int.Parse(textBox12.Text);
                    total += int.Parse(textBox12.Text) * prix[11];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "tapis_bain";
                    dr[2] = int.Parse(textBox13.Text);
                    total += int.Parse(textBox13.Text) * prix[12];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "peignoir";
                    dr[2] = int.Parse(textBox14.Text);
                    total += int.Parse(textBox14.Text) * prix[13];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "oreiller";
                    dr[2] = int.Parse(textBox15.Text);
                    total += int.Parse(textBox15.Text) * prix[14];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "serviette_toilette_spa";
                    dr[2] = int.Parse(textBox16.Text);
                    total += int.Parse(textBox16.Text) * prix[15];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "aleze";
                    dr[2] = int.Parse(textBox17.Text);
                    total += int.Parse(textBox17.Text) * prix[16];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "draps_bain_spa";
                    dr[2] = int.Parse(textBox18.Text);
                    total += int.Parse(textBox18.Text) * prix[17];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "tapis_m2";
                    dr[2] = int.Parse(textBox19.Text);
                    total += int.Parse(textBox19.Text) * prix[18];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "serviette_table";
                    dr[2] = int.Parse(textBox20.Text);
                    total += int.Parse(textBox20.Text) * prix[19];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "rideau_gm_m2";
                    dr[2] = int.Parse(textBox21.Text);
                    total += int.Parse(textBox21.Text) * prix[20];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "housse_coussin_pm";
                    dr[2] = int.Parse(textBox22.Text);
                    total += int.Parse(textBox22.Text) * prix[21];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "housse_coussin_gm";
                    dr[2] = int.Parse(textBox23.Text);
                    total += int.Parse(textBox23.Text) * prix[22];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "taie_kiria";
                    dr[2] = int.Parse(textBox24.Text);
                    total += int.Parse(textBox24.Text) * prix[23];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "housse_canape";
                    dr[2] = int.Parse(textBox25.Text);
                    total += int.Parse(textBox25.Text) * prix[24];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "devant";
                    dr[2] = int.Parse(textBox26.Text);
                    total += int.Parse(textBox26.Text) * prix[25];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "chemin_table";
                    dr[2] = int.Parse(textBox27.Text);
                    total += int.Parse(textBox27.Text) * prix[26];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "nappe";
                    dr[2] = int.Parse(textBox28.Text);
                    total += int.Parse(textBox28.Text) * prix[27];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "chemin_lit";
                    dr[2] = int.Parse(textBox29.Text);
                    total += int.Parse(textBox29.Text) * prix[28];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "fouteille";
                    dr[2] = int.Parse(textBox30.Text);
                    total += int.Parse(textBox30.Text) * prix[29];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "matlant";
                    dr[2] = int.Parse(textBox31.Text);
                    total += int.Parse(textBox31.Text) * prix[30];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "torchon";
                    dr[2] = int.Parse(textBox32.Text);
                    total += int.Parse(textBox32.Text) * prix[31];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "couverture";
                    dr[2] = int.Parse(textBox33.Text);
                    total += int.Parse(textBox33.Text) * prix[33];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "couette";
                    dr[2] = int.Parse(textBox34.Text);
                    total += int.Parse(textBox34.Text) * prix[33];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    dr = ado3.Ds.Tables["avoir"].NewRow();
                    dr[0] = idFacture;
                    dr[1] = "lavette";
                    dr[2] = int.Parse(textBox35.Text);
                    total += int.Parse(textBox35.Text) * prix[34];
                    ado3.Ds.Tables["avoir"].Rows.Add(dr);
                    //mise a jour de la base de donnée : 
                    SqlCommandBuilder sql2 = new SqlCommandBuilder(ado3.Adapter);
                    sql2.GetInsertCommand();
                    ado3.Adapter.Update(ado3.Ds.Tables["avoir"]);

                    //mise a jour de la table facture : 
                    decimal tvaCal = (decimal.Parse(tva.Text) / 100);
                    pht.Visible = tva_.Visible = pttc.Visible = true;
                    pht.Text = $"{total}";
                    tva_.Text = $"{total * tvaCal}";
                    pttc.Text = $"{total + (total * tvaCal)}";
                } else
                {
                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(ado3.Adapter);
                    if(Shared.showMessage("Facture deja faite pour ce client souhaitez vous la remodifier ?",""))
                    {
                        foreach(DataRow dataRow in ado3.Ds.Tables["avoir"].Rows)
                        {
                            if(int.Parse(dataRow["idfacture"].ToString()) == idFacture)
                            {
                                dataRow.Delete();
                            }
                        }
                        sqlCommandBuilder.GetDeleteCommand();
                        ado3.Adapter.Update(ado3.Ds.Tables["avoir"]);
                    }
                }
            } catch (SqlException ex)
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
                ado.Ds.Tables["FACTURE"].Rows[position]["fac_n_o"] = 1;
                ado.Ds.Tables["FACTURE"].Rows[position]["total_ht"] = decimal.Parse(totalHt.Text);
                ado.Ds.Tables["FACTURE"].Rows[position]["total_ttc"] = decimal.Parse(totalTtc.Text);
                ado.Ds.Tables["FACTURE"].Rows[position]["total_rest"] = decimal.Parse(totalTtc.Text);
                ado.Ds.Tables["FACTURE"].Rows[position]["montantLettre"] = ConvertClasse.ToLettres(double.Parse(totalTtc.Text));
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
