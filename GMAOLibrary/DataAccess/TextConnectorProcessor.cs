using GMAOLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// only the text connector can access this 
namespace GMAOLibrary.DataAccess.TextHelpers 
{
    // **Load the text files first to know which new Id gone set  
    // ** convert the text to a list of intervenat 
    // find the max Id 
    // add the new record with the new Id 
    // convert the prizes to lis of string 
    // save the list of string to the text file 
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)// intervenant.csv
        {
            // return the path which is C:data\GmaoBase\fileName.csv
            return ConfigurationManager.AppSettings["filePath"] +"\\" + fileName ;
        }
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }
        public static List<Intervenants> convertToIntervenat(this List<string> lines)
        {
            //list of the intervenant 
            List<Intervenants> output = new List<Intervenants>();
            // treat each line alone of the intervenants 
            foreach (string line in lines)
            {
                // split everyline by the comas into columns 
                string[] cols = line.Split(',');
                // create an intervenant instance 
                Intervenants i = new Intervenants();
                //parse : it convert the string into an integer 
                i.CodeIntervenant = int.Parse(cols[0]);
                i.Nom = cols[1] ; 
                i.Prenom = cols[2] ; 
                i.Adresse = cols[3] ; 
                i.NumeroTelephone = cols[4]; 
                i.Email = cols[5] ; 
                i.Specialite = cols[6] ;
                i.Provenance = cols[7];

                output.Add(i);

             
            }
            return output;  
        }
        public static void SaveToIntervenantFile(this List<Intervenants> intervenants)
        {
            List<string> lines = new List<string>();
            foreach (Intervenants i in intervenants)
            {
                lines.Add(i.CodeIntervenant+","+i.Nom+","+i.Prenom+","+i.Adresse+","+
                    i.NumeroTelephone+","+i.Email+","+i.Specialite+","+i.Provenance);
            }
            File.WriteAllLines(GlobalConfig.IntervenantsFile.FullFilePath(), lines); 
        }
    }
}
