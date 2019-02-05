using ASP_Project_Final.App_Code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Project_Final
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string Address = txtAddress.Text;
            string BusinessPhone = txtBusinessPhone.Text;
            string City = txtCity.Text;
            string Country = txtCountry.Text;
            int Fax = Convert.ToInt32(txtFax.Text);
            string FirstName = txtFirstName.Text;
            string HomePhone = txtHomePhone.Text;
            string LastName = txtLastName.Text;
            string PostalCode = txtPostalCode.Text;
            string Province = txtProvince.Text;
            string Password = txtPassword.Text;
            string email = txtEmail.Text;

            if (txtPassword.Text == txtRetypePassword.Text)
            {
                if (CustomerDB.addCustomer(FirstName, LastName, Address, City, Province, PostalCode, Country, HomePhone, BusinessPhone, email, Fax, Password) == true)
                    TextBox1.Text = "Customer registration successful";
            }
            else {
                TextBox1.Text = "Password didn't match";
                TextBox1.Focus();
                TextBox1.BackColor = Color.Red;
            }

        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtBusinessPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}