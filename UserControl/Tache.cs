using RNetApp.Properties;
using System;
using System.Data;
using System.Resources;
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
            
            important_Click(sender, e);
        }
        private bool testPage(string namePage)
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
    }
}
