using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RNetApp
{
    public partial class ModifierFacture : Form
    {
        int idfacture;
        AdoNet ado = new AdoNet();
        public ModifierFacture()
        {
            InitializeComponent();
        }
        public int Idfacture { get => idfacture; set => idfacture = value; }
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
        private void searchFac()
        {
            ado.Ds.Tables["facture"].PrimaryKey = new DataColumn[] { ado.Ds.Tables["facture"].Columns["idfacture"] };
            DataRow row = ado.Ds.Tables["facture"].Rows.Find(idfacture);
            if(row != null)
            {
                monHT.Text = row["total_ht"].ToString();
                monTtc.Text = row["total_ttc"].ToString();
                if(row["pay_o_n"].ToString() == "0")
                {
                    statuFac.Text = "Non Payée";
                } else
                {
                    statuFac.Text = "Payée";
                }
                searchClient(Guid.Parse(row["idclient"].ToString()));
            }
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
        private void ModifierFacture_Load(object sender, EventArgs e)
        {
            loadData();
            searchFac();
        }
    }
}
