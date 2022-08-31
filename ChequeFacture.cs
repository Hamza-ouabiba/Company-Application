using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using RNetApp.Forms;
namespace RNetApp
{
    public partial class ChequeFacture : Form
    {
        AdoNet ado = new AdoNet();
        private static Guid idClient;
        private int factureNum;
        public static Guid IdClient { get => idClient; set => idClient = value; }
        public int FactureNum { get => factureNum; set => factureNum = value; }

        public ChequeFacture()
        {
            InitializeComponent();
        }

        private void ChequeFacture_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = $"SELECT * FROM CLIENT WHERE IDCLIENT = '{IdClient}'";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            /*factuNu*/
            nomT.Text = ado.Dt.Rows[0]["NOM"].ToString();
            factuNu.Text = $"{FactureNum}";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void enrBtn_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(ado.Adapter);
            ado.Cmd.CommandText = "SELECT * FROM CHEQUE";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds, "cheque");
            DataRow dr = ado.Ds.Tables["cheque"].NewRow();
            dr[0] = int.Parse(numCheq.Text);
            dr[1] = FactureNum;
            dr[2] = idClient;
            dr[3] = decimal.Parse(montantChe.Text);
            ado.Ds.Tables["cheque"].Rows.Add(dr);
            scb.GetInsertCommand();
            ado.Adapter.Update(ado.Ds.Tables["cheque"]);
            MessageBox.Show("Cheque ajouté avec succés");
            this.Close();
        }
    }
}
