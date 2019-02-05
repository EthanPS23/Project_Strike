using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OOSD_Project_Phase_2.App_Code;

namespace OOSD_Project_Phase_2
{
    public partial class EditProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblErrorMsg.Visible = false;
                lblPassword.Visible = false;
                txtPassword.Visible = false;
                if (Session["CustEmail"] == null || Session["CustFirstName"] == null)
                {
                    Session.Clear();
                    Response.Redirect("Login.aspx");
                }
                string CustEmail = Session["CustEmail"].ToString();
                Customer Cust = CustomerDB.GetAllCustomer(CustEmail);
                txtAddress.Text = Cust.CustAddress;
                txtBusinessPhone.Text = Cust.CustBusPhone.ToString();
                txtCity.Text = Cust.CustCity;
                txtCountry.Text = Cust.CustCountry;
                txtFax.Text = Cust.CustFax.ToString();
                txtFirstName.Text = Cust.CustFirstName;
                txtHomePhone.Text = Cust.CustHomePhone.ToString();
                txtLastName.Text = Cust.CustLastName;
                txtPostalCode.Text = Cust.CustPostalCode;
                txtProvince.Text = Cust.CustProv;
                txtEmail.Text = Cust.CustEmail;
            }
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
            string email = txtEmail.Text;
            //string password = txtPassword.Text;

            if (CustomerDB.UpdateCustomer(FirstName, LastName, Address, City, Province, PostalCode, Country, HomePhone, BusinessPhone, email, Fax) == true)
            {
                lblErrorMsg.Visible = true;
                lblErrorMsg.Text = "Updated successfully";
            }
            else
            {
                lblErrorMsg.Visible = true;
                lblErrorMsg.Text = "Update Failed";
                lblErrorMsg.Focus();
                lblErrorMsg.BackColor = Color.Red;
            }
        }
    }
}