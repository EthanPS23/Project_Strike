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
using System.Windows.Shapes;
using Travel_Experts_Services_WPF.Properties;
using TravelExpertsDB;

namespace Travel_Experts_Services_WPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();

            txtUser.Text = Settings.Default.UserName;
            txtPassword.Password = Settings.Default.Password;
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
                SqlConnection con = DBConnection.GetConnection();
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
                    if(ckbRemember.IsChecked ?? true)
                    {
                        Settings.Default.UserName = txtUser.Text;
                        Settings.Default.Password = txtPassword.Password;
                    }
                    MessageBox.Show("You have logged in successfully <3 " + txtUser.Text);
                    MainWindow window = new MainWindow();
                    window.Show();
                    this.Close();
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

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
            txtUser.Focus();
            Settings.Default.Reset();
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
