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
    /// Interaction logic for ThirdSurveyWindow.xaml
    /// </summary>
    public partial class ThirdSurveyWindow : Page
    {
        public ThirdSurveyWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button PressedButton = (Button)sender;
            if (PressedButton == NotVeryActiveButton)
            {

            }
            else if (PressedButton == ActiveButton)
            {

            }
            else if (PressedButton == VeryActiveButton)
            {

            }
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            App.SurviesFrame.Navigate(App.SurveyWindow_4);
        }
    }
}
