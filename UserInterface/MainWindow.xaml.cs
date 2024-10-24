using DataAccess.Models;
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
        private Account Account;

        private AccountWindow accountWindow;
        private StatisticsWindow statisticsWindow;
        private FoodPlansWindow foodPlansWindow;
        private RecipesWindow recipesWindow;
        private SettingsWindow settingsWindow;

        public MainWindow()
        {
            accountWindow = new AccountWindow();
            statisticsWindow = new StatisticsWindow();
            foodPlansWindow = new FoodPlansWindow();
            recipesWindow = new RecipesWindow();
            settingsWindow = new SettingsWindow();
            InitializeComponent();
        }
        public MainWindow(Account account)
        {
            Account = account;
            accountWindow = new AccountWindow();
            statisticsWindow = new StatisticsWindow();
            foodPlansWindow = new FoodPlansWindow();
            recipesWindow = new RecipesWindow();
            settingsWindow = new SettingsWindow();
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RightSideFrame.Navigate(accountWindow);
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
    }
}