using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class GestionEspece : UserControl
    {
        AdoNet ado = new AdoNet();
        AdoNet ado2 = new AdoNet();
        DataRow factureActu;
        public GestionEspece()
        {
            InitializeComponent();
        }
        void loadData()
        {
            ado.Cmd.CommandText = "GETTABLES";
            ado.Cmd.CommandType = CommandType.StoredProcedure;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);
            ado.Ds.Tables[0].TableName = "facture";
            ado.Ds.Tables[1].TableName = "client";
            ado.Ds.Tables[2].TableName = "cheque";
            ado2.Cmd.CommandText = "SELECT * from ESPECE";
            ado2.Cmd.Connection = ado2.Connection;
            ado2.Adapter.SelectCommand = ado2.Cmd;
            ado2.Adapter.Fill(ado2.Dt);
        }
        private void GestionEspece_Load(object sender, EventArgs e)
        {
            loadData();
            dataGridView1.DataSource = ado2.Dt;
            //fill the combobox : 
            nbrefac.Text = $"{ado.Ds.Tables["facture"].Rows.Count}";
            dataGridView1.Columns["IDCLIENT"].Visible = false;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowHeadersVisible = false;
            Shared.addCol(dataGridView1, "voir", "voir", "");
            Shared.addCol(dataGridView1, "edit", "edit", "");
            Shared.addCol(dataGridView1, "delete", "delete", "");
        }
        private void lister_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(ado2.Dt);
            dv.RowFilter = $"idclient = '{Guid.Parse(comboBox2.SelectedValue.ToString())}'";
            MessageBox.Show(comboBox2.SelectedValue.ToString());
            if (comboBox2.Text != "Tous")
            {
                dataGridView1.DataSource = dv;
            }
            else
            {
                dataGridView1.DataSource = ado2.Dt;
            }
        }

        private void ajoutEsp_Click(object sender, EventArgs e)
        {
            AjoutEspece ajout_espece = new AjoutEspece();
            ajout_espece.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if(colName == "edit")
            {
                ModifierEspece modifierEspece = new ModifierEspece();
                modifierEspece.IdEspece = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["idespece"].Value.ToString());
                modifierEspece.Show();
            }
        }
    }
}
