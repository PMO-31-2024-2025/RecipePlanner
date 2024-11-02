using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Views;

namespace UserInterface.MVVM.Helpers
{
    public static class WindowIntitializer
    {
        public static MainWindow InitMainWindow() => new MainWindow();
        public static LoginWindow InitLoginWindow() => new LoginWindow();
        public static FirstSurveyWindow InitFirstSurveyPage() => new FirstSurveyWindow();
        public static SecondSurveyWindow InitSecondSurveyPage() => new SecondSurveyWindow();
        public static ThirdSurveyWindow InitThirdSurveyPage() => new ThirdSurveyWindow();
        public static FourthSurveyWindow InitFourthSurveyPage() => new FourthSurveyWindow();
        public static FiveSurveyWindow InitFiveSurveyPage() => new FiveSurveyWindow();
        public static CongratulationWindow InitCongratulationPage() => new CongratulationWindow();
        public static AccountWindow InitAccountPage() => new AccountWindow();
        public static StatisticsWindow InitStatisticsPage() => new StatisticsWindow();
        public static RecipesWindow InitRecipePage() => new RecipesWindow();
        public static UpdateRecipePage InitAddRecipePage() => new UpdateRecipePage();
        public static SeeRecipePage InitSeeRecipePage() => new SeeRecipePage();
        public static SettingsWindow InitSettingPage() => new SettingsWindow();
        public static FoodPlansWindow InitFoodPlansPage() => new FoodPlansWindow();
        public static ChangeEmailPage InitChangeEmailPage() => new ChangeEmailPage();
        public static ChangePasswordPage InitChangePasswordPage() => new ChangePasswordPage();

    }
}
