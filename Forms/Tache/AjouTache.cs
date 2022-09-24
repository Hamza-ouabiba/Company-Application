using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class AjouTache : Form
    {
        AdoNet ado = new AdoNet();  
        
        public AjouTache()
        {
            InitializeComponent();
        }
        private void fillCombo(ComboBox com)
        {
            com.DisplayMember = ado.Ds.Tables["categorie"].Columns["nomcategorie"].ToString();
            com.ValueMember = ado.Ds.Tables["categorie"].Columns["nomcategorie"].ToString();
            com.DataSource = ado.Ds.Tables["categorie"];
        }
        void loadData()
        {
            ado.Cmd.CommandText = "gestiontache";
            ado.Cmd.CommandType = CommandType.StoredProcedure;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);
            ado.Ds.Tables[0].TableName = "tache";
            ado.Ds.Tables[1].TableName = "categorie";
        }
        private void AjouTache_Load(object sender, EventArgs e)
        {
            loadData();
            fillCombo(comboBox1);
        }
        private bool verifyTextBoxes()
        {
            return description.Text != "" && comboBox1.Text != "";
        }
        private void enregistrer_Click(object sender, EventArgs e)
        {
            //adding a new data row ! 
            DataRow tacheRow = ado.Ds.Tables["tache"].NewRow();
            SqlCommandBuilder tacheBuilder = new SqlCommandBuilder(ado.Adapter);
            //verfieri  : 
            try
            {
                if(verifyTextBoxes())
                {
                    tacheRow["desription"] = description.Text;
                    tacheRow["date_depart"] = date_depart.Text;
                    tacheRow["termine_o_n"] = 0;
                    tacheRow["nomcategorie"] = comboBox1.Text ;

                    ado.Ds.Tables["tache"].Rows.Add(tacheRow);
                    //updating database :
                    tacheBuilder.GetInsertCommand();
                    ado.Adapter.Update(ado.Ds.Tables["tache"]);
                }
            } catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
