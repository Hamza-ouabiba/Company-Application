using System;
using System.Resources;
using System.Text;
using RNetApp.Properties;
using System.Data;
using Microsoft.Reporting.NETCore;

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
        public static void printToPdf(string RptPath, string nameSrcRpt, DataTable valueSrcRpt, string fileName, string subReport = null)
        {
            StreamReader sr = new StreamReader(RptPath);
            LocalReport report = new LocalReport();
            report.LoadReportDefinition(sr);
            report.DataSources.Add(new ReportDataSource(nameSrcRpt, valueSrcRpt));
            byte[] pdf = report.Render("pdf");
            if (subReport != null)
            {

            }
            Stream stm;
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "All filter(*.*)| *.*";
            DateTime dt = DateTime.Now;
            string outputFileName = $"{fileName} {dt.Day}-{dt.Month}-{dt.Year}.pdf";
            saveFile.FileName = outputFileName;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if ((stm = saveFile.OpenFile()) != null)
                {
                    stm.Write(pdf, 0, pdf.Length);
                    stm.Close();
                }
            }
        }
    }
}
