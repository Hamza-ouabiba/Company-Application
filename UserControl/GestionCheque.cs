using System;
using System.Data;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class GestionCheque : UserControl
    {
        AdoNet ado = new AdoNet();
        public GestionCheque()
        {
            InitializeComponent();
        }
        private void fillCombo(ComboBox comb, string[] names)
        {
            comb.Items.Clear();
            names[0] = "Tous";
            comb.Items.AddRange(names);
        }
        private string[] retrievingEmployees(DataTable dt)
        {
            string[] ret = new string[dt.Rows.Count + 1];
            for (int i = 1; i < ret.Length; i++)
            {
                ret[i] = dt.Rows[i - 1]["nom"].ToString();
            }
            return ret;
        }
        private void setDataGrid()
        {
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.Columns["IDCLIENT"].Visible = false;
            Shared.addCol(dataGridView1, "voir", "voir", "");
            Shared.addCol(dataGridView1, "edit", "edit", "");
            Shared.addCol(dataGridView1, "delete", "delete", "");
        }
        private void GestionCheque_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = $"SELECT * FROM CHEQUE";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds, "Cheque");
            dataGridView1.DataSource = ado.Ds.Tables["Cheque"];
            ado.Cmd.CommandText = $"SELECT * FROM client";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds, "client");
            fillCombo(comboBox1, retrievingEmployees(ado.Ds.Tables["client"]));
            setDataGrid();
        }
        private void nvChequeBtn_Click_1(object sender, EventArgs e)
        {
            ChequeFacture cf = new ChequeFacture();
            cf.Show();
        }
        //search for client with name and return its id :
        private Guid searchClientCombo(string nom)
        {
            for (int i = 0; i < ado.Ds.Tables["client"].Rows.Count; i++)
            {
                if (nom == ado.Ds.Tables["client"].Rows[i]["nom"].ToString())
                {
                    return Guid.Parse(ado.Ds.Tables["client"].Rows[i]["idclient"].ToString());
                }
            }
            return Guid.Empty;
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(ado.Ds.Tables["cheque"]);
            dv.RowFilter = $"idclient = '{searchClientCombo(comboBox1.Text)}'";
            if (comboBox1.Text != "Tous")
            {
                dataGridView1.DataSource = dv;
            }
            else
            {
                dataGridView1.DataSource = ado.Ds.Tables["cheque"];
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex != -1)
            {
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colName == "voir")
                {
                    ChequeInfo cheque = new ChequeInfo();
                    ChequeInfo.Idcheque = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["idcheque"].Value.ToString());
                    cheque.Show();
                } else if(colName == "edit")
                {
                    ModifierCheque modifier_cheque = new ModifierCheque();
                    ModifierCheque.Idcheque = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["idcheque"].Value.ToString());
                    modifier_cheque.Show();
                }
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colName == "voir" || colName == "edit" || colName == "delete")
                {
                    dataGridView1.Cursor = Cursors.Hand;
                } else
                {
                    dataGridView1.Cursor = Cursors.Default;
                }
            }
        }
    }
}
