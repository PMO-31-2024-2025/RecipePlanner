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
    /// Interaction logic for CongratulationWindow.xaml
    /// </summary>
    public partial class CongratulationWindow : Page
    {
        public CongratulationWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.MyLoginWindow.LoginBorder.Visibility = Visibility.Visible;
            App.MyLoginWindow.SurviesBorder.Visibility = Visibility.Collapsed;
            App.MyLoginWindow.SurviesFrame.Navigate(App.SurveyWindow_1);
        }
    }
}
