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
                    Pd.ProductId = (int)reader["ProductId"];
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
                cmd.Parameters.AddWithValue("@ProductId", p.ProductId);
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

        public static void InsertProduct(Products np)
        {
            SqlConnection con = DBConnection.GetConnection();
            string sql = "INSERT Products (ProdName) " +
                         "VALUES (@ProdName)";
            SqlCommand cmdInsert = new SqlCommand(sql, con);
            cmdInsert.Parameters.AddWithValue("@ProdName", np.ProdName);

            try
            {
                con.Open();
                cmdInsert.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public static void UpdateProduct(Products newp, Products oldp)
        {
            SqlConnection con = DBConnection.GetConnection();
            string sql = "UPDATE Products " +
                          "SET ProdName = @nProdName " +
                         "WHERE ProductId = @ProductId " +
                         "AND ProdName = @OldProdName";
            SqlCommand cmdUpdate = new SqlCommand(sql, con);
            cmdUpdate.Parameters.AddWithValue("@nProdName", newp.ProdName);
            cmdUpdate.Parameters.AddWithValue("@OldProdName", oldp.ProdName);
            cmdUpdate.Parameters.AddWithValue("@ProductID", oldp.ProductId);
            try
            {
                con.Open();
                cmdUpdate.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public static void DeleteProduct(Products dp)
        {
            SqlConnection con = DBConnection.GetConnection();
            string sql =
                "DELETE FROM Products " +
                "WHERE ProductId = @ProductID " +
                "AND ProdName = @ProdName"; 
            SqlCommand cmdDelete = new SqlCommand(sql, con);
            cmdDelete.Parameters.AddWithValue("@ProductID", dp.ProductId);
            cmdDelete.Parameters.AddWithValue("@ProdName", dp.ProdName);

            try
            {
                con.Open();
                cmdDelete.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
