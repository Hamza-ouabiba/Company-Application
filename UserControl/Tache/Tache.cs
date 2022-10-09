using RNetApp.Properties;
using System;
using System.Data;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;
using RNetApp;
using System.Data.SqlClient;

namespace RNetApp
{
    public partial class Tache : UserControl
    {
        AdoNet ado = new AdoNet();
        TacheVariante p = new TacheVariante();
        List<TacheVariante> list = new List<TacheVariante>();
        static string catego_choix = null;
        TabPage page;
        string days_label = $"{DateTime.Today.Day}";
        private bool triggerTabPage = false;//if the user hit all tasks this will turn to true and the tabpage will automatically display the tasks
        static int month, year,day;
        public static string Catego_choix { get => catego_choix; set => catego_choix = value; }
        public  TabPage Page { get => page; set => page = value; }
        public static int Month { get => month; set => month = value; }
        public static int Year { get => year; set => year = value; }
        public  string Days_Label { get => days_label; set => days_label = value; }   
        public Tache()
        {
            InitializeComponent();
        }
        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            Month = now.Month;
            Year = now.Year;
            string nomMois = DateTimeFormatInfo.CurrentInfo.GetMonthName(Month);
            Mois.Text = days_label + " " +  nomMois + "" + Year;//giving day and month :
            //get the first day of the month : 
            DateTime firstOfMonth = new DateTime(Year, Month, 1);
            //get the count of days in month : 
            int days = DateTime.DaysInMonth(Year,Month);
            //get the count of days in week : 
            int daysofWeek = Convert.ToInt32(firstOfMonth.DayOfWeek.ToString("d"))+1;
            for (int i = 1; i < daysofWeek; i++)
            {
                BlankUserControl blank = new BlankUserControl();
                dayContainer.Controls.Add(blank);
            }
            //display days : 
            for (int i = 1; i <= days; i++)
            {
                DaysUserControl day = new DaysUserControl(i);
                dayContainer.Controls.Add(day);
            }
            if (Month == 12)
            {
                Month = 1;
                Year++;
            }
        }
        public void displayDate()//o kat3iyt 3la had methode a chaque fois kadir button click : 
        {
            string nomMois = DateTimeFormatInfo.CurrentInfo.GetMonthName(Month);
            Mois.Text = days_label + " " + nomMois + "" + Year;//giving day and month :
        }
        //inserting tabpages using categories : 
        private void insertTabPages()
        {
            //convert all categories to string : 
            TabPage tabPage;
            tabControl1.TabPages.Clear();
            foreach(DataRow row in ado.Ds.Tables["categorie"].Rows)
            {
                //insert to tabcontro: 
                tabPage = new TabPage();
                tabControl1.Controls.Add(tabPage);
                tabPage.Text = row["nomcategorie"].ToString();
            }
        }
        private void Tache_Load(object sender, EventArgs e)
        {
            //set the datagridview for all each categorie : 
            DisplayDays();
            ado.Cmd.CommandText = "gestiontache";
            ado.Cmd.CommandType = CommandType.StoredProcedure;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);
            ado.Ds.Tables[0].TableName = "tache";
            ado.Ds.Tables[1].TableName = "categorie";
            insertTabPages();
            if(tabControl1.SelectedIndex != -1)
            {
                string currenCategoryName = tabControl1.TabPages[tabControl1.SelectedIndex].Text;
                p.Dock = DockStyle.Fill;
                p.Name1 = currenCategoryName;
                tabControl1.SelectedTab.Controls.Add(p);
                p.filterData();
                DaysUserControl.tache = this;//kat3tiha had l instance l dayuser controle 
                DaysUserControl.Variante = p;
            }
        }
        public bool testPage(string namePage)
        {
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                if (tabPage.Text == namePage)
                {
                    return true;
                }
            }
            return false;
        }
        private void important_Click(object sender, EventArgs e)
        {
               
        }
        private void ajouTache_Click(object sender, EventArgs e)
        {
            AjouTache ajouTache = new AjouTache();
            ajouTache.Show();
        }
        
        private void planifie_Click(object sender, EventArgs e)
        {
          
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            ResourceManager rm = Resources.ResourceManager;
            Bitmap icon = (Bitmap)rm.GetObject("delete");
            e.Graphics.DrawImage(icon, e.Bounds);
        }
        private void termine_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage();
            termine p = new termine();
            tabPage.Text = "Termiinée";
            if (!testPage(tabPage.Text))
            {
                p.Dock = DockStyle.Fill;
                tabPage.Controls.Add(p);
                tabControl1.TabPages.Add(tabPage);
            }
            else MessageBox.Show("deja existant");
        }
        private Button[] insertingButtons()
        {
            int position = 0;
            int i = 0;
            Button[] btn = new Button[ado.Ds.Tables["categorie"].Rows.Count];
            foreach (DataRow row in ado.Ds.Tables["categorie"].Rows)
            {
                Button button = new Button();
                button.Location = new Point(341, 547 + position);
                button.Height = ajouTache.Height;
                button.Width = ajouTache.Width;
                button.Text = row["nomcategorie"].ToString();
                button.Visible = true;
                position += 30;
                btn[i++] = button;
            }
            return btn;
        }
        private void next_Click(object sender, EventArgs e)
        {
            Month++;
            if (Month == 13)
            {
                Month = 1;
                Year++;
            }
            dayContainer.Controls.Clear();
            string nomMois = DateTimeFormatInfo.CurrentInfo.GetMonthName(Month);
            DateTime firstOfMonth = new DateTime(Year, Month, 1);
            int days = DateTime.DaysInMonth(Year, Month);
            //get the count of days in week : 
            int daysofWeek = Convert.ToInt32(firstOfMonth.DayOfWeek.ToString("d"));
            if(daysofWeek == 0)
            {
                daysofWeek = 7;
            }
            Mois.Text = days_label + nomMois + "" + Year;
            for (int i = 1; i < daysofWeek; i++)
            {
                BlankUserControl blank = new BlankUserControl();
                dayContainer.Controls.Add(blank);
            }
            //display days : 
            for (int i = 1; i <= days; i++)
            {
                DaysUserControl day = new DaysUserControl(i);
                dayContainer.Controls.Add(day);
            }
        }
        public void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currenCategoryName = tabControl1.TabPages[tabControl1.SelectedIndex].Text;
            //set the datagridview for all each categorie : 
            p.Name1 = currenCategoryName;   
            p.Dock = DockStyle.Fill;
            p.filterData();
            tabControl1.SelectedTab.Controls.Add(p);
            DaysUserControl.Variante = p;
        }

        private void tous_Click(object sender, EventArgs e)
        {
            triggerTabPage = true;
            p.TacheVariante_Load(sender, e);
        }

        private void textBox1_ModifiedChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable tache = new DataTable();
            TextBox search = sender as TextBox;
            string searchText = search.Text;
            SqlDataAdapter adapter_tache = new SqlDataAdapter($"select * from tache where desription like '{searchText}%' or nomcategorie like '{searchText}%'", ado.Connection);
            //identify wether the user search for task or category: :
            adapter_tache.Fill(tache);
            if(tache.Rows.Count > 0)
            {
                p.filterDataTable(tache);
            } 
        }

        private void previous_Click(object sender, EventArgs e)
        {
            Month--;
            if (Month == 0)
            {
                Month = 12;
                Year--;
            }
            dayContainer.Controls.Clear();
            DateTime firstOfMonth = new DateTime(Year, Month, 1);
            int days = DateTime.DaysInMonth(Year, Month);
            //get the count of days in week : 
            int daysofWeek = Convert.ToInt32(firstOfMonth.DayOfWeek.ToString("d"));
           /* MessageBox.Show($"days of week {daysofWeek}");*/
            string nomMois = DateTimeFormatInfo.CurrentInfo.GetMonthName(Month);
            Mois.Text = days_label + nomMois + "" + Year;
            if (daysofWeek == 0)
            {
                daysofWeek = 7;
            }
            for (int i = 1; i < daysofWeek; i++)
            {
                BlankUserControl blank = new BlankUserControl();
                dayContainer.Controls.Add(blank);
            }
            //display days : 
            for (int i = 1; i <= days; i++)
            {
                DaysUserControl day = new DaysUserControl(i);
                dayContainer.Controls.Add(day);
            }
        }

        private void catego_Click(object sender, EventArgs e)
        {
            ChoixCategorie choix = new ChoixCategorie();
            choix.Show();
            /*if(Catego_choix != null)
            {
                TabPage tabPage = new TabPage();
                DifferentTache dt = new DifferentTache();
                tabPage.Text = Catego_choix;
                if (!testPage(tabPage.Text))
                {
                    dt.Dock = DockStyle.Fill;
                    tabPage.Controls.Add(dt);
                    tabControl1.TabPages.Add(tabPage);
                }
                else MessageBox.Show("deja existant");
            }*/
        }
    }
}
