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
            ado.Cmd.CommandText = "gestiontache";
            ado.Cmd.CommandType = CommandType.StoredProcedure;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);
            ado.Ds.Tables[0].TableName = "tache";
            ado.Ds.Tables[1].TableName = "categorie";
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
        private void subMenus_Click(object sender, EventArgs e)
        {
            Button[] btn = insertingButtons();
            if (subMenus.BackColor == Control.DefaultBackColor)
            {
                foreach (Button button in btn)
                {
                    this.Controls.Add(button);
                }
                subMenus.BackColor = Color.Wheat;
            }
            else
            {
                foreach (Button button in btn)
                {
                    this.Controls.Remove(button);
                }
                subMenus.BackColor = Control.DefaultBackColor;
            }
        }
        private void subMenus_DragEnter(object sender, DragEventArgs e)
        {
            MessageBox.Show("ll");
        }
        private void subMenus_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void subMenus_MouseLeave(object sender, EventArgs e)
        {
            
        }
    }
}
