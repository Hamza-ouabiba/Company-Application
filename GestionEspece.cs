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
        public GestionEspece()
        {
            InitializeComponent();
        }
        private void GestionEspece_Load(object sender, EventArgs e)
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
            ado2.Adapter.Fill(ado2.Dt) ;
            dataGridView1.DataSource = ado2.Dt;
            //fill the combobox : 
            comboBox1.DisplayMember = ado.Ds.Tables["facture"].Columns["idfacture"].ToString();
            comboBox1.ValueMember = ado.Ds.Tables["client"].Columns["idclient"].ToString();
            comboBox1.DataSource = ado.Ds.Tables["facture"];
            nbrefac.Text = $"{ado.Ds.Tables["facture"].Rows.Count}";
            dataGridView1.Columns["IDCLIENT"].Visible = false;
            dataGridView1.Columns["idfacture"].Width = 200;
            dataGridView1.Columns["montant"].Width = 200;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowHeadersVisible = false;
            Shared.addCol(dataGridView1, "but", "voir", "");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                ado.Ds.Tables["facture"].PrimaryKey = new DataColumn[] { ado.Ds.Tables["facture"].Columns["idfacture"] };
                DataRow dr_facture = ado.Ds.Tables["facture"].Rows.Find(int.Parse(comboBox1.Text));
                //verifier la facture : 
                if (dr_facture["pay_o_n"].ToString() == "True")
                {
                    error.Visible = true;
                    error.Text = "Facture deja payée";
                    enrBtn.Enabled = false;
                }
                else
                {
                    ado.Ds.Tables["client"].PrimaryKey = new DataColumn[] { ado.Ds.Tables["client"].Columns["idclient"] };
                    DataRow dr_client = ado.Ds.Tables["client"].Rows.Find(Guid.Parse(dr_facture["idclient"].ToString()));
                    enrBtn.Enabled = true;
                    error.Visible = false;
                    nomClt.Text = dr_client["nom"].ToString();
                }
            }
        }

        private void enrBtn_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(ado.Adapter);
            DataRow dr = ado.Dt.NewRow();
            dr[0] = int.Parse(numEsp.Text);
            dr[1] = int.Parse(comboBox1.Text);
            dr[2] = Guid.Parse(comboBox1.SelectedValue.ToString());
            dr[3] = decimal.Parse(Montant.Text);
            ado.Ds.Tables["espece"].Rows.Add(dr);
            scb.GetInsertCommand();
            MessageBox.Show($"{ado.Dt.Rows.Count}");
            ado.Adapter.Update(ado.Dt);
        }
    }
}
