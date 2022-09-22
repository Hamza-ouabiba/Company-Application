﻿using RNetApp.Properties;
using System;
using System.Data;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class Tache : UserControl
    {
        AdoNet ado = new AdoNet();
        static string catego_choix = null;
        TabPage page;
        int month, year,day;
        public static string Catego_choix { get => catego_choix; set => catego_choix = value; }
        public  TabPage Page { get => page; set => page = value; }
        public Tache()
        {
            InitializeComponent();
        }
        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string nomMois = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            Mois.Text = nomMois + "" + year;
            //get the first day of the month : 
            DateTime firstOfMonth = new DateTime(year, month, 1);
            //get the count of days in month : 
            int days = DateTime.DaysInMonth(year,month);
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
                DaysUserControl day = new DaysUserControl();
                day.Days(i);
                dayContainer.Controls.Add(day);
            }
            if (month == 12)
            {
                month = 1;
                year++;
            } 
        }
        private void Tache_Load(object sender, EventArgs e)
        {
            DisplayDays();
            ado.Cmd.CommandText = "gestiontache";
            ado.Cmd.CommandType = CommandType.StoredProcedure;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);
            ado.Ds.Tables[0].TableName = "tache";
            ado.Ds.Tables[1].TableName = "categorie";
            important_Click(sender, e);
           
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
               TabPage tabPage = new TabPage();
               important ip = new important();
               tabPage.Text = "Important";
                if (!testPage(tabPage.Text))
                {
                    ip.Dock = DockStyle.Fill;
                    tabPage.Controls.Add(ip);
                    tabControl1.TabPages.Add(tabPage);
                }
                else MessageBox.Show("deja existant");
        }
        private void ajouTache_Click(object sender, EventArgs e)
        {
            TacheAjout tacheAjout = new TacheAjout();
            tacheAjout.Show();
        }
        
        private void planifie_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage();
            planifie p = new planifie();
            tabPage.Text = "planifie";
            if (!testPage(tabPage.Text))
            {
                p.Dock = DockStyle.Fill;
                tabPage.Controls.Add(p);
                tabControl1.TabPages.Add(tabPage);
            }
            else MessageBox.Show("deja existant");
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
            month++;

            if (month == 13)
            {
                month = 1;
                year++;
            } 
            MessageBox.Show($"month = {month}");
            dayContainer.Controls.Clear();
            DateTime firstOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            //get the count of days in week : 
            int daysofWeek = Convert.ToInt32(firstOfMonth.DayOfWeek.ToString("d"));
            if(daysofWeek == 0)
            {
                daysofWeek = 7;
            }
            MessageBox.Show($"days of week {daysofWeek}");
            string nomMois = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            Mois.Text = nomMois + "" + year;
            for (int i = 1; i < daysofWeek; i++)
            {
                BlankUserControl blank = new BlankUserControl();
                dayContainer.Controls.Add(blank);
            }
            //display days : 
            for (int i = 1; i <= days; i++)
            {
                DaysUserControl day = new DaysUserControl();
                day.Days(i);
                dayContainer.Controls.Add(day);
            }
            MessageBox.Show($"days {days}");
            if (month == 12)
            {
                month = 0;
                year++;
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            month--;
            if (month == 0)
            {
                month = 12;
                year--;
            }
            dayContainer.Controls.Clear();
            DateTime firstOfMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            //get the count of days in week : 
            int daysofWeek = Convert.ToInt32(firstOfMonth.DayOfWeek.ToString("d"));
            MessageBox.Show($"days of week {daysofWeek}");
            string nomMois = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            Mois.Text = nomMois + "" + year;
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
                DaysUserControl day = new DaysUserControl();
                day.Days(i);
                dayContainer.Controls.Add(day);
            }
            MessageBox.Show($"days {days}");
            
        }

        private void catego_Click(object sender, EventArgs e)
        {
            ChoxiCategorie choix = new ChoxiCategorie();
            ChoxiCategorie.Categorie = ado.Ds.Tables["categorie"];
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
