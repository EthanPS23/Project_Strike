using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASP_Project_Final.App_Code
{
    public static class CustomerDB
    {
        public static bool Login(string CustEmail, string Password)
        {
            bool result = false;
            List<Customer> CustEmailLst = new List<Customer>();
            Customer Cust = null;
            //List<string> CustPasswordLst = new List<string>();
            String CustEmailquery = "SELECT [CustEmail], PASSWORD FROM customers WHERE [CustEmail] = @CustEmail AND PASSWORD =@PASSWORD";
            SqlConnection Connection = new SqlConnection(TravelDB.GetConnectionString());
            SqlCommand cmd = new SqlCommand(CustEmailquery, Connection);
            cmd.Parameters.AddWithValue("@CustEmail", CustEmail);
            cmd.Parameters.AddWithValue("@Password", Password);

            try
            {
                Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Cust = new Customer();
                    Cust.CustEmail = reader["CustEmail"].ToString();
                    Cust.Password =  reader["Password"].ToString();
                    CustEmailLst.Add(Cust);
                }
                foreach (var item in CustEmailLst)
                {
                    if (item.CustEmail == CustEmail && item.Password == Password)
                        result = true;
                    else
                        result = false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }
            return result;
        }
        public static bool addCustomer(string CustFirstName, string CustLastName, string CustAddress, string CustCity, string CustProvince, string CustPostalCode, string CustCountry, string CustHomePhone, string CustBusPhone, string CustEmail, int CustFax, string Password)
        {
            bool result = false;
            string query = "INSERT INTO Customers(CustFirstName, CustLastName, CustAddress, CustCity, CustProv, CustPostal, CustCountry, CustHomePhone, CustBusPhone, CustEmail, CustFax, Password)VALUES(@CustFirstName, @CustLastName, @CustAddress, @CustCity, @CustProvince, @CustPostalCode, @CustCountry, @CustHomePhone, @CustBusPhone, @CustEmail, @CustFax, @Password)";
            SqlConnection Connection = new SqlConnection(TravelDB.GetConnectionString());
            SqlCommand cmd = new SqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("@CustFirstName", CustFirstName);
            cmd.Parameters.AddWithValue("@CustLastName", CustLastName);
            cmd.Parameters.AddWithValue("@CustAddress", CustAddress);
            cmd.Parameters.AddWithValue("@CustCity", CustCity);
            cmd.Parameters.AddWithValue("@CustProvince", CustProvince);
            cmd.Parameters.AddWithValue("@CustPostalCode", CustPostalCode);
            cmd.Parameters.AddWithValue("@CustCountry", CustCountry);
            cmd.Parameters.AddWithValue("@CustHomePhone", CustHomePhone);
            cmd.Parameters.AddWithValue("@CustBusPhone", CustBusPhone);
            cmd.Parameters.AddWithValue("@CustEmail", CustEmail);
            cmd.Parameters.AddWithValue("@CustFax", CustFax);
            cmd.Parameters.AddWithValue("@Password", Password);
            try
            {
                Connection.Open();
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static bool UpdateCustomer(string CustFirstName, string CustLastName, string CustAddress, string CustCity, string CustProvince, string CustPostalCode, string CustCountry, string CustHomePhone, string CustBusPhone, string CustEmail, int CustFax, string Password)
        {
            if (!CustomerDB.Login(CustEmail, Password) == true)
            {
                return false;
            }
            bool result = false;
            string query = "UPDATE CUSTOMERS SET CustFirstName = @CustFirstName, CustLastName = @CustLastName, CustAddress = @CustAddress, CustCity = @CustCity, CustProv = @CustProvince, CustPostal = @CustPostalCode, CustCountry = @CustCountry, CustHomePhone = @CustHomePhone, CustBusPhone = @CustBusPhone, CustEmail = @CustEmail, CustFax = @CustFax, Password = @Password WHERE CustEmail = @CustEmail";

            SqlConnection Connection = new SqlConnection(TravelDB.GetConnectionString());
            SqlCommand cmd = new SqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("@CustFirstName", CustFirstName);
            cmd.Parameters.AddWithValue("@CustLastName", CustLastName);
            cmd.Parameters.AddWithValue("@CustAddress", CustAddress);
            cmd.Parameters.AddWithValue("@CustCity", CustCity);
            cmd.Parameters.AddWithValue("@CustProvince", CustProvince);
            cmd.Parameters.AddWithValue("@CustPostalCode", CustPostalCode);
            cmd.Parameters.AddWithValue("@CustCountry", CustCountry);
            cmd.Parameters.AddWithValue("@CustHomePhone", CustHomePhone);
            cmd.Parameters.AddWithValue("@CustBusPhone", CustBusPhone);
            cmd.Parameters.AddWithValue("@CustEmail", CustEmail);
            cmd.Parameters.AddWithValue("@CustFax", CustFax);
            cmd.Parameters.AddWithValue("@Password", Password);
            try
            {
                Connection.Open();
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}