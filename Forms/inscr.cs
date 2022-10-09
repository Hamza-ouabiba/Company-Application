using System.Data;
using System.Data.SqlClient;
namespace RNetApp
{
    public partial class inscr : Form
    {
        public inscr()
        {
            InitializeComponent();
        }
        AdoNet ado = new AdoNet();
        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static byte[] ConvertFile(string file)
        {
            byte[] bytes;
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[fs.Length];
                fs.Read(bytes, 0, (int)bytes.Length);
                return bytes;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofs = new OpenFileDialog();
            ofs.Filter = "Images |*.jpg; *.jpeg; *.png";
            ofs.Title = "Selectionner une image";
            if (ofs.ShowDialog() == DialogResult.OK)
            {
                path.Text = ofs.FileName;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder sql = new SqlCommandBuilder(ado.Adapter);    
                string query = "SELECT * from CHEF";
                ado.Cmd.CommandText = query;
                ado.Cmd.Connection = ado.Connection;
                ado.Adapter.SelectCommand = ado.Cmd;
                ado.Adapter.Fill(ado.Dt);
                ado.Dt.TableName = "CHEF";
                DataRow dr = ado.Dt.NewRow();
                dr[1] = nom.Text;
                dr[2] = prenom.Text;
                dr[3] = login.Text;
                dr[4] = mdp.Text;
                dr[5] = ConvertFile(path.Text);
                ado.Dt.Rows.Add(dr);
                //mise a jour de la table dans la base de donnée : 
                ado.Adapter.Update(ado.Dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
