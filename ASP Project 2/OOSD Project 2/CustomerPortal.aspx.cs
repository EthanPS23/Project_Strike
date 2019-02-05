using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OOSD_Project_Phase_2
{
    public partial class CustomerPortal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustFirstName"] == null || Session["CustFirstName"] == null)
            {
                lblCustFirstName.Visible = false;
                Response.Redirect("Login.aspx");
            }
            else
            {
                lblCustFirstName.Visible = true;
                lblCustFirstName.Text = Session["CustFirstName"].ToString();
            }
        }
        

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["CustEmail"] = null;
            Session["CustFirstName"] = null;
            Response.Redirect("Default.aspx");
        }

        protected void btnEditProfile_Click(object sender, EventArgs e)
        {
            string CustEmail = Session["CustEmail"].ToString();
            Response.Redirect("EditProfile.aspx");
        }

        protected void btnPackage_Click(object sender, EventArgs e)
        {
            string CustEmail = Session["CustEmail"].ToString();
            Response.Redirect("Package.aspx");
        }
    }
}