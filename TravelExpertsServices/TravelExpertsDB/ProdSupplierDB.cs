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
        public static void UpdateProductIDByPackage(int pkgid, int prodid, int prodsupid)
        {
            SqlConnection con = DBConnection.GetConnection();
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
            
            SqlCommand cmdupdate = new SqlCommand(sql, con);
            cmdupdate.Parameters.AddWithValue("@Productid", prodid);
            cmdupdate.Parameters.AddWithValue("@PackageId", pkgid);
            cmdupdate.Parameters.AddWithValue("@ProductSupplierId", prodsupid);
            //MessageBox.Show(cmdupdate.CommandText);
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
