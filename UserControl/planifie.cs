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
    public partial class planifie : UserControl
    {
        AdoNet ado = new AdoNet();
        public planifie()
        {
            InitializeComponent();
        }
        void filterData(DataTable dt)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = $"nomcategorie = 'planifie' and termine_o_n = {0}";
            dgvplanifie.DataSource = dv;    
;        }
        private void planifie_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = "gestiontache";
            ado.Cmd.CommandType = CommandType.StoredProcedure;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);
            ado.Ds.Tables[0].TableName = "tache";
            ado.Ds.Tables[1].TableName = "categorie";
            dgvplanifie.DataSource = ado.Ds.Tables[0];
            Shared.addCol(dgvplanifie, "finish", "finish","termine");
            Shared.addCol(dgvplanifie, "delete", "delete", "supprimer");
            dgvplanifie.RowTemplate.Height = 40;
            filterData(ado.Ds.Tables[0]);
        }
        private void dgvplanifie_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != -1)
            {
                string colName = dgvplanifie.Columns[e.ColumnIndex].Name;
                if(colName == "delete" || colName == "finish")
                {
                    dgvplanifie.Cursor = Cursors.Hand;
                } else
                {
                    dgvplanifie.Cursor = Cursors.Default;
                }
            }
        }
    }
}
