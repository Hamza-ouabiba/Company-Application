using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RNetApp.Forms
{
    public partial class ModifierClient : Form
    {
        AdoNet ado = new AdoNet();
        private static Guid idClient;

        public static Guid IdClient { get => idClient; set => idClient = value; }

        public ModifierClient()
        {
            InitializeComponent();
        }

        private void ModifierClient_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = $"Select * from CLIENT where IDCLIENT = '{IdClient}'";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            nomClt.Text = ado.Dt.Rows[0]["NOM"].ToString();
            Montant.Text = ado.Dt.Rows[0]["MONTANT"].ToString();
            avance.Text = ado.Dt.Rows[0]["AVANCE"].ToString();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
