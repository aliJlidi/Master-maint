using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAOLibrary.Models
{
   public class Equipement
    {
       public Departement departement { get; set; }
       public string NomEquipement { get; set; }
       public string Famille { get; set; }
       public string SousFamille { get; set; }
       public string Etat { get; set; }
       public string DateInstalation { get; set; }
       public string Description { get; set;  }
    }
}
