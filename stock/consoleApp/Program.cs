
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
        
        bool quit = false;
        do
        {
            quit = MainMenu();
        } while (!quit);
        
        var name = Prompt.Input<string>("What's your name?");
        var number = Prompt.Input<int>("Enter any number");
        Console.WriteLine($"{name} {number}");
        Console.WriteLine(DataSec.CreateMD5("Hello, World!"));
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
        else if (choix == "TestBD") {
            DataAccessObject.CreateTable();
        }
        return false;

    }

    public static void CreerCompte()
    {
        MNouveauCompte result = Prompt.Bind<MNouveauCompte>();
        Console.WriteLine(result.NAS);
    }
}

public class MNouveauCompte
{
    [Display(Name = "Votre nom d'utilisateur?")]
    [Required]
    public string Name { get; set; }

    [Display(Name = "Votre mot de passe?")]
    [DataType(DataType.Password)]
    [Required]
    [MinLength(4)]
    public string Password { get; set; }

    [Display(Name = "Votre mot de passe (confirmation)?")]
    [DataType(DataType.Password)]
    [Required]
    [MinLength(4)]
    public string PasswordConfirm { get; set; }

    [Display(Name = "Votre numero d'assurance sociale (NAS)?")]
    [Required]
    [MinLength(9)]
    [MaxLength(9)]
    public string NAS { get; set; }
}
