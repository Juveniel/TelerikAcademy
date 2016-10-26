using System;
using System.Configuration;
using System.Data.SqlClient;

namespace _02.RetrieveData
{
    public class RetrieveData
    {
        public static void Main()
        {
            GetCategoriesFromDatabase();
        }

        private static void GetCategoriesFromDatabase()
        {
            var connectioNString = ConfigurationManager.ConnectionStrings["SqlDbContext"].ConnectionString;

            using (var dbConnection = new SqlConnection(connectioNString))
            {
                dbConnection.Open();
                var sqlCommand = GetSqlCommand(dbConnection);

                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Category: {reader["CategoryName"]} -> {reader["Description"]}");
                    }
                }
            }
        }

        private static SqlCommand GetSqlCommand(SqlConnection sqlConnection)
        {
            var sqlCommand = new SqlCommand(@"SELECT CategoryName, Description FROM Categories", sqlConnection);

            return sqlCommand;
        }
    }
}
