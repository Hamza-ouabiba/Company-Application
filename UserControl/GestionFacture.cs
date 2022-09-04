﻿using System;
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
        private decimal calculTotal(DataGridViewRow data)
        {
            decimal total = 0;
            DataRow[] dr_cheque;
            DataRow[] dr_montant;
            dr_cheque = ado.Ds.Tables["cheque"].Select($"idfacture = '{int.Parse(data.Cells["idfacture"].Value.ToString())}'");
            dr_montant = ado.Ds.Tables["espece"].Select($"idfacture = '{int.Parse(data.Cells["idfacture"].Value.ToString())}'");
            foreach(DataRow dr2 in dr_cheque)
            {
                    total += decimal.Parse(dr2["montant"].ToString());
            }
            foreach (DataRow dr2 in dr_montant)
            {
                total += decimal.Parse(dr2["montant"].ToString());
            }
            return total;
        }
        private void GestionFacture_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = "GETTABLES";
            ado.Cmd.CommandType = CommandType.StoredProcedure;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);
            ado.Ds.Tables[0].TableName = "facture";
            ado.Ds.Tables[1].TableName = "client";
            ado.Ds.Tables[2].TableName = "cheque";
            ado.Ds.Tables[3].TableName = "espece";
            dataGridView1.DataSource = ado.Ds.Tables["facture"];
            //fill the combobox : 
            comboBox1.DataSource = ado.Ds.Tables["client"];
            comboBox1.DisplayMember = ado.Ds.Tables["client"].Columns["nom"].ToString();
            comboBox1.ValueMember = ado.Ds.Tables["client"].Columns["idclient"].ToString();
            nbrefac.Text = $"{ado.Ds.Tables["facture"].Rows.Count}";
            dataGridView1.Columns["IDCLIENT"].Visible = false;
            dataGridView1.Columns["fac_n_o"].Visible = false;
            dataGridView1.Columns["idfacture"].Width = 200;
            dataGridView1.Columns["total_ttc"].Width = 200;
            dataGridView1.Columns["total_ht"].Width = 200;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowHeadersVisible = false;
            Shared.addCol(dataGridView1, "but", "voir", "");
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                if(e.RowIndex != -1)
                {
                DataRow[] dr = ado.Ds.Tables["cheque"].Select($"idfacture = '{int.Parse(dataGridView1.Rows[e.RowIndex].Cells["idfacture"].Value.ToString())}'");
                    for (int j = 0; j < ado.Ds.Tables["client"].Rows.Count; j++)
                    {
                        if (dataGridView1.Rows[e.RowIndex].Cells["IDCLIENT"].Value.ToString() == ado.Ds.Tables["client"].Rows[j]["IDCLIENT"].ToString())
                        {
                            numFac.Text = dataGridView1.Rows[e.RowIndex].Cells["IDFACTURE"].Value.ToString();
                            nomCltT.Text = ado.Ds.Tables["client"].Rows[j]["NOM"].ToString();
                            nbreCheque.Text = $"{dr.Length}";
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
            SqlCommandBuilder sql = new SqlCommandBuilder(ado.Adapter);
            DataRow dr = ado.Ds.Tables["facture"].NewRow();
            dr[1] = dt;
            dr[4] = 0;
            dr[5] = 0;
            dr[6] = Guid.Parse(comboBox1.SelectedValue.ToString());
            ado.Ds.Tables["facture"].Rows.Add(dr);
            sql.GetInsertCommand();
            ado.Adapter.Update(ado.Ds.Tables["facture"]);
            form.IdClient = Guid.Parse(comboBox1.SelectedValue.ToString());
            form.NameClient = comboBox1.Text;
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
          
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
        private void verifierBtn_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(ado.Adapter);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                MessageBox.Show($"{calculTotal(dataGridView1.Rows[i])}");
                if (dataGridView1.Rows[i].Cells["total_ttc"].Value.ToString() != "" && decimal.Parse(dataGridView1.Rows[i].Cells["total_ttc"].Value.ToString()) == calculTotal(dataGridView1.Rows[i]))
                {
                    ado.Ds.Tables["facture"].Rows[i]["pay_o_n"] = 1;
                    scb.GetUpdateCommand();
                    ado.Adapter.Update(ado.Ds.Tables["facture"]);
                    dataGridView1.Rows[i].Cells["pay_o_n"].Style.BackColor = Color.Lime;
                }
                else
                {

                    ado.Ds.Tables["facture"].Rows[i]["pay_o_n"] = 0;
                    dataGridView1.Rows[i].Cells["pay_o_n"].Style.BackColor = Color.Red;
                }
            }
        }
    }
}
