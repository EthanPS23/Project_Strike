using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOSD_Project_Phase_2.App_Code
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public string CustAddress { get; set; }
        public string CustCity { get; set; }
        public string CustProv { get; set; }
        public string CustPostalCode { get; set; }
        public string CustCountry { get; set; }
        public Int64 CustHomePhone { get; set; }
        public Int64 CustBusPhone { get; set; }
        public string CustEmail { get; set; }
        public int AgentID { get; set; }
        public int CustFax { get; set; }
        public string Password { get; set; }
    }
}