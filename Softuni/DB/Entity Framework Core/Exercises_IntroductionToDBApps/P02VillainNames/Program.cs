using System;
using System.Data.SqlClient;

namespace P02VillainNames
{
    class Program
    {
        private static string connectionString =
            "Server=.\\SQLEXPRESS;" +
            "Database=MinionsDB;" +
            "Integrated Security=true;";
        static void Main(string[] args)
        {
            var connection = new SqlConnection(connectionString);

            connection.Open();

            using (connection)
            {
                var queryString = @"SELECT v.Name, COUNT(mv.VillainId) AS MinionsCount  
                                        FROM Villains AS v 
                                        JOIN MinionsVillains AS mv ON v.Id = mv.VillainId 
                                    GROUP BY v.Id, v.Name 
                                      HAVING COUNT(mv.VillainId) > 3 
                                    ORDER BY COUNT(mv.VillainId)";

                var villainSelectComand = new SqlCommand(queryString, connection);

                try
                {
                    var reader = villainSelectComand.ExecuteReader();

                    Console.WriteLine("Comand was sucessful!");

                    using(reader)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader["Name"]} - {reader["MinionsCount"]}");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Comand wasn't sucessful!");
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
