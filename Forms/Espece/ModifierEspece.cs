using System;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class ModifierEspece : Form
    {
        AdoNet ado = new AdoNet();
        AdoNet ado2 = new AdoNet(); 
        int idEspece = 0;
        public ModifierEspece()
        {
            InitializeComponent();
        }
        public int IdEspece { get => idEspece; set => idEspece = value; }
        private void loadEspeceData()
        {
            ado.Cmd.CommandText = $"select * from espece where idespece = {idEspece};";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
        }
        private string loadClientData()
        {
            ado2.Cmd.CommandText = $"select * from client where idclient = '{Guid.Parse(ado.Dt.Rows[0]["idclient"].ToString())}'";
            ado2.Cmd.Connection = ado.Connection;
            ado2.Adapter.SelectCommand = ado2.Cmd;
            ado2.Adapter.Fill(ado2.Dt);
            return ado2.Dt.Rows[0]["nom"].ToString();
        }
        private void ModifierEspece_Load(object sender, EventArgs e)
        {
            loadEspeceData();
            string nomClient = loadClientData();
            nomT.Text = nomClient;
            montantEsp.Text = $"{ado.Dt.Rows[0]["montant"].ToString()}";
            factuNu.Text = ado.Dt.Rows[0]["idfacture"].ToString();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {

        }
    }
}
