using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using RNetApp.Forms;
namespace RNetApp
{
    public partial class GestionEmploye : UserControl
    {
        //récupération de l'id chef depuis le login page: 
        private static Guid idChef;
        private string idEmp;
        private int position;
        public GestionEmploye()
        {
            InitializeComponent();
        }
        AdoNet ado = new AdoNet();
        public static Guid IdChef { get => idChef; set => idChef = value; }
        private void GestionEmploye_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = "Select * from EMPLOYE";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds, "EMPLOYE");
            dataGridView1.DataSource = ado.Ds.Tables["EMPLOYE"];
            comboBox1.DataSource = ado.Ds.Tables["EMPLOYE"];
            nbrEmp.Text = $"{ado.Ds.Tables["EMPLOYE"].Rows.Count}";
            comboBox1.DisplayMember = ado.Ds.Tables["EMPLOYE"].Columns["PRENOM"].ToString();
            comboBox1.ValueMember = ado.Ds.Tables["EMPLOYE"].Columns["IDEMPLOYE"].ToString();
            dataGridView1.Columns["IDEMPLOYE"].Visible = false;
            dataGridView1.Columns["IDCHEF"].Visible = false;
            dataGridView1.Columns["DATE_DEPART"].Visible = false;
            dataGridView1.Columns["DATE_FIN"].Visible = false;
            dataGridView1.Columns["AGE"].Visible = false;
            dataGridView1.Columns["PRENOM"].Width = 150;
            dataGridView1.Columns["SALAIRE"].Width = 150;
            dataGridView1.Columns["SALAIRE_RESTANT"].Width = 150;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowHeadersVisible = false;
            Shared.addCol(dataGridView1, "delete", "delete","supprimer");
            Shared.addCol(dataGridView1, "edit", "edit","modifier");
            dataGridView1.Columns["PRENOM"].HeaderText = "Prénom";
            dataGridView1.Columns["SALAIRE"].HeaderText = "Salaire";
            dataGridView1.Columns["SALAIRE_RESTANT"].HeaderText = "Salaire Restant";
            dataGridView1.Columns["AVANCE"].HeaderText = "Avance";
        }
        private void congerBtn_Click(object sender, EventArgs e)
        {
            ReposCalcul rc = new ReposCalcul();
            ReposCalcul.IdEmploye = Guid.Parse(ado.Ds.Tables["EMPLOYE"].Rows[position][0].ToString());
            rc.Show();
        }
        private bool checkEmpWithId(string nomEmp, string id)
        {
            foreach (DataRow row in ado.Ds.Tables["EMPLOYE"].Rows)
            {
                if (row["IDEMPLOYE"].ToString().ToLower() == id.ToLower() && row["PRENOM"].ToString().ToLower() == nomEmp.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private bool checkEmpWithNoId(string nomEmp, string id)
        {
            foreach (DataRow row in ado.Ds.Tables["EMPLOYE"].Rows)
            {
                if (row["IDEMPLOYE"].ToString().ToLower() != id.ToLower() && row["PRENOM"].ToString().ToLower() == nomEmp.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private void modifier_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(ado.Adapter);
            congerBtn.Enabled = true;
            checkEmpWithNoId(prenom.Text, idEmp);
            if (checkEmpWithNoId(prenom.Text,idEmp))
            {
                MessageBox.Show("Employé deja existant dans la base : ");
            } else if(checkEmpWithId(prenom.Text,idEmp) || !checkEmpl(prenom.Text))
            {
                ado.Ds.Tables["EMPLOYE"].Rows[position]["NOM"] = nom.Text;
                ado.Ds.Tables["EMPLOYE"].Rows[position]["PRENOM"] = prenom.Text;
                ado.Ds.Tables["EMPLOYE"].Rows[position]["SALAIRE"] = decimal.Parse(salaire.Text);
                ado.Ds.Tables["EMPLOYE"].Rows[position]["AVANCE"] = decimal.Parse(avance.Text);
                ado.Ds.Tables["EMPLOYE"].Rows[position]["SALAIRE_RESTANT"] = decimal.Parse(salaire.Text) - decimal.Parse(avance.Text);
                scb.GetUpdateCommand();
                ado.Adapter.Update(ado.Ds.Tables["EMPLOYE"]);
                MessageBox.Show("modification avec succes");
            }
        }
        private void comboBox1_ValueMemberChanged(object sender, EventArgs e)
        {
        }
        private void ficheBtn_Click(object sender, EventArgs e)
        {
            FichierEmpl emp = new FichierEmpl();
            FichierEmpl.IdEmpl = Guid.Parse(comboBox1.SelectedValue.ToString());
            emp.Show(); 
        }
        private bool checkEmpl(string prenom)
        {
            foreach(DataRow row in ado.Ds.Tables["EMPLOYE"].Rows)
            {
                if (row["PRENOM"].ToString().ToLower() == prenom.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private bool checkInfo()
        {
            return nom.Text != "" && prenom.Text != "" && age.Text != "" && salaire.Text != "";
        }
        private void empBtn_Click(object sender, EventArgs e)
        {
            DataRow dr;
            SqlCommandBuilder sql = new SqlCommandBuilder(ado.Adapter);
            if(!checkEmpl(prenom.Text))
            {
                try
                {
                   if(checkInfo())
                    {
                        affich.Visible = false;
                        dr = ado.Ds.Tables["EMPLOYE"].NewRow();
                        dr[1] = IdChef;
                        dr[2] = nom.Text;
                        dr[3] = prenom.Text;
                        dr[4] = age.Text;
                        dr[8] = decimal.Parse(avance.Text);
                        dr[9] = decimal.Parse(salaire.Text);
                        dr[10] = decimal.Parse(salaire.Text) - decimal.Parse(avance.Text);
                        //attendre les repos depuis le formulaire de calcule : 
                        //
                        ado.Ds.Tables["EMPLOYE"].Rows.Add(dr);
                        sql.GetInsertCommand();
                        ado.Adapter.Update(ado.Ds.Tables["EMPLOYE"]);
                        ado.Ds.Tables["EMPLOYE"].Clear();
                        ado.Cmd.CommandText = "Select * from EMPLOYE";
                        ado.Cmd.Connection = ado.Connection;
                        ado.Adapter.SelectCommand = ado.Cmd;
                        ado.Adapter.Fill(ado.Ds, "EMPLOYE");
                        dataGridView1.DataSource = ado.Ds.Tables["EMPLOYE"];
                    }
                    else
                    {
                        affich.Visible = true;
                        affich.Text = "Veuillez remplir les champs requis";
                    }
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                affich.Visible = true;
                affich.Text = "Employée existe deja";
            }
        }
        private void rechercher_Click(object sender, EventArgs e)
        {
            if (recherche.Text != "")
            {
                DataView dv = new DataView(ado.Ds.Tables["EMPLOYE"]);
                if (checkEmpl(recherche.Text.ToLower()))
                {
                    error.Visible = false;
                    dv.RowFilter = $"PRENOM like '{recherche.Text}'";
                    dataGridView1.DataSource = dv;
                }
                else
                {
                    error.Visible = true;
                    error.Text = "Cet employé n'existe pas";
                }
            }
            else
            {
                error.Visible = true;
                error.Text = "Veuillez inserer quelque chose";
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                        ado.Ds.Tables["EMPLOYE"].Rows[e.RowIndex].Delete();
                        ado.Adapter.Update(ado.Ds.Tables["EMPLOYE"]) ;
                        nbrEmp.Text = $"{ado.Ds.Tables["EMPLOYE"].Rows.Count}";
                    }
                }
                else if (colName == "edit")
                {
                    bool confirmation = Shared.showMessage("Voulez vous vraiment modifier le client ?", "Confirmation de modification");
                    if (confirmation)
                    {
                        DataRow dr = ado.Ds.Tables["EMPLOYE"].Rows[e.RowIndex];
                        nom.Text = dr[2].ToString();
                        prenom.Text = dr[3].ToString();
                        age.Text = dr[4].ToString();
                        salaire.Text = dr[9].ToString();
                        avance.Text = dr[8].ToString();
                        empBtn.Enabled = false;
                        modifier.Enabled = true;
                        congerBtn.Enabled = true;
                        position = e.RowIndex;
                        idEmp = dr[0].ToString();
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
        private void filtreBtn_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(ado.Ds.Tables["EMPLOYE"]);
            dv.Sort = "NOM";
            dataGridView1.DataSource = dv;
        }
    }
}
