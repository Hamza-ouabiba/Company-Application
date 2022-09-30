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

        private void imprimer_Click(object sender, EventArgs e)
        {
            //fill datagrid : 
            DGVPrinter dGVPrinter = new DGVPrinter();
            int idcheque = int.Parse(ado.Ds.Tables["cheque"].Rows[0]["idcheque"].ToString());
            int idfacture = int.Parse(ado.Ds.Tables["cheque"].Rows[0]["idfacture"].ToString());
            Guid idclient = Guid.Parse(ado.Ds.Tables["cheque"].Rows[0]["idclient"].ToString());
            ado.Dt.Clear();
            ado.Cmd.CommandText = $"select cheque.idCheque,client.NOM,facture.idfacture from ((cheque inner join client on cheque.idcheque = {idcheque} and client.IDCLIENT = cheque.idclient and client.idclient = '{idclient}') inner join facture on facture.idfacture = cheque.idfacture and facture.idfacture = {idfacture})";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            dataGridView1.DataSource = ado.Dt;
            dGVPrinter.Title = $"Chèque de la facture : {idfacture}";
            dGVPrinter.Footer = "Blanchisserie R-net Plus";
            dGVPrinter.PorportionalColumns = true;
            dGVPrinter.FooterSpacing = 15;
            dGVPrinter.PrintPreviewDataGridView(dataGridView1);
        }
    }
}
