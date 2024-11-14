using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

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
    }
}
