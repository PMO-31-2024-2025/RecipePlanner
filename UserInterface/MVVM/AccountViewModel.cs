using DataAccess;
using BusinessLogic;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;
using System.Windows;
using LiveCharts.Defaults;
using DataAccess.Models;
using UserInterface.MVVM.Commands.AccountCommands;
using Microsoft.Win32;
using System.IO;
using System.Windows.Media.Imaging;

namespace UserInterface.MVVM
{
    public class AccountViewModel : BaseViewModel
    {
        #region Fields
        private SeriesCollection _series = new SeriesCollection();
        #endregion

        #region Properties
        public Func<double, string> XFormatter { get; set; }
        public Func<double, string> YFormatter { get; set; }
        public string Email 
        {
            get
            {
                return AccountManager.LoginedAccount.Email;
            }
            set
            {
                AccountManager.LoginedAccount.Email = value;
                OnPropertyChanged(nameof(Email));
            } 
        }
        public string Password
        {
            get
            {
                return AccountManager.LoginedAccount.Password;
            }
            set
            {
                AccountManager.LoginedAccount.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public int Age
        {
            get
            {
                return AccountManager.LoginedAccount.AccountInfo.Age;
            }
            set
            {
                AccountManager.LoginedAccount.AccountInfo.Age = value;
                OnPropertyChanged(nameof(Age));
            }
        }
        public Sex Gender
        {
            get
            {
                return AccountManager.LoginedAccount.AccountInfo.Sex;
            }
            set
            {
                AccountManager.LoginedAccount.AccountInfo.Sex = value;
                OnPropertyChanged(nameof(Gender));
            }
        }
        public WeightGoal Goal
        {
            get
            {
                return AccountManager.LoginedAccount.AccountInfo.Goal;
            }
            set
            {
                AccountManager.LoginedAccount.AccountInfo.Goal = value;
                OnPropertyChanged(nameof(Goal));
            }
        }
        public int DesiredWeight
        {
            get
            {
                return AccountManager.LoginedAccount.AccountInfo.DesiredWeight;
            }
            set
            {
                AccountManager.LoginedAccount.AccountInfo.DesiredWeight = value;
                OnPropertyChanged(nameof(DesiredWeight));
            }
        }
        public int CurrentWeight
        {
            get
            {
                return AccountManager.LoginedAccount.AccountInfo.Weight;
            }
            set
            {
                AccountManager.LoginedAccount.AccountInfo.Weight = value;
                OnPropertyChanged(nameof(CurrentWeight));
            }
        }
        public int Height
        {
            get
            {
                return AccountManager.LoginedAccount.AccountInfo.Height;
            }
            set
            {
                AccountManager.LoginedAccount.AccountInfo.Height = value;
                OnPropertyChanged(nameof(Height));
            }
        }
        public string ImagePath
        {
            get
            {
                if (AccountManager.LoginedAccount.AccountInfo.ImageUrl != null)
                {
                    return AccountManager.LoginedAccount.AccountInfo.ImageUrl;
                }

                return "pack://application:,,,/Images/Accounts/MainPictures/Test.png";
            }
            set
            {
                AccountManager.LoginedAccount.AccountInfo.ImageUrl = value;
                OnPropertyChanged(nameof(ImagePath));
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

        #region Commands
        public UpdateAccountCommand UpdateAccountCommand { get; }
        public UpdateAccountInfoCommand UpdateAccountInfoCommand { get; }
        public ChangeImageCommand ChangeImageCommand { get; }
        #endregion

        #region Constructor
        public AccountViewModel()
        {
            UpdateAccountCommand = new UpdateAccountCommand(this);
            UpdateAccountInfoCommand = new UpdateAccountInfoCommand(this);
            ChangeImageCommand = new ChangeImageCommand(this);

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

            try
            {
                Series.Add(new LineSeries()
                {
                    Title = "Weights",
                    Values = values,
                    Fill = brush
                });
            }
            catch {}

        }
        #endregion

        #region Methods
        public void ChangeAccount()
        {
            DbHelper.db.Accounts.Update(AccountManager.LoginedAccount);
            DbHelper.db.SaveChanges();
            MessageBox.Show("Account Updated Successfully. In order to see changes relogin", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public void ChangeAccountInfo()
        {
            DbHelper.db.AccountInformations.Update(AccountManager.LoginedAccount.AccountInfo);
            DbHelper.db.SaveChanges();
            MessageBox.Show("Account Updated Successfully. In order to see changes relogin", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public void ChangeImage()
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files|*.jpg;*.png";
            openDialog.FilterIndex = 1;
            if (openDialog.ShowDialog() == true)
            {
                string destination = $"../../../Images/Accounts/MainPictures/{AccountManager.LoginedAccount.Email}.png";
                File.Copy(openDialog.FileName, destination, true);
                ImagePath = $"pack://application:,,,/Images/Accounts/MainPictures/{AccountManager.LoginedAccount.Email}.png";
                ChangeAccountInfo();
            }
        }
        #endregion
    }
}
