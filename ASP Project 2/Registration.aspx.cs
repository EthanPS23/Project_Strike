using System;
using System.Collections.Generic;
using System.Drawing;
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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            /*if (Page.IsValid)
            {*/
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



                //string Password = GetShaData(txtPassword.Text);

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


            if (txtPassword.Text == txtRetypePassword.Text)
            {
                if (CustomerDB.addCustomer(FirstName, LastName, Address, City, Province, PostalCode, Country, HomePhone, BusinessPhone, email, Fax, hash_pass) == true)
                {
                    lblMessage.Text = "Customer registration successful";               
                }
            }
            else
            {
                lblMessage.Text = "Password didn't match";
                lblMessage.Focus();
                lblMessage.BackColor = Color.Red;
            }
            /*            }

                        else
                        {
                            lblMessage.Text = "Validation Failed";
                            lblMessage.Focus();
                            lblMessage.BackColor = Color.Red;
                        }*/
        }
        protected string GetShaData(string inputPass) {
            /*SHA21 sha = SHA1.Create();
            Byte[] hasData = sha.ComputeHash(Encoding.Default.GetBytes(inputPass));
            StringBuilder returnValue = new StringBuilder();
            for (int i = 0; i < hasData.Length; i++)
            {
                returnValue.Append(hasData[i].ToString());
            }
            return returnValue.ToString();*/
            /*string strmsg = string.Empty;
            byte[] encode = new byte[inputPass.Length];
            encode = Encoding.UTF8.GetBytes(inputPass);
            strmsg = Convert.ToBase64String(encode);
            return strmsg;*/
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(inputPass);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    inputPass = Convert.ToBase64String(ms.ToArray());
                }
            }
            return inputPass;
        }
    }
}