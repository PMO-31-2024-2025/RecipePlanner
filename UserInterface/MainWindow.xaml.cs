using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserInterface.Views;

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AccountWindow accountWindow = new AccountWindow();
        private StatisticsWindow statisticsWindow = new StatisticsWindow();
        private FoodPlansWindow foodPlansWindow = new FoodPlansWindow();
        private RecipesWindow recipesWindow = new RecipesWindow();
        private SettingsWindow settingsWindow = new SettingsWindow();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RightSideFrame.Navigate(accountWindow);
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button pressedButton = (Button)sender;
            switch (pressedButton.Name)
            {
                case "AccountButton":
                    RightSideFrame.Navigate(accountWindow);
                    break;
                case "StatisticsButton":
                    RightSideFrame.Navigate(statisticsWindow);
                    break;
                case "FoodPlansButton":
                    RightSideFrame.Navigate(foodPlansWindow);
                    break;
                case "RecipesButton":
                    RightSideFrame.Navigate(recipesWindow);
                    break;
                case "SettingsButton":
                    RightSideFrame.Navigate(settingsWindow);
                    break;
            }
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button clickedButton = (Button)sender;
            var mainButtonHoverStyle = (Style)FindResource("MainButtonHoverStyle");
            clickedButton.Style = mainButtonHoverStyle;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button clickedButton = (Button)sender;
            var mainButtonHoverStyle = (Style)FindResource("MainButtonStyle");
            clickedButton.Style = mainButtonHoverStyle;
        }
    }
}