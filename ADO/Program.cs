using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            var connexionString = ConfigurationManager.ConnectionStrings["connexionString"].ConnectionString;
            var connection = new SqlConnection(connexionString);
            connection.Open();

            AfficherTous(connection);

            Console.WriteLine("Entrer un Nom");
            var nom = Console.ReadLine();
            Console.WriteLine("Entrer un Prenom");
            var prenom = Console.ReadLine();

            var command = new SqlCommand($"Insert into Personne  VALUES( '{nom}', '{prenom}')", connection);
            var count = command.ExecuteNonQuery();
            Console.WriteLine($"Number of affected lines:{count}");

            AfficherTous(connection);
            connection.Close();
        }

        public static void AfficherTous(SqlConnection connection)
        {
            var command = new SqlCommand("Select * from Personne", connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Id={reader.GetInt32(0)}, Nom={reader.GetString(1)}, Prenom={reader.GetString(2)} ");
            }
            reader.Close();
            Console.ReadKey();
        }
    }
}
