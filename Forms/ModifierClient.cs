using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RNetApp.Forms
{
    public partial class ModifierClient : Form
    {
        AdoNet ado = new AdoNet();
        private static Guid idClient;

        public static Guid IdClient { get => idClient; set => idClient = value; }

        public ModifierClient()
        {
            InitializeComponent();
        }

        private void ModifierClient_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = $"Select * from CLIENT where IDCLIENT = '{IdClient}'";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            idClientT.Text = ado.Dt.Rows[0]["IDCLIENT"].ToString();
            nomClt.Text = ado.Dt.Rows[0]["NOM"].ToString();
            Montant.Text = ado.Dt.Rows[0]["MONTANT"].ToString();
            avance.Text = ado.Dt.Rows[0]["AVANCE"].ToString();
            totalRes.Text = ado.Dt.Rows[0]["TOTAL_REST"].ToString();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
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
        private bool checkClientWithId(string nomClt, string id)
        {
            foreach (DataRow row in ado.Dt.Rows)
            {
                if (row["IDCLIENT"].ToString().ToLower() == id.ToLower() && row["NOM"].ToString().ToLower() == nomClt.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private bool checkClientWithNoId(string nomClt, string id)
        {
            foreach (DataRow row in ado.Dt.Rows)
            {
                if (row["IDCLIENT"].ToString().ToLower() != id.ToLower() && row["NOM"].ToString().ToLower() == nomClt.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private void modBtn_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(ado.Adapter);
            try
            {
                if (checkClientWithNoId(nomClt.Text, idClientT.Text))
                {
                    MessageBox.Show("Ce client existe deja dans la base de donnée Pensez a saisir un nouveau nom");
                }
                else if (checkClientWithId(nomClt.Text, idClientT.Text) || !checkClient(nomClt.Text))
                {
                    if (float.Parse(avance.Text) <= float.Parse(Montant.Text))
                    {
                        ado.Dt.Rows[0]["NOM"] = nomClt.Text;
                        ado.Dt.Rows[0]["MONTANT"] = decimal.Parse(Montant.Text);
                        ado.Dt.Rows[0]["AVANCE"] = decimal.Parse(avance.Text);
                        ado.Dt.Rows[0]["TOTAL_REST"] = decimal.Parse(Montant.Text) - decimal.Parse(avance.Text);
                        scb.GetUpdateCommand();
                        ado.Adapter.Update(ado.Dt);
                        MessageBox.Show("modification avec succes");
                    }
                    else MessageBox.Show("C'est illogique d'avoir l'avance plus que le montant ");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
