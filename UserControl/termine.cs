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
    public partial class termine : UserControl
    {
        AdoNet ado = new AdoNet();
        public termine()
        {
            InitializeComponent();
        }
        void filterData(DataTable dt)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = $"termine_o_n = {1}";
            dataGridView1.DataSource = dv;
        }
        private void termine_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = "gestiontache";
            ado.Cmd.CommandType = CommandType.StoredProcedure;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);
            ado.Ds.Tables[0].TableName = "tache";
            ado.Ds.Tables[1].TableName = "categorie";
            dataGridView1.DataSource = ado.Ds.Tables["tache"];
            filterData(ado.Ds.Tables["tache"]);
            Shared.addCol(dataGridView1, "delete", "delete", "supprimer");
        }
    }
}
