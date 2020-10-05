using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Data.Database
{
    public class Adapter
    {
        protected SqlConnection sqlConnection; const string consKeyDefaultCnnString = "ConnStringLocal";

        protected void OpenConnection()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString);
            sqlConnection.Open();
        }

        protected void CloseConnection()
        {
            sqlConnection.Close();
            sqlConnection = null;
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
