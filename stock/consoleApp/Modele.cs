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

    public class MAnneeRevenu
    {
        public string Nom              { get; set; }
        public int Annee              { get; set; }
        public int Revenu            { get; set; }
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
}
