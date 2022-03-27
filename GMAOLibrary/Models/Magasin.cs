using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAOLibrary.Models
{
   public class Magasin
    {
       public Intervenants intervenant { get; set; }
       public Article article { get; set; }
       public string Etat { get; set; }
    }
}
