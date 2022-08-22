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
            repos.Text = ado.Dt.Rows[0]["REPOS"].ToString();
            Avance.Text = ado.Dt.Rows[0]["AVANCE"].ToString();
            salaire.Text = ado.Dt.Rows[0]["SALAIRE"].ToString();
            SalaireRes.Text = ado.Dt.Rows[0]["SALAIRE_RESTANT"].ToString();
            absc.Text = ado.Dt.Rows[0]["ABSCENCE"].ToString();
        }
    }
}
