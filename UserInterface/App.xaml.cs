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

        //Additional information windows
        public static FirstSurveyWindow SurveyWindow_1;
        public static SecondSurveyWindow SurveyWindow_2;
        public static ThirdSurveyWindow SurveyWindow_3;
        public static FourthSurveyWindow SurveyWindow_4;
        public static FiveSurveyWindow SurveyWindow_5;
        public static CongratulationWindow SurveyWindow_6;

        public static Frame SurviesFrame;

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

            MyLoginWindow.StartGainingAdditionalInformation.TextChanged += (s, e) =>
            {
                if (MyLoginWindow.StartGainingAdditionalInformation.Text == "True")
                {
                    MyLoginWindow.LoginBorder.Visibility = Visibility.Hidden;
                    MyLoginWindow.SurviesBorder.Visibility = Visibility.Visible;
                    MyLoginWindow.SurviesFrame.Navigate(SurveyWindow_1);
                }
                else
                {
                    MyLoginWindow.SurviesFrame.Navigate(SurveyWindow_1);
                    MyLoginWindow.SurviesBorder.Visibility = Visibility.Hidden;
                    MyLoginWindow.LoginBorder.Visibility = Visibility.Visible;
                }
            };

            SurveyWindow_1 = new FirstSurveyWindow();
            SurveyWindow_2 = new SecondSurveyWindow();
            SurveyWindow_3 = new ThirdSurveyWindow();
            SurveyWindow_4 = new FourthSurveyWindow();
            SurveyWindow_5 = new FiveSurveyWindow();
            SurveyWindow_6 = new CongratulationWindow();
        }
    }
}
