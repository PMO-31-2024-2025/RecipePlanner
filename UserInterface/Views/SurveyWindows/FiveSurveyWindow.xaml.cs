using DataAccess;
using DataAccess.Models;
using SQLitePCL;
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
    /// Interaction logic for FiveSurveyWindow.xaml
    /// </summary>
    public partial class FiveSurveyWindow : Page
    {
        public static AccountInfo? _info = null;
        public FiveSurveyWindow()
        {
            InitializeComponent();
            _info = new AccountInfo();
        }

        private void HeightTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (int.TryParse(HeightTextBox.Text, out int height))
            {
                _info.Height = height;
            }
            else if (!string.IsNullOrWhiteSpace(HeightTextBox.Text))
            {
                MessageBox.Show("Please enter a valid height.");
            }
        }


        private void CurrentWeightTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (int.TryParse(CurrentWeightTextBox.Text, out int currentWeight))
            {
                _info.Weight = currentWeight;
            }
            else if (!string.IsNullOrWhiteSpace(CurrentWeightTextBox.Text))
            {
                MessageBox.Show("Please enter a valid current weight.");
            }
        }


        //private void TextBoxDesiredWeight_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    if (int.TryParse(DesiredWeightTextBox.Text, out int desiredWeight))
        //    {
        //        _info.DesiredWeight = desiredWeight;

        //    }
        //    else if (!string.IsNullOrWhiteSpace(DesiredWeightTextBox.Text))
        //    {
        //        MessageBox.Show("Please enter a valid desired weight.");
        //    }
        //}

        //App.SurviesFrame.Navigate(App.SurveyWindow_6);

        //private void DesiredWeightTextBox_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    if (int.TryParse(DesiredWeightTextBox.Text, out int desiredWeight))
        //    {
        //        _info.DesiredWeight = desiredWeight;

        //        App.SurviesFrame.Navigate(App.SurveyWindow_6);
        //        //this.NavigationService.Navigate(App.SurveyWindow_6);  
        //    }
        //    else if (!string.IsNullOrWhiteSpace(DesiredWeightTextBox.Text))
        //    {
        //        MessageBox.Show("Please enter a valid desired weight.");
        //    }

        //    App.SurviesFrame.Navigate(App.SurveyWindow_6);
        //}

        private void DesiredWeightTextBox_Д(object sender, MouseEventArgs e)
        {
            if (int.TryParse(DesiredWeightTextBox.Text, out int desiredWeight))
            {
                _info.DesiredWeight = desiredWeight;
                App.SurviesFrame.Navigate(App.SurveyWindow_6);
            }
            else if (!string.IsNullOrWhiteSpace(DesiredWeightTextBox.Text))
            {
                MessageBox.Show("Please enter a valid desired weight.");
            }
        }

    }
}
