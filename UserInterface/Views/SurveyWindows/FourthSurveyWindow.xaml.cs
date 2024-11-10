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
    /// Interaction logic for FourthSurveyWindow.xaml
    /// </summary>
    public partial class FourthSurveyWindow : Page
    {
        public FourthSurveyWindow()
        {
            InitializeComponent();
        }

        private void MaleRadioButton_Click(object sender, RoutedEventArgs e)
        {
            DietCreator.Gender = Sex.Male;
        }

        private void FemaleRadioButton_Click(object sender, RoutedEventArgs e)
        {
            DietCreator.Gender = Sex.Female;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DietCreator.Age = int.Parse(AgeTextBox.Text);
                App.SurviesFrame.Navigate(App.SurveyWindow_5);
            }
            catch { MessageBox.Show("Enter valid age", "Error", MessageBoxButton.OK, MessageBoxImage.Error); }

        }
    }

}