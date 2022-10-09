using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace RNetApp.Forms
{
    public partial class ReposCalcul : Form
    {
        private static Guid idEmploye;
        AdoNet ado = new AdoNet();
        public ReposCalcul()
        {
            InitializeComponent();
        }
        public static Guid IdEmploye { get => idEmploye; set => idEmploye = value; }
        private void calcul_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            SqlCommandBuilder cmd = new SqlCommandBuilder(ado.Adapter);
            double d1 = (dateTimePicker1.Value.ToLocalTime() - new DateTime(1970, 1, 1)).TotalMilliseconds;
            double d2 = (dateTimePicker2.Value.ToLocalTime() - new DateTime(1970, 1, 1)).TotalMilliseconds;
            double temps;
            nbreCon.Visible = true;
            nbreCon.Text = $"{Math.Round((d2 - d1) / (1000 * 3600 * 24))} Jours de repos ";
            ado.Ds.Tables["EMPLOYE"].Rows[0]["REPOS"] = Math.Round((d2 - d1) / (1000 * 3600 * 24));
            cmd.GetUpdateCommand();
            ado.Adapter.Update(ado.Ds.Tables["EMPLOYE"]);
            MessageBox.Show("Enregistrement de la valeur de repos avec succés ");
            this.Hide();
        }
        private void ReposCalcul_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = $"SELECT * from EMPLOYE where IDEMPLOYE  = '{IdEmploye}'";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds, "EMPLOYE");
            nomEmp.Text = ado.Ds.Tables["EMPLOYE"].Rows[0]["NOM"].ToString();
            PrenoEmp.Text = ado.Ds.Tables["EMPLOYE"].Rows[0]["PRENOM"].ToString();
        }
    }
}
