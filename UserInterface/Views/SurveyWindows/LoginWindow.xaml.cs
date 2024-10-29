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
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Email" || textBox.Text == "Password") textBox.Text = "";
        }
    }
}
