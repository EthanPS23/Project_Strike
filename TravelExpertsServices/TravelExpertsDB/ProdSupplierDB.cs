using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsDB
{
    public class ProdSupplierDB
    {
        
        public static ProdSuppliers GetProductSupplierById(int pId, int sId)
        {
            ProdSuppliers ps = new ProdSuppliers();
            SqlConnection con = DBConnection.GetConnection();
            string sql =
                "SELECT ProductSupplierId, ProductId, SupplierId " +
                "FROM Products_Suppliers " +
               "WHERE ProductId = @pId and SupplierId =@sId";
            SqlCommand cmdSelect = new SqlCommand(sql, con);
            cmdSelect.Parameters.AddWithValue("@pId", pId);
            cmdSelect.Parameters.AddWithValue("@sId", sId);
            try
            {
                con.Open();
                SqlDataReader Reader = cmdSelect.ExecuteReader();
                while (Reader.Read())
                {
                    ps.ProductSupplierId = Convert.ToInt32(Reader["ProductSupplierId"]);
                    ps.ProdId = Convert.ToInt32(Reader["ProductId"]);
                    ps.SupplierId = Convert.ToInt32(Reader["SupplierId"]);

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
            return ps;
        }

        public static void InsertProdSupplier(ProdSuppliers newps)
        {
            SqlConnection con = DBConnection.GetConnection();

            string sql = "INSERT Products_Suppliers (ProductId,SupplierId) " +
                        "VALUES (@npsPid, @npsSid)";
            SqlCommand cmdInsert = new SqlCommand(sql, con);//get connection
            cmdInsert.Parameters.AddWithValue("@npsPid", newps.ProdId);//assign value with parameter
            cmdInsert.Parameters.AddWithValue("@npsSid", newps.SupplierId);//assign value with parameter
            try
            {
                con.Open();//connection open
                cmdInsert.ExecuteNonQuery();//execute query
            }
            catch (SqlException ex)
            {
                throw ex;//throw exception
            }
            finally
            {
                con.Close();//close connection
            }
        }

        // Ethan Shipley
        //Updates the productId associated with the product supplier Id by connecting to the database, creating an sql statement and then executing the sql command
        public static void UpdateProductIDByPackage(int pkgid, int prodid, int prodsupid)
        {
            // create sql connection
            SqlConnection con = DBConnection.GetConnection();
            //prepare the sql statement
            string sql = "UPDATE Products_Suppliers " +
                         "SET ProductId = @Productid " +
                         "FROM Packages pk " +
                         "INNER JOIN Packages_Products_Suppliers pps " +
                         "ON pps.PackageId = pk.PackageId " +
                         "INNER JOIN Products_Suppliers ps " +
                         "ON pps.ProductSupplierId = ps.ProductSupplierId " +
                         "INNER JOIN Products P " +
                         "ON p.ProductId = ps.ProductId " +
                         "INNER JOIN Suppliers s " +
                         "ON s.SupplierId = ps.SupplierId " +
                         "WHERE pps.PackageId = @PackageId AND pps.ProductSupplierId = @ProductSupplierId";
            //sql command is created containing the sql statement and connection
            SqlCommand cmdupdate = new SqlCommand(sql, con);
            cmdupdate.Parameters.AddWithValue("@Productid", prodid);
            cmdupdate.Parameters.AddWithValue("@PackageId", pkgid);
            cmdupdate.Parameters.AddWithValue("@ProductSupplierId", prodsupid);
            //trys to open a connection with database, executes the query and then displays a message if update successful
            try
            {
                con.Open();
                cmdupdate.ExecuteNonQuery();
                MessageBox.Show("Package product update successful");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                con.Close();
            }
        }

        // Ethan Shipley
        //Updates the supplierId associated with the product supplier Id by connecting to the database, creating an sql statement and then executing the sql command
        public static void UpdateSupplierIDByPackage(int pkgid, int supid, int prodsupid)
        {
            // create sql connection
            SqlConnection con = DBConnection.GetConnection();
            //prepare the sql statement
            string sql = "UPDATE Products_Suppliers " +
                         "SET SupplierId = @SupplierId " +
                         "FROM Packages pk " +
                         "INNER JOIN Packages_Products_Suppliers pps " +
                         "ON pps.PackageId = pk.PackageId " +
                         "INNER JOIN Products_Suppliers ps " +
                         "ON pps.ProductSupplierId = ps.ProductSupplierId " +
                         "INNER JOIN Products P " +
                         "ON p.ProductId = ps.ProductId " +
                         "INNER JOIN Suppliers s " +
                         "ON s.SupplierId = ps.SupplierId " +
                         "WHERE pps.PackageId = @PackageId AND pps.ProductSupplierId = @ProductSupplierId";
            //sql command is created containing the sql statement and connection
            SqlCommand cmdupdate = new SqlCommand(sql, con);
            cmdupdate.Parameters.AddWithValue("@SupplierId", supid);
            cmdupdate.Parameters.AddWithValue("@PackageId", pkgid);
            cmdupdate.Parameters.AddWithValue("@ProductSupplierId", prodsupid);
            //trys to open a connection with database, executes the query and then displays a message if update successful
            try
            {
                con.Open();
                cmdupdate.ExecuteNonQuery();
                MessageBox.Show("Package product update successful");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
