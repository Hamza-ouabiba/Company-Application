using System;
using System.Data;
using System.Windows.Forms;

namespace RNetApp
{
    public partial class FichierEmpl : Form
    {
        private static Guid idEmpl;
        AdoNet ado = new AdoNet();
        public static Guid IdEmpl { get => idEmpl; set => idEmpl = value; }
        public FichierEmpl()
        {
            InitializeComponent();
        }
        private void FichierEmpl_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = $"Select * from EMPLOYE where IDEMPLOYE like '{IdEmpl}'";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            nom.Text = ado.Dt.Rows[0]["NOM"].ToString();
            age.Text = ado.Dt.Rows[0]["AGE"].ToString();
            prenom.Text = ado.Dt.Rows[0]["PRENOM"].ToString();
            if (ado.Dt.Rows[0]["REPOS"].ToString() != "")
                repos.Text = ado.Dt.Rows[0]["REPOS"].ToString();
            else
                repos.Text = "Aucun Repos";
            Avance.Text = ado.Dt.Rows[0]["AVANCE"].ToString();
            salaire.Text = ado.Dt.Rows[0]["SALAIRE"].ToString();
            if (ado.Dt.Rows[0]["SALAIRE_RESTANT"].ToString() != "")
                SalaireRes.Text = ado.Dt.Rows[0]["SALAIRE_RESTANT"].ToString();
            else
                SalaireRes.Text = "Aucun reste";
            if (ado.Dt.Rows[0]["ABSCENCE"].ToString() != "")
                absc.Text = ado.Dt.Rows[0]["ABSCENCE"].ToString();
            else
                absc.Text = "Aucun abscence";   
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
