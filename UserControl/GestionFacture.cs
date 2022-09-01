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
            SqlCommandBuilder scb = new SqlCommandBuilder(ado.Adapter);
            ado.Cmd.CommandText = $"Select * from CLIENT";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds,"client");
            ado.Adapter.Update(ado.Ds.Tables["CLIENT"]);
            comboBox1.DataSource = ado.Ds.Tables["client"];
            comboBox1.DisplayMember = "NOM";
            comboBox1.ValueMember = "IDCLIENT";
            ado.Cmd.CommandText = $"SELECT FACTURE.idFacture,CLIENT.NOM,FACTURE.DATE_,CLIENT.IDCLIENT,CHEQUE.idCheque,cheque.MONTANT FROM FACTURE,CHEQUE,CLIENT where CHEQUE.IDCLIENT = CLIENT.IDCLIENT AND FACTURE.idClient = CHEQUE.idclient";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds, "facture_inner");
            nbrefac.Text = ado.Ds.Tables["facture_inner"].Rows.Count.ToString();
            dataGridView1.DataSource = ado.Ds.Tables["facture_inner"];
            dataGridView1.Columns["NOM"].Width = 150;
            dataGridView1.Columns["idfacture"].Width = 150;
            dataGridView1.Columns["IDCLIENT"].Visible= false;
            dataGridView1.Columns["DATE_"].Width = 150;
            dataGridView1.Columns["MONTANT"].Width = 200;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowHeadersVisible = false;
            //changer le nom du headertext : 
            dataGridView1.Columns["idfacture"].HeaderText = "Numéro de facture";
            dataGridView1.Columns["DATE_"].HeaderText = "Date de Création de facture";
            dataGridView1.Columns["MONTANT"].HeaderText = "Montant du Cheque";
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                if(e.RowIndex != -1)
                {
                    for (int j = 0; j < ado.Ds.Tables["client"].Rows.Count; j++)
                    {
                        if (dataGridView1.Rows[e.RowIndex].Cells["IDCLIENT"].Value.ToString() == ado.Ds.Tables["client"].Rows[j]["IDCLIENT"].ToString())
                        {
                            numFac.Text = dataGridView1.Rows[e.RowIndex].Cells["IDFACTURE"].Value.ToString();
                            nomCltT.Text = ado.Ds.Tables["client"].Rows[j]["NOM"].ToString();
                            position = e.RowIndex;
                            break;
                        }
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
            dr[1] = Guid.Parse(numFac.Text);
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
            DataView dv = new DataView(ado.Ds.Tables["facture_inner"]);
            if (comboBox1.SelectedValue.ToString() != "")
            {
                MessageBox.Show(comboBox1.SelectedValue.ToString());
                if (comboBox1.GetItemText(comboBox1.SelectedItem) != "TOUS")
                {
                    dv.RowFilter = $"IDCLIENT = '{comboBox1.SelectedValue}'";
                }else
                {
                }
                dataGridView1.DataSource = dv;
            }
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for(int i=0;i<dataGridView1.Rows.Count;i++)
            {
                if(dataGridView1.Rows[i].Cells["IDCHEQUE"].Value.ToString() != "")
                {
                    dataGridView1.Rows[i].Cells["IDCHEQUE"].Style.BackColor = Color.Lime;
                }
            }
        }

        private void ficheBtn_Click(object sender, EventArgs e)
        {

        }

        private void chequeBtn_Click(object sender, EventArgs e)
        {
            if (position != -1)
            {
                ChequeFacture cf = new ChequeFacture();
                ChequeFacture.IdClient = Guid.Parse(dataGridView1.Rows[position].Cells["IDCLIENT"].Value.ToString());
                cf.FactureNum = int.Parse(numFac.Text);
                cf.Show();
            }
            else MessageBox.Show("Veuillez choisir un client ");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void cheque_CheckedChanged(object sender, EventArgs e)
        {
            if(cheque.Checked)
            {
                chequeBtn.Enabled = true;
            } 
        }
        private void espece_CheckedChanged(object sender, EventArgs e)
        {
            if(espece.Checked)
            {
                chequeBtn.Enabled = false;
                MessageBox.Show("Inserer le montant ");
            }
        }
    }
}
