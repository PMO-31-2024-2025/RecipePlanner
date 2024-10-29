using BusinessLogic;
using DataAccess;
using System.Windows;
using System.Windows.Controls;
using UserInterface.Views;

namespace UserInterface
{
    public partial class App : Application
    {
        // Startup windows
        public static LoginWindow MyLoginWindow;

        // Main application window and it's components
        public static Frame RightSideFrame;
        public static MainWindow MyMainWindow;

        // Main windows
        public static AccountWindow? MyAccountWindow;
        public static RecipesWindow? MyRecipesWindow;
        public static SettingsWindow? MySettingsWindow;
        public static StatisticsWindow? MyStatisticsWindow;
        public static FoodPlansWindow? MyFoodPlansWindow;

        // Secondary windows
        public static AddRecipe MyAddRecipeWindow = new AddRecipe();
        public static SeeRecipePage MySeeRecipeWindow = new SeeRecipePage();

        public void Application_Startup(object sender, StartupEventArgs e)
        {
            MyLoginWindow = new LoginWindow();
            MyLoginWindow.Show();
            MyLoginWindow.IsLoginSuccessfulTextBox.TextChanged += (s, e) =>
            {
                if (MyLoginWindow.IsLoginSuccessfulTextBox.Text == "True")
                {
                    MyMainWindow = new MainWindow();
                    MyMainWindow.Show();
                    MyLoginWindow.Close();
                }
            };
        }
    }
}
