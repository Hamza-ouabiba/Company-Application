﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using RNetApp.Forms;
namespace RNetApp
{
    public partial class ChequeFacture : Form
    {
        AdoNet ado = new AdoNet();
        public ChequeFacture()
        {
            InitializeComponent();
        }

        private void ChequeFacture_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = "chequetables";
            ado.Cmd.CommandType = CommandType.StoredProcedure;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);
            /*factuNu*/
            ado.Ds.Tables[0].TableName = "cheque";
            ado.Ds.Tables[1].TableName = "facture";
            ado.Ds.Tables[2].TableName = "client";
            comboBox1.DisplayMember = ado.Ds.Tables["facture"].Columns["idfacture"].ToString();
            comboBox1.ValueMember = ado.Ds.Tables["facture"].Columns["idclient"].ToString();
            comboBox1.DataSource = ado.Ds.Tables["facture"];
           
        }

        private void enrBtn_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(ado.Adapter);
            DataRow dr = ado.Ds.Tables["cheque"].NewRow();
            dr[0] = int.Parse(numCheq.Text);
            dr[1] = int.Parse(comboBox1.Text);
            dr[2] = Guid.Parse(comboBox1.SelectedValue.ToString());

            dr[3] = decimal.Parse(montantChe.Text);
            ado.Ds.Tables["cheque"].Rows.Add(dr);
            scb.GetInsertCommand();
            ado.Adapter.Update(ado.Ds.Tables["cheque"]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != -1)
            {
                ado.Ds.Tables["facture"].PrimaryKey = new DataColumn[] { ado.Ds.Tables["facture"].Columns["idfacture"] };
                DataRow dr_facture = ado.Ds.Tables["facture"].Rows.Find(int.Parse(comboBox1.Text));
                //verifier la facture : 
                if (dr_facture["pay_o_n"].ToString() == "True")
                {
                    MessageBox.Show("facture deja payee");
                }
                else
                {
                    DataRow[] dr = ado.Ds.Tables["client"].Select($"idclient = '{Guid.Parse(comboBox1.SelectedValue.ToString())}'");
                    foreach (DataRow dr2 in dr)
                    {
                        nomClient.ReadOnly = true;
                        nomClient.Text = dr2["nom"].ToString();
                    }
                }
            }

        }
    }
}