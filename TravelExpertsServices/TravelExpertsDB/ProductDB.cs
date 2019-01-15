using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    public class ProductDB
    {
        public static List<Products> GetProducts()
        {
            List<Products> Prod = new List<Products>();
            Products Pd;
            SqlConnection con = DBConnection.GetConnection();
            string query = "SELECT ProductId, ProdName " +
                            "FROM Products " +
                             "ORDER BY ProductId";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Pd = new Products();
                    Pd.ProdId = (int)reader["ProdId"];
                    Pd.ProdName = (string)reader["ProdName"];

                    Prod.Add(Pd);
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
            return Prod;
        }
    }
}
