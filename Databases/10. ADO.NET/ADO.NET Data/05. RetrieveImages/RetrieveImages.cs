using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace _05.RetrieveImages
{
    public class RetrieveImages
    {
        public static void Main()
        {
            GetImagesFromDatabase();
        }

        private static void GetImagesFromDatabase()
        {
            var connectioNString = ConfigurationManager.ConnectionStrings["SqlDbContext"].ConnectionString;

            using (var dbConnection = new SqlConnection(connectioNString))
            {
                dbConnection.Open();
                var sqlCommand = GetSqlCommand(dbConnection);
            
                using (var reader = sqlCommand.ExecuteReader())
                {
                    var imageId = 1;

                    while (reader.Read())
                    {
                        var fileBinaryData = (byte[])reader["Picture"];

                        var stream = File.OpenWrite($"../../pic{imageId}.jpg");

                        using (stream)
                        {
                            stream.Write(fileBinaryData, 0, fileBinaryData.Length);
                        }

                        imageId++;
                    }
                }
            }
        }
       
        private static SqlCommand GetSqlCommand(SqlConnection sqlConnection)
        {
            var sqlCommand = new SqlCommand(@"SELECT Picture  FROM Categories", sqlConnection);

            return sqlCommand;
        }
    }
}
