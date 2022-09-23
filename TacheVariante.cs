using System;
using System.Data;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class TacheVariante : UserControl
    {
        static string name;
        AdoNet ado = new AdoNet();
        public TacheVariante()
        {
            InitializeComponent();
        }
        public static string Name1 { get => name; set => name = value; }
        private void loadData()
        {
            ado.Cmd.CommandText = $"select * from tache where nomcategorie = '{Name1}'";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            dataGridView1.DataSource = ado.Dt;
        }
        private void TacheVariante_Load(object sender, EventArgs e)
        {
            Tache tache = new Tache();
            catego.Text = Name1;
            loadData();
        }
    }
}
