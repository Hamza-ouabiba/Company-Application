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
    public partial class FacturePaimentSeul : Form
    {
        public FacturePaimentSeul()
        {
            InitializeComponent();
        }

        private void FacturePaimentSeul_Load(object sender, EventArgs e)
        {
            this.Height = 467;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != -1)
            {
                if(comboBox1.Text == "Chèque")
                {
                    numChe.Visible = dateEnc.Visible = panel5.Visible = panel6.Visible = true;
                    this.Height = 626;
                }
            }
        }

        private void numChe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
