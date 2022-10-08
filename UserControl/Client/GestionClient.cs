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
        private void GestionClient_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = $"SELECT * from client";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            videError.Visible = false;
            videBase();
            nbreClt.Text = ado.Dt.Rows.Count.ToString();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ado.Dt;
            fillCombo(clientCombo,retrievingNames(ado.Dt));
            affichageGrid();
        }
        private void videBase()
        {
            if (ado.Dt.Rows.Count == 0)
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
            dataGridView1.Columns["edit"].Width = 40;
            dataGridView1.Columns["delete"].Width = 40;
            dataGridView1.Columns["voir"].Width = 50;
            dataGridView1.RowTemplate.Height = 50;
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
        private bool checkClientWithId(string nomClt, string id)
        {
            foreach (DataRow row in ado.Dt.Rows)
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
            foreach (DataRow row in ado.Dt.Rows)
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
            DataView dv = new DataView(ado.Dt);
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
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colName == "delete")
                {
                    bool confirmation = Shared.showMessage("Voulez vous vraiment supprimer le client ?", "Confirmation de suppression");
                    if (confirmation)
                    {
                        SqlCommandBuilder scb = new SqlCommandBuilder(ado.Adapter);
                        scb.GetDeleteCommand();
                        ado.Dt.Rows[e.RowIndex].Delete();
                        ado.Adapter.Update(ado.Dt);
                        nbreClt.Text = $"{ado.Dt.Rows.Count}";
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
                } else if(colName == "voir")
                {
                    ficheClt clt = new ficheClt();
                    ficheClt.IdClient = Guid.Parse(dataGridView1.Rows[e.RowIndex].Cells["IDCLIENT"].Value.ToString());
                    clt.Show();
                }
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
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(i%2 == 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(224);
                }
            }
        }
    }
}
