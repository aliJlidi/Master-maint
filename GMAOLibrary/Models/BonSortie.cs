using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAOLibrary.Models
{
   public class BonSortie
    {
        public Article article { get; set; }
        public Intervenants intervenant { get; set; }
        public int Quantite { get; set; }
    }
}
