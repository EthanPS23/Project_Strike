using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsDB
{
    public static class PackagesDB
    {
        public static List<Packages> GetPackages()
        {
            List<Packages> Packages = new List<Packages>();
            Packages pkg;

            string query = "SELECT * FROM Packages";
            SqlConnection Connection = DBConnection.GetConnection(/*ServerName, DatabaseName*/);
            SqlCommand cmd = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();//
                while (reader.Read())
                {
                    pkg = new Packages();
                    pkg.PackageID = Convert.ToInt32(reader["PackageID"]);
                    pkg.PkgName = reader["PkgName"].ToString();// getting Package name
                    if (reader["PkgStartDate"] == DBNull.Value)
                    {
                        pkg.PkgStartDate = null;
                    }
                    else
                    {
                        pkg.PkgStartDate = Convert.ToDateTime(reader["PkgStartDate"]);
                    }
                    if (reader["PkgEndDate"] == DBNull.Value)
                    {
                        pkg.PkgEndDate = null;
                    }
                    else
                    {
                        pkg.PkgEndDate = Convert.ToDateTime(reader["PkgEndDate"]);
                    }
                    pkg.PkgDesc = reader["PkgDesc"].ToString();// getting Package name
                    pkg.PkgBasePrice = Convert.ToDecimal(reader["PkgBasePrice"]);// getting Package name
                    //pkg.PkgAgencyCommission = Convert.ToDecimal(reader["PkgAgencyCommission"]);
                    pkg.PkgAgencyCommission = Convert.ToDecimal(reader["PkgAgencyCommission"]);
                //    if (reader["PkgAgencyCommission"] == DBNull.Value)
                //    {
                //        pkg.PkgAgencyCommission = null;
                //    }
                //    else
                //    {
                //        pkg.PkgAgencyCommission = Convert.ToDecimal(reader["PkgAgencyCommission"]);
                //    }
                    Packages.Add(pkg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The error is " +  ex.Message, ex.GetType().ToString());
            }
            finally
            {
                Connection.Close();
            }
            return Packages; // returns the gathered packagaes information
        }
    }
}
