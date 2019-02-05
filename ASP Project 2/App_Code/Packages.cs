using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOSD_Project_Phase_2.App_Code
{
    public class Packages
    {
        public string PkgName { get; set; }
        public DateTime PkgStartDate { get; set; }
        public DateTime PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal PkgAgencyCommission { get; set; }
        public decimal CostOfAllPackages { get; set; }
        public int CountOfPackagesBought { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public string CustEmail { get; set; }
    }
}