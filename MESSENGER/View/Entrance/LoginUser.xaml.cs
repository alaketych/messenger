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

namespace MESSENGER.View.Entrance
{
    public partial class LoginUser : Window
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registration newRegistration = new Registration();
            newRegistration.Show();
            this.Close();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("UserName", txtUserName.Text));
            sqlParams.Add(new SqlParameter("Password", txtPassword.Text));

            DataTable dtLoginResults = DAL.ExecSP("ValidateLogin", sqlParams);

            if (dtLoginResults.Rows.Count == 1)
            {
                MESSENGER.View.MainMessenger.MainWindow DisplayMainWindow = new MESSENGER.View.MainMessenger.MainWindow();
                DisplayMainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login or password.");
            }
        }
    }
}
