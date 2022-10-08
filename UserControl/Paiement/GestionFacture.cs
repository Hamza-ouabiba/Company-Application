using System;
using System.Data;
using RNetApp.Forms;
using System.Data.SqlClient;
namespace RNetApp
{
    public partial class GestionFacture : UserControl
    {
        private Guid idClient;
        private string nomClient;
        private int position = -1;
        AdoNet ado = new AdoNet();
        public Guid IdClient { get => idClient; set => idClient = value; }
        public GestionFacture()
        {
            InitializeComponent();
        }
        private decimal calculSommeRegler()
        {
            decimal somme = 0;
            foreach (DataRow row in ado.Ds.Tables["facture"].Rows)
            {
                if (int.Parse(row["pay_o_n"].ToString()) == 1 && row["total_ttc"].ToString() != "" )
                {
                    somme += decimal.Parse(row["total_ttc"].ToString());
                }
            }
            return somme;
        }
        private decimal calculSommeNonRegler()
        {
            decimal somme = 0;
            foreach (DataRow row in ado.Ds.Tables["facture"].Rows)
            {
                if (int.Parse(row["pay_o_n"].ToString()) == 0 && row["total_ttc"].ToString() != "")
                {
                    somme += decimal.Parse(row["total_ttc"].ToString());
                }
            }
            return somme;
        }
        private decimal calculTotal(DataGridViewRow data)
        {

            decimal total = 0;
            DataRow[] dr_cheque;
            DataRow[] dr_montant;

            dr_cheque = ado.Ds.Tables["cheque"].Select($"idfacture = '{int.Parse(data.Cells["idfacture"].Value.ToString())}'");
            dr_montant = ado.Ds.Tables["espece"].Select($"idfacture = '{int.Parse(data.Cells["idfacture"].Value.ToString())}'");

            //sum of all checks : 
            foreach(DataRow dr2 in dr_cheque)
            {
                    total += decimal.Parse(dr2["montant"].ToString());
            }
            //sum of all in cash
            foreach (DataRow dr2 in dr_montant)
            {
                total += decimal.Parse(dr2["montant"].ToString());
            }
            return total;
        }
        private void fillCombo(ComboBox comb, string[] names)
        {
            comb.Items.Clear();
            names[0] = "Tous";
            comb.Items.AddRange(names);
        }
        private string[] retrievingNum(DataTable dt,Guid comboid)
        {
            //retrieving numbers for each client : 
            if (comboid != Guid.Empty)
            {
                DataRow[] dataRows = dt.Select($"idclient = '{comboid}'");
                string[] ret = new string[dataRows.Length + 1];

                for (int i = 1; i < ret.Length; i++)
                {
                    ret[i] = dataRows[i - 1]["idfacture"].ToString();
                }
                return ret;
            }
            else
            {
                //when the Guid is not required : 

                string[] ret = new string[dt.Rows.Count+ 1];

                for (int i = 1; i < ret.Length; i++)
                {
                    ret[i] = dt.Rows[i - 1]["idfacture"].ToString();
                }
                return ret;

            }
        }
        private string[] retrievingClients(DataTable dt)
        {
            string[] ret = new string[dt.Rows.Count+1];
            for (int i = 1; i < ret.Length; i++)
            {
                ret[i] = dt.Rows[i - 1]["nom"].ToString();
            }
            return ret;
        }
        private void setDataGridView()
        {
            dataGridView1.Columns["IDCLIENT"].Visible = false;
            dataGridView1.Columns["fac_n_o"].Visible = false;
            dataGridView1.Columns["total_ht"].HeaderText = "Total hors taxe";
            dataGridView1.Columns["idfacture"].HeaderText = "N°Facture";
            dataGridView1.Columns["total_ttc"].HeaderText = "total ttc";
            dataGridView1.Columns["pay_o_n"].HeaderText = "etat de facture";
            dataGridView1.Columns["date_"].HeaderText = "Date de facture";
            dataGridView1.Columns["total_rest"].HeaderText = "Total restant";
            Shared.addCol(dataGridView1, "delete", "delete", "supprimer");
            Shared.addCol(dataGridView1, "edit", "edit", "modifier");
            Shared.addCol(dataGridView1, "voir", "voir", "voir facture");
            Shared.addCol(dataGridView1, "add", "add", "Ajouter une méthode de paiment");

            dataGridView1.RowTemplate.Height = 40;
        }
        private void setStatusFacture()
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells["pay_o_n"].Value.ToString() == "False")
                {
                    row.Cells["pay_o_n"].Value = "Non payée";
                }
            }
        }
        private void loadData()
        {
            ado.Cmd.CommandText = "GETTABLES";
            ado.Cmd.CommandType = CommandType.StoredProcedure;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);

            ado.Ds.Tables[0].TableName = "facture";
            ado.Ds.Tables[1].TableName = "client";
            ado.Ds.Tables[2].TableName = "cheque";
            ado.Ds.Tables[3].TableName = "espece";
            ado.Ds.Tables[4].TableName = "changer";
        }
        private void fillComboWithDataSource(ComboBox com)
        {
            com.DisplayMember = ado.Ds.Tables["client"].Columns["nom"].ToString();
            com.ValueMember = ado.Ds.Tables["client"].Columns["idclient"].ToString();
            com.DataSource = ado.Ds.Tables["client"];
        }
        private void GestionFacture_Load(object sender, EventArgs e)
        {
            loadData();
            dataGridView1.DataSource = ado.Ds.Tables["facture"];
            //fill the combobox : 
            fillCombo(comboBox1, retrievingClients(ado.Ds.Tables["client"]));
            fillComboWithDataSource(comboBox3);
            setDataGridView();
            nbrefac.Text = $"{ado.Ds.Tables["facture"].Rows.Count}";
            regler.Text = calculSommeRegler() + "";
            nnregler.Text = calculSommeNonRegler() + "";
            comboBox1.Text = "Tous";
        }
        private bool verificationClientPrix(Guid idclient)
        {
            foreach(DataRow row in ado.Ds.Tables["changer"].Rows)
            {
                if(Guid.Parse(row["idclient"].ToString()) == Guid.Parse(comboBox3.SelectedValue.ToString()))
                {
                    return true;
                }
            }
            return false;
        }
        private bool checkClient(string nomClt)
        {
            foreach (DataRow row in ado.Dt.Rows)
            {
                if (row["NOM"].ToString().ToLower() == nomClt.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private void rechercher_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(ado.Ds.Tables["facture"]);
            if(comboBox1.Text != "Tous")
            {

                dv.RowFilter = $"idclient = '{Guid.Parse(comboBox1.SelectedValue.ToString())}'";

                dataGridView1.DataSource = dv;
            } else
            {
                dataGridView1.DataSource = ado.Ds.Tables["facture"];
            }
        }
        private void verifierBtn_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(ado.Adapter);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                MessageBox.Show($"{calculTotal(dataGridView1.Rows[i])}");

                if (dataGridView1.Rows[i].Cells["total_ttc"].Value.ToString() != "" && decimal.Parse(dataGridView1.Rows[i].Cells["total_ttc"].Value.ToString()) == calculTotal(dataGridView1.Rows[i]))
                {
                    ado.Ds.Tables["facture"].Rows[i]["pay_o_n"] = 1;

                    scb.GetUpdateCommand();

                    ado.Adapter.Update(ado.Ds.Tables["facture"]);

                    dataGridView1.Rows[i].Cells["pay_o_n"].Style.BackColor = Color.Lime;

                }
                else
                {
                    ado.Ds.Tables["facture"].Rows[i]["pay_o_n"] = 0;
                    dataGridView1.Rows[i].Cells["pay_o_n"].Style.BackColor = Color.Red;
                }
            }
        }
        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                //setting the primary key of the 'facture' datatable 
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;
               if(colName == "see")
                {
                    ado.Ds.Tables["facture"].PrimaryKey = new DataColumn[] { ado.Ds.Tables["facture"].Columns["idfacture"] };
                    DataRow dr = ado.Ds.Tables["facture"].Rows.Find(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    DataRow[] cheque_facture = ado.Ds.Tables["cheque"].Select($"idfacture = {int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())}");
                    DataRow[] espece_facture = ado.Ds.Tables["espece"].Select($"idfacture = {int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())}");
                    if (dr != null)
                    {
                        infoFacture ifa = new infoFacture();

                        infoFacture.Facture = dr;

                        infoFacture.Client = ado.Ds.Tables["client"];

                        infoFacture.NombreCheque = cheque_facture.Length;

                        infoFacture.NombreEspece = espece_facture.Length;

                        ifa.Show();
                    }
                }
            } 
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["pay_o_n"].Value.ToString() == "1")
                {
                    dataGridView1.Rows[i].Cells["pay_o_n"].Style.BackColor = Color.Lime;
                }
                else
                {
                    dataGridView1.Rows[i].Cells["pay_o_n"].Style.BackColor = Color.Red;
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex != -1)
            {
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                if(colName == "delete")
                {

                    if(Shared.showMessage("Voulez-vous vraiment supprimer la facture ?(cette opération va causer la suppression des chèques et des epèces de cette facture!!)",""))
                    {
                        SqlCommandBuilder scb = new SqlCommandBuilder(ado.Adapter);
                        scb.GetDeleteCommand();
                        ado.Ds.Tables["facture"].Rows[e.RowIndex].Delete();
                        ado.Adapter.Update(ado.Ds.Tables["facture"]);
                    }

                } else if(colName == "voir")
                {
                    //giving this row to the facturecheck form 
                    FactureCheck factureCheck = new FactureCheck();
                    factureCheck.Facture = ado.Ds.Tables["facture"].Rows[e.RowIndex];
                    factureCheck.Show();
                } else if(colName == "edit")
                {
                    if (Shared.showMessage("Voulez-vous vraiment modifier la facture?", ""))
                    {
                        ModifierFacture modifierFacture = new ModifierFacture();
                        modifierFacture.Idfacture = int.Parse(ado.Ds.Tables["facture"].Rows[e.RowIndex]["idfacture"].ToString());
                        modifierFacture.Show();
                    }
                } else if(colName == "add")
                {
                    FacturePaimentSeul facturePaimentSeul = new FacturePaimentSeul();
                    facturePaimentSeul.IdFacture = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["idfacture"].Value.ToString());  
                    facturePaimentSeul.Show();
                }
            }
        }
        //search for client with name and return its id :
        private Guid searchClientCombo(string nom)
        {
            for(int i=0;i<ado.Ds.Tables["client"].Rows.Count;i++)
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
            DataView dv = new DataView(ado.Ds.Tables["facture"]);

            if (comboBox1.Text != "Tous" && comboBox1.Text != "")
            {
                if(searchClientCombo(comboBox1.Text) != Guid.Empty)
                {
                    fillCombo(comboBox2, retrievingNum(ado.Ds.Tables["facture"],searchClientCombo(comboBox1.Text)));

                    dv.RowFilter = $"idclient = '{searchClientCombo(comboBox1.Text)}'";

                    dataGridView1.DataSource = dv;
                }
            }
            else if (comboBox1.Text == "Tous" && comboBox1.Text != "")
            {
                comboBox2.Items.Clear();

                fillCombo(comboBox2, retrievingNum(ado.Ds.Tables["facture"], searchClientCombo(comboBox1.Text)));

                dataGridView1.DataSource = ado.Ds.Tables["facture"];
            }
        }
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(ado.Ds.Tables["facture"]);

            if (comboBox2.Text != "Tous" && comboBox2.Text != "")
            {
                dv.RowFilter = $"idfacture = '{comboBox2.Text}'";

                dataGridView1.DataSource = dv;
            }
            else if (comboBox2.Text == "Tous")
            {

                if(searchClientCombo(comboBox1.Text) != Guid.Empty)
                {

                    dv.RowFilter = $"idclient = '{searchClientCombo(comboBox1.Text)}'";

                    dataGridView1.DataSource = dv;
                } 
                else
                {
                    dataGridView1.DataSource = ado.Ds.Tables["facture"];
                }
            }
        }

        private void AjoutFac_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            FactureForm form = new FactureForm();
            SqlCommandBuilder sql = new SqlCommandBuilder(ado.Adapter);
            if (verificationClientPrix(Guid.Parse(comboBox3.SelectedValue.ToString())))
            {
                //creating new row : 
                DataRow dr = ado.Ds.Tables["facture"].NewRow();
                dr[1] = dt;
                dr[5] = 0;
                dr[6] = Guid.Parse(comboBox3.SelectedValue.ToString());
                dr[7] = 0;

                ado.Ds.Tables["facture"].Rows.Add(dr);
                sql.GetInsertCommand();

                ado.Adapter.Update(ado.Ds.Tables["facture"]);

                form.IdClient = Guid.Parse(comboBox3.SelectedValue.ToString());

                form.NameClient = comboBox3.Text;
                form.Show();
            }
            else MessageBox.Show("voud devez d'abord fixer les prix pour ce client : ");
        }

        private void actuaNu_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && comboBox2.Text != "Tous")
            {
                DataView data = new DataView(ado.Ds.Tables["facture"]);
                data.RowFilter = $"idfacture = '{int.Parse(comboBox2.Text)}'";
                if (data.Count > 0)
                {
                    dataGridView1.DataSource = data;
                } 
            } else
            {
                dataGridView1.DataSource = ado.Ds.Tables["facture"];
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["pay_o_n"].Index)
            {
                if(e.Value.ToString() == "0")
                {

                    e.Value = "non payée";
                    e.FormattingApplied = true;

                } else
                {

                    e.Value = " payée";
                    e.FormattingApplied = true;

                }
            }
        }
        
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                DataView data = new DataView(ado.Ds.Tables["facture"]);
                data.RowFilter = $"idclient = '{searchClientCombo(comboBox1.Text)}'";
                if (data.Count > 0)
                {
                    dataGridView1.DataSource = data;
                }
            }
            else
            {
                dataGridView1.DataSource = ado.Ds.Tables["facture"];
            }
        }

    }
}
