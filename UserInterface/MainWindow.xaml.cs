using System.Windows;
using System.Windows.Controls;
using UserInterface.Views;

namespace UserInterface
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            App.RightSideFrame = RightSideFrame;
            App.MyAccountWindow = new AccountWindow();
            App.MyRecipesWindow = new RecipesWindow();
            App.MySettingsWindow = new SettingsWindow();
            App.MyStatisticsWindow = new StatisticsWindow();
            App.MyEditRecipeWindow = new UpdateRecipePage();
            App.MyAddRecipeWindow = new AddrecipePage();
            App.MySeeRecipeWindow = new SeeRecipePage();
            App.MyManageEntitesPage = new ManageEntitiesPage();

        App.RightSideFrame.Navigate(App.MyAccountWindow);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button pressedButton = (Button)sender;
            switch (pressedButton.Name)
            {
                case "AccountButton":
                    RightSideFrame.Navigate(App.MyAccountWindow);
                    break;
                case "StatisticsButton":
                    RightSideFrame.Navigate(App.MyStatisticsWindow);
                    break;
                case "RecipesButton":
                    RightSideFrame.Navigate(App.MyRecipesWindow);
                    break;
                case "SettingsButton":
                    RightSideFrame.Navigate(App.MySettingsWindow);
                    break;
            }
        }
    }
}