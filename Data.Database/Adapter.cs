using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Data.Database
{
    public class Adapter
    {
        #region SQLEXPRESS
        //protected SqlConnection sqlConnection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=tp2_net;Integrated Security=False");

        //Clave por defecto a utlizar para la cadena de conexion

        //const string consKeyDefaultCnnString = "ConnStringExpress";
        #endregion;

        #region SQL NO EXPRESS
        //protected SqlConnection sqlConnection = new SqlConnection("Data Source=localhost;Initial Catalog=tp2_net;Integrated Security=False");

        //Clave por defecto a utlizar para la cadena de conexion
        //const string consKeyDefaultCnnString = "ConnStringLocal";
        #endregion
        
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
