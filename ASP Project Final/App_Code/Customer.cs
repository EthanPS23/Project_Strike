using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Project_Final.App_Code
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
        public string CustHomePhone { get; set; }
        public string CustBusPhone { get; set; }
        public string CustEmail { get; set; }
        public int AgentID { get; set; }
        public int CustFax { get; set; }
        public string Password { get; set; }
    }
}