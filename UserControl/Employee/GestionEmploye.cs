using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using RNetApp.Forms;
namespace RNetApp
{
    public partial class GestionEmploye : UserControl
    {
        //Getting the chef's id 
        private static Guid idChef;
        private string idEmp;
        private int position;
        public GestionEmploye()
        {
            InitializeComponent();
        }
        AdoNet ado = new AdoNet();
        public static Guid IdChef { get => idChef; set => idChef = value; }
        private void fillCombo(ComboBox com,string[] names)
        {
            names[0] = "Tous";
            com.Items.AddRange(names);
        }
        private string[] retrievingEmployees(DataTable dt)
        {
            string[] ret = new string[dt.Rows.Count + 1];
            for (int i = 1; i < ret.Length; i++)
            {
                ret[i] = dt.Rows[i - 1]["prenom"].ToString();
            }
            return ret;
        }
        private void setDataGridViewIcons()
        {
            Shared.addCol(dataGridView1, "delete", "delete", "supprimer");
            Shared.addCol(dataGridView1, "edit", "edit", "modifier");
            Shared.addCol(dataGridView1, "calendar", "repos", "");
        }
        private void setDataGridView()
        {
            dataGridView1.Columns["IDEMPLOYE"].Visible = false;
            dataGridView1.Columns["IDCHEF"].Visible = false;
            dataGridView1.Columns["DATE_DEPART"].Visible = false;
            dataGridView1.Columns["DATE_FIN"].Visible = false;
            dataGridView1.Columns["AGE"].Visible = false;
            dataGridView1.Columns["PRENOM"].HeaderText = "Prénom";
            dataGridView1.Columns["SALAIRE"].HeaderText = "Salaire";
            dataGridView1.Columns["SALAIRE_RESTANT"].HeaderText = "Salaire Restant";
            dataGridView1.Columns["AVANCE"].HeaderText = "Avance";
            setDataGridViewIcons();
            dataGridView1.RowTemplate.Height = 40;
        }
        private void fillComboWithDataSource(ComboBox com)
        {
            com.DataSource = ado.Dt;
            com.DisplayMember = ado.Dt.Columns["PRENOM"].ToString();
            com.ValueMember = ado.Dt.Columns["IDEMPLOYE"].ToString();
        }
        private void GestionEmploye_Load(object sender, EventArgs e)
        {
            //fill the dataSet! 
            ado.Cmd.CommandText = "Select * from EMPLOYE";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            dataGridView1.DataSource = ado.Dt;

            fillComboWithDataSource(comboBox1);

            fillCombo(comboEmp, retrievingEmployees(ado.Dt));

            setDataGridView();

            comboEmp.Text = "Tous";
            nbrEmp.Text = $"{ado.Dt.Rows.Count}";
        }
        private void congerBtn_Click(object sender, EventArgs e)
        {
            ReposCalcul rc = new ReposCalcul();
            ReposCalcul.IdEmploye = Guid.Parse(ado.Dt.Rows[position][0].ToString());
            rc.Show();
        }
       /* private bool checkEmpWithId(string nomEmp, string id)
        {
            foreach (DataRow row in ado.Ds.Tables["EMPLOYE"].Rows)
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
            foreach (DataRow row in ado.Ds.Tables["EMPLOYE"].Rows)
            {
                if (row["IDEMPLOYE"].ToString().ToLower() != id.ToLower() && row["PRENOM"].ToString().ToLower() == nomEmp.ToLower())
                {
                    return true;
                }
            }
            return false;
        }*/
        private void comboBox1_ValueMemberChanged(object sender, EventArgs e)
        {
        }
        private void ficheBtn_Click(object sender, EventArgs e)
        {
            FichierEmpl emp = new FichierEmpl();
            FichierEmpl.IdEmpl = Guid.Parse(comboBox1.SelectedValue.ToString());
            emp.Show(); 
        }
        private bool checkEmpl(string prenom)
        {
            foreach(DataRow row in ado.Dt.Rows)
            {
                if (row["PRENOM"].ToString().ToLower() == prenom.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private void filtreBtn_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(ado.Dt);
            dv.RowFilter = $"salaire_restant = {0}";
            dataGridView1.DataSource = dv;
        }
        private void filtreNnPai_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(ado.Dt);
            dv.RowFilter = $"salaire_restant > {0}";
            dataGridView1.DataSource = dv;
        }
        private void dataGridView1_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (decimal.Parse(dataGridView1.Rows[i].Cells["SALAIRE_RESTANT"].Value.ToString()) == 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Lime;
                }
                else dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
            }
        }

        private void dataGridView1_CellMouseEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colName != "delete" && colName != "edit" && colName != "add")
                {
                    dataGridView1.Cursor = Cursors.Default;
                }
                else
                {
                    dataGridView1.Cursor = Cursors.Hand;
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                if (colName == "delete")
                {
                    bool confirmation = Shared.showMessage("Voulez vous vraiment supprimer le client ?", "Confirmation de suppression");
                    if (confirmation)
                    {
                        SqlCommandBuilder scb = new SqlCommandBuilder(ado.Adapter);
                        scb.GetDeleteCommand();
                        ado.Dt.Rows[e.RowIndex].Delete();
                        ado.Adapter.Update(ado.Dt);
                        nbrEmp.Text = $"{ado.Dt.Rows.Count}";
                    }
                }
                else if (colName == "edit")
                {
                    bool confirmation = Shared.showMessage("Voulez vous vraiment modifier le client ?", "Confirmation de modification");
                    if (confirmation)
                    {
                        ModifierEmploye me = new ModifierEmploye();
                        DataRow dr = ado.Dt.Rows[e.RowIndex];
                        me.Employe = dr;
                        me.Show();
                    }
                }
                else if (colName == "calendar")
                {
                    ReposCalcul rc = new ReposCalcul();
                    ReposCalcul.IdEmploye = Guid.Parse(dataGridView1.Rows[e.RowIndex].Cells["idemploye"].Value.ToString());
                    rc.Show();
                } else if(colName == "add")
                {
                    AjoutEmploye ajoutEmploye = new AjoutEmploye();
                    ajoutEmploye.Show();
                }
            }
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            //refreshing datagridview
            ado.Dt.Clear();
            ado.Cmd.CommandText = "Select * from EMPLOYE";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);

            dataGridView1.DataSource = ado.Dt;
            //refreshing combobox : 

            comboEmp.Items.Clear();
            fillCombo(comboEmp, retrievingEmployees(ado.Dt));
        }
        private void comboEmp_SelectedValueChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(ado.Dt);
            if (comboEmp.Text != "Tous" && comboEmp.Text != "")
            {
                dv.RowFilter = $"prenom = '{comboEmp.Text}'";
                dataGridView1.DataSource = dv;
            }
            else if (comboEmp.Text == "Tous" )
            {
                dataGridView1.DataSource = ado.Dt;
            }
        }

        private void AjoutEmp_Click(object sender, EventArgs e)
        {
            AjoutEmploye ajoutEmploye = new AjoutEmploye();
            ajoutEmploye.Show();
        }
    }
}
