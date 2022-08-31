using System;
using System.Data;
using RNetApp.Forms;
using System.Data.SqlClient;
namespace RNetApp
{
    public partial class GestionFacture : UserControl
    {
        private Guid idClient;
        private string nomClient;
        private int position = -1;
        AdoNet ado = new AdoNet();
        public Guid IdClient { get => idClient; set => idClient = value; }
        public GestionFacture()
        {
            InitializeComponent();
        }
        private void GestionFacture_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = $"Select * from CLIENT";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds,"client");
            comboBox1.DataSource = ado.Ds.Tables["client"];
            comboBox1.DisplayMember = "NOM";
            comboBox1.ValueMember = "IDCLIENT";
            ado.Cmd.CommandText = $"Select * from FACTURE";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds, "facture");
            nbrefac.Text = ado.Ds.Tables["FACTURE"].Rows.Count.ToString();
            dataGridView1.DataSource = ado.Ds.Tables["facture"];
            dataGridView1.Columns["idcheque"].Visible = false;
            dataGridView1.Columns["idfacture"].Width = 200;
            dataGridView1.Columns["idclient"].Visible = false;
            dataGridView1.Columns["DATE_"].Width = 200;
            dataGridView1.Columns["total_ttc"].Width = 200;
            dataGridView1.Columns["total_ht"].Width = 200;
            dataGridView1.Columns["fac_n_o"].Visible = false;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowHeadersVisible = false;
            //changer le nom du headertext : 
            dataGridView1.Columns["idfacture"].HeaderText = "Numéro de facture";
            dataGridView1.Columns["DATE_"].HeaderText = "Date de Création de facture";
            dataGridView1.Columns["total_ttc"].HeaderText = "Total TTC";
            dataGridView1.Columns["total_ht"].HeaderText = "Total Hors-Taxe";
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
                for (int j = 0; j < ado.Ds.Tables["client"].Rows.Count; j++)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells["IDCLIENT"].Value.ToString() == ado.Ds.Tables["client"].Rows[j]["IDCLIENT"].ToString())
                    {
                        idCltT.Text = dataGridView1.Rows[e.RowIndex].Cells["IDFACTURE"].Value.ToString();
                        nomCltT.Text = ado.Ds.Tables["client"].Rows[j]["NOM"].ToString();
                    totalTtc.Text = dataGridView1.Rows[e.RowIndex].Cells["total_ttc"].Value.ToString();
                    totalHt.Text = dataGridView1.Rows[e.RowIndex].Cells["total_ht"].Value.ToString();
                    }
                }
        }
        private void factureBtn_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            FactureForm form = new FactureForm();   
            AdoNet ado = new AdoNet();
            SqlCommandBuilder sql = new SqlCommandBuilder(ado.Adapter);
            ado.Cmd.CommandText = $"Select * from FACTURE";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds,"facture");
            DataRow dr = ado.Ds.Tables["facture"].NewRow();
            dr[1] = Guid.Parse(idCltT.Text);
            dr[3] = dt;
            dr[6] = 0;
            ado.Dt.Rows.Add(dr);
            sql.GetInsertCommand();
            ado.Adapter.Update(ado.Ds.Tables["facture"]);
            form.IdClient = IdClient;
            form.NameClient = nomClient;
            form.Show();
        }
        private bool checkClient(string nomClt)
        {
            foreach (DataRow row in ado.Dt.Rows)
            {
                if (row["NOM"].ToString().ToLower() == nomClt.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private void rechercher_Click(object sender, EventArgs e)
        {
            if (recherche.Text != "")
            {
                DataView dv = new DataView(ado.Ds.Tables["facture"]);
                if (checkClient(recherche.Text))
                {
                    error.Visible = false;
                    dv.RowFilter = $"NOM like '{recherche.Text}'";
                    dataGridView1.DataSource = dv;
                }
                else
                {
                    error.Visible = true;
                    error.Text = "Ce client n'existe pas";
                }
            }
            else
            {
                error.Visible = true;
                error.Text = "Veuillez inserer quelque chose";
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }

        private void ficheBtn_Click(object sender, EventArgs e)
        {

        }

        private void chequeBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
