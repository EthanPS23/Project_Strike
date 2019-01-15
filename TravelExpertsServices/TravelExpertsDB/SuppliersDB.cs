using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    public class SuppliersDB
    {
        public static List<Suppliers> GetProducts()
        {
            List<Suppliers> Sup = new List<Suppliers>();
            Suppliers Sp;
            SqlConnection con = DBConnection.GetConnection();
            string query = "SELECT SupplierId, SupName " +
                             "FROM Suppliers " +
                            "ORDER BY SupplierId";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Sp = new Suppliers();
                    Sp.SupplierId = (int)reader["SupplierId"];
                    Sp.SupName = (string)reader["SupName"];
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return Sup;
        }
    }
}
