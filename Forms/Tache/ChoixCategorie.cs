using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace RNetApp
{
    public partial class ChoixCategorie : Form
    {
        AdoNet ado = new AdoNet();
        public ChoixCategorie()
        {
            InitializeComponent();
        }
        private void setDataGridView(List<string> categories)
        {
            Shared.addCol(dataGridView1, "edit", "edit", "Modifier");
            foreach (string category in categories)
            {
                dataGridView1.Rows.Add(category);
            }
        }
        private void ChoxiCategorie_Load(object sender, EventArgs e)
        {
            List<string> categories = new List<string>();
            ado.Cmd.CommandText = "select * from categorie";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            //convert all categories from database into the list : 
            foreach(DataRow row in ado.Dt.Rows)
            {
                categories.Add(row["nomcategorie"].ToString());
            }
            setDataGridView(categories);
        }
        private void Enre_Click(object sender, EventArgs e)
        {
            //adding a row to the datagrid : 
            dataGridView1.Rows.Add();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SqlCommandBuilder categoryCommandBuilder = new SqlCommandBuilder(ado.Adapter);
                string categorieValue = null;
                DataRow categorieRow;
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    categorieValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    //adding new row to the category datatable :
                    categorieRow = ado.Dt.NewRow();
                    categorieRow["nomcategorie"] = categorieValue;
                    ado.Dt.Rows.Add(categorieRow);

                    //updating dataBase : 
                    categoryCommandBuilder.GetInsertCommand();
                    ado.Adapter.Update(ado.Dt);
                }
                else MessageBox.Show("enter something");
            } catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
