using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class AjoutClient : Form
    {
        AdoNet ado = new AdoNet();
        public AjoutClient()
        {
            InitializeComponent();
        }

        private void AjoutClient_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = "select * from client";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
        }
        private bool checkClient(string nom)
        {
            foreach (DataRow row in ado.Dt.Rows)
            {
                if (nom == row["nom"].ToString())
                {
                    return true;
                }
            }
            return false;
        }
        private void enregistrer_Click(object sender, EventArgs e)
        {
            DataRow dr;
            SqlCommandBuilder sql = new SqlCommandBuilder(ado.Adapter);
                try
                {
                    if (!checkClient(nomClt.Text))
                    {
                        dr = ado.Dt.NewRow();
                        dr[1] = nomClt.Text;
                        dr[2] = decimal.Parse(Montant.Text);
                        dr[3] = telClient.Text;
                        ado.Dt.Rows.Add(dr);
                        sql.GetInsertCommand();
                        ado.Adapter.Update(ado.Dt);
                        ado.Dt = new DataTable();
                        MessageBox.Show("Client Ajoutée avec succés", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else { MessageBox.Show("Ce client existe deja dans la base de donnée pensez a resaisir un autre");  }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
    }
}
