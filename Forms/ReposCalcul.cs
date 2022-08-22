using System;
using System.Data;
using System.Windows.Forms;
namespace RNetApp.Forms
{
    public partial class ReposCalcul : Form
    {
        private static Guid idEmploye; 
        public ReposCalcul()
        {
            InitializeComponent();
        }
        public static Guid IdEmploye { get => idEmploye; set => idEmploye = value; }
        private void calcul_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int jour = dateTimePicker1.Value.Day;
            nbreCon.Visible = true;
            nbreCon.Text = $"{now.Day - jour} Jours";
        }
    }
}
