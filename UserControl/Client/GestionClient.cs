using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using RNetApp.Forms;
namespace RNetApp
{
    public partial class GestionClient : UserControl
    {
        private int position;
        AdoNet ado = new AdoNet();
        public GestionClient()
        {
            InitializeComponent();
        }
        private void fillCombo(ComboBox comb,string[] names)
        {
            comb.Items.Clear();
            names[0] = "Tous";
            comb.Items.AddRange(names);
        }
        string[] retrievingNames(DataTable dt)
        {
            string[] retrievingNames = new string[dt.Rows.Count+1];    
            for (int i = 1; i < retrievingNames.Length; i++)
            {
                retrievingNames[i] = dt.Rows[i-1]["nom"].ToString();
            }
            return retrievingNames;
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
        private void GestionClient_Load(object sender, EventArgs e)
        {
            loadData();
            videError.Visible = false;
            videBase();
            nbreClt.Text = ado.Ds.Tables["client"].Rows.Count.ToString();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ado.Ds.Tables["client"];
            fillCombo(clientCombo,retrievingNames(ado.Ds.Tables["client"]));
            clientCombo.Text = "Tous";
            affichageGrid();
        }
        private void videBase()
        {
            if (ado.Ds.Tables["client"].Rows.Count == 0)
            {
                videError.Visible = true;
                videError.Text = "Base de donnée vide veuillez insérer un client";
            }
        }
        //pour datagridview : 
        private void affichageGrid()
        {
            dataGridView1.Columns["IDCLIENT"].Visible = false;
            dataGridView1.Columns["NOM"].HeaderText = "Nom client";
            dataGridView1.Columns["MONTANT"].HeaderText = "Montant Par mois";
            Shared.addCol(dataGridView1, "delete", "delete", "supprimer");
            Shared.addCol(dataGridView1, "edit", "edit", "modifier");
            Shared.addCol(dataGridView1, "voir", "voir", "voir client");
            Shared.addCol(dataGridView1, "add", "add", "Facture");
        }
        private bool checkClient(string nomClt)
        {
            foreach (DataRow row in ado.Ds.Tables["client"].Rows)
            {
                if (row["NOM"].ToString().ToLower() == nomClt.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private bool checkClientWithId(string nomClt, string id)
        {
            foreach (DataRow row in ado.Ds.Tables["client"].Rows)
            {
                if (row["IDCLIENT"].ToString().ToLower() == id.ToLower() && row["NOM"].ToString().ToLower() == nomClt.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private bool checkClientWithNoId(string nomClt, string id)
        {
            foreach (DataRow row in ado.Ds.Tables["client"].Rows)
            {
                if (row["IDCLIENT"].ToString().ToLower() != id.ToLower() && row["NOM"].ToString().ToLower() == nomClt.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Silver;
                }
            }
        }
        private void clientCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(ado.Ds.Tables["client"]);
            if (clientCombo.Text != "" && clientCombo.Text != "Tous")
            {
                if (checkClient(clientCombo.Text))
                {
                    error.Visible = false;
                    dv.RowFilter = $"NOM like '{clientCombo.Text}'";
                    dataGridView1.DataSource = dv;
                }
            } else if(clientCombo.Text == "Tous")
            {
                dv.RowFilter = $"NOM Not like 'Tous'";
                dataGridView1.DataSource = dv;
            }
        }
        private bool verificationClientPrix(Guid idclient)
        {
            foreach (DataRow row in ado.Ds.Tables["changer"].Rows)
            {
                if (Guid.Parse(row["idclient"].ToString()) == idclient)
                {
                    return true;
                }
            }
            return false;
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != -1)
                {
                    string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                    if (colName == "delete")
                    {
                        bool confirmation = Shared.showMessage("Voulez vous vraiment supprimer le client ?", "Confirmation de suppression");
                        if (confirmation)
                        {
                            SqlDataAdapter sqlDataAdapterClient = new SqlDataAdapter("select * from client", ado.Connection);
                            SqlCommandBuilder scb = new SqlCommandBuilder(sqlDataAdapterClient);
                            scb.GetDeleteCommand();
                            ado.Ds.Tables["client"].Rows[e.RowIndex].Delete();
                            sqlDataAdapterClient.Update(ado.Ds.Tables["client"]);
                            nbreClt.Text = $"{ado.Ds.Tables["client"].Rows.Count}";
                            videBase();
                        }
                    }
                    else if (colName == "edit")
                    {
                        bool confirmation = Shared.showMessage("Voulez vous vraiment modifier le client ?", "Confirmation de modification");
                        if (confirmation)
                        {
                            ModifierClient mc = new ModifierClient();
                            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells["IDCLIENT"].Value.ToString());
                            ModifierClient.IdClient = Guid.Parse(dataGridView1.Rows[e.RowIndex].Cells["IDCLIENT"].Value.ToString());
                            mc.Show();
                        }
                    }
                    else if (colName == "voir")
                    {
                        ficheClt clt = new ficheClt();
                        ficheClt.IdClient = Guid.Parse(dataGridView1.Rows[e.RowIndex].Cells["IDCLIENT"].Value.ToString());
                        clt.Show();
                    }
                    else if (colName == "add")
                    {
                        DateTime dt = DateTime.Now;
                        SqlDataAdapter sqlDataAdapterFacture = new SqlDataAdapter("select * from facture", ado.Connection);
                        SqlCommandBuilder sql = new SqlCommandBuilder(sqlDataAdapterFacture);
                        if (verificationClientPrix(Guid.Parse(dataGridView1.Rows[e.RowIndex].Cells["idclient"].Value.ToString())))
                        {
                            //creating new row : 
                            DataRow dr = ado.Ds.Tables["facture"].NewRow();
                            dr[1] = dt;
                            dr[5] = 0;
                            dr[6] = Guid.Parse(dataGridView1.Rows[e.RowIndex].Cells["idclient"].Value.ToString());
                            dr[7] = 0;

                            ado.Ds.Tables["facture"].Rows.Add(dr);
                            sql.GetInsertCommand();

                            sqlDataAdapterFacture.Update(ado.Ds.Tables["facture"]);
                            FactureForm factureForm = new FactureForm();
                            factureForm.IdClient = Guid.Parse(dataGridView1.Rows[e.RowIndex].Cells["idclient"].Value.ToString());
                            factureForm.NameClient = dataGridView1.Rows[e.RowIndex].Cells["nom"].Value.ToString();
                            factureForm.Show();
                        }
                        else MessageBox.Show("veuillez d'avoir fixer les prix");
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colName != "delete" && colName != "edit" && colName!="voir")
                {
                    dataGridView1.Cursor = Cursors.Default;
                }
                else
                {
                    dataGridView1.Cursor = Cursors.Hand;
                }
            }
        }
        private void AjoutClient_Click(object sender, EventArgs e)
        {
            AjoutClient form_client = new AjoutClient();
            form_client.Show();
        }

        private void dataGridView1_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i%2 == 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Silver;
                }
            }
        }

        private void articleMod_Click(object sender, EventArgs e)
        {
            ModificationPrixArticle modificationPrixArticle =  new ModificationPrixArticle();
            modificationPrixArticle.Show();
        }
    }
}
