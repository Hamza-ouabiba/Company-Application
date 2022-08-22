using System;
using System.Data;
using System.Windows.Forms;
namespace RNetApp.Forms
{
    public partial class menu : Form
    {
        private static Guid idChef;
        public menu()
        {
            InitializeComponent();
        }
        AdoNet ado = new AdoNet();
        public static Guid IdChef { get => idChef; set => idChef = value; }
        private void menu_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DataRow dr;
            GestionClient client = new GestionClient();
            //afficher Le controleur d'utilisateur client : 
            panelContent.Controls.Clear();
            client.Dock = DockStyle.Fill;
            panelContent.Controls.Add(client);
            //
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            //chercher le nom et le prenom de l'utilisateur connecter actuellement : 
            ado.Cmd.CommandText = $"Select NOM,PRENOM from CHEF where IDCHEF = '{IdChef}'";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            ado.Dt.TableName = "CHEF";
            dr = ado.Dt.Rows[0];
            utilisateurEn.Text = dr["NOM"].ToString() + "-" + dr["PRENOM"].ToString();
            date.Text = now.Date.ToString("dddd dd MMMM yyyy");
        }
        private void DeconBtn_Click(object sender, EventArgs e)
        {
            if (Shared.showMessage("Voulez Vous vraiment se déconnecter ?", "Confirmation de Déconnexion"))
            {
                login m = new login();
                this.Hide();
                m.Show();
            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (Shared.showMessage("Voulez Vous vraiment Fermer l'application ?", "Confirmation de Fermeture"))
                Application.Exit();
        }
        private void ClientBtn_Click(object sender, EventArgs e)
        {
            GestionClient client = new GestionClient();
            //afficher Le controleur d'utilisateur client : 
            panelContent.Controls.Clear();
            client.Dock = DockStyle.Fill;
            panelContent.Controls.Add(client);
        }

        private void FactureBtn_Click(object sender, EventArgs e)
        {
            GestionFacture facture = new GestionFacture();
            //afficher Le controleur d'utilisateur client : 
            panelContent.Controls.Clear();
            facture.Dock = DockStyle.Fill;
            panelContent.Controls.Add(facture);
        }

        private void prixModBtn_Click(object sender, EventArgs e)
        {
            ArticleMod article = new ArticleMod();
            //afficher Le controleur d'utilisateur client : 
            panelContent.Controls.Clear();
            article.Dock = DockStyle.Fill;
            panelContent.Controls.Add(article);
        }
        private void GestionEmp_Click(object sender, EventArgs e)
        {
            GestionEmploye ge = new GestionEmploye();
            //afficher le controleur de gestion des employées : 
            panelContent.Controls.Clear();
            ge.Dock = DockStyle.Fill;
            panelContent.Controls.Add(ge);
        }
    }
}
