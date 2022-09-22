using System;
using System.Data;
using System.Windows.Forms;

namespace RNetApp
{
    public partial class ficheClt : Form
    {
        private static Guid idClient;
        AdoNet ado = new AdoNet();
        public ficheClt()
        {
            InitializeComponent();
        }

        public static Guid IdClient { get => idClient; set => idClient = value; }

        private void ficheClt_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = $"Select * from CLIENT where IDCLIENT  = '{IdClient}'";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            nomCL.Text = ado.Dt.Rows[0]["NOM"].ToString();
            salaire.Text = ado.Dt.Rows[0]["MONTANT"].ToString();
            tel_cl.Text = ado.Dt.Rows[0]["tel_client"].ToString();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
