using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnexion
    {
        public SqlConnection OpenConnexion()
        {
            string connexionString = ConfigurationManager.ConnectionStrings["connexionString"].ConnectionString;
            var connection = new SqlConnection(connexionString);
            connection.Open();

            return connection;
        }
    }
}
