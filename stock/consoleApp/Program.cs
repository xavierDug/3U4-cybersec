
using Sharprompt;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

// https://github.com/shibayan/Sharprompt for the win
namespace consoleApp;

class Program
{

   
    public static void Main(string[] args) {
        Console.WriteLine("Bienvenue dans l'application la plus sure du monde!");
        Console.WriteLine("Com'on, on hash les mots de passe et on encrypte les NAS");
        Console.WriteLine();
        DataAccessObject.CreateTable();
        
        bool quit = false;
        do
        {
            quit = MainMenu();
        } while (!quit);
        
        var name = Prompt.Input<string>("What's your name?");
        var number = Prompt.Input<int>("Enter any number");
        Console.WriteLine($"{name} {number}");
        Console.WriteLine(DataSec.HashThePassword("Hello, World!"));
        Console.WriteLine(DataSec.CreateSHA256("Hello, World!"));
        string encrypted = DataSec.Encrypt("123456789");
        Console.WriteLine(encrypted);
    }

    public static bool MainMenu() {
        var choix = Prompt.Select("Quelle action veux-tu effectuer", 
            new[] { 
                "Creer un compte", 
                "Changer tes informations personnelles", 
                "Entrer tes informations pour cette annee",
                "Lister utilisateurs",
                "TestBD",
                "Quitter"
            });
        if (choix == "Quitter")
        {
            return true;
        }
        else if (choix == "Creer un compte")
        {
            CreerCompte();
        }
        else if (choix == "TestBD")
        {
            MNouveauCompte justin = new MNouveauCompte();
            justin.MotDePasse = "Password1!";
            justin.MotDePasseConfirmation = "Password1!";
            justin.NAS = "111111111";
            justin.Nom = "Justin Trudeau";
            DataAccessObject.InsertNewUser(justin);

            MNouveauCompte stephen = new MNouveauCompte();
            stephen.MotDePasse = "stephen the best";
            stephen.MotDePasseConfirmation = "stephen the best";
            stephen.NAS = "123456123";
            stephen.Nom = "Stephen Harper";
            DataAccessObject.InsertNewUser(stephen);

            MNouveauCompte paul = new MNouveauCompte();
            paul.MotDePasse = "Password1!";
            paul.MotDePasseConfirmation = "Password1!";
            paul.NAS = "456456465";
            paul.Nom = "Paul Martin";
            DataAccessObject.InsertNewUser(paul);

            MNouveauCompte jean = new MNouveauCompte();
            jean.MotDePasse = "Shawinigan";
            jean.MotDePasseConfirmation = "Shawinigan";
            jean.NAS = "987987987";
            jean.Nom = "Jean Chrétien";
            DataAccessObject.InsertNewUser(jean);

            MNouveauCompte kim = new MNouveauCompte();
            kim.MotDePasse = "Who's the girl!";
            kim.MotDePasseConfirmation = "Who's the girl!";
            kim.NAS = "123123123";
            kim.Nom = "Kim Campbell";
            DataAccessObject.InsertNewUser(kim);

        }
        else if (choix == "Lister utilisateurs") {
            List<MUtilisateur> liste = DataAccessObject.ReadData();
            foreach (var item in liste)
            {
                Console.WriteLine(item.Nom+ " NAS: " + item.NAS + " MDP: " + item.MotDePasseHash);
            }
        }
        return false;

    }

    public static void CreerCompte()
    {
        MNouveauCompte result = Prompt.Bind<MNouveauCompte>();
        Console.WriteLine(result.NAS);
        DataAccessObject.InsertNewUser(result);
        DataAccessObject.ReadData();
    }
}
