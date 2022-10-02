using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class GestionCheque : UserControl
    {
        AdoNet ado = new AdoNet();
        public GestionCheque()
        {
            InitializeComponent();
        }
        private void fillCombo(ComboBox comb, string[] names)
        {
            comb.Items.Clear();
            names[0] = "Tous";
            comb.Items.AddRange(names);
        }
        private string[] retrievingEmployees(DataTable dt)
        {
            string[] ret = new string[dt.Rows.Count + 1];
            for (int i = 1; i < ret.Length; i++)
            {
                ret[i] = dt.Rows[i - 1]["nom"].ToString();
            }
            return ret;
        }
        private void setDataGrid()
        {
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.Columns["IDCLIENT"].Visible = false;
            Shared.addCol(dataGridView1, "voir", "voir", "");
            Shared.addCol(dataGridView1, "edit", "edit", "");
            Shared.addCol(dataGridView1, "delete", "delete", "");
        }
        private void loadData(string dataSource)
        {
            ado.Cmd.CommandText = "GETTABLES";
            ado.Cmd.CommandType = CommandType.StoredProcedure;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);
            ado.Ds.Tables[0].TableName = "facture";
            ado.Ds.Tables[1].TableName = "client";
            ado.Ds.Tables[2].TableName = "cheque";
        }
        private void GestionCheque_Load(object sender, EventArgs e)
        {
            loadData("cheque");
            dataGridView1.DataSource = ado.Ds.Tables["Cheque"];
            loadData("client");
            fillCombo(comboBox1, retrievingEmployees(ado.Ds.Tables["client"]));
            setDataGrid();
        }
        private void nvChequeBtn_Click_1(object sender, EventArgs e)
        {
            ChequeFacture cf = new ChequeFacture();
            cf.Show();
        }
        //search for client with name and return its id :
        private Guid searchClientCombo(string nom)
        {
            for (int i = 0; i < ado.Ds.Tables["client"].Rows.Count; i++)
            {
                if (nom == ado.Ds.Tables["client"].Rows[i]["nom"].ToString())
                {
                    return Guid.Parse(ado.Ds.Tables["client"].Rows[i]["idclient"].ToString());
                }
            }
            return Guid.Empty;
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           try
            {
                DataView dv = new DataView(ado.Ds.Tables["cheque"]);
                dv.RowFilter = $"idclient = '{searchClientCombo(comboBox1.Text)}'";
                if (comboBox1.Text != "Tous")
                {
                    dataGridView1.DataSource = dv;
                }
                else
                {
                    dataGridView1.DataSource = ado.Ds.Tables["cheque"];
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.ColumnIndex != -1)
                {
                    string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                    if (colName == "voir")
                    {
                        ChequeInfo cheque = new ChequeInfo();
                        ChequeInfo.Idcheque = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["idcheque"].Value.ToString());
                        cheque.Show();
                    }
                    else if (colName == "edit")
                    {
                        ModifierCheque modifier_cheque = new ModifierCheque();
                        ModifierCheque.Idcheque = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["idcheque"].Value.ToString());
                        modifier_cheque.Show();
                    }
                    else if (colName == "delete")
                    {
                        //asking the user if he wants to change the amount left according to the invoice : 
                        string idFactureDataGrid = dataGridView1.Rows[e.RowIndex].Cells["idfacture"].Value.ToString();
                        SqlDataAdapter adapter = new SqlDataAdapter("select * from cheque",ado.Connection);  
                        SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
                        if (Shared.showMessage("Voulez vous vraiment supprimer le chèque ?", "confirmation de suppression"))
                        {
                            if (Shared.showMessage($"Changer le total restant de la facture numero : {idFactureDataGrid}", "Confirmation de changement de montant restant"))
                            {
                                //substract the amount of the check to the invoice : 
                                DataTable dt_cheque = new DataTable();

                                SqlDataAdapter factureAdapter = new SqlDataAdapter($"select * from facture where idfacture = {int.Parse(idFactureDataGrid)}", ado.Connection);
                                SqlCommandBuilder sqlCommandBuilder1 = new SqlCommandBuilder(factureAdapter);

                                factureAdapter.Fill(dt_cheque);

                                MessageBox.Show("avant" + dt_cheque.Rows[0]["total_rest"].ToString());

                                dt_cheque.Rows[0]["total_rest"] = decimal.Parse(dt_cheque.Rows[0]["total_rest"].ToString()) + decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells["montant"].Value.ToString());
                                MessageBox.Show("apres" + dt_cheque.Rows[0]["total_rest"].ToString());

                                sqlCommandBuilder1.GetUpdateCommand();

                                factureAdapter.Update(dt_cheque);
                                sqlCommandBuilder.GetDeleteCommand();

                                ado.Ds.Tables["cheque"].Rows[e.RowIndex].Delete();

                                adapter.Update(ado.Ds.Tables["cheque"]);

                                MessageBox.Show("Supprimer avec succes avec changement de montant");

                            }
                            else
                            {
                                sqlCommandBuilder.GetDeleteCommand();

                                ado.Ds.Tables["cheque"].Rows[e.RowIndex].Delete();

                                adapter.Update(ado.Ds.Tables["cheque"]);

                                MessageBox.Show("Supprimer avec succes");

                            }
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        } 

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != -1)
                {
                    string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                    if (colName == "voir" || colName == "edit" || colName == "delete")
                    {
                        dataGridView1.Cursor = Cursors.Hand;
                    }
                    else
                    {
                        dataGridView1.Cursor = Cursors.Default;
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
