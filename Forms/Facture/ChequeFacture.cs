using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using RNetApp.Forms;
namespace RNetApp
{
    public partial class ChequeFacture : Form
    {
        AdoNet ado = new AdoNet();
        DataRow factureActurel;
        public ChequeFacture()
        {
            InitializeComponent();
        }
        private void fillCombo(ComboBox com)
        {
            com.DisplayMember = ado.Ds.Tables["facture"].Columns["idfacture"].ToString();
            com.ValueMember = ado.Ds.Tables["facture"].Columns["idclient"].ToString();
            com.DataSource = ado.Ds.Tables["facture"];
        }
        private void ChequeFacture_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = "gettables";
            ado.Cmd.CommandType = CommandType.StoredProcedure;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);
            /*factuNu*/
            ado.Ds.Tables[0].TableName = "facture";
            ado.Ds.Tables[1].TableName = "client";
            ado.Ds.Tables[2].TableName = "cheque";
            ado.Ds.Tables[3].TableName = "espece";
            fillCombo(comboBox1);
        }
        private bool chercherCheque(int numeroCheque)
        {
            foreach(DataRow dr in ado.Ds.Tables["cheque"].Rows)
            {
                if(numeroCheque == int.Parse(dr["idcheque"].ToString()))
                {
                    return true;
                }
            }
            return false;
        }
        private void enrBtn_Click(object sender, EventArgs e)
        {
            int flag = 0;
            try
            {
                if (!chercherCheque(int.Parse(numCheq.Text)))
                 {
                    if (decimal.Parse(factureActurel["total_rest"].ToString()) != 0)
                    {
                        if (decimal.Parse(montantChe.Text) <= decimal.Parse(factureActurel["total_rest"].ToString()))
                        {
                            //(each datatable needs a dataAdapter)
                            SqlDataAdapter facture_adapter = new SqlDataAdapter("select * from facture", ado.Connection);

                            SqlDataAdapter cheque_adapter = new SqlDataAdapter("select * from cheque", ado.Connection);
                            SqlCommandBuilder scb = new SqlCommandBuilder(facture_adapter);
                            SqlCommandBuilder scb2 = new SqlCommandBuilder(cheque_adapter);

                            scb.GetUpdateCommand();
                            factureActurel.BeginEdit();
                            factureActurel["total_rest"] = decimal.Parse(factureActurel["total_rest"].ToString()) - decimal.Parse(montantChe.Text);
                            factureActurel["pay_o_n"] = 2;
                            factureActurel.EndEdit();
                            facture_adapter.Update(ado.Ds.Tables["facture"]);

                            DataRow dr = ado.Ds.Tables["cheque"].NewRow();
                            dr[0] = int.Parse(numCheq.Text);
                            dr[1] = int.Parse(comboBox1.Text);
                            dr[2] = Guid.Parse(comboBox1.SelectedValue.ToString());
                            dr[3] = decimal.Parse(montantChe.Text);
                            ado.Ds.Tables["cheque"].Rows.Add(dr);

                            scb2.GetInsertCommand();
                            cheque_adapter.Update(ado.Ds.Tables["cheque"]);

                            //etat de la facture : 
                        }
                        else MessageBox.Show("Inserer un montant qui inférieur ou égale au montant de la facture");
                    }
                    else
                    {
                        MessageBox.Show("paiement effectuée deja");
                    }
                 } else MessageBox.Show("ce numero de cheque existe deja ");
            } catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);    
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private decimal calculTotal(int idfacture)
        {
            decimal total = 0;
            DataRow[] dr_cheque;
            DataRow[] dr_montant;
            dr_cheque = ado.Ds.Tables["cheque"].Select($"idfacture = '{idfacture}'");
            dr_montant = ado.Ds.Tables["espece"].Select($"idfacture = '{idfacture}'");
            foreach (DataRow dr2 in dr_cheque)
            {
                total += decimal.Parse(dr2["montant"].ToString());
            }
            foreach (DataRow dr2 in dr_montant)
            {
                total += decimal.Parse(dr2["montant"].ToString());
            }
            return total;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    ado.Ds.Tables["facture"].PrimaryKey = new DataColumn[] { ado.Ds.Tables["facture"].Columns["idfacture"] };
                    DataRow dr_facture = ado.Ds.Tables["facture"].Rows.Find(int.Parse(comboBox1.Text));
                    factureActurel = dr_facture;

                    //verifier la facture : 
                    if (dr_facture["pay_o_n"].ToString() == "1")
                    {
                        error.Visible = true;
                        error.Text = "Facture deja payée";
                        enrBtn.Enabled = false;
                        montRest.Text = "0";
                    }
                    else
                    {
                        enrBtn.Enabled = true;
                        error.Visible = false;
                        DataRow[] dr = ado.Ds.Tables["client"].Select($"idclient = '{Guid.Parse(comboBox1.SelectedValue.ToString())}'");

                        foreach (DataRow dr2 in dr)
                        {
                            nomClient.ReadOnly = true;
                            nomClient.Text = dr2["nom"].ToString();
                        }

                        montRest.Text = dr_facture["total_rest"].ToString();
                        if (decimal.Parse(factureActurel["total_rest"].ToString()) == 0)
                        {
                            factureActurel["pay_o_n"] = 1;
                        }
                    }
                }
            } catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
