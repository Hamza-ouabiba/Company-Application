using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RNetApp
{
    public partial class ChoxiCategorie : Form
    {
        static DataTable categorie = null;
        public ChoxiCategorie()
        {
            InitializeComponent();
        }

        public static DataTable Categorie { get => categorie; set => categorie = value; }

        private void ChoxiCategorie_Load(object sender, EventArgs e)
        {
            if(Categorie != null)
            {
                choix_catego.DisplayMember = "nomcategorie";
                choix_catego.DataSource = Categorie;
            }
        }
        private void Enre_Click(object sender, EventArgs e)
        {
            Tache ta = new Tache();
            Tache.Catego_choix = choix_catego.Text;
            DifferentTache dif = new DifferentTache();  
            ta.Page = new TabPage();
            ta.Page.Text = choix_catego.Text;
            if (!ta.testPage(ta.Page.Text))
            {
                MessageBox.Show("nice");
                ta.Controls.Add(dif);
                dif.Dock = DockStyle.Fill;  
                ta.Page.Controls.Add(dif);
                ta.tabControl1.TabPages.Add(ta.Page);
            }
            MessageBox.Show("enregistrer avec succes");
            this.Hide();
        }
    }
}
