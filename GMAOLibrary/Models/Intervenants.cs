using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAOLibrary.Models
{
    public class Intervenants
    {
        // the unique identifier for the intervenant 
        public int CodeIntervenant { get; set; }
        public Calendrier cal { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string NumeroTelephone { get; set; }
        public string Email { get; set; }
        public string Specialite { get; set; }
        public string Provenance { get; set; }

        public string fullName { get { return Nom + " " + Prenom + "   " + Provenance; } }

        public Intervenants()
        {

        }

        public Intervenants(string nom , string prenom , string adresse , string numeroTelephone, string email
            ,string specialite , string provenance)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            NumeroTelephone = numeroTelephone;
            Email = email;
            Specialite = specialite;
            Provenance = provenance; 
        }
    }
}
