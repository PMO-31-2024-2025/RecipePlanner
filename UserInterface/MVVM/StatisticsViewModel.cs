using BusinessLogic;
using DataAccess;
using DataAccess.Models;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;
using UserInterface.MVVM.Commands.StatisticsCommands;

namespace UserInterface.MVVM
{
    public class StatisticsViewModel : BaseViewModel
    {
        #region Fields
        private string _userEmail = AccountManager.LoginedAccount.Email;

        private ZoomingOptions _zoomingMode = ZoomingOptions.None;
        private double? _xMinValue = double.NaN;
        private double? _xMaxValue = double.NaN;
        private double? _yMinValue = double.NaN;
        private double? _yMaxValue = double.NaN;

        private SeriesCollection _series = new SeriesCollection();
        private DateTime? _fromDateTime;
        private DateTime? _toDateTime;

        // Manage Entities Page
        private StatisticEntity? _selectedEntity;
        private string _date;
        private string _weight = "0";
        #endregion

        #region Properties
        #region Points
        public double? XMin
        {
            get { return _xMinValue; }
            set
            {
                _xMinValue = value;
                OnPropertyChanged(nameof(XMin));
            }
        }
        public double? XMax
        {
            get { return _xMaxValue; }
            set
            {
                _xMaxValue = value;
                OnPropertyChanged(nameof(XMax));
            }
        }
        public double? YMin
        {
            get { return _yMinValue; }
            set
            {
                _yMinValue = value;
                OnPropertyChanged(nameof(YMin));
            }
        }
        public double? YMax
        {
            get { return _yMaxValue; }
            set
            {
                _yMaxValue = value;
                OnPropertyChanged(nameof(YMax));
            }
        }
        #endregion
        public string UserEmail
        {
            get { return _userEmail; }
            set
            {
                _userEmail = value;
                OnPropertyChanged(nameof(UserEmail));
            }
        }
        public Func<double, string> XFormatter { get; set; }
        public Func<double, string> YFormatter { get; set; }
        public ZoomingOptions ZoomingMode
        {
            get { return _zoomingMode; }
            set
            {
                _zoomingMode = value;
                OnPropertyChanged(nameof(ZoomingMode));
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

        public DateTime? FromDateTime
        {
            get { return _fromDateTime; }
            set
            {
                _fromDateTime = value;
                OnPropertyChanged(nameof(FromDateTime));
            }
        }
        public DateTime? ToDateTime
        {
            get { return _toDateTime; }
            set
            {
                _toDateTime = value;
                OnPropertyChanged(nameof(ToDateTime));
            }
        }
        // Manage Entities Page
        public ObservableCollection<StatisticEntity> Entities { get; set; }

        public StatisticEntity? SelectedEntity
        {
            get { return _selectedEntity; }
            set
            {
                _selectedEntity = value;
                OnPropertyChanged(nameof(SelectedEntity));
            }
        }
        public string Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }
        public string Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPropertyChanged(nameof(Weight));
            }
        }
        #endregion

        #region Commands
        public ResetZoomingModeCommand ResetZoomingModeCommand { get; }
        public ToggleZoomingModeCommand ToggleZoomingModeCommand { get; }
        public ManageEntitiesCommand ManageEntitiesCommand { get; }
        public DatePickerChangedCommand DatePickerChangedCommand { get; }

        // Manage Entities Page
        public AddNewEntityCommand AddNewEntityCommand { get; }
        public RemoveSelectedEntityCommand RemoveSelectedEntityCommand { get; }
        #endregion

        #region Constructor
        public StatisticsViewModel()
        {
            // Statistics Page
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

            ResetZoomingModeCommand = new ResetZoomingModeCommand(this);
            ToggleZoomingModeCommand = new ToggleZoomingModeCommand(this);
            ManageEntitiesCommand = new ManageEntitiesCommand(this);
            DatePickerChangedCommand = new DatePickerChangedCommand(this);

            ChartValues<DateTimePoint> weightStatistics = GetTimeData();
            AddNewSerie(Colors.Blue, "Weights", weightStatistics);

            // Manage Entities Page
            Entities = new ObservableCollection<StatisticEntity>();
            PopulateEntities();

            AddNewEntityCommand = new AddNewEntityCommand(this);
            RemoveSelectedEntityCommand = new RemoveSelectedEntityCommand(this);
        }
        #endregion

