using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class GestionClient : UserControl
    {
        private static int position;
        private static int position2 = -1;
        public GestionClient()
        {
            InitializeComponent();
        }
        AdoNet ado = new AdoNet();
        AdoNet ado2 = new AdoNet();
        private void GestionClient_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = $"Select * from CLIENT";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            nbreClt.Text = ado.Dt.Rows.Count.ToString();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ado.Dt;
            affichageGrid();
        }
        //Methode pour verifier les champs :
        private bool checkInfo()
        {
                return nomClt.Text != "" && Montant.Text != "" && avance.Text != "";
        }
        private bool checkClient(string nomClt)
        {
            foreach(DataRow row in ado.Dt.Rows)
            {
                if(row["NOM"].ToString().ToLower() == nomClt.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private bool checkUserWithId(string nomClt,string id)
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
        private bool checkUserWithNoId(string nomClt, string id)
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
        private void effacerTextBox()
        {
            nomClt.Clear();
            avance.Clear(); 
            Montant.Clear();
            totalRes.Clear();
            cheque.Checked = false;
            espece.Checked = false;
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
                    if (float.Parse(avance.Text) <= float.Parse(Montant.Text))
                    {
                        if (!checkClient(nomClt.Text))
                        {
                            dr = ado.Dt.NewRow();
                            dr[1] = nomClt.Text;
                            dr[2] = float.Parse(Montant.Text);
                            dr[4] = float.Parse(avance.Text);
                            dr[3] = float.Parse(Montant.Text) - float.Parse(avance.Text);
                            if (cheque.Checked)
                            {
                                dr[6] = true;
                                dr[5] = false;
                            }
                            else if(espece.Checked)
                            {
                                dr[6] = false;
                                dr[5] = true;
                            }
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
                    }
                    else MessageBox.Show("c'est illogique d'avoir l'avance plus que le montant");
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
            dataGridView1.Columns["NOM"].Width = 150;
            dataGridView1.Columns["MONTANT"].Width = 150;
            dataGridView1.Columns["TOTAL_REST"].Width = 150;
            dataGridView1.Columns["Avance"].Width = 150;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowHeadersVisible = false;
            Shared.addCol(dataGridView1, "delete", "delete", "supprimer");
            Shared.addCol(dataGridView1, "edit", "edit", "modifier");
            dataGridView1.Columns["NOM"].HeaderText = "Nom client";
            dataGridView1.Columns["MONTANT"].HeaderText = "Montant Par mois";
            dataGridView1.Columns["TOTAL_REST"].HeaderText = "Total Restant";
            dataGridView1.Columns["Avance"].HeaderText = "Avance";
            dataGridView1.Columns["payE"].HeaderText = "Payé par espèce";
            dataGridView1.Columns["payC"].HeaderText = "Payé par chèque";
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
                        SqlCommandBuilder scb2 = new SqlCommandBuilder(ado2.Adapter);
                        MessageBox.Show($"{position2}");
                        if (position2 != -1)
                        {
                            scb2.GetDeleteCommand();
                            ado2.Dt.Rows[position2].Delete();
                            ado2.Adapter.Update(ado2.Dt);
                            nbreClt.Text = $"{ado2.Dt.Rows.Count}";
                            position2 = -1;
                        } else
                        {
                            scb.GetDeleteCommand();
                            ado.Dt.Rows[e.RowIndex].Delete();
                            ado.Adapter.Update(ado.Dt);
                            nbreClt.Text = $"{ado.Dt.Rows.Count}";
                        }
                    }
                } else if(colName == "edit")
                {
                    bool confirmation = Shared.showMessage("Voulez vous vraiment modifier le client ?", "Confirmation de modification");
                    if(confirmation)
                    {
                        DataRow dr = ado.Dt.Rows[e.RowIndex];
                        idClientT.Text = dr[0].ToString();
                        nomClt.Text = dr[1].ToString();
                        Montant.Text = dr[2].ToString();
                        totalRes.Text = dr[3].ToString();
                        avance.Text = dr[4].ToString();
                        enregBtn.Enabled = false;
                        modifierBtn.Enabled = true;
                        position = e.RowIndex;
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
        private void modifierBtn_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(ado.Adapter);
            try
            {
                if(checkUserWithNoId(nomClt.Text,idClientT.Text))
                {
                    MessageBox.Show("Ce client existe deja dans la base de donnée Pensez a saisir un nouveau nom");
                } else if(checkUserWithId(nomClt.Text,idClientT.Text) || !checkClient(nomClt.Text))
                {
                    ado.Dt.Rows[position]["NOM"] = nomClt.Text;
                    ado.Dt.Rows[position]["MONTANT"] = decimal.Parse(Montant.Text);
                    ado.Dt.Rows[position]["AVANCE"] = decimal.Parse(avance.Text);
                    ado.Dt.Rows[position]["TOTAL_REST"] = decimal.Parse(Montant.Text) - decimal.Parse(avance.Text);
                    if (cheque.Checked)
                    {
                        ado.Dt.Rows[position]["payE"] = false;
                        ado.Dt.Rows[position]["payC"] = true;
                    }
                    else
                    {
                        ado.Dt.Rows[position]["payE"] = true;
                        ado.Dt.Rows[position]["payC"] = false;
                    }
                    scb.GetUpdateCommand();
                    ado.Adapter.Update(ado.Dt);
                    effacerTextBox();
                    MessageBox.Show("modification avec succes");
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void rechercher_Click(object sender, EventArgs e)
        {
            if (recherche.Text != "")
            {
                ado2.Dt = new DataTable();
                ado2.Cmd.CommandText = $"Select * from CLIENT where NOM like '{recherche.Text}'";
                ado2.Cmd.Connection = ado2.Connection;
                ado2.Adapter.SelectCommand = ado2.Cmd;
                ado2.Adapter.Fill(ado2.Dt);
                dataGridView1.DataSource = ado2.Dt;
                MessageBox.Show($"{ado2.Dt.Rows.Count}");
                for(int i=0;i<ado2.Dt.Rows.Count;i++)
                {
                    if(recherche.Text == ado2.Dt.Rows[i]["NOM"].ToString())
                    {
                        nbreClt.Text = $"{ado2.Dt.Rows.Count}";
                        position2 = i;
                        break;
                    }
                }
            }
            else
            {
                ado.Dt = new DataTable();
                GestionClient_Load(sender, e);
            }

        }
    }
}
