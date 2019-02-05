using OOSD_Project_Phase_2.App_Code;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace OOSD_Project_Phase_2
{
    public partial class Package : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustEmail"] == null || Session["CustFirstName"] == null)
            {
                Session.Clear();
                Response.Redirect("Login.aspx");
            }
            string CustEmail = Session["CustEmail"].ToString();
            if (!IsPostBack)
            {
                List<Packages> myPackageList = new List<Packages>();
                myPackageList = PackageDB.GetPackages(CustEmail);
                GridView1.DataSource = myPackageList;
                GridView1.DataBind();
            }
        }
    }
}