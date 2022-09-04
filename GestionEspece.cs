using System;
using System.Data;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class GestionEspece : UserControl
    {
        AdoNet ado = new AdoNet();
        public GestionEspece()
        {
            InitializeComponent();
        }
        private void GestionEspece_Load(object sender, EventArgs e)
        {
            ado.Cmd.CommandText = $"SELECT * FROM ESPECE";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds, "ESPECE");
            dataGridView1.DataSource = ado.Ds.Tables["ESPECE"];
            dataGridView1.Columns["idespece"].Width = 150;
            dataGridView1.Columns["idfacture"].Width = 150;
            dataGridView1.Columns["IDCLIENT"].Visible = false;
            dataGridView1.Columns["MONTANT"].Width = 200;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowHeadersVisible = false;
            ado.Cmd.CommandText = $"SELECT * FROM client";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds, "client");
            Shared.addCol(dataGridView1, "but", "voir", "");
        }
    }
}
