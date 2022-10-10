using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace RNetApp
{
    public partial class ChoixCategorie : Form
    {
        AdoNet ado = new AdoNet();
        bool ButtonTrigger = false;
        public static TabControl tab;
        public ChoixCategorie()
        {
            InitializeComponent();
        }
        private void setDataGridView(List<string> categories)
        {
            Shared.addCol(dataGridView1, "delete", "delete", "Supprimer");
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
            ButtonTrigger = true;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SqlCommandBuilder categoryCommandBuilder = new SqlCommandBuilder(ado.Adapter);
                if(ButtonTrigger == true)
                {
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
                        TabPage tabPage = new TabPage();
                        tabPage.Text = categorieValue;
                        tab.TabPages.Add(tabPage);
                    }
                    else MessageBox.Show("enter something");
                } else if(ButtonTrigger == false)
                {
                    categoryCommandBuilder.GetUpdateCommand();
                    tab.TabPages[e.RowIndex].Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    ado.Dt.Rows[e.RowIndex]["nomcategorie"] = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    ado.Adapter.Update(ado.Dt);
                }
                ButtonTrigger = false;
            } catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            SqlCommandBuilder categoryCommandBuilder = new SqlCommandBuilder(ado.Adapter);
            if (colName == "delete")
            {
                categoryCommandBuilder.GetDeleteCommand();
                ado.Dt.Rows[e.RowIndex].Delete();
                ado.Adapter.Update(ado.Dt);
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                tab.TabPages.RemoveAt(e.RowIndex);
            } 
        }
    }
}
