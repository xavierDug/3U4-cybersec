using Microsoft.Data.Sqlite;

//https://sqlitebrowser.org/   https://download.sqlitebrowser.org/DB.Browser.for.SQLite-3.12.2-win64.zip

// https://sqlitebrowser.org/ pour regarder dans le dedans de la BD
// https://www.codeguru.com/dotnet/using-sqlite-in-a-c-application/
namespace consoleApp
{
    class DataAccessObject
    {
        static SqliteConnection sqlite_conn = new SqliteConnection("Data Source=database.db;");

        public static void CreateTable()
        {
            sqlite_conn.Open();
            SqliteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE IF NOT EXISTS MUtilisateur" +
                               " (nom VARCHAR(200)," +
                               " motDePasse VARCHAR(200)," +
                               " nas VARCHAR(10))";

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            // create a second table MAnneeRevenu with the user name, the year and the income
            string Createsql1 = "CREATE TABLE IF NOT EXISTS MAnneeRevenu" +
                                " (nom VARCHAR(200)," +
                                " annee INT," +
                                " revenu INT)";
            var sqlite_cmd2 = sqlite_conn.CreateCommand();
            sqlite_cmd2.CommandText = Createsql1;
            try
            {
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd2.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Data);
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
                                     "VALUES('" + compte.Nom + "', '" +
                                     DataSec.HashThePassword(compte.MotDePasse) + "', '" +
                                     DataSec.Encrypt(compte.NAS) + "'); ";
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

        public static List<MAnneeRevenu> ReadYearlyIncome(string utilisateurConnecte)
        {
            sqlite_conn.Open();
            SqliteDataReader sqlite_datareader;
            SqliteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            List<MAnneeRevenu> liste = new List<MAnneeRevenu>();
            // execute the request and extract the data
            sqlite_cmd.CommandText = "SELECT * FROM MAnneeRevenu WHERE nom = '" + utilisateurConnecte + "'";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                MAnneeRevenu revenu = new MAnneeRevenu();
                revenu.Nom = sqlite_datareader.GetString(0);
                revenu.Annee = sqlite_datareader.GetInt32(1);
                revenu.Revenu = sqlite_datareader.GetInt32(2);
                liste.Add(revenu);
            }
            return liste;
        }

        public static MUtilisateur UtilisateurParSonNom(string nom)
        {
            sqlite_conn.Open();
            SqliteDataReader sqlite_datareader;
            SqliteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM MUtilisateur WHERE nom = '" + nom + "'";

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

            public static void EraseAll()
            {
                // delete all the users
                sqlite_conn.Open();
                SqliteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "DELETE FROM MUtilisateur";
                sqlite_cmd.ExecuteNonQuery();
                // make a second command to erase the other table
                sqlite_cmd.CommandText = "DELETE FROM MAnneeRevenu";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_conn.Close();

            }

            public static void CreateYearlyIncome(string utilisateurConnecte, int annee, int revenu)
            {
                sqlite_conn.Open();
                SqliteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO MAnneeRevenu (nom, annee, revenu) " +
                                         "VALUES('" + utilisateurConnecte + "', " + annee + ", " + revenu + "); ";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_conn.Close();
            }
        }
}  
