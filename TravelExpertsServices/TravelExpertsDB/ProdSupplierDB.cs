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
            SqlConnection dbConn = DBConnection.GetConnection();
            string sql =
                "SELECT ProductSupplierId, ProductId, SupplierId " +
                "FROM Products_Suppliers " +
               "WHERE ProductId = @pId and SupplierId =@sId";
            SqlCommand cmdSelect = new SqlCommand(sql, dbConn);
            cmdSelect.Parameters.AddWithValue("@pId", pId);
            cmdSelect.Parameters.AddWithValue("@sId", sId);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmdSelect.ExecuteReader();
                while (dbReader.Read())
                {
                    ps.ProductSupplierId = Convert.ToInt32(dbReader["ProductSupplierId"]);
                    ps.ProdId = Convert.ToInt32(dbReader["ProductId"]);
                    ps.SupplierId = Convert.ToInt32(dbReader["SupplierId"]);

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbConn.Close();
            }
            return ps;
        }
    }
}
