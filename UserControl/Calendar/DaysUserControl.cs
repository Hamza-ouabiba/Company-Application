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
    public partial class DaysUserControl : UserControl
    {
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
    }
}
