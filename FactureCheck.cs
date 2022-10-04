using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;
namespace RNetApp
{
    public partial class FactureCheck : Form
    {
        private DataRow facture;
        AdoNet ado = new AdoNet();
        public FactureCheck()
        {
            InitializeComponent();
        }
        public DataRow Facture { get => facture; set => facture = value; }

        private void ajustementEcran()
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }
        private void loadData()
        {
            ado.Cmd.CommandText = "FactureCheck";
            ado.Cmd.CommandType = CommandType.StoredProcedure;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);
            ado.Ds.Tables[0].TableName = "facture";
            ado.Ds.Tables[1].TableName = "client";
            ado.Ds.Tables[2].TableName = "avoir";
        }
        private string seachClientName()
        {
            foreach(DataRow dataRow in ado.Ds.Tables["client"].Rows)
            {
                if (Guid.Parse(facture["idclient"].ToString()) == Guid.Parse(dataRow["idclient"].ToString()))
                    return dataRow["nom"].ToString();
            }
            return null;
        }
        private void textBoxValues()
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox )
                {
                    foreach(DataRow dataRow in ado.Ds.Tables["avoir"].Rows)
                    {
                        if(dataRow["designation"].ToString() == control.Name && dataRow["idfacture"].ToString() == facture["idfacture"].ToString())
                        {
                            control.Text = dataRow["quantite"].ToString();
                        }
                    }
                }
            }
        }
        private void FactureCheck_Load(object sender, EventArgs e)
        {
            ajustementEcran();
            loadData();
            string nomClient = seachClientName();
            dateNow.Text = facture["date_"].ToString();
            nomCl.Text = nomClient;
            facturNum.Text = facture["idfacture"].ToString();
            textBoxValues();
        }
        private void print_Click_1(object sender, EventArgs e)
        {
            AdoNet ado2 = new AdoNet();
            factureDs factureDs = new factureDs();
            ado2.Cmd.CommandText = $"select a.MontantLettre,a.total_ttc,a.idFacture,b.NOM,d.DESIGNATION,d.quantite,c.prix_unitaire from facture a join client b on a.idclient = b.IDCLIENT join changer c on c.IDCLIENT = b.IDCLIENT join avoir d on a.idFacture = d.IDFACTURE and a.idfacture = {int.Parse(facture["idfacture"].ToString())} and c.Designation = d.DESIGNATION";
            ado2.Cmd.Connection = ado2.Connection;
            ado2.Adapter.SelectCommand = ado2.Cmd;
            ado2.Adapter.Fill(factureDs.FactureClient);
            DataTable datasource = factureDs.FactureClient;
            string path = @"reports\Report1.rdlc";
            string dataSource_ = "Facture";
            string fileName = "Facture";
            Shared.printToPdf(path, dataSource_, datasource, fileName);
        }
    }
}
