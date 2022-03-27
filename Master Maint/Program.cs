using GMAOLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Maint
{
    static class Program
    {
      public static  SqlConnection con = new SqlConnection();
      public static  SqlCommand com = new SqlCommand();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Initialize the database connections
            GMAOLibrary.GlobalConfig.InitializeConnections(DatabaseType.Sql);
            
          Application.Run(new LogIn());
          //Application.Run(new IntervenantForm());
           if (LogIn.LogedIn == true)
            {
                 con.Open();
            com.Connection = con;
            com.CommandText = "select * from Domain";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows) { 
                      if (dr.Read())
                        {
                            if (dr["Name"].ToString() == "Hotel")
                               {
                                   Application.Run(new Home());

                               }
                           else
                              {
                                 Application.Run(new Domains());
                              }
                        }
                  }
            else
            {
                Application.Run(new Domains());
            }
            if (Domains.isHotel)
            {
                Application.Run(new Home());
            }
          }
            
            
        }
    }
}
