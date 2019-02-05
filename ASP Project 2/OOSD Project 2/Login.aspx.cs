using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OOSD_Project_Phase_2.App_Code;

namespace OOSD_Project_Phase_2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMsg.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string finalPass;
            string Email = txtEmail.Text;
            byte[] sh1 = new byte[50];
            string Password = txtPassword.Text;
            SHA1 sh = SHA1.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(Password);
            byte[] hash1 = sh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash1.Length; i++)
            {
                sh1[i] = hash1[i];
                sb.Append(sh1[i].ToString("x2"));
            }
            var hash_pass = sb.ToString();


            if (CustomerDB.Login(Email, hash_pass) == true)
            {
                Session["CustEmail"] = Email;
                Session["CustFirstName"] = CustomerDB.GetCustomer(Email, hash_pass);
                Response.Redirect("~/CustomerPortal.aspx");
                
            }
            else
            {
                 lblErrorMsg.Text = "Successfully Failed";
            }
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}