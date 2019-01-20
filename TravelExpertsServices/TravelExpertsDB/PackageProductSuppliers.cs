using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    public class PackageProductSuppliers
    {
        public int PackageId { get; set; }
        public int ProductSupplierId { get; set; }
        public string PkgName { get; set; }
        public string ProdName { get; set; }
        public string SupName { get; set; }

        public PackageProductSuppliers()
        {
            PackageId = -1;
            ProductSupplierId = -1;
            PkgName = "";
            ProdName = "";
            SupName = "";
        }

        public PackageProductSuppliers(int id, int psid, string pkn, string pdn, string spn)
        {
            PackageId = id;
            ProductSupplierId = psid;
            PkgName = pkn;
            ProdName = pdn;
            SupName = spn;

        }

        public PackageProductSuppliers(string pkn, string pdn, string spn)
        {
            PkgName = pkn;
            ProdName = pdn;
            SupName = spn;

        }
    }
}

