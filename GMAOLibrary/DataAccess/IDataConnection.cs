using GMAOLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAOLibrary.DataAccess
{
   public interface IDataConnection
    {
       // create an intervenant 
       void CreateIntervenant(Intervenants intervenant);
       // read intervenant firstName/lastName
       List<Intervenants> intervenant_GetAll();
       // delete intervenant 
       void DeleteIntervenant(Intervenants intervenant);
       // create a speciality 
       void CreateSpecialite(mSpecialite specialite); 
       // Read from specialite
       List<mSpecialite> getspec_All();
       //Delete from specialite
       void DeleteSpecialite(mSpecialite specialite);
    }
}
