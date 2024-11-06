using DataAccess;
using BusinessLogic;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;
using System.Windows;
using LiveCharts.Defaults;
using DataAccess.Models;

namespace UserInterface.MVVM
{
    public class AccountViewModel : BaseViewModel
    {
        #region Fields
        private string _email = AccountManager.LoginedAccount.Email;
        private int _age = AccountManager.LoginedAccount.AccountInfo.Age;
        private Sex _gender = AccountManager.LoginedAccount.AccountInfo.Sex;
        private WeightGoal _goal = AccountManager.LoginedAccount.AccountInfo.Goal;
        private int _desiredWeight = AccountManager.LoginedAccount.AccountInfo.DesiredWeight;
        private int _currentWeight = AccountManager.LoginedAccount.AccountInfo.Weight;
        private int _height = AccountManager.LoginedAccount.AccountInfo.Height;

        private SeriesCollection _series = new SeriesCollection();
        #endregion
        #region Properties
        public Func<double, string> XFormatter { get; set; }
        public Func<double, string> YFormatter { get; set; }
        public string Email 
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            } 
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }
        public Sex Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }
        public WeightGoal Goal
        {
            get
            {
                return _goal;
            }
            set
            {
                _goal = value;
                OnPropertyChanged(nameof(Goal));
            }
        }
        public int DesiredWeight
        {
            get
            {
                return _desiredWeight;
            }
            set
            {
                _desiredWeight = value;
                OnPropertyChanged(nameof(DesiredWeight));
            }
        }
        public int CurrentWeight
        {
            get
            {
                return _currentWeight;
            }
            set
            {
                _currentWeight = value;
                OnPropertyChanged(nameof(CurrentWeight));
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                OnPropertyChanged(nameof(Height));
            }
        }
        public SeriesCollection Series
        {
            get { return _series; }
            set
            {
                _series = value;
                OnPropertyChanged(nameof(Series));
            }
        }
        #endregion

        public AccountViewModel()
        {
            XFormatter = (val) =>
            {
                try
                {
                    DateTime dateTime = new DateTime((long)val);
                    return DateOnly.FromDateTime(dateTime).ToString();
                }
                catch { return "None"; }
            };
            YFormatter = (val) =>
            {
                try { return $"{val} kg"; }
                catch { return "None"; }
            };

            ChartValues<DateTimePoint> values = new ChartValues<DateTimePoint>();
            foreach (StatisticEntity entity in AccountManager.LoginedAccount.StatisticEntities!.OrderBy(ent => ent.Date))
            {
                values.Add(new DateTimePoint(entity.Date, entity.Weight));
            }
            LinearGradientBrush brush = new LinearGradientBrush()
            {
                StartPoint = new Point(0, 0),
                EndPoint = new Point(0, 1),
            };
            brush.GradientStops.Add(new GradientStop(Colors.Blue, 0));
            brush.GradientStops.Add(new GradientStop(Colors.Transparent, 1));

            Series.Add(new LineSeries()
            {
                Title = "Weights",
                Values = values,
                Fill = brush
            });
        }
    }
}
