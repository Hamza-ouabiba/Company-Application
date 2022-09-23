using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class AjoutEspece : Form
    {
        AdoNet ado = new AdoNet();
        AdoNet especeTable = new AdoNet();
        DataRow factureActuel;
        public AjoutEspece()
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
            especeTable.Cmd.CommandText = "select * from espece";
            especeTable.Cmd.Connection = especeTable.Connection;
            especeTable.Adapter.SelectCommand = especeTable.Cmd;
            especeTable.Adapter.Fill(especeTable.Dt);
        }
        void loadCombo(ComboBox comboBox, DataColumn display, DataColumn value, DataTable dataSource)
        {
            comboBox.DisplayMember = display.ToString();
            comboBox.ValueMember = value.ToString();
            comboBox.DataSource = dataSource;
        }
        private void AjoutEspece_Load(object sender, EventArgs e)
        {
            loadData();
            comboBox1.DisplayMember = ado.Ds.Tables["facture"].Columns["idfacture"].ToString();
            comboBox1.ValueMember = ado.Ds.Tables["facture"].Columns["idclient"].ToString();
            comboBox1.DataSource = ado.Ds.Tables["facture"];
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
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
                        montRest.Text = "0";
                    }
                    else
                    {
                        montRest.Text = dr_facture["total_rest"].ToString();
                        factureActuel = dr_facture;
                        ado.Ds.Tables["client"].PrimaryKey = new DataColumn[] { ado.Ds.Tables["client"].Columns["idclient"] };
                        DataRow dr_client = ado.Ds.Tables["client"].Rows.Find(Guid.Parse(dr_facture["idclient"].ToString()));
                        enrBtn.Enabled = true;
                        error.Visible = false;
                        nomClient.Text = dr_client["nom"].ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void enrBtn_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(especeTable.Adapter);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from facture", ado.Connection);
            SqlCommandBuilder sb2 = new SqlCommandBuilder(adapter);
            if (decimal.Parse(montantEsp.Text) <= decimal.Parse(factureActuel["total_rest"].ToString()))
            {
                DataRow dr = especeTable.Dt.NewRow();
                MessageBox.Show((comboBox1.Text + "du client :: " + comboBox1.SelectedValue.ToString()));
                dr[1] = int.Parse(comboBox1.Text);
                dr[2] = Guid.Parse(comboBox1.SelectedValue.ToString());
                dr[3] = decimal.Parse(montantEsp.Text);
                factureActuel["total_rest"] = decimal.Parse(factureActuel["total_rest"].ToString()) - decimal.Parse(montantEsp.Text);
                especeTable.Dt.Rows.Add(dr);
                scb.GetInsertCommand();
                especeTable.Adapter.Update(especeTable.Dt);
                sb2.GetUpdateCommand();
                if (decimal.Parse(factureActuel["total_rest"].ToString()) == 0)
                {
                    factureActuel["pay_o_n"] = 1;
                }
                adapter.Update(ado.Ds.Tables["facture"]);
            }
            else
            {
                MessageBox.Show("Inserer un montant qui <= au montant de la facture");
            }
        }
    }
}
