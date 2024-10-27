using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
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
        List<Account> Accounts;
        public LoginWindow()
        {
            GetAccounts();
            InitializeComponent();
        }

        public void GetAccounts()
        {
            Accounts = DbHelper.db.Accounts.Include("AccountInfo").Include("Dishes").ToList();
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Email" || textBox.Text == "Password") textBox.Text = "";
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (Accounts.Where(acc => acc.Email == LoginTextBox.Text) == null)
            {
                MessageBox.Show("Login Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Account account = Accounts.Find(acc => acc.Email == LoginTextBox.Text)!;
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
            if (Accounts.FirstOrDefault(acc => acc.Email == LoginTextBox.Text) != null)
            {
                MessageBox.Show("Account Already Exist", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            DbHelper.db.AddAsync(new Account() { Email = LoginTextBox.Text, Password = PasswordTextBox.Text });

            MessageBox.Show("Account Successfully Registered");
            GetAccounts();

            Account account = Accounts.Find(acc => acc.Email == LoginTextBox.Text)!;
            MainWindow programEntry = new MainWindow(account);
            programEntry.Show();
            Close();
        }
    }
}
