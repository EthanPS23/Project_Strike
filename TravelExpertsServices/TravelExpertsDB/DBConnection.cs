using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    public static class DBConnection
    {
        public static SqlConnection GetConnection(/*string ServerName, string DatabaseName*/)
        {
            string ConnectionString = "Server = tcp:oosd.database.windows.net; Database = TravelExperts; User ID = ethan@oosd; Password = Travel2$19; Trusted_Connection = False; Encrypt = True";

            SqlConnection connection = new SqlConnection(ConnectionString);

            return connection;
        }

        // @"Data Source=oosd.database.windows.net;Initial Catalog=TravelExperts;User ID=sheila;Password=Travel2$19";
    }
}
