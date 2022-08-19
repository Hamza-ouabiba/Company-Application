using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace RNetApp
{
    class AdoNet
    {

        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dt;
        private DataSet ds;
        private SqlCommand cmd;
        private string connectionStr;
        public DataTable Dt { get => dt; set => dt = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public SqlConnection Connection { get => connection; set => connection = value; }
        public DataSet Ds { get => ds; set => ds = value; }
        public SqlCommand Cmd { get => cmd; set => cmd = value; }
        public string ConnectionStr { get => connectionStr;}

        public AdoNet()
        {
            connectionStr = ConfigurationManager.ConnectionStrings["blanchisserie_app"].ConnectionString;
            connection = new SqlConnection(connectionStr);
            cmd = new SqlCommand();
            Ds = new DataSet(); 
            adapter = new SqlDataAdapter();
            dt  = new DataTable();
        }
    }
}
