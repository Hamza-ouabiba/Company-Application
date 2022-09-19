using System;
using System.Data;
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
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
