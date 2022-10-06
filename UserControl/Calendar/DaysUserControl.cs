using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class DaysUserControl : UserControl
    {
        private int numDay;
        private static int day;
        private static TacheVariante variante;
        public static int Day { get => day; set => day = value; }
        public static TacheVariante Variante { get => variante; set => variante = value; }
        public static Tache tache;
        public DaysUserControl(int day)
        {
            InitializeComponent();
            this.numDay = day;
            button1.Text = day + "";
        }
        public void Days(int numday)
        {
        }
        private void DaysUserControl_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //getting the current day/month/year : 
            
            Day = int.Parse(button1.Text);
            tache.Days_Label = button1.Text;
            tache.displayDate();
            TacheVariante.Day = Day;
            TacheVariante.Month = Tache.Month;
            TacheVariante.Year = Tache.Year;
            variante.filterData();
;        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
         
        }
    }
}
