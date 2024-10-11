using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace consoleApp
{
    public class MUtilisateur
    {
        public string Nom              { get; set; }
        public string MotDePasseHash   { get; set; }
        public string NAS              { get; set; }
    }


    public class MNouveauCompte
    {
        [Display(Name = "Votre nom d'utilisateur?")]
        [Required]
        public string Nom { get; set; }

        [Display(Name = "Votre mot de passe?")]
        [DataType(DataType.Password)]
        [Required]
        [MinLength(4)]
        public string MotDePasse { get; set; }

        [Display(Name = "Votre mot de passe (confirmation)?")]
        [DataType(DataType.Password)]
        [Required]
        [MinLength(4)]
        public string MotDePasseConfirmation { get; set; }

        [Display(Name = "Votre numero d'assurance sociale (NAS)?")]
        [Required]
        [MinLength(9)]
        [MaxLength(9)]
        public string NAS { get; set; }
    }
    
    public class DemandeConnexion
    {
        [Display(Name = "Votre nom d'utilisateur?")]
        [Required]
        public string Nom { get; set; }

        [Display(Name = "Votre mot de passe?")]
        [DataType(DataType.Password)]
        [Required]
        [MinLength(4)]
        public string MotDePasse { get; set; }
    }
    
    public class DemandeAjoutAnneeRevenu
    {
        [Display(Name = "Votre année de déclaration de revenu?")]
        [Required]
        // add minimal length
        [MinLength(4)]
        //add minimal value of 1900 and max value of 2099
        [Range(1900, 2099)]
        public int Annee { get; set; }

        [Display(Name = "Votre revenu en dollars arrondi?")]
        [Required]
        public int Revenu { get; set; }
    }
    



}
