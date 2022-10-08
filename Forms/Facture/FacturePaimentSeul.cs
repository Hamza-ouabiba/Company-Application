using System;
using System.Data;
using System.Windows.Forms;

namespace RNetApp
{
    public partial class FacturePaimentSeul : Form
    {
        int idFacture;
        AdoNet ado = new AdoNet();
        public int IdFacture { get => idFacture; set => idFacture = value; }

        public FacturePaimentSeul()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            ado.Cmd.CommandText = "GETTABLES";
            ado.Cmd.CommandType = CommandType.StoredProcedure;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);

            ado.Ds.Tables[0].TableName = "facture";
            ado.Ds.Tables[1].TableName = "client";
            ado.Ds.Tables[2].TableName = "cheque";
            ado.Ds.Tables[3].TableName = "espece";
            ado.Ds.Tables[4].TableName = "changer";
        }
        private void searchClient(Guid idclient)
        {
            ado.Ds.Tables["client"].PrimaryKey = new DataColumn[] { ado.Ds.Tables["client"].Columns["idclient"] };
            DataRow row = ado.Ds.Tables["client"].Rows.Find(idclient);
            if (row != null)
            {
                nomClt.Text = row["nom"].ToString();
            }
        }
        private void FacturePaimentSeul_Load(object sender, EventArgs e)
        {
            loadData();
            ado.Ds.Tables["facture"].PrimaryKey = new DataColumn[] { ado.Ds.Tables["facture"].Columns["idfacture"] };
            DataRow row = ado.Ds.Tables["facture"].Rows.Find(idFacture);
            searchClient(Guid.Parse(row["idclient"].ToString()));
            facNum.Text = row["idfacture"].ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numChe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
