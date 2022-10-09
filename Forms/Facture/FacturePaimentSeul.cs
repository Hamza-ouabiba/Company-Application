using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RNetApp
{
    public partial class FacturePaimentSeul : Form
    {
        int idFacture;
        AdoNet ado = new AdoNet();
        public int IdFacture { get => idFacture; set => idFacture = value; }
        DataRow row;
        public FacturePaimentSeul()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            ado.Cmd.CommandText = "GETTABLES";
            ado.Cmd.CommandType = CommandType.StoredProcedure;
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Ds);

            ado.Ds.Tables[0].TableName = "facture";
            ado.Ds.Tables[1].TableName = "client";
            ado.Ds.Tables[2].TableName = "cheque";
            ado.Ds.Tables[3].TableName = "espece";
            ado.Ds.Tables[4].TableName = "changer";
        }
        private void searchClient(Guid idclient)
        {
            ado.Ds.Tables["client"].PrimaryKey = new DataColumn[] { ado.Ds.Tables["client"].Columns["idclient"] };
            DataRow data = ado.Ds.Tables["client"].Rows.Find(idclient);
            if (data != null)
            {
                nomClt.Text = data["nom"].ToString();
            }
        }
        private Guid searchClientId(Guid idclient)
        {
            ado.Ds.Tables["client"].PrimaryKey = new DataColumn[] { ado.Ds.Tables["client"].Columns["idclient"] };
            DataRow row = ado.Ds.Tables["client"].Rows.Find(idclient);
            return Guid.Parse(row["idclient"].ToString());
        }
        private void FacturePaimentSeul_Load(object sender, EventArgs e)
        {
            loadData();
            comboBox1.Text = "Espèce";
            ado.Ds.Tables["facture"].PrimaryKey = new DataColumn[] { ado.Ds.Tables["facture"].Columns["idfacture"] };
            row = ado.Ds.Tables["facture"].Rows.Find(idFacture);
            searchClient(Guid.Parse(row["idclient"].ToString()));
            facNum.Text = row["idfacture"].ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Chèque")
            {
                numCh.ReadOnly = false;
            } else numCh.ReadOnly = true;
        }

        bool searchChequeNumber(int numCheque)
        {
            foreach(DataRow dataRow in ado.Ds.Tables["cheque"].Rows)
            {
                if(numCheque == int.Parse(dataRow["idcheque"].ToString()))
                {
                    return true;
                }
            }
            return false;
        }
        private void enrBtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapterFacture = new SqlDataAdapter("select * from facture", ado.Connection);
            SqlCommandBuilder sqlFacture = new SqlCommandBuilder(adapterFacture);
            if (comboBox1.Text == "Chèque")
            {
                SqlDataAdapter adapterCheque = new SqlDataAdapter("select * from cheque",ado.Connection);
                SqlCommandBuilder sql = new SqlCommandBuilder(adapterCheque);
                    if (decimal.Parse(row["total_rest"].ToString()) > 0 && decimal.Parse(Mnt.Text) <= decimal.Parse(row["total_rest"].ToString()) && (decimal.Parse(row["total_rest"].ToString()) - decimal.Parse(Mnt.Text)) > 0)
                    {
                    if (!searchChequeNumber(int.Parse(numCh.Text)))
                    {
                        DataRow data = ado.Ds.Tables["cheque"].NewRow();
                        data[0] = int.Parse(numCh.Text);
                        data[1] = int.Parse(facNum.Text);
                        data[2] = Guid.Parse(row["idclient"].ToString());
                        data[3] = decimal.Parse(Mnt.Text);

                        sql.GetInsertCommand();
                        ado.Ds.Tables["cheque"].Rows.Add(data);
                        adapterCheque.Update(ado.Ds.Tables["cheque"]);
                        sqlFacture.GetUpdateCommand();

                        row["total_rest"] = decimal.Parse(row["total_rest"].ToString()) - decimal.Parse(Mnt.Text);
                        row["pay_o_n"] = 2;
                        adapterFacture.Update(ado.Ds.Tables["facture"]);
                    }
                    else MessageBox.Show("Numéro de chèque déja existant");

                    } else if ((decimal.Parse(row["total_rest"].ToString())== 0))
                    {
                        MessageBox.Show("facture  payée");
                        sqlFacture.GetUpdateCommand();
                        row["pay_o_n"] = 1;
                        adapterFacture.Update(ado.Ds.Tables["facture"]);
                    } else if (decimal.Parse(Mnt.Text) > decimal.Parse(row["total_rest"].ToString()))
                    {
                        MessageBox.Show("Montant très supérieur au montant de la facture !!!");
                    }
                    else if ((decimal.Parse(row["total_rest"].ToString()) - decimal.Parse(Mnt.Text) == 0))
                    {
                        MessageBox.Show("facture  payée");
                        sqlFacture.GetUpdateCommand();
                        row["pay_o_n"] = 1;
                        adapterFacture.Update(ado.Ds.Tables["facture"]);
                    }
            } else
            {
                SqlDataAdapter adapterEspece= new SqlDataAdapter("select * from espece", ado.Connection);
                SqlCommandBuilder sql = new SqlCommandBuilder(adapterEspece);
                if (decimal.Parse(row["total_rest"].ToString()) > 0 && decimal.Parse(Mnt.Text) <= decimal.Parse(row["total_rest"].ToString()) && (decimal.Parse(row["total_rest"].ToString()) - decimal.Parse(Mnt.Text)) > 0)
                {
                    DataRow data = ado.Ds.Tables["espece"].NewRow();
                    data[1] = int.Parse(facNum.Text);
                    data[2] = Guid.Parse(row["idclient"].ToString());
                    data[3] = decimal.Parse(Mnt.Text);
                    sql.GetInsertCommand();
                    ado.Ds.Tables["espece"].Rows.Add(data);
                    adapterEspece.Update(ado.Ds.Tables["espece"]);
                    sqlFacture.GetUpdateCommand();

                    row["total_rest"] = decimal.Parse(row["total_rest"].ToString()) - decimal.Parse(Mnt.Text);
                    row["pay_o_n"] = 2;
                    adapterFacture.Update(ado.Ds.Tables["facture"]);
                } else if(decimal.Parse(row["total_rest"].ToString()) == 0)
                {
                    MessageBox.Show("facture  payée");
                    sqlFacture.GetUpdateCommand();
                    row["pay_o_n"] = 1;
                    adapterFacture.Update(ado.Ds.Tables["facture"]);
                } else if(decimal.Parse(Mnt.Text) > decimal.Parse(row["total_rest"].ToString()))
                {
                    MessageBox.Show("Montant très supérieur au montant de la facture !!!");
                } else if((decimal.Parse(row["total_rest"].ToString()) - decimal.Parse(Mnt.Text) == 0))
                {
                    MessageBox.Show("facture  payée");
                    sqlFacture.GetUpdateCommand();
                    row["pay_o_n"] = 1;
                    adapterFacture.Update(ado.Ds.Tables["facture"]);
                }
                    
            }
        }
    }
}
