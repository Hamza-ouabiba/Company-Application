using System.Data;
using System.Data.SqlClient;
using RNetApp.Forms;
namespace RNetApp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        AdoNet ado = new AdoNet();
        private void cnxBtn_Click(object sender, EventArgs e)
        {
            Guid idChef ;
            bool flag = false;
            string query = "SELECT * from CHEF";
            ado.Cmd.CommandText = query;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            ado.Dt.TableName = "CHEF";
            //tester sur le login :
            foreach (DataRow dr in ado.Dt.Rows)
            {
                if(userName.Text == dr["LOGIN"].ToString() && pass.Text == dr["MOT_PASSE"].ToString())
                {
                    idChef = Guid.Parse(dr["IDCHEF"].ToString());
                    menu.IdChef = idChef;
                    GestionEmploye.IdChef = idChef;
                    flag = true;
                    break;
                }
            }
            if (!flag) MessageBox.Show("Login ou mot de passe erronée");
            else
            {
                menu m = new menu();
                this.Hide();
                m.Show();
                MessageBox.Show("Connexion Reussie");
            }
        }
        //Quitter l'application
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                pass.UseSystemPasswordChar = false;
            } else pass.UseSystemPasswordChar = true;
        }

        private void inscrBtn_Click(object sender, EventArgs e)
        {
            inscr i = new inscr();
            this.Hide();
            i.Show();
        }
    }
}