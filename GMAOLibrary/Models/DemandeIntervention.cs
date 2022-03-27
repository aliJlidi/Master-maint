using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAOLibrary.Models
{
   public class DemandeIntervention
    {
       public Equipement equipement { get; set; }
       public string Emetteur { get; set; }
       public string DateSouhaite { get; set; }
       public string DescriptionPanne { get; set; }
    }
}
