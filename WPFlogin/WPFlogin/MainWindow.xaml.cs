using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFlogin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static SqlConnection GetConnection(/*string ServerName, string DatabaseName*/)
        {
            string ConnectionString = @"Data Source=oosd.database.windows.net;Initial Catalog=TravelExperts;User ID=ethan;Password=Travel2$19";

            SqlConnection cs = new SqlConnection(ConnectionString);

            return cs;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButton.OK);
                txtUser.Focus();
                return;
            }
            if (txtPassword.Password == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButton.OK);
                txtPassword.Focus();
                return;
            }
            try
            {
                SqlConnection con = GetConnection();
                //myConnection = new SqlConnection(cs);

                // SqlCommand myCommand = default(SqlCommand);

                String query = "SELECT Username, Password FROM Users WHERE Username = @UserName";
                SqlCommand cmd = new SqlCommand(query, con);

                //myCommand = new SqlCommand("SELECT Username, Password FROM Users WHERE Username = @Username");

                SqlParameter uname = new SqlParameter("@UserName", SqlDbType.VarChar);
                SqlParameter upassword = new SqlParameter("@Password", SqlDbType.VarChar);

                uname.Value = txtUser.Text;
                upassword.Value = txtPassword.Password;

                cmd.Parameters.Add(uname);
                cmd.Parameters.Add(upassword);

                cmd.Connection.Open();

                SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader.Read() == true)
                {
                    MessageBox.Show("You have logged in successfully <3 " + txtUser.Text);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed... Try again!", "Login Denied", MessageBoxButton.OK);

                    txtUser.Clear();
                    txtPassword.Clear();
                    txtUser.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }    
}
