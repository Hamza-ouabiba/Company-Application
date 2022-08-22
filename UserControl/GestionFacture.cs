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
            ado.Adapter.Fill(ado.Dt);
            nbreClt.Text = ado.Dt.Rows.Count.ToString();
            dataGridView1.DataSource = ado.Dt;
            dataGridView1.Columns["IDCLIENT"].Visible = false;
            dataGridView1.Columns["NOM"].Width = 150;
            dataGridView1.Columns["MONTANT"].Width = 150;
            dataGridView1.Columns["TOTAL_REST"].Width = 150;
            dataGridView1.Columns["Avance"].Width = 150;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns["NOM"].HeaderText = "Nom client";
            dataGridView1.Columns["MONTANT"].HeaderText = "Montant Par mois";
            dataGridView1.Columns["TOTAL_REST"].HeaderText = "Total Restant";
            dataGridView1.Columns["Avance"].HeaderText = "Avance";
            dataGridView1.Columns["payE"].HeaderText = "Payé par espèce";
            dataGridView1.Columns["payC"].HeaderText = "Payé par chèque";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                idCltT.Text = ado.Dt.Rows[e.RowIndex][0].ToString();
                idClient = Guid.Parse(idCltT.Text);
                nomClient = ado.Dt.Rows[e.RowIndex][1].ToString();
                nomCltT.Text = ado.Dt.Rows[e.RowIndex][1].ToString();
                Montant.Text = ado.Dt.Rows[e.RowIndex][2].ToString();
                totalRes.Text = ado.Dt.Rows[e.RowIndex][3].ToString();
                factureBtn.Enabled = true;
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
            ado.Adapter.Fill(ado.Dt);
            DataRow dr = ado.Dt.NewRow();
            dr[1] = Guid.Parse(idCltT.Text);
            dr[2] = dt;
            dr[5] = 0;
            ado.Dt.Rows.Add(dr);
            sql.GetInsertCommand();
            ado.Adapter.Update(ado.Dt);
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
                DataView dv = new DataView(ado.Dt);
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
    }
}
