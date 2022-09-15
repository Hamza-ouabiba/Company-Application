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
            loadCombo(comboBox1,ado.Ds.Tables["facture"].Columns["idfacture"], ado.Ds.Tables["client"].Columns["idclient"],ado.Ds.Tables["facture"]);
            loadCombo(comboBox2, ado.Ds.Tables["client"].Columns["nom"], ado.Ds.Tables["client"].Columns["idclient"],ado.Ds.Tables["client"]);
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
                    montRes.Text = "0";
                }
                else
                {
                    montRes.Text = dr_facture["total_rest"].ToString();
                    factureActu = dr_facture;
                    ado.Ds.Tables["client"].PrimaryKey = new DataColumn[] { ado.Ds.Tables["client"].Columns["idclient"] };
                    DataRow dr_client = ado.Ds.Tables["client"].Rows.Find(Guid.Parse(dr_facture["idclient"].ToString()));
                    enrBtn.Enabled = true;
                    error.Visible = false;
                    nomClt.Text = dr_client["nom"].ToString();
                }
            }
        }
        void loadCombo(ComboBox comboBox,DataColumn display,DataColumn value,DataTable dataSource)
        {
            comboBox.DisplayMember = display.ToString();
            comboBox.ValueMember = value.ToString();
            comboBox.DataSource = dataSource;
        }
        private void enrBtn_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(ado2.Adapter);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from facture", ado.Connection);
            SqlCommandBuilder sb2 = new SqlCommandBuilder(adapter);
            if (decimal.Parse(Montant.Text) <= decimal.Parse(factureActu["total_rest"].ToString()))
            {
                DataRow dr = ado2.Dt.NewRow();
                MessageBox.Show((comboBox1.Text + "du client :: " + comboBox1.SelectedValue.ToString()));
                dr[1] = int.Parse(comboBox1.Text);
                dr[2] = Guid.Parse(comboBox1.SelectedValue.ToString());
                dr[3] = decimal.Parse(Montant.Text);
                factureActu["total_rest"] = decimal.Parse(factureActu["total_rest"].ToString()) - decimal.Parse(Montant.Text);
                ado2.Dt.Rows.Add(dr);
                scb.GetInsertCommand();
                MessageBox.Show($"{ado2.Dt.Rows.Count}");
                ado2.Adapter.Update(ado2.Dt);
                sb2.GetUpdateCommand();
                adapter.Update(ado.Ds.Tables["facture"]);
            }
            else
            {
                MessageBox.Show("Inserer un montant qui <= au montant de la facture");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
    }
}
