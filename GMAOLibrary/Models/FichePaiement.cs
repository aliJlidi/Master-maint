using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAOLibrary.Models
{
   public class FichePaiement
    {
       public Intervenants intervenant { get; set; }
       public string CoutMo { get; set; }
       public string CoutTotale { get; set; }
    }
}
