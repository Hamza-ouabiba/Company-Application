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
        void loadData(string query)
        {
            ado.Cmd.CommandText = query;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            ado.Dt.TableName = "CHEF";
        }
        bool testDataTable(DataTable dt)
        {
            bool flag = false;
            return dt.Rows.Count > 0;
        }
        private void cnxBtn_Click(object sender, EventArgs e)
        {
            Guid idChef ;
            bool flag = false;
            string query = $"SELECT * from CHEF where login = '{userName.Text}' and mot_passe = '{pass.Text}' ";
            loadData(query);
            //tester sur le login :
            if (testDataTable(ado.Dt))
            {
                MessageBox.Show("Connexion reussie");
                idChef = Guid.Parse(ado.Dt.Rows[0]["idchef"].ToString());
                menu m = new menu();
                menu.IdChef = idChef;
                GestionEmploye.IdChef = idChef;
                this.Hide();
                m.Show();
            }
            else MessageBox.Show("veuillez reessayer");
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