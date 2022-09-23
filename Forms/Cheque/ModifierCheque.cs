using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace RNetApp
{
    public partial class ModifierCheque : Form
    {
        private static int idcheque;
        AdoNet ado = new AdoNet();
        AdoNet factureTable = new AdoNet();
        AdoNet especeTable  = new AdoNet(); 
        DataRow row = null;
        public ModifierCheque()
        {
            InitializeComponent();
        }
        public static int Idcheque { get => idcheque; set => idcheque = value; }
        private DataRow searchCheque()
        {
            foreach(DataRow row in ado.Dt.Rows)
            {
                if(int.Parse(row["idcheque"].ToString()) == Idcheque)
                {
                    return row;
                }
            }
            return null;
        }
        private void ModifierCheque_Load(object sender, EventArgs e)
        {
            AdoNet ado2=  new AdoNet();
            ado.Cmd.CommandText = $"select * from cheque";
            ado.Cmd.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Cmd;
            ado.Adapter.Fill(ado.Dt);
            ado2.Cmd.CommandText = $"select * from client where idclient = '{Guid.Parse(ado.Dt.Rows[0]["idclient"].ToString())}'";
            ado2.Cmd.Connection = ado2.Connection;
            ado2.Adapter.SelectCommand = ado2.Cmd;
            ado2.Adapter.Fill(ado2.Dt);
            //getting the datarow of the current check : 
            row = searchCheque();   
            numCheq.Text = row["idcheque"].ToString();
            montantChe.Text = row["montant"].ToString();
            nomT.Text = ado2.Dt.Rows[0]["nom"].ToString();
            factuNu.Text = row["idfacture"].ToString();
        }
        private bool checkCheque(string numero)
        {
            foreach(DataRow row in ado.Dt.Rows)
            {
                if(numero == row["idcheque"].ToString())
                {
                    return true;
                }
            }
            return false;
        }
        private bool verifyFacture()
        {
            if(row != null)
            {
                
            }
            return decimal.Parse(montantChe.Text) <= decimal.Parse(factureTable.Dt.Rows[0]["total_rest"].ToString());
        }
        //the sum of all checks to modify a check : 
        private decimal calculTotal(int idfacture,int idCheque)
        {
            decimal total = 0;
            DataRow[] dr_cheque;
            DataRow[] dr_montant;
            dr_cheque = ado.Dt.Select($"idfacture = '{idfacture}'");
            dr_montant = especeTable.Dt.Select($"idfacture = '{idfacture}'");
            foreach (DataRow dr2 in dr_cheque)
            {
                if(int.Parse(dr2["idcheque"].ToString()) != idcheque)
                 {
                    MessageBox.Show($"cheque a valeur : {dr2["montant"].ToString()} ");
                    total += decimal.Parse(dr2["montant"].ToString());
                 }
            }
            foreach (DataRow dr2 in dr_montant)
            {
                total += decimal.Parse(dr2["montant"].ToString());
            }
            return total;
        }
        private void Modifier_Click(object sender, EventArgs e)
        {
            decimal montantVerifier;
            int idfacture;

            SqlCommandBuilder sql = new SqlCommandBuilder(ado.Adapter);
            SqlCommandBuilder factureBuilder = new SqlCommandBuilder(factureTable.Adapter);
            

            //déterminer la facture actuel 
            factureTable.Cmd.CommandText = $"select * from facture where idfacture = {int.Parse(row["idfacture"].ToString())}";
            factureTable.Cmd.Connection = factureTable.Connection;
            factureTable.Adapter.SelectCommand = factureTable.Cmd;
            factureTable.Adapter.Fill(factureTable.Dt);

            especeTable.Cmd.CommandText = $"select * from espece";
            especeTable.Cmd.Connection = especeTable.Connection;
            especeTable.Adapter.SelectCommand = especeTable.Cmd;
            especeTable.Adapter.Fill(especeTable.Dt);

            row["idcheque"] = int.Parse(numCheq.Text);


            //verifier si la facture n'est pas encore payé : 
            sql.GetUpdateCommand();
            ado.Adapter.Update(ado.Dt);


            idfacture = int.Parse(factureTable.Dt.Rows[0]["idfacture"].ToString());
            //sum of all checks and including the new range : 

            montantVerifier = calculTotal(idfacture, int.Parse(row["idcheque"].ToString())) + decimal.Parse(montantChe.Text);



            if (montantVerifier <= decimal.Parse(factureTable.Dt.Rows[0]["total_ttc"].ToString()))
            {

                factureTable.Dt.Rows[0]["total_rest"] = decimal.Parse(factureTable.Dt.Rows[0]["total_ttc"].ToString()) - montantVerifier;

                //if there is still some cash not given it will be an unpaid invoice: 
                if (decimal.Parse(factureTable.Dt.Rows[0]["total_rest"].ToString()) != 0)
                {
                    factureTable.Dt.Rows[0]["pay_o_n"] = 0;
                }  else factureTable.Dt.Rows[0]["pay_o_n"] = 1;

                //updating the amount 
                row["montant"] = decimal.Parse(montantChe.Text);

                sql.GetUpdateCommand();
                factureBuilder.GetUpdateCommand();
                ado.Adapter.Update(ado.Dt);
                factureTable.Adapter.Update(factureTable.Dt);
            } else
            {
                MessageBox.Show("Veuillez resaisir la valeur du montant du chèque");
            }
        }
    }
}
