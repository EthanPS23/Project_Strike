using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
