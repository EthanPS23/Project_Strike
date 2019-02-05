using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using OOSD_Project_Phase_2.App_Code;

namespace OOSD_Project_Phase_2.App_Code
{
    public static class PackageDB
    {
        public static List<Packages> GetPackages(string CustEmail)
        {
            List<Packages> PkgList = new List<Packages>();
            Packages Pkg = null;
            string query = "SELECT SUM(P.PkgBasePrice) CostOfAllPackages,(SUM(P.PkgBasePrice))/P.PkgBasePrice CountOfPackagesBought, p.PkgDesc, P.PkgBasePrice, P.PkgName, C.CustFirstName, c.CustLastName,               c.CustEmail FROM PACKAGES P INNER JOIN BOOKINGS B ON P.PackageId = B.PackageId INNER JOIN CUSTOMERS C ON C.CustomerId = B.CustomerId where c.CustEmail = @CustEmail GROUP BY c.CustEmail, P.PkgName, P.PkgBasePrice, C.CustFirstName, c.CustLastName, p.PkgDesc";
            SqlConnection Connection = new SqlConnection(TravelDB.GetConnectionString());
            SqlCommand cmd = new SqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("@CustEmail", CustEmail);
            try
            {
                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Pkg = new Packages();
                    Pkg.PkgDesc = reader["PkgDesc"].ToString();
                    Pkg.PkgBasePrice = Convert.ToDecimal(reader["PkgBasePrice"]);
                    Pkg.PkgName = reader["PkgName"].ToString();
                    Pkg.CostOfAllPackages = Convert.ToDecimal(reader["CostOfAllPackages"]);
                    Pkg.CountOfPackagesBought = Convert.ToInt32(reader["CountOfPackagesBought"]);
                    Pkg.CustEmail = reader["CustEmail"].ToString();
                    Pkg.CustFirstName = reader["CustFirstName"].ToString();
                    Pkg.CustLastName = reader["CustLastName"].ToString();
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