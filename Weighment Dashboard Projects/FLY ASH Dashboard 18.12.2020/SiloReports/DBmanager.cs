using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SiloReports
{
    class DBmanager
    {
        
        private string connectionString = @"Password=Sh@kth1$;Persist Security Info=True;User ID=sa;Initial Catalog=ktppwb;Data Source=172.21.36.20;";
        DataTable dt = new DataTable();       

        public DataTable fetchDataFromDatabase(string query)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query,sqlConnection);
                dt.Rows.Clear();
                sqlDataAdapter.Fill(dt);
                sqlConnection.Close();
            }

            return dt;

        }
        public string fetchTotalTonnage(string query)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string MTonnes="";
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                MTonnes = ds.Tables[0].Rows[0].ItemArray[0].ToString()+"  MT";
                sqlConnection.Close();
                return MTonnes;
            }
        }



    }
}
