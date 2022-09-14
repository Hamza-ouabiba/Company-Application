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

        private void GestionCheque_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = $"SELECT * FROM CHEQUE";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds, "Cheque");
            dataGridView1.DataSource = ado.Ds.Tables["Cheque"];
            dataGridView1.Columns["IDCHEQUE"].Width = 150;
            dataGridView1.Columns["idfacture"].Width = 150;
            dataGridView1.Columns["IDCLIENT"].Visible = false;
            dataGridView1.Columns["MONTANT"].Width = 200;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowHeadersVisible = false;
            ado.Cmd.CommandText = $"SELECT * FROM client";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds, "client");
            comboBox1.DisplayMember = ado.Ds.Tables["client"].Columns["NOM"].ToString();
            comboBox1.ValueMember = ado.Ds.Tables["client"].Columns["idclient"].ToString();
            comboBox1.DataSource = ado.Ds.Tables["client"];
            Shared.addCol(dataGridView1, "but", "voir", "");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                if(colName == "but")
                {
                    foreach(DataRow dr in ado.Ds.Tables["client"].Rows)
                    {
                        if(dr["idclient"].ToString() == dataGridView1.Rows[e.RowIndex].Cells["idCLient"].Value.ToString())
                        {
                            nomT.Text = dr["nom"].ToString();
                            factuNu.Text = dataGridView1.Rows[e.RowIndex].Cells["idfacture"].Value.ToString();
                            numCheq.Text = dataGridView1.Rows[e.RowIndex].Cells["idcheque"].Value.ToString();
                            montantChe.Text = dataGridView1.Rows[e.RowIndex].Cells["montant"].Value.ToString();
                            break;
                        }
                    }
                }
            }
        }

        private void nvChequeBtn_Click(object sender, EventArgs e)
        {
            ChequeFacture cf = new ChequeFacture();
            cf.Show();
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(ado.Ds.Tables["cheque"]);
            dv.RowFilter = $"idclient = '{Guid.Parse(comboBox1.SelectedValue.ToString())}'";
            if(comboBox1.Text != "Tous")
            {
                dataGridView1.DataSource = dv;
            } else
            {
                dataGridView1.DataSource = ado.Ds.Tables["cheque"];
            }
        }
    }
}
