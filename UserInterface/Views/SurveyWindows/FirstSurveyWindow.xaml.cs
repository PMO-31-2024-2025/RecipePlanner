using BusinessLogic;
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
    /// Interaction logic for FirstSurveyWindow.xaml
    /// </summary>
    public partial class FirstSurveyWindow : Page
    {
        public static AccountInfo? _info = null;

        public FirstSurveyWindow()
        {
            InitializeComponent();
            _info = new AccountInfo();
        }

        private void LoseWeightButton_Click(object sender, RoutedEventArgs e)
        {
            _info.Goal = WeightGoal.Lose;
            LoseWeightButton.Background = System.Windows.Media.Brushes.DarkGray;
            App.SurviesFrame.Navigate(App.SurveyWindow_2);
        }


        private void GainWeightButton_Click(object sender, RoutedEventArgs e)
        {
            _info.Goal = WeightGoal.Gain;
            GainWeightButton.Background = System.Windows.Media.Brushes.DarkGray;
            App.SurviesFrame.Navigate(App.SurveyWindow_2);
        }

        private void MaintainWeightButton_Click(object sender, RoutedEventArgs e)
        {
            _info.Goal = WeightGoal.Maintain;
            MaintainWeightButton.Background = System.Windows.Media.Brushes.DarkGray;
            App.SurviesFrame.Navigate(App.SurveyWindow_2);
        } 
      
    }
}
