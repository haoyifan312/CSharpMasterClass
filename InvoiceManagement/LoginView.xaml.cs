using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InvoiceManagement
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public void OnLoginButtonClicked(object sender, RoutedEventArgs e)
        {
            string passwordEntered = PasswordBox.Password;
            string? envPw = System.Environment.GetEnvironmentVariable("InvoiceManagement");
            if (envPw != null)
            {
                string msg = (envPw == passwordEntered) ? "Entered correct password" : "password is wrong";
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("Env variable 'InvoiceManagement' for password is not setup");
            }
        }

        public void OnPasswordChanged(object sender, EventArgs e)
        {
            LoginButton.IsEnabled = !string.IsNullOrEmpty(PasswordBox.Password);
        }
    }
}
