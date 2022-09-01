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
        private void GestionClient_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = $"Select * from CLIENT";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            videError.Visible = false;
            videBase();
            nbreClt.Text = ado.Dt.Rows.Count.ToString();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ado.Dt;
            comboBox1.DataSource = ado.Dt;
            comboBox1.DisplayMember = ado.Dt.Columns["NOM"].ToString();
            comboBox1.ValueMember = ado.Dt.Columns["IDCLIENT"].ToString();
            testCombo();
            affichageGrid();
        }
        private void testCombo()
        {
            if (comboBox1.Items.Count > 0)
            {
                ficheBtn.Enabled = true;
            }
            else ficheBtn.Enabled = false;
        }
        private void videBase()
        {
            if (ado.Dt.Rows.Count == 0)
            {
                videError.Visible = true;
                videError.Text = "Base de donnée vide veuillez insérer un client";
            }
        }
        //Methode pour verifier les champs :
        private void effacerTextBox()
        {
            nomClt.Clear();
            Montant.Clear();
        }
        private void enregBtn_Click(object sender, EventArgs e)
        {
            //instancier une nouvelle ligne  : 
            DataRow dr;
            SqlCommandBuilder sql = new SqlCommandBuilder(ado.Adapter);
            if (checkInfo())
            {
                try
                {
                        if (!checkClient(nomClt.Text))
                        {
                            dr = ado.Dt.NewRow();
                            dr[1] = nomClt.Text;
                            dr[2] = float.Parse(Montant.Text);
                            ado.Dt.Rows.Add(dr);
                            sql.GetInsertCommand();
                            ado.Adapter.Update(ado.Dt);
                            effacerTextBox();
                            ado.Dt = new DataTable();
                            GestionClient_Load(sender, e);
                            nbreClt.Text = $"{ado.Dt.Rows.Count}";
                            MessageBox.Show("Client Ajoutée avec succés","",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        }
                        else {MessageBox.Show("Ce client existe deja dans la base de donnée pensez a resaisir un autre"); effacerTextBox(); }
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else MessageBox.Show("Veuillez saisir les champs requies");
        }
        //pour datagridview : 
        private void affichageGrid()
        {
            dataGridView1.Columns["IDCLIENT"].Visible = false;
            dataGridView1.Columns["NOM"].Width = 300;
            dataGridView1.Columns["MONTANT"].Width = 300;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowHeadersVisible = false;
            Shared.addCol(dataGridView1, "delete", "delete", "supprimer");
            Shared.addCol(dataGridView1, "edit", "edit", "modifier");
            dataGridView1.Columns["NOM"].HeaderText = "Nom client";
            dataGridView1.Columns["MONTANT"].HeaderText = "Montant Par mois";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != -1)
            {
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                if(colName == "delete")
                {
                    bool confirmation = Shared.showMessage("Voulez vous vraiment supprimer le client ?", "Confirmation de suppression");
                    if(confirmation)
                    {
                        SqlCommandBuilder scb = new SqlCommandBuilder(ado.Adapter);
                        scb.GetDeleteCommand();
                        ado.Dt.Rows[e.RowIndex].Delete();
                        ado.Adapter.Update(ado.Dt);
                        nbreClt.Text = $"{ado.Dt.Rows.Count}";
                        videBase();
                        testCombo();
                    }
                } else if(colName == "edit")
                {
                    bool confirmation = Shared.showMessage("Voulez vous vraiment modifier le client ?", "Confirmation de modification");
                    if(confirmation)
                    {
                        ModifierClient mc = new ModifierClient();
                        MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells["IDCLIENT"].Value.ToString());
                        ModifierClient.IdClient = Guid.Parse(dataGridView1.Rows[e.RowIndex].Cells["IDCLIENT"].Value.ToString());
                        mc.Show();
                    }
                }
            }
        }
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colName != "delete" && colName != "edit")
                {
                    dataGridView1.Cursor = Cursors.Default;
                }
                else
                {
                    dataGridView1.Cursor = Cursors.Hand;
                }
            }
        }
        
        private void rechercher_Click(object sender, EventArgs e)
        {
            if (recherche.Text != "")
            {
                DataView dv = new DataView(ado.Dt);
                if (checkClient(recherche.Text))
                {
                    error.Visible = false;
                    dv.RowFilter = $"NOM like '{recherche.Text}'";
                    dataGridView1.DataSource = dv;
                }
                else
                {
                    error.Visible = true;
                    error.Text = "Ce client n'existe pas";
                }
            }
            else
            {
                error.Visible = true;
                error.Text = "Veuillez inseGrer quelque chose";
            }
        }
        private bool checkInfo()
        {
            return nomClt.Text != "" && Montant.Text != "";
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ficheBtn_Click(object sender, EventArgs e)
        {
            ficheClt clt = new ficheClt();
            MessageBox.Show($"{comboBox1.Items.Count}");
            ficheClt.IdClient = Guid.Parse(comboBox1.SelectedValue.ToString());
            clt.Show();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            /*for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Silver;
                }
            }*/
        }
    }
}
