﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    public class SupplierDB
    {
        public static List<Suppliers> GetSuppliers()
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
                    Sup.Add(Sp);
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

        public static List<Products> GetProductsByProductSupplier(Suppliers s)
        {
            if (s == null)
                return null;
            else
            {
                List<Products> products = new List<Products>();
                SqlConnection con = DBConnection.GetConnection();
                string sql =
                    "SELECT p.ProductId, p.ProdName " +
                    "FROM Products p " +
                    "inner join Products_Suppliers ps " +
                    "ON p.ProductId = ps.ProductId " +
                    "inner join Suppliers s " +
                    "ON s.SupplierId = ps.SupplierId " +
                    "WHERE s.SupplierId = @SupplierId ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@SupplierId", s.SupplierId);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Products product = new Products();
                        product.ProductId = Convert.ToInt32(reader["ProductId"]);
                        product.ProdName = Convert.ToString(reader["ProdName"]);
                        products.Add(product);
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
                return products;
            }
        }

        public static void InsertSupplier(Suppliers ns)
        {
            SqlConnection con = DBConnection.GetConnection();
            string sql =
                         "INSERT Suppliers (SupplierId, SupName) " +
                         "VALUES ((select top 1 SupplierId from Suppliers order by SupplierId desc) +1" +
                         " , @SupName)";
            SqlCommand cmdInsert = new SqlCommand(sql, con);
            cmdInsert.Parameters.AddWithValue("@SupName", ns.SupName);

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

        public static void UpdateSupplier(Suppliers news, Suppliers olds)
        {
            SqlConnection con = DBConnection.GetConnection();
            string sql = "UPDATE Suppliers " +
                          "SET SupName = @nSupName " +
                         "WHERE SupplierId = @SupplierId " +
                         "AND SupName = @OldSupName";
            SqlCommand cmdUpdate = new SqlCommand(sql, con);
            cmdUpdate.Parameters.AddWithValue("@nSupName", news.SupName);
            cmdUpdate.Parameters.AddWithValue("@OldProdName", olds.SupName);
            cmdUpdate.Parameters.AddWithValue("@SupplierId", olds.SupplierId);
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

        public static void DeleteSupplier(Suppliers ds)
        {
            SqlConnection con = DBConnection.GetConnection();
            string sql =
                "DELETE FROM Suppliers " +
                "WHERE SupplierId = @SupplierId " +
                "AND SupName = @SupName";
            SqlCommand cmdDelete = new SqlCommand(sql, con);
            cmdDelete.Parameters.AddWithValue("@SupplierId", ds.SupplierId);
            cmdDelete.Parameters.AddWithValue("@SupName", ds.SupName);

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