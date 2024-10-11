using Microsoft.Data.Sqlite;

//https://sqlitebrowser.org/   https://download.sqlitebrowser.org/DB.Browser.for.SQLite-3.12.2-win64.zip

// https://sqlitebrowser.org/ pour regarder dans le dedans de la BD
// https://www.codeguru.com/dotnet/using-sqlite-in-a-c-application/
namespace consoleApp
{
    class DataAccessObject
    {
        static SqliteConnection sqlite_conn = new SqliteConnection("Data Source=database.db;");

        public static void CreateTable() {
            sqlite_conn.Open();
            SqliteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE MUtilisateur" +
                " (nom VARCHAR(200)," +
                " motDePasse VARCHAR(200)," +
                " nas VARCHAR(10))";
           
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            try {
                sqlite_cmd.ExecuteNonQuery();
            } catch (Exception e)
            {

            }
            finally
            {
                sqlite_conn.Close();
            }
            
            //sqlite_conn.Close();
            //sqlite_cmd.CommandText = Createsql1;
            //sqlite_cmd.ExecuteNonQuery();
        }

        public static void InsertNewUser(MNouveauCompte compte)
        {
            sqlite_conn.Open();
            SqliteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO MUtilisateur (nom, motDePasse, nas) " +
                "VALUES('"+ compte.Nom +"', '"+
                DataSec.HashThePassword(compte.MotDePasse)+"', '"+
                DataSec.Encrypt(compte.NAS)  +"'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }


        public static List<MUtilisateur> ReadData()
        {
            sqlite_conn.Open();
            SqliteDataReader sqlite_datareader;
            SqliteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            List<MUtilisateur> liste = new List<MUtilisateur>();
            sqlite_cmd.CommandText = "SELECT * FROM MUtilisateur";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                //string myreader = sqlite_datareader.GetString(0);
                MUtilisateur compte = new MUtilisateur();
                compte.Nom = sqlite_datareader.GetString(0);
                compte.MotDePasseHash = sqlite_datareader.GetString(1);
                compte.NAS = sqlite_datareader.GetString(2);
                //Console.WriteLine(DataSec.Decrypt(compte.NAS));
                liste.Add(compte);

                //Console.WriteLine(sqlite_datareader.GetString(0));
                //Console.WriteLine(sqlite_datareader.GetString(1));
                //Console.WriteLine(sqlite_datareader.GetString(2));
            }
            sqlite_conn.Close();
            return liste;
            //conn.Close();
        }
        
        public static MUtilisateur UtilisateurParSonNom(string nom)
        {
            sqlite_conn.Open();
            SqliteDataReader sqlite_datareader;
            SqliteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM MUtilisateur WHERE nom = '"+ nom +"'";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            MUtilisateur compte = new MUtilisateur();
            // get the user from the database
            while (sqlite_datareader.Read())
            {
                compte.Nom = sqlite_datareader.GetString(0);
                compte.MotDePasseHash = sqlite_datareader.GetString(1);
                compte.NAS = sqlite_datareader.GetString(2);
            }
            sqlite_conn.Close();
            return compte;
        }
    }
}
