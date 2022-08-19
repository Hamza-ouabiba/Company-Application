using System;
using System.Resources;
using System.Text;
using RNetApp.Properties;
namespace RNetApp
{
    internal class Shared
    {
        public static void addCol(DataGridView dgv, string colName, string iconName,string headerText)
        {
            ResourceManager rm = Resources.ResourceManager;
            Bitmap icon = (Bitmap)rm.GetObject(iconName);
            DataGridViewImageColumn col = new DataGridViewImageColumn
            {
                Name = colName,
                HeaderText = headerText,
                Image = icon,
                Width = 60
            };
            col.HeaderCell.Style.Padding = new Padding(10, 0, 10, 0);
            dgv.Columns.Add(col);
        }
        public static bool showMessage(string msg, string conf)
        {
            DialogResult result = MessageBox.Show(msg, conf, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }
    }
}
