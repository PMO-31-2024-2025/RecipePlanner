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
        public static AccountInfo? _info = null;
        public FourthSurveyWindow()
        {
            InitializeComponent();
            _info = new AccountInfo();
        }

        private void AgeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(AgeTextBox.Text, out int age))
            {
                _info.Age = age;
            }
            else if (!string.IsNullOrWhiteSpace(AgeTextBox.Text))
            {
                MessageBox.Show("Please enter a valid age.");
            }
        }




        private void MaleRadioButton_Click(object sender, RoutedEventArgs e)
        {
            _info.Sex = Sex.Male;
            App.SurviesFrame.Navigate(App.SurveyWindow_5);
        }

        private void FemaleRadioButton_Click(object sender, RoutedEventArgs e)
        {
            _info.Sex = Sex.Female;
            App.SurviesFrame.Navigate(App.SurveyWindow_5);
        }
    }

}