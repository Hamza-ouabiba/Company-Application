using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;
using RNetApp.Datasets;
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
            ado.Cmd.CommandText = $"select a.idFacture,d.DESIGNATION,d.quantite,c.prix_unitaire from facture a join client b on a.idclient = b.IDCLIENT join changer c on c.IDCLIENT = b.IDCLIENT join avoir d on a.idFacture = d.IDFACTURE and a.idfacture = {int.Parse(facture["idfacture"].ToString())} and c.Designation = d.DESIGNATION";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            dataGridView1.DataSource = ado.Dt;
        }
        private void FactureCheck_Load(object sender, EventArgs e)
        {
            ajustementEcran();
            loadData();
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
