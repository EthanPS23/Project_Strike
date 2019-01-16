using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    public class Suppliers
    {
        public int SupplierId { get; set; }
        public string SupName { get; set; }

        public Suppliers()
        {
            SupplierId = -1;
            SupName = null;
        }

        public Suppliers(int id, string pn)
        {
            SupplierId = id;
            SupName = pn;
        }

        public Suppliers(string pn)
        {
            SupName = pn;
        }

        public override string ToString()
        {
            return SupName;
        }
    }
}
