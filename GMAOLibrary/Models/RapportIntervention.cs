using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAOLibrary.Models
{
    public class RapportIntervention
    {
        public Equipement equipement { get; set; }
        public Intervenants intervenant { get; set; }
        public Departement departement { get; set; }
        public Article article { get; set; }
        public string DateCreation { get; set; }
        public string DateIntervention { get; set; }
        public string DateDebut { get; set; }
        public string DateFin { get; set; }
        public string TraveauxRealises { get; set; }
    }
}
