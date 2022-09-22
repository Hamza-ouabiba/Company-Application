using RNetApp.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace RNetApp
{
    public partial class ModifierEmploye : Form
    {
        AdoNet ado = new AdoNet();
        DataRow employe = null;
        public ModifierEmploye()
        {
            InitializeComponent();
        }
        public DataRow Employe { get => employe; set => employe = value; }
        private void fillDataTable()
        {
            ado.Cmd.CommandText = $"select * from employe";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            dataGridView1.DataSource = ado.Dt;
        }
        private void ModifierEmploye_Load(object sender, EventArgs e)
        {
            fillDataTable();
            if (employe != null)
            {
                prenom.Text = employe["prenom"].ToString();
                salaire.Text = employe["salaire"].ToString();
                avance.Text = employe["avance"].ToString();
                abscence.Text = employe["abscence"].ToString();
                repos.Text = employe["repos"].ToString();
                SalaireRest.Text = employe["salaire_restant"].ToString();
                dateDebut.Text = employe["Date_depart"].ToString();
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //check Employee with Id : 
        private bool checkEmpWithId(string nomEmp, string id)
        {
            foreach (DataRow row in ado.Dt.Rows)
            {
                if (row["IDEMPLOYE"].ToString().ToLower() == id.ToLower() && row["PRENOM"].ToString().ToLower() == nomEmp.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private bool checkEmpWithNoId(string nomEmp, string id)
        {
            foreach (DataRow row in ado.Dt.Rows)
            {
                if (row["IDEMPLOYE"].ToString().ToLower() != id.ToLower() && row["PRENOM"].ToString().ToLower() == nomEmp.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private bool checkEmpl(string prenom)
        {
            foreach (DataRow row in ado.Dt.Rows)
            {
                if (row["PRENOM"].ToString().ToLower() == prenom.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private int positionEmploye()
        {
            for (int i = 0; i < ado.Dt.Rows.Count; i++)
            {
                if (ado.Dt.Rows[i]["idemploye"].ToString() == employe["idemploye"].ToString())
                {
                    return i;
                }
            }
            return -1;
        }
        private bool testSalaire(int position)
        {
            return decimal.Parse(salaire.Text) != decimal.Parse(ado.Dt.Rows[position]["salaire"].ToString());
        }
        private void modifier_Click(object sender, EventArgs e)
        {
            int position = positionEmploye();
            SqlCommandBuilder scb = new SqlCommandBuilder(ado.Adapter);
            //searching the current row in the data table so we can update it : 
            if(position != -1)
            {
                if (checkEmpWithNoId(prenom.Text, employe["idemploye"].ToString()))
                {
                    MessageBox.Show("ce nom existe deja dans la base");
                }
                else if (checkEmpWithId(prenom.Text, employe["idemploye"].ToString()) || !checkEmpl(prenom.Text))
                {
                    ado.Dt.Rows[position]["prenom"] = prenom.Text;
                    if (decimal.Parse(SalaireRest.Text) == 0 && !testSalaire(position))
                    {
                            ado.Dt.Rows[position]["avance"] = decimal.Parse(avance.Text);
                            ado.Dt.Rows[position]["date_depart"] = dateTimePicker1.Value;
                            scb.GetUpdateCommand();
                            ado.Adapter.Update(ado.Dt);
                            MessageBox.Show("modification avec succes");
                    } else if(decimal.Parse(SalaireRest.Text) == 0 && testSalaire(position))
                    {
                            ado.Dt.Rows[position]["salaire"] = decimal.Parse(salaire.Text);
                            ado.Dt.Rows[position]["salaire_restant"] = decimal.Parse(salaire.Text) - decimal.Parse(avance.Text);
                            ado.Dt.Rows[position]["avance"] = decimal.Parse(avance.Text);
                            ado.Dt.Rows[position]["date_depart"] = dateTimePicker1.Value;
                            scb.GetUpdateCommand();
                            ado.Adapter.Update(ado.Dt);
                            MessageBox.Show("modification avec succes");
                    }
                   if(decimal.Parse(SalaireRest.Text) !=0 && !testSalaire(position))
                    {
                        if (decimal.Parse(avance.Text) <= decimal.Parse(SalaireRest.Text))
                        {
                            ado.Dt.Rows[position]["salaire_restant"] = decimal.Parse(SalaireRest.Text) - decimal.Parse(avance.Text);
                            ado.Dt.Rows[position]["avance"] = decimal.Parse(avance.Text);
                            ado.Dt.Rows[position]["date_depart"] = dateTimePicker1.Value;
                            scb.GetUpdateCommand();
                            ado.Adapter.Update(ado.Dt);
                            MessageBox.Show("modification avec succes");
                        }
                        else MessageBox.Show("Reessayer car le montant donne est superieur au salaire restant ");
                    } else if(decimal.Parse(SalaireRest.Text) != 0 && testSalaire(position))
                    {
                        if (decimal.Parse(avance.Text) <= decimal.Parse(salaire.Text))
                        {
                            ado.Dt.Rows[position]["salaire"] = decimal.Parse(salaire.Text);
                            ado.Dt.Rows[position]["salaire_restant"] = decimal.Parse(salaire.Text) - decimal.Parse(avance.Text);
                            ado.Dt.Rows[position]["avance"] = decimal.Parse(avance.Text);
                            ado.Dt.Rows[position]["date_depart"] = dateTimePicker1.Value;
                            scb.GetUpdateCommand();
                            ado.Adapter.Update(ado.Dt);
                            MessageBox.Show("modification avec succes");
                        }
                        else MessageBox.Show("Reessayer car le montant donne est superieur au salaire  ");
                    }
                }
            }
        }
        private void congerBtn_Click(object sender, EventArgs e)
        {
            int position = positionEmploye();
            ReposCalcul repos_cal = new ReposCalcul();
            ReposCalcul.IdEmploye = Guid.Parse(ado.Dt.Rows[position]["idemploye"].ToString());
        }
    }
}
