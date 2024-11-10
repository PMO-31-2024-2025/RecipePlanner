using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for SecondSurveyWindow.xaml
    /// </summary>
    public partial class SecondSurveyWindow : Page
    {
        public int StepsPerDay { get; set; }
        public SecondSurveyWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button PressedButton = (Button)sender;

            if (PressedButton == LessThan1000Button)
            {
                StepsPerDay = 999; 
                UpTo3000Button.Background = System.Windows.Media.Brushes.DarkGray;
                App.SurviesFrame.Navigate(App.SurveyWindow_3);
            }
            else if (PressedButton == UpTo3000Button)
            {
                StepsPerDay = 3000; 
                UpTo3000Button.Background = System.Windows.Media.Brushes.DarkGray;
                App.SurviesFrame.Navigate(App.SurveyWindow_3);
            }
            else if (PressedButton == UpTo7000Button)
            {
                StepsPerDay = 7000; 
                UpTo7000Button.Background = System.Windows.Media.Brushes.DarkGray;
                App.SurviesFrame.Navigate(App.SurveyWindow_3);
            }
            else if (PressedButton == MoreThan7000Button)
            {
                StepsPerDay = 7001;
                MoreThan7000Button.Background = System.Windows.Media.Brushes.DarkGray;
                App.SurviesFrame.Navigate(App.SurveyWindow_3);
            }
            else if (PressedButton == NoIdeaButton)
            {
                StepsPerDay = 0; 
                NoIdeaButton.Background = System.Windows.Media.Brushes.DarkGray;
                App.SurviesFrame.Navigate(App.SurveyWindow_3);
            }
        }
    }
}
