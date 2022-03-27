using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAOLibrary.Models
{
   public class Reapprovisionement
    {
       public Fournisseur fournisseur { get; set; }
       public Article article { get; set; }
       public int Quantite { get; set; }
       public string DateExecution { get; set; }
    }
}
