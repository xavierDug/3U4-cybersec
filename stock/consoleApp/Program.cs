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
        DonneesAcces.CreateTable();
        if (DonneesAcces.ReadData().Count == 0)
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
                "(De)Connexion",
                "Créer un compte", "Voir mon profil",
                "Entrer tes revenus pour cette année", "Revenus par année",
                "Les premiers ministres", "Lister utilisateurs",
                "Effacer la console", "Effacer la BD", "Quitter" });
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
                                  " \nNAS encrypté : " + DonneesAcces.UtilisateurParSonNom(utilisateurConnecte).NAS+
                                  " \nNAS décrypté : " + DonneesSecurite.Decrypt(DonneesAcces.UtilisateurParSonNom(utilisateurConnecte).NAS)+
                                  " \nMot de passe hashé : " + DonneesAcces.UtilisateurParSonNom(utilisateurConnecte).MotDePasseHash);
                break;
            case "(De)Connexion":
                if (utilisateurConnecte == "")
                { Connexion(); }
                else { Deconnexion(); }
                break;
            case "Les premiers ministres": PremiersMinistres(); break;
            case "Lister utilisateurs":
                List<DonneesUtilisateur> liste = DonneesAcces.ReadData();
                foreach (var item in liste)
                { Console.WriteLine(item.Nom ); }
                break;
        }
        return false;
    }

    // source https://www.canada.ca/en/revenue-agency/services/tax/individuals/frequently-asked-questions-individuals/canadian-income-tax-rates-individuals-current-previous-years.html
    private static void Revenus()
    {
        if (utilisateurConnecte == "")
        {
            Console.WriteLine("Tu n'es pas connecté, tu ne peux pas voir tes revenus");
            return;
        } 
        Console.Clear();
        List<DonneesAnneeRevenu> liste = DonneesAcces.ReadYearlyIncome(utilisateurConnecte);
        foreach (var item in liste)
        {
            Console.WriteLine("-------------- Année de déclaration "+item.Annee+" --------------");
            Console.WriteLine( "  Revenu déclaré  " + item.Revenu);
            // show that first 20000 gave 0% tax, 
            int amountFirst55867 = Math.Max(0, Math.Min(item.Revenu, 55867));
            decimal taxFirst55867 = amountFirst55867 * 0.15m;

            int amount55867to111733 = Math.Max(0, Math.Min(item.Revenu - 55867, 55866));
            decimal tax55867to111733 = amount55867to111733 * 0.205m;

            int amount111733to173205 = Math.Max(0, Math.Min(item.Revenu - 111733, 61472));
            decimal tax111733to173205 = amount111733to173205 * 0.26m;

            int amount173205to246752 = Math.Max(0, Math.Min(item.Revenu - 173205, 73547));
            decimal tax173205to246752 = amount173205to246752 * 0.29m;

            int amountOver246752 = Math.Max(0, item.Revenu - 246752);
            decimal taxOver246752 = amountOver246752 * 0.33m;

            var impotTotal = taxFirst55867 + tax55867to111733 + tax111733to173205 + tax173205to246752 + taxOver246752;

            Console.WriteLine("    15% sur les premiers 55867$ :      " + taxFirst55867 + "$     soit 15% de " + amountFirst55867);
            Console.WriteLine("    20.5% sur les 55866$ suivants :    " + tax55867to111733 + "$     soit 20.5% de " + amount55867to111733);
            Console.WriteLine("    26% sur les 61472$ suivants :      " + tax111733to173205 + "$     soit 26% de " + amount111733to173205);
            Console.WriteLine("    29% sur les 73547$ suivants :      " + tax173205to246752 + "$     soit 29% de " + amount173205to246752);
            Console.WriteLine("    33% sur le reste (> 246752$):      " + taxOver246752 + "$     soit 33% de " + amountOver246752);
            Console.WriteLine("       Impôt total:                    " + impotTotal + "$"); }
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
        DonneesAcces.CreateYearlyIncome(utilisateurConnecte, annee, revenu);
    }

    private static void EffacerBD()
    {
        DonneesAcces.EraseAll();
        utilisateurConnecte = "";
    }

    private static void PremiersMinistres()
    {
        Formulaires.FormulaireNouveauCompte justin = new Formulaires.FormulaireNouveauCompte();
        justin.MotDePasse = "Passw0rd1!";
        justin.MotDePasseConfirmation = "Passw0rd1!";
        justin.NAS = "111111111";
        justin.Nom = "Justin Trudeau";
        DonneesAcces.InsertNewUser(justin);

        Formulaires.FormulaireNouveauCompte stephen = new Formulaires.FormulaireNouveauCompte();
        stephen.MotDePasse = "stephen the best";
        stephen.MotDePasseConfirmation = "stephen the best";
        stephen.NAS = "123456123";
        stephen.Nom = "Stephen Harper";
        DonneesAcces.InsertNewUser(stephen);

        Formulaires.FormulaireNouveauCompte paul = new Formulaires.FormulaireNouveauCompte();
        paul.MotDePasse = "Ministre 1!";
        paul.MotDePasseConfirmation = "Ministre 1!";
        paul.NAS = "456456465";
        paul.Nom = "Paul Martin";
        DonneesAcces.InsertNewUser(paul);

        Formulaires.FormulaireNouveauCompte jean = new Formulaires.FormulaireNouveauCompte();
        jean.MotDePasse = "shawinigan";
        jean.MotDePasseConfirmation = "shawinigan";
        jean.NAS = "987987987";
        jean.Nom = "Jean Chrétien";
        DonneesAcces.InsertNewUser(jean);

        Formulaires.FormulaireNouveauCompte kim = new Formulaires.FormulaireNouveauCompte();
        kim.MotDePasse = "Who's the girl!";
        kim.MotDePasseConfirmation = "Who's the girl!";
        kim.NAS = "123123123";
        kim.Nom = "Kim Campbell";
        DonneesAcces.InsertNewUser(kim);
    }

    public static void CreerCompte()
    {
        Formulaires.FormulaireNouveauCompte result = Prompt.Bind<Formulaires.FormulaireNouveauCompte>();
        Console.WriteLine(result.NAS);
        DonneesAcces.InsertNewUser(result);
        DonneesAcces.ReadData();
        utilisateurConnecte = result.Nom;
    }
    
    public static void Connexion()
    {
        Console.WriteLine("Connexion");
        Formulaires.FormulaireConnexion formulaire = Prompt.Bind<Formulaires.FormulaireConnexion>();
        Console.WriteLine(formulaire.MotDePasse);
        DonneesUtilisateur utilisateur = DonneesAcces.UtilisateurParSonNom(formulaire.Nom);
        if (utilisateur.MotDePasseHash == DonneesSecurite.HashThePassword(formulaire.MotDePasse))
        {
            Console.WriteLine("Connexion réussie, bienvenue " + formulaire.Nom);
            utilisateurConnecte = formulaire.Nom;
        }
        else
        {
            Console.Error.WriteLine("Connexion échouée, mauvais nom et/ou mot de passe");
        }
    }
    
    public static void Deconnexion()
    {
        Console.WriteLine("Deconnexion");
        utilisateurConnecte = "";
    }
}