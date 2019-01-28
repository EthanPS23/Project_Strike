using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASP_Project_Final.App_Code
{
    public static class PackageDB
    {
        public static List<Packages> GetPackages()
        {
            List<Packages> PkgList = new List<Packages>();
            Packages Pkg = null;
            string query = "SELECT * FROM PACKAGES";
            SqlConnection Connection = new SqlConnection(TravelExpertsDB.GetConnectionString());
            SqlCommand cmd = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Pkg = new Packages();
                    Pkg.PkgDesc = reader["PkgDesc"].ToString();
                    Pkg.PkgStartDate = Convert.ToDateTime(reader["PkgStartDate"]);
                    Pkg.PkgEndDate = Convert.ToDateTime(reader["PkgEndDate"]);
                    Pkg.PkgBasePrice = Convert.ToDecimal(reader["PkgBasePrice"]);
                    Pkg.PkgName = reader["PkgName"].ToString();
                    PkgList.Add(Pkg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }
            return PkgList;
        }
    }
}