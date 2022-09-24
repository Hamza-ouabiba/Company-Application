using System;
using System.Data;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class TacheVariante : UserControl
    {
        static string name;
        public  TacheVariante hadi;
        private static TabControl tabControl;
        AdoNet ado = new AdoNet();
        private static int day = 23, month = 9, year = 2022;
        public TacheVariante()
        {
            InitializeComponent();
        }

        public TacheVariante(string name1)
        {
            Name1 = name1;
        }
        public  string Name1 { get => name; set => name = value; }
        public static int Day { get => day; set => day = value; }
        public static int Month { get => month; set => month = value; }
        public static int Year { get => year; set => year = value; }
        public void filterData()
        {
            string date = $"{Month}/{Day}/{Year}";
            ado.Dt.Clear();
            ado.Cmd.CommandText = $"select * from tache where nomcategorie = '{Name1}' and date_depart = '{date}'";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            this.dataGridView1.DataSource = ado.Dt;
        }
        public void loadData()
        {
            ado.Cmd.CommandText = $"select * from tache where nomcategorie = '{Name1}'";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            dataGridView1.DataSource = ado.Dt;
        }
        public void TacheVariante_Load(object sender, EventArgs e)
        {
            catego.Text = Name1;
            loadData();
            filterData();
        }
    }
}
