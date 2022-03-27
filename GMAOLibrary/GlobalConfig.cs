using GMAOLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAOLibrary
{
    public static class GlobalConfig
    {
        public const string IntervenantsFile = "Intervenants.csv";
        // everyone can read the value of connection but only methods inside this class can edit it
        // list of dataConnection cause we can have more than data source 
        // in the future you may add an other data source 
        // it hold anything that implement the idataconnctions contracts 
        public static IDataConnection Connections { get; private set; } 

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                //TODO set up the qsl connector properly
                SQLConnector sql = new SQLConnector();
                Connections = sql; 
            }
          /*  else  if (db == DatabaseType.TextFile)
            {
                //TODO Create The Text Connection
                TextConnector text = new TextConnector();
                Connections = text;
            }*/
        }
        public static string connString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
