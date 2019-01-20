using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    public class PackageProductSuppliersDB
    {
        public static List<PackageProductSuppliers> GetProductSuppliersByPackage(Packages pkg)
        {
            List<PackageProductSuppliers> ppss = new List<PackageProductSuppliers>();
            SqlConnection con = DBConnection.GetConnection();
            string sql =
                "SELECT pk.PackageId, pk.PkgName, pps.ProductSupplierId, p.ProdName, s.SupName " +
                "FROM Packages pk " +
                "inner join Packages_Products_Suppliers pps " +
                "ON pps.PackageId = pk.PackageId " +
                "inner join Products_Suppliers ps " +
                "ON pps.ProductSupplierId = ps.ProductSupplierId " +
                "inner join Products p " +
                "ON p.ProductId = ps.ProductId " +
                "inner join Suppliers s " +
                "ON s.SupplierId = ps.SupplierId " +
                "WHERE pk.PackageId = @Package " +
                "ORDER BY p.ProdName";
            SqlCommand cmdSelect = new SqlCommand(sql, con);
            cmdSelect.Parameters.AddWithValue("@Package", pkg.PackageID);
            try
            {
                con.Open();
                SqlDataReader Reader = cmdSelect.ExecuteReader();
                while (Reader.Read())
                {
                    PackageProductSuppliers pps = new PackageProductSuppliers();
                    pps.PackageId = Convert.ToInt32(Reader["PackageId"]);
                    pps.ProductSupplierId = Convert.ToInt32(Reader["ProductSupplierId"]);
                    pps.PkgName = Convert.ToString(Reader["PkgName"]);
                    pps.ProdName = Convert.ToString(Reader["ProdName"]);
                    pps.SupName = Convert.ToString(Reader["SupName"]);

                    ppss.Add(pps);
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
            return ppss;
        }
    }
    
}
