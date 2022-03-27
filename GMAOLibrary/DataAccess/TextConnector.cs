using GMAOLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMAOLibrary.DataAccess.TextHelpers ;
namespace GMAOLibrary.DataAccess
{
   public class TextConnector 
    {
       private const string IntervenantFile = "Intervenant.csv";
       //TODO wire up the CreateIntervenant for the text file 
        public void CreateIntervenant(Intervenants intervenant)
        {
            // **Load the text files first to know which new Id gone set  
            // ** convert the text to a list of intervenat 
            List<Intervenants> intervenants = IntervenantFile.FullFilePath().LoadFile().convertToIntervenat();
            // the hightest id in the list and add one because of the list 
            int currentId = 1 ; 
            if(intervenants.Count > 0 )
            {
                currentId = intervenants.OrderByDescending(x => x.CodeIntervenant).First().CodeIntervenant + 1 ;
            }
                //add the new record with the new id (max + 1)
            intervenant.CodeIntervenant = currentId;
            intervenants.Add(intervenant);
            // convert the prizes to a list<string>
            // save the list<string> to the next file 
            intervenants.SaveToIntervenantFile(); 

        }


        public void CreateSpecialite(mSpecialite specialite)
        {
            throw new NotImplementedException();
        }
    }
}
