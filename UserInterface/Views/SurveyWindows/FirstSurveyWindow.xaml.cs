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
    /// Interaction logic for FirstSurveyWindow.xaml
    /// </summary>
    public partial class FirstSurveyWindow : Page
    {
        public FirstSurveyWindow()
        {
            InitializeComponent();
        }

        private void LoseWeightButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GainWeightButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MaintainWeightButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            App.SurviesFrame.Navigate(App.SurveyWindow_2);
        }
    }
}
