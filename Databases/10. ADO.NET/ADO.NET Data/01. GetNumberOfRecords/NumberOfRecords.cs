using System;
using System.Configuration;
using System.Data.SqlClient;

namespace _01.GetNumberOfRecords
{   
    public class NumberOfRecords
    {
        public static void Main()
        {
            GetNumberOfCategories();
        }

        private static void GetNumberOfCategories()
        {
            var connectioNString = ConfigurationManager.ConnectionStrings["SqlDbContext"].ConnectionString;

  
            using (var dbConnection = new SqlConnection(connectioNString))
            {
                dbConnection.Open();
                var sqlCommand = GetSqlCommand(dbConnection);

                var recordsCount = (int)sqlCommand.ExecuteScalar();
                Console.WriteLine($"Total records: {recordsCount}");
            }
        }

        private static SqlCommand GetSqlCommand(SqlConnection sqlConnection)
        {            
            var sqlCommand = new SqlCommand(@"SELECT COUNT(CategoryId) FROM Categories", sqlConnection);

            return sqlCommand;
        }
    }
}
