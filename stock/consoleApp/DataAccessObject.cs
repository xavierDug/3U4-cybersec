using Microsoft.Data.Sqlite;


namespace consoleApp
{
    class DataAccessObject
    {
        static SqliteConnection sqlite_conn = new SqliteConnection("Data Source=database.db;");

        public static void CreateTable() {
            sqlite_conn.Open();
            SqliteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE SampleTable (Col1 VARCHAR(20), Col2 INT)";
           
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            //sqlite_cmd.CommandText = Createsql1;
            //sqlite_cmd.ExecuteNonQuery();
        }


    }
}
