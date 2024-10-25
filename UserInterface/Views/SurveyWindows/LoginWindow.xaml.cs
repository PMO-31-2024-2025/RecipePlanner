using BusinessLogic.Managers;
using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
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

namespace UserInterface.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Email" || textBox.Text == "Password") textBox.Text = "";
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (AuthorisationManager.Registered(LoginTextBox.Text) == false)
            {
                MessageBox.Show("Login Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Account account = AuthorisationManager.GetAccountByEmail(LoginTextBox.Text);
            if (account.Password == PasswordTextBox.Text)
            {
                MainWindow programEntry = new MainWindow(account);
                programEntry.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong Password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if (AuthorisationManager.Registered(LoginTextBox.Text) == true)
            {
                MessageBox.Show("Account Already Exist", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            AuthorisationManager.Register(LoginTextBox.Text, PasswordTextBox.Text);
            MessageBox.Show("Account Successfully Registered");
            MainWindow programEntry = new MainWindow(AuthorisationManager.GetAccountByEmail(LoginTextBox.Text));
            programEntry.Show();
            Close();
        }
    }
}
