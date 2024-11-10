using BusinessLogic;
using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserInterface.Views
{
    /// <summary>
    /// Interaction logic for CongratulationWindow.xaml
    /// </summary>
    public partial class CongratulationWindow : Page
    {
        public static AccountInfo? _info = null;
        public int StepsPerDay { get; set; }
        public string ActivityLevel { get; set; }

        public CongratulationWindow()

        {
            InitializeComponent();
            _info = new AccountInfo();
            CalculateIntakeCalories();
        }

        public int CalculateIntakeCalories()
        {
            double bmr;

            if (_info.Sex == Sex.Male)
            {
                bmr = (10 * _info.Weight) + (6.25 * _info.Height) - (5 * _info.Age) + 5;
            }
            else
            {
                bmr = (10 * _info.Weight) + (6.25 * _info.Height) - (5 * _info.Age) - 161;
            }

            double activityMultiplier;

            switch (ActivityLevel)
            {
                case "Not Very Active":
                    activityMultiplier = 1.2;
                    break;
                case "Active":
                    activityMultiplier = 1.375;
                    break;
                case "Very Active":
                    activityMultiplier = 1.55;
                    break;
                default:
                    activityMultiplier = 1.2;
                    break;
            }

            double stepCaloriesBurned = StepsPerDay * 0.05;
            double totalCalories = (bmr * activityMultiplier) + stepCaloriesBurned;
            double weightDifference = _info.DesiredWeight - _info.Weight;

            switch (_info.Goal)
            {
                case WeightGoal.Gain:
                    if (weightDifference > 0)
                    {
                        totalCalories += 500;
                    }
                    break;
                case WeightGoal.Lose:
                    if (weightDifference < 0)
                    {
                        totalCalories -= 500;
                    }
                    break;
                case WeightGoal.Maintain:
                    break;
            }

            _info.DailyCalories = (int)Math.Round(totalCalories);
            CaloriesTextBlock.Text = _info.DailyCalories.ToString();

            //DbHelper.db.Add(_info);
            //DbHelper.db.SaveChanges();

            App.MyLoginWindow.SurviesFrame.Navigate(App.SurveyWindow_1);
            App.MyLoginWindow.SurviesBorder.Visibility = Visibility.Hidden;
            App.MyLoginWindow.LoginBorder.Visibility = Visibility.Visible;

            return _info.DailyCalories;
        }

    }
}
