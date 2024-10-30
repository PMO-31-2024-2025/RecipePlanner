using BusinessLogic;
using System.Windows;
using System.Windows.Controls;

namespace UserInterface.Views
{
    public partial class AccountWindow : Page
    {
        public AccountWindow()
        {
            InitializeComponent();
        }

        private void EditCommand_Click(object sender, RoutedEventArgs e)
        {
            App.RightSideFrame.Navigate(App.MySettingsWindow);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            App.MyLoginWindow = new LoginWindow();
            App.MyLoginWindow.Show();
            App.MyLoginWindow.IsLoginSuccessfulTextBox.TextChanged += (s, e) =>
            {
                if (App.MyLoginWindow.IsLoginSuccessfulTextBox.Text == "True")
                {
                    App.MyMainWindow = new MainWindow();
                    App.MyMainWindow.Show();
                    App.MyLoginWindow.Close();
                }
            };
            App.MyMainWindow.Close();
        }
    }
}
