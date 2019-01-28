using ASP_Project_Final.App_Code;
using System;

namespace ASP_Project_Final
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            if (CustomerDB.Login(Email, Password) == true)
            {
                Response.Redirect("~/Main.aspx");
            }
            else
            {
                TextBox1.Text = "Successfully Failed";
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void btnMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }
}