using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class important : UserControl
    {
        AdoNet ado = new AdoNet();
        public important()
        {
            InitializeComponent();
        }
        void filterData(DataTable dt)
        {
            DataView dv = new DataView(ado.Ds.Tables["tache"]);
            dv.RowFilter = $"nomcategorie = 'important' and termine_o_n = {0}";
            dataGridView1.DataSource = dv;
        }
        private void important_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = "gestiontache";
            ado.Cmd.CommandType = CommandType.StoredProcedure;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);
            ado.Ds.Tables[0].TableName = "tache";
            ado.Ds.Tables[1].TableName = "categorie";
            filterData(ado.Ds.Tables[0]);
            Shared.addCol(dataGridView1, "finish", "finish", "termine");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            filterData(ado.Ds.Tables["tache"]);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(ado.Adapter);
            if (e.ColumnIndex != -1)
            {
                if(dataGridView1.Columns[e.ColumnIndex].Name == "finish")
                {
                    MessageBox.Show($"{e.RowIndex}");
                    sqlCommandBuilder.GetUpdateCommand();
                    ado.Ds.Tables["tache"].Rows[e.RowIndex]["termine_o_n"] = 1;
                    ado.Adapter.Update(ado.Ds.Tables["tache"]);
                }
            }
        }
    }
}
