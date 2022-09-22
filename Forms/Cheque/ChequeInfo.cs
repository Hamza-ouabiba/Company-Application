using System;
using System.Data;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class ChequeInfo : Form
    {
        private static int idcheque;
        AdoNet ado = new AdoNet();
        public ChequeInfo()
        {
            InitializeComponent();
        }
        public static int Idcheque { get => idcheque; set => idcheque = value; }
        
        private void ChequeInfo_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = $"select * from cheque where idcheque = {idcheque}";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds,"cheque");
            ado.Cmd.CommandText = $"select * from client where idclient = '{Guid.Parse(ado.Ds.Tables["cheque"].Rows[0]["idclient"].ToString())}'";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds, "client");
            numCheq.Text = ado.Ds.Tables["cheque"].Rows[0]["idcheque"].ToString();
            montantChe.Text = ado.Ds.Tables["cheque"].Rows[0]["montant"].ToString();
            nomT.Text = ado.Ds.Tables["client"].Rows[0]["nom"].ToString();
            factuNu.Text = ado.Ds.Tables["cheque"].Rows[0]["idfacture"].ToString();
        }
    }
}
