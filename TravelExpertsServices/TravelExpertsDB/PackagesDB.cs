using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    public static class PackagesDB
    {
        public static List<Packages> GetPackages()
        {
            List<Packages> Packages = new List<Packages>();
            Packages pkg;

            string query = "SELECT ";
            SqlConnection Connection = DBConnection.GetConnection(/*ServerName, DatabaseName*/);
        }
    }
}
