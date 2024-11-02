using BusinessLogic;
using DataAccess;
using DataAccess.Models;
using System.Windows;
using System.Windows.Controls;
using UserInterface.MVVM.Helpers;
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
        public static UpdateRecipePage MyAddEditRecipeWindow;
        public static SeeRecipePage MySeeRecipeWindow;
        public void Application_Startup(object sender, StartupEventArgs e)
        {
            MyLoginWindow = WindowIntitializer.InitLoginWindow();
            MyLoginWindow.Show();

            SurveyWindow_1 = WindowIntitializer.InitFirstSurveyPage();
            SurveyWindow_2 = WindowIntitializer.InitSecondSurveyPage();
            SurveyWindow_3 = WindowIntitializer.InitThirdSurveyPage();
            SurveyWindow_4 = WindowIntitializer.InitFourthSurveyPage();
            SurveyWindow_5 = WindowIntitializer.InitFiveSurveyPage();
            SurveyWindow_6 = WindowIntitializer.InitCongratulationPage();
        }
    }
}
