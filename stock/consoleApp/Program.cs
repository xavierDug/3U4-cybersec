
using System.ComponentModel;
using Sharprompt;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;


// mettre les mots de passe visible dans la console dans la version distribuée
// ajouter un mode admin protégé par un mot de passe unique
// avec la liste utilisateurs

// https://github.com/shibayan/Sharprompt for the win
namespace consoleApp;

class Program
{
    private static string utilisateurConnecte = ""; 
   
    public static void Main(string[] args) {
        // chercher s'il y a des comptes et si non créer les premiers ministres
        DataAccessObject.CreateTable();
        if (DataAccessObject.ReadData().Count == 0)
        {
            PremiersMinistres();
        }
        Console.WriteLine("Bienvenue dans l'application la plus sure du monde!");
        Console.WriteLine("Com'on, on hash les mots de passe et on encrypte les NAS");
        bool quit = false;
        do
        {
            quit = MainMenu();
        } while (!quit);
        
        // var name = Prompt.Input<string>("What's your name?");
        // var number = Prompt.Input<int>("Enter any number");
        // Console.WriteLine($"{name} {number}");
        // Console.WriteLine(DataSec.HashThePassword("Hello, World!"));
        // Console.WriteLine(DataSec.CreateSHA256("Hello, World!"));
        // string encrypted = DataSec.Encrypt("123456789");
        // Console.WriteLine(encrypted);
    }

    public static bool MainMenu() {
        var choix = Prompt.Select("Quelle action veux-tu effectuer ? " + utilisateurConnecte, 
            new[] { 
                "Créer un compte",
                "(De)Connexion",
                "Entrer tes revenus pour cette année", "Revenus par année",
                "Voir mon profil",
                "Les premiers ministres",
                "Lister utilisateurs",
                "Effacer la console",
                "Effacer la BD",
                "Quitter"
            });
        switch (choix)
        {
            case "Quitter": return true;
            case "Effacer la console": Console.Clear(); break;
            case "Créer un compte": CreerCompte(); break;
            case "Effacer la BD": EffacerBD(); break;
            case "Entrer tes revenus pour cette année": EntrerRevenu(); break;
            case "Revenus par année": Revenus(); break;
            case "Voir mon profil":
                Console.WriteLine("Nom: " + utilisateurConnecte + 
                                  " \nNAS encrypté : " + DataAccessObject.UtilisateurParSonNom(utilisateurConnecte).NAS+
                                  " \nNAS décrypté : " + DataSec.Decrypt(DataAccessObject.UtilisateurParSonNom(utilisateurConnecte).NAS)+
                                  " \nMot de passe hashé : " + DataAccessObject.UtilisateurParSonNom(utilisateurConnecte).MotDePasseHash);
                break;
            case "(De)Connexion":
                if (utilisateurConnecte == "")
                { Connexion(); }
                else { Deconnexion(); }
                break;
            case "Les premiers ministres": PremiersMinistres(); break;
            case "Lister utilisateurs":
                List<MUtilisateur> liste = DataAccessObject.ReadData();
                foreach (var item in liste)
                { Console.WriteLine(item.Nom ); }
                break;
        }
        return false;
    }

    private static void Revenus()
    {
        if (utilisateurConnecte == "")
        {
            Console.WriteLine("Tu n'es pas connecté, tu ne peux pas voir tes revenus");
            return;
        } 
        Console.Clear();
        List<MAnneeRevenu> liste = DataAccessObject.ReadYearlyIncome(utilisateurConnecte);
        foreach (var item in liste)
        {
            Console.WriteLine("-------------- Année de déclaration "+item.Annee+" --------------");
            Console.WriteLine( "Revenu déclaré  " + item.Revenu);
            // show that first 20000 gave 0% tax, 
            double taxFirst20000 = 0;
            Console.WriteLine("0$ sur les premiers 20000$");
            // show the total tax
            double tax20to50 = Math.Min(item.Revenu - 20000, 30000);
            Console.WriteLine("20% sur les 30000$ suivants: " + tax20to50 * 0.2 + " soit 20% de " + tax20to50);
            double tax50to100 = Math.Min(item.Revenu - 50000, 50000);
        }
    }

    private static void EntrerRevenu()
    {
        if (utilisateurConnecte == "")
        {
            Console.Error.WriteLine("il faut être connecté pour entrer des revenus");
            return;
        }
        int annee = Prompt.Input<int>("Merci d'entrer l'année de déclaration:");
        Console.WriteLine($"Entrez le revenu pour l'année {annee}: ");
        int revenu = Prompt.Input<int>($"Entrez le revenu pour l'année {annee}: ");

        Console.WriteLine(annee + "  " + revenu);
        // add in database
        DataAccessObject.CreateYearlyIncome(utilisateurConnecte, annee, revenu);
    }

    private static void EffacerBD()
    {
        DataAccessObject.EraseAll();
    }

    private static void PremiersMinistres()
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

    public static void CreerCompte()
    {
        MNouveauCompte result = Prompt.Bind<MNouveauCompte>();
        Console.WriteLine(result.NAS);
        DataAccessObject.InsertNewUser(result);
        DataAccessObject.ReadData();
        utilisateurConnecte = result.Nom;
    }
    
    public static void Connexion()
    {
        Console.WriteLine("Connexion");
        DemandeConnexion demande = Prompt.Bind<DemandeConnexion>();
        Console.WriteLine(demande.MotDePasse);
        MUtilisateur utilisateur = DataAccessObject.UtilisateurParSonNom(demande.Nom);
        if (utilisateur.MotDePasseHash == DataSec.HashThePassword(demande.MotDePasse))
        {
            Console.WriteLine("Connexion réussie, bienvenue " + demande.Nom);
            utilisateurConnecte = demande.Nom;
        }
        else
        {
            Console.Error.WriteLine("Connexion échouée, le mot de passe est mauvais ");
        }
    }
    
    public static void Deconnexion()
    {
        Console.WriteLine("Deconnexion");
        utilisateurConnecte = "";
    }
}
