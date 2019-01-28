using ASP_Project_Final.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Project_Final
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Packages> PkgList = new List<Packages>();
            PkgList = PackageDB.GetPackages();
            foreach (var item in PkgList)
            {
                
            }
        }
    }
}