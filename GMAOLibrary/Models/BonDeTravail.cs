using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAOLibrary.Models
{
    public class BonDeTravail
    {
        public Intervenants IntNom { get; set; }
        public Article ArticleDes {get; set ;}
        public string DateCreatation { get; set; }
        public string DateSouhaite { get; set; }
        public string Emetteur { get; set; }
        public string Priorite { get; set; }
    }
}
