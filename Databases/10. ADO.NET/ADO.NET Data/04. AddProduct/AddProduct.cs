using System;
using System.Configuration;
using System.Data.SqlClient;

namespace _04.AddProduct
{
    public class AddProduct
    {
        public static void Main()
        {
            InsertProductInDatabase();
        }

        private static void InsertProductInDatabase()
        {
            var connectioNString = ConfigurationManager.ConnectionStrings["SqlDbContext"].ConnectionString;

            using (var dbConnection = new SqlConnection(connectioNString))
            {
                dbConnection.Open();
                var sqlCommand = GetInsertProductSqlCommand(dbConnection);

                var queryResult = sqlCommand.ExecuteNonQuery();
                Console.WriteLine($"({queryResult} row(s) affected)");
            }
        }

        private static SqlCommand GetInsertProductSqlCommand(SqlConnection sqlConnection)
        {
            var dateTimeNowStamp = DateTime.Now.ToString("ddmmss");

            var productName = "Nescafe Coffee - " + dateTimeNowStamp;
            const int supplierId = 22;
            const int categoryId = 1;
            const string quantityPerUnit = "16 - 500 g tins";
            const double unitPrice = 46.0d;
            const int unitsInStock = 1000;
            const int unitsInOrder = 500;
            const int reorderLevel = 30;
            const int discontinued = 0;

            var sqlCommand = GetSqlCommand(sqlConnection);
            sqlCommand.Parameters.AddWithValue("@productName", productName);
            sqlCommand.Parameters.AddWithValue("@supplierId", supplierId);
            sqlCommand.Parameters.AddWithValue("@categoryId", categoryId);
            sqlCommand.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
            sqlCommand.Parameters.AddWithValue("@unitPrice", unitPrice);
            sqlCommand.Parameters.AddWithValue("@unitsInStock", unitsInStock);
            sqlCommand.Parameters.AddWithValue("@unitsInOrder", unitsInOrder);
            sqlCommand.Parameters.AddWithValue("@reorderLevel", reorderLevel);
            sqlCommand.Parameters.AddWithValue("@discontinued", discontinued);
            return sqlCommand;
        }

        private static SqlCommand GetSqlCommand(SqlConnection sqlConnection)
        {
            var sqlCommand = new SqlCommand(@"INSERT INTO Products
                                 VALUES (@productName, @supplierId, @categoryId, @quantityPerUnit, @unitPrice, 
                                         @unitsInStock, @unitsInOrder, @reorderLevel, @discontinued)", sqlConnection);
            return sqlCommand;
        }
    }
}
