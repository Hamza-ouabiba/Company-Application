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
            double d1 = (dateTimePicker1.Value.ToLocalTime() - new DateTime(1970, 1, 1)).TotalMilliseconds;
            double d2 = (dateTimePicker2.Value.ToLocalTime() - new DateTime(1970, 1, 1)).TotalMilliseconds;
            nbreCon.Visible = true;
            nbreCon.Text = $"{Math.Round((d2 - d1) / (1000 * 3600 * 24))} Jours de repos ";
        }
    }
}
