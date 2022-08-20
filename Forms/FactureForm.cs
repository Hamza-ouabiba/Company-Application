using System;
using System.Data;
using System.Windows.Forms;
using RNetApp.Forms;
using System.Data.SqlClient;
namespace RNetApp.Forms
{
    public partial class FactureForm : Form
    {
        private Guid idClient;
        private string nameClient;
        public FactureForm()
        {
            InitializeComponent();
        }
        AdoNet ado = new AdoNet();
        public Guid IdClient { get => idClient; set => idClient = value; }
        public string NameClient { get => nameClient; set => nameClient = value; }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FactureForm_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            DateTime date = DateTime.Now;
            ado.Cmd.CommandText = $"Select * from FACTURE where IDCLIENT = '{IdClient}'";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            nomCl.Text = nameClient;
            for (int i =0;i<ado.Dt.Rows.Count;i++)
            {
                if (ado.Dt.Rows[i]["fac_n_o"].ToString() == "0")
                {
                    MessageBox.Show("oui");
                    dateNow.Text = $"{date.Day}/{date.Month}/{date.Year}";
                    facturNum.Text = $"{ado.Dt.Rows[i]["IDFACTURE"].ToString()}/{date.Year}";
                    break;
                }
            }
        }
    }
}
