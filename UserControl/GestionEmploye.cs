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
            comboBox1.DisplayMember = ado.Ds.Tables["EMPLOYE"].Columns["PRENOM"].ToString();
            comboBox1.ValueMember = ado.Ds.Tables["EMPLOYE"].Columns["IDEMPLOYE"].ToString();
            dataGridView1.Columns["IDEMPLOYE"].Visible = false;
            dataGridView1.Columns["IDCHEF"].Visible = false;
            dataGridView1.Columns["DATE_DEPART"].Visible = false;
            dataGridView1.Columns["DATE_FIN"].Visible = false;
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
            rc.Show();
        }
        private void modifier_Click(object sender, EventArgs e)
        {
            congerBtn.Visible = true;
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
                if(row["PRENOM"].ToString() == prenom)
                {
                    return true;
                }
            }
            return false;
        }
        private void empBtn_Click(object sender, EventArgs e)
        {
            DataRow dr;
            SqlCommandBuilder sql = new SqlCommandBuilder(ado.Adapter);
            if(!checkEmpl(prenom.Text))
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
                ado.Ds.Tables["EMPLOYE"].Rows.Add(dr);
                sql.GetInsertCommand();
                ado.Adapter.Update(ado.Ds.Tables["EMPLOYE"]);
            } else
            {
                affich.Visible = true;
                affich.Text = "Employée existe deja";
            }
        }
    }
}
