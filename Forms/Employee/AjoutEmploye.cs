using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class AjoutEmploye : Form
    {
        AdoNet ado = new AdoNet();
        public AjoutEmploye()
        {
            InitializeComponent();
        }
        private void AjoutEmploye_Load(object sender, EventArgs e)
        {
            //having the employee datatable : 
            ado.Cmd.CommandText = "Select * from EMPLOYE";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
        }
        private bool checkInfo(string prenomEmp)
        {
            foreach(DataRow row in ado.Dt.Rows)
            {
                if(prenomEmp == row["prenom"].ToString())
                {
                    return true;
                }
            }
            return false;
        }
        private void Enreg_Click(object sender, EventArgs e)
        {
            DataRow dr;
            SqlCommandBuilder sql = new SqlCommandBuilder(ado.Adapter);
            if (!checkInfo(prenom.Text))
            {
                dr = ado.Dt.NewRow();
                dr[1] = GestionEmploye.IdChef;
                dr[2] = nom.Text;
                dr[3] = prenom.Text;
                dr[5] = dateTimePicker1.Value;
                dr[8] = decimal.Parse(avance.Text);
                dr[9] = decimal.Parse(salaire.Text);
                dr[10] = decimal.Parse(salaire.Text) - decimal.Parse(avance.Text);
                dr[11] = int.Parse(abscence.Text);
                ado.Dt.Rows.Add(dr);
                sql.GetInsertCommand();
                ado.Adapter.Update(ado.Dt);
                MessageBox.Show("Client Ajoutée avec succés", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else MessageBox.Show("emloye existe deja");
        }
    }
}
