using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace _06.CreateExcelFile
{
    public class CreateExcelFile
    {
        public static void Main()
        {
            ReadExcelData();
        }

        private static void ReadExcelData()
        {
            var connectioNString = ConfigurationManager.ConnectionStrings["OleDbContext"].ConnectionString;

            using (var excelConnection = new OleDbConnection(connectioNString))
            {
                excelConnection.Open();
                var sheetName = GetSheetName(excelConnection);
                var excelCommand = GetOleDbCommand(sheetName, excelConnection);

                using (var oleDbDataAdapter = new OleDbDataAdapter(excelCommand))
                {
                    var dataSet = new DataSet();
                    oleDbDataAdapter.Fill(dataSet);

                    using (var reader = dataSet.CreateDataReader())
                    {
                        while (reader.Read())
                        {
                            var fullName = reader["Name"];
                            var score = reader["Score"];

                            Console.WriteLine(fullName + " -> " + score);
                        }
                    }
                }
            }
        }

        private static string GetSheetName(OleDbConnection oleDbConnection)
        {
            var excelSchema = oleDbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            var sheetName = excelSchema.Rows[0]["TABLE_NAME"].ToString();

            return sheetName;
        }

        private static OleDbCommand GetOleDbCommand(string sheetName, OleDbConnection excelConnection)
        {
            var oleDbCommand = new OleDbCommand(@"SELECT * FROM [" + sheetName + "]", excelConnection);

            return oleDbCommand;
        }
    }
}
