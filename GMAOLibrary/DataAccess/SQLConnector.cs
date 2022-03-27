using Dapper;
using GMAOLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GMAOLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {
       
        public void CreateIntervenant(Intervenants intervenant)
        {
            // Idbconnection interface made by microsoft to make whatever database connection 
            //when ending between bracktes the connection destroy's (avoid memory leak )
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.connString("connString")))
            {
                var p = new DynamicParameters();
                p.Add("@Nom", intervenant.Nom);
                p.Add("@Prenom", intervenant.Prenom);
                p.Add("@Adresse", intervenant.Adresse);
                p.Add("@NumeroTelephone", intervenant.NumeroTelephone);
                p.Add("@Email", intervenant.Email);
                p.Add("@Specialite", intervenant.Specialite);
                p.Add("@Provenance", intervenant.Provenance);
                p.Add("@CodeIntervenant",0,dbType: DbType.Int32,direction:ParameterDirection.Output);

                // just read , modifiy or delete, that's what an execution can do
                // passing all the p parameters
                connection.Execute("dbo.spIntervenant_CreateInt", p, commandType: CommandType.StoredProcedure);

                intervenant.CodeIntervenant = p.Get<int>("@CodeIntervenant");

               
            }
        }


        public void CreateSpecialite(mSpecialite specialite)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.connString("connString")))
            {
                var p = new DynamicParameters();
                p.Add("@SpName", specialite.SpName);

                connection.Execute("dbo.Specialite_insert", p, commandType: CommandType.StoredProcedure);

            }
        }


        public List<mSpecialite> getspec_All()
        {
            List<mSpecialite> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.connString("connString")))
            {
                output = connection.Query<mSpecialite>("dbo.Specialite_GetAll").ToList();
            }
            return output;

        }


        public void DeleteSpecialite(mSpecialite specialite)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.connString("connString")))
            {
                var p = new DynamicParameters();
                p.Add("@SpName", specialite.SpName);

                connection.Execute("dbo.Specialite_Delete", p, commandType: CommandType.StoredProcedure);

            }
        }


        public List<Intervenants> intervenant_GetAll()
        {
            List<Intervenants> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.connString("connString")))
            {
                output = connection.Query<Intervenants>("dbo.spIntervenant_GetAll").ToList();
            }
            return output;
        }


        public void DeleteIntervenant(Intervenants intervenant)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.connString("connString")))
            {
                var p = new DynamicParameters();
                p.Add("@CodeIntervenant", intervenant.CodeIntervenant);

                connection.Execute("dbo.intervenant_Delete", p, commandType: CommandType.StoredProcedure);

            }
        }
    }
}
