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
    public partial class Registration : Window
    {
        LoginUser backLoginUser = new LoginUser();

        public Registration()
        {
            InitializeComponent();
        }

        private void RegistationButton_Click_1(object sender, RoutedEventArgs e)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();

            sqlParams.Add(new SqlParameter("Username", txtNewUserName.Text));
            sqlParams.Add(new SqlParameter("Password", txtNewPassword.Text));

            DAL.ExecSP("CreateUser", sqlParams);
            MessageBox.Show("You have been registrated.");

            backLoginUser.Show();
            this.Close();
        }

        private void BackToLogin_Click(object sender, RoutedEventArgs e)
        {
            backLoginUser.Show();
            this.Close();
        }
    }
}
