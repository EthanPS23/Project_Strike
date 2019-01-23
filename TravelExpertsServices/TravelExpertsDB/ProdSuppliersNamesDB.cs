using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    //Ethan Shipley gets the names and ids for productsuppliers
    public class ProdSuppliersNamesDB
    {
        public static ProdSuppliers GetProdSupAll()
        {
            ProdSuppliersNames psn = new ProdSuppliersNames();
            SqlConnection con = DBConnection.GetConnection();
            string sql =
                "SELECT ps.ProductSupplierId, p.ProductID, p.ProdName, s.SupplierId, s.SupName " +
                "FROM Products_Suppliers ps " +
                "INNER JOIN Suppliers s " +
                "ON ps.SupplierId = s.SupplierId " +
                "INNER JOIN Products p " +
                "ON ps.ProductId = p.ProductId " +
                "ORDER BY p.ProductID; ";
            SqlCommand cmdselect = new SqlCommand(sql, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmdselect.ExecuteReader();
                while (reader.Read())
                {
                    psn.ProductSupplierId = Convert.ToInt32(reader["ProductSupplierId"]);

                }
                public int ProductSupplierId { get; set; }
        public int ProdId { get; set; }
        public int SupplierId { get; set; }
        public string ProdName { get; set; }
        public string SupName { get; set; }
    }
            catch (SqlException ex)
            {
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }
        }
    }
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
}
