using System;
using System.Data.SqlClient;

namespace P03MinionNames
{
    class Program
    {
        public static string connectionString =
            "Server=.\\SQLEXPRESS;" +
            "Database=MinionsDB;" +
            "Integrated Security=true;";
        static void Main(string[] args)
        {
            var connection = new SqlConnection(connectionString);

            connection.Open();

            var Id = int.Parse(Console.ReadLine());

            using (connection)
            {
                var queryString = @"SELECT Name FROM Villains WHERE Id = @Id";

                var sqlComand = new SqlCommand(queryString, connection);
                sqlComand.Parameters.AddWithValue("@Id", Id);

                try
                {
                    var name = sqlComand.ExecuteScalar();


                }
                catch (Exception)
                {

                    throw;
                }
                

            }
        }
    }
}
