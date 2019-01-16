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

        public static List<Suppliers> GetProductSuppliersByProduct(Products p)
        {
            if (p == null)
                return null;
            else
            {
                List<Suppliers> suppliers = new List<Suppliers>();
                SqlConnection con = DBConnection.GetConnection();
                string sql =
                    "SELECT s.SupplierId, s.SupName " +
                    "FROM Suppliers s " +
                    "inner join Products_Suppliers ps " +
                    "ON s.SupplierId = ps.SupplierId " +
                    "inner join Products p " +
                    "ON p.ProductId = ps.ProductId " +
                    "WHERE p.ProductId = @ProductId";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ProductId", p.ProdId);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Suppliers supplier = new Suppliers();
                        supplier.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                        supplier.SupName = Convert.ToString(reader["SupName"]);
                        suppliers.Add(supplier);
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
                return suppliers;
            }
        }
    }
}
