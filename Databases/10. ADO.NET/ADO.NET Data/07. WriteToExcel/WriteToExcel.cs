using System;
using System.Configuration;
using System.Data.OleDb;

namespace _07.WriteToExcel
{
    public class WriteToExcel
    {
        public static void Main()
        {
            InsertRecordsToExcel();
        }

        private static void InsertRecordsToExcel(int numberOfRecordsToInsert = 1)
        {
            var connectioNString = ConfigurationManager.ConnectionStrings["OleDbContext"].ConnectionString;

            using (var excelConnection = new OleDbConnection(connectioNString))
            {
                excelConnection.Open();
                var sheetName = GetSheetName(excelConnection);
                var excelCommand = GetInsertOleDbCommand(excelConnection, sheetName);

                for (var i = 0; i < numberOfRecordsToInsert; i++)
                {
                    var queryResult = excelCommand.ExecuteNonQuery();
                    Console.WriteLine($"({queryResult} row(s) affected)");
                }
            }
        }

        private static string GetSheetName(OleDbConnection oleDbCommand)
        {
            var excelSchema = oleDbCommand.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            var sheetName = excelSchema.Rows[0]["TABLE_NAME"].ToString();
            return sheetName;
        }

        private static OleDbCommand GetInsertOleDbCommand(OleDbConnection oleDbConnection, string sheetName)
        {
            const string name = "Ivan Genchev";
            const int age = 20;

            var excelCommand = new OleDbCommand("INSERT INTO [" + sheetName + "] VALUES (@name, @age)", oleDbConnection);

            excelCommand.Parameters.AddWithValue("@name", name);
            excelCommand.Parameters.AddWithValue("@age", age);

            return excelCommand;
        }
    }
}
