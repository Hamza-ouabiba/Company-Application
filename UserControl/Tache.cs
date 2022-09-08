using System;
using System.Data;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class Tache : UserControl
    {
        AdoNet ado = new AdoNet();
        public Tache()
        {
            InitializeComponent();
        }

        private void Tache_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = "SELECT * FROM TACHE";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            dataGridView1.DataSource = ado.Dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
