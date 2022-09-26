using System;
using System.Data;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class TacheVariante : UserControl
    {
        static string name;
        public  TacheVariante hadi;
        AdoNet ado = new AdoNet();
        private static int day = 0, month = 0, year = 0;
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
            if(Day != 0 && Month != 0 && year != 0)
            {
                string date = $"{Month}/{Day}/{Year}";
                ado.Dt.Clear();
                ado.Cmd.CommandText = $"select * from tache where nomcategorie = '{Name1}' and date_depart = '{date}'";
                ado.Cmd.Connection = ado.Connection;
                ado.Adapter.SelectCommand = ado.Cmd;
                ado.Adapter.Fill(ado.Dt);
                catego.Text = Name1;
                this.dataGridView1.DataSource = ado.Dt;
            } else
            {
                ado.Dt.Clear();
                ado.Cmd.CommandText = $"select * from tache where nomcategorie = '{Name1}'";
                ado.Cmd.Connection = ado.Connection;
                ado.Adapter.SelectCommand = ado.Cmd;
                ado.Adapter.Fill(ado.Dt);
                catego.Text = Name1;
                this.dataGridView1.DataSource = ado.Dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if(colName == "finish")
            {
                MessageBox.Show($"datagrid : {dataGridView1.Rows[e.RowIndex].Cells["desription"].Value.ToString()} ");
                MessageBox.Show($"datarow {ado.Dt.Rows[e.RowIndex]["desription"].ToString()}");
            }
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
            ado.Dt.Clear();
            /*Shared.addCol(dataGridView1, "finish", "finish", "terminée la tache");*/
            loadData();
        }
    }
}
