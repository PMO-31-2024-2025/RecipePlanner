using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace UserInterface.Views
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            App.SurviesFrame = SurviesFrame;
            App.SurviesFrame.Navigate(App.SurveyWindow_1);
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Email" || textBox.Text == "Password") textBox.Text = "";
        }
        
    }
}
