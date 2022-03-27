using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAOLibrary.Models
{
   public class PlanningPreventive
    {
       public Equipement equipement { get; set; }
       public Intervenants intervenant { get; set; }
       public Departement departement { get; set; }
       public string DateCreation { get; set; }
       public string DateExecution { get; set; }
       public string PeriodeExecution { get; set; }
       public string Description { get; set; }
    }
}
