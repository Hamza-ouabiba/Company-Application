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
    public partial class infoFacture : Form
    {
        static DataRow facture = null;
        static DataTable client = null;
        static int nombreCheque = 0;
        static int nombreEspece = 0;
        public infoFacture()
        {
            InitializeComponent();
        }
        public static DataRow Facture { get => facture; set => facture = value; }
        public static DataTable Client { get => client; set => client = value; }
        public static int NombreCheque { get => nombreCheque; set => nombreCheque = value; }
        public static int NombreEspece { get => nombreEspece; set => nombreEspece = value; }
        private void infoFacture_Load(object sender, EventArgs e)
        {
            if(Facture != null)
            {
                client.PrimaryKey = new DataColumn[] { client.Columns["idclient"] };
                DataRow dr = client.Rows.Find(Guid.Parse(Facture["idclient"].ToString()));
                nomClt.Text = dr["nom"].ToString();
                numFac.Text = facture["idfacture"].ToString();
                nbreCheq.Text = $"{nombreCheque} cheque qui sont versée ";
                totalHt.Text = facture["total_ht"].ToString();
                totalTtc.Text = facture["total_ttc"].ToString();
                dateFa.Text = facture["date_"].ToString();
                nbreEsp.Text = $"{nombreEspece} Espèces";
                restPa.Text = facture["total_rest"].ToString();
            }
        }
    }
}
