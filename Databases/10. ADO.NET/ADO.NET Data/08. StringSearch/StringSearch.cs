using System;
using System.Configuration;
using System.Data.SqlClient;

namespace _08.StringSearch
{
    public class StringSearch
    {
        public static void Main()
        {
            Console.Write("Enter a search string: ");
            var pattern = Console.ReadLine();

            SearchProductNameByPattern(pattern);
        }

        private static void SearchProductNameByPattern(string pattern)
        {
            var connectioNString = ConfigurationManager.ConnectionStrings["SqlDbContext"].ConnectionString;

            using (var dbConnection = new SqlConnection(connectioNString))
            {
                dbConnection.Open();
                var sqlCommand = GetSearchByPatternSqlCommand(dbConnection, pattern);

                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productName = reader["ProductName"];

                        Console.WriteLine(" - " + productName);
                    }
                }
            }
        }

        private static SqlCommand GetSearchByPatternSqlCommand(SqlConnection sqlConnection, string pattern)
        {
            var sqlCommand = new SqlCommand(@"SELECT ProductName 
                                                     FROM Products
                                                     WHERE CHARINDEX(@pattern, ProductName) > 0", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@pattern", pattern);
            return sqlCommand;
        }
    }
}
