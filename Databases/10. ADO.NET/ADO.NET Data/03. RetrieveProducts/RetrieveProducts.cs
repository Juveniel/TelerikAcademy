using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace _03.RetrieveProducts
{
    public class RetrieveProducts
    {
        public static void Main()
        {
            var categoryProducts = new Dictionary<string, ISet<string>>();
            GetCategoryProducts(categoryProducts);
            PrintResult(categoryProducts);
        }

        private static void GetCategoryProducts(IDictionary<string, ISet<string>> categoryProducts)
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
                        var categoryName = reader["CategoryName"].ToString();
                        var productName = reader["ProductName"].ToString();

                        if (!categoryProducts.ContainsKey(categoryName))
                        {
                            categoryProducts[categoryName] = new HashSet<string>();
                        }

                        categoryProducts[categoryName].Add(productName);
                    }
                }
            }
        }

        private static SqlCommand GetSqlCommand(SqlConnection sqlConnection)
        {
            var sqlCommand = new SqlCommand(@"SELECT c.CategoryName, p.ProductName
                                                FROM Categories c
                                                JOIN Products P
                                                    ON c.CategoryID = p.CategoryID
                                                ORDER BY c.CategoryID", sqlConnection);
            return sqlCommand;
        }

        private static void PrintResult(IDictionary<string, ISet<string>> categoryProducts)
        {
            foreach (var categories in categoryProducts)
            {
                Console.WriteLine($"Category name: {categories.Key}");

                foreach (var productName in categories.Value)
                {
                    Console.WriteLine($" - {productName}");
                }

                Console.WriteLine();
            }
        }
    }
}
