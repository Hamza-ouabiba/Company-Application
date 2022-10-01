using System;
using System.Data;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class DaysUserControl : UserControl
    {
        private static int day;
        private static TacheVariante variante;
        public static int Day { get => day; set => day = value; }
        public static TacheVariante Variante { get => variante; set => variante = value; }
        public static Tache tache;
        public DaysUserControl()
        {
            InitializeComponent();
        }
        private void DaysUserControl_Load(object sender, EventArgs e)
        {

        }
        public void Days(int numday)
        {
            button1.Text = numday + "";
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
