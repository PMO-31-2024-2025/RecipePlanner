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
    /// Interaction logic for AccountWindow.xaml
    /// </summary>
    public partial class AccountWindow : Page
    {
        private Account LoginedAccount;
        private Frame RightSideFrame;
        private MainWindow MyMainWindow;
        public AccountWindow(Account account, Frame frame, MainWindow window)
        {
            LoginedAccount = account;
            RightSideFrame = frame;
            MyMainWindow = window;

            InitializeComponent();
            MainGrid.DataContext = account;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            RightSideFrame.Navigate(new SettingsWindow());
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            MyMainWindow.Close();
        }
    }
}