        #region Methods
        private void AddNewSerie(Color color, string title, ChartValues<DateTimePoint> values)
        {
            LinearGradientBrush brush = new LinearGradientBrush()
            {
                StartPoint = new Point(0, 0),
                EndPoint = new Point(0, 1),
            };
            brush.GradientStops.Add(new GradientStop(color, 0));
            brush.GradientStops.Add(new GradientStop(Colors.Transparent, 1));
            
            Series.Add(new LineSeries()
            {
                Title = title,
                Values = values,
                Fill = brush
            });
        }
        private void ResetLiveChart(DateTime? From = null, DateTime? To = null)
        {
            Series.Clear();
            ChartValues<DateTimePoint> weightStatistics;
            if (From == null && To == null || From != null && To == null || From == null && To != null)
            {
                weightStatistics = GetTimeData();
            }
            else
            {
                weightStatistics = GetTimeData(From, To);
            }
            AddNewSerie(Colors.Blue, "Weights", weightStatistics);
        }
        private ChartValues<DateTimePoint> GetTimeData(DateTime? From = null, DateTime? To = null)
        {
            ChartValues<DateTimePoint> valuesPoints = new ChartValues<DateTimePoint>();
            List<StatisticEntity> Entities;
            if (From == null && To == null || From != null && To == null || From == null && To != null)
            {
                Entities = AccountManager.LoginedAccount.StatisticEntities!.OrderBy(entity => entity.Date).ToList();
            }
            else
            {
                Entities = AccountManager.LoginedAccount.StatisticEntities!.OrderBy(entity => entity.Date)
                    .Where(entity => entity.Date > From && entity.Date < To).ToList();
            }
            foreach (StatisticEntity entity in Entities)
            {
                valuesPoints.Add(new DateTimePoint(entity.Date, entity.Weight));
            }
            return valuesPoints;
        }
        public void ExecuteToggleZoomModeCommand()
        {
            switch (ZoomingMode)
            {
                case ZoomingOptions.None:
                    ZoomingMode = ZoomingOptions.X;
                    break;
                case ZoomingOptions.X:
                    ZoomingMode = ZoomingOptions.Y;
                    break;
                case ZoomingOptions.Y:
                    ZoomingMode = ZoomingOptions.Xy;
                    break;
                case ZoomingOptions.Xy:
                    ZoomingMode = ZoomingOptions.None;
                    break;
            }
        }
        public void ExecuteResetZoomCommand()
        {
            XMin = double.NaN;
            XMax = double.NaN;
            YMin = double.NaN;
            YMax = double.NaN;
            FromDateTime = null;
            ToDateTime = null;
        }

        public void ExecuteManageEntitiesCommand()
        {
            App.MyManageEntitesPage.DataContext = this;
            App.RightSideFrame.Navigate(App.MyManageEntitesPage);
        }

        public void ExecuteDatePickerChangedCommand()
        {
            ResetLiveChart(FromDateTime, ToDateTime);
        }

        // Manage Entities Page
        public void PopulateEntities()
        {
            Entities.Clear();
            foreach (StatisticEntity entity in AccountManager.LoginedAccount.StatisticEntities!.OrderBy(entity => entity.Date))
            {
                Entities.Add(entity);
            }
        }

        public void ExecuteRemoveSelectedEntityCommand()
        {
            try
            {
                StatisticEntity entity = DbHelper.db.StatisticEntities.First(entity => entity.Id == SelectedEntity!.Id);
                DbHelper.db.Remove(entity);
                DbHelper.db.SaveChanges();
                PopulateEntities();
                ResetLiveChart();
            }
            catch { }
        }
        public void ExecuteAddNewEntityCommand()
        {
            StatisticEntity entity = new StatisticEntity()
            {
                AccountEmail = AccountManager.LoginedAccount.Email,
                Date = DateTime.Parse(Date),
                Weight = int.Parse(Weight)
            };
            DbHelper.db.StatisticEntities.Add(entity);
            DbHelper.db.SaveChanges();
            PopulateEntities();
            ResetLiveChart();
        }
        #endregion
    }
}
