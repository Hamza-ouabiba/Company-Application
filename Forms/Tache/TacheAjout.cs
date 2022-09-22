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
    public partial class TacheAjout : Form
    {
        AdoNet ado = new AdoNet();
        public TacheAjout()
        {
            InitializeComponent();
        }
        private void TacheAjout_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = "gestiontache";
            ado.Cmd.CommandType = CommandType.StoredProcedure;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);
            ado.Ds.Tables[0].TableName = "tache";
            ado.Ds.Tables[1].TableName = "categorie";
            comboBox1.DisplayMember = "nomcategorie";
            comboBox1.DataSource = ado.Ds.Tables["categorie"];
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            date_planif.Text = monthCalendar1.SelectionStart.ToShortDateString();  
        }
    }
}
