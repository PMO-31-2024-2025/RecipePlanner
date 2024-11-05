using BusinessLogic;
using DataAccess;
using DataAccess.Models;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
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
        #endregion

        #region Commands
        public ResetZoomingModeCommand ResetZoomingModeCommand { get; }
        public ToggleZoomingModeCommand ToggleZoomingModeCommand { get; }
        #endregion

        #region Constructor
        public StatisticsViewModel()
        {
            XFormatter = (val) =>
            {
                try { return new DateTime((long)val).ToString("dd/MMM/yyyy"); }
                catch { return "None"; }
            };
            YFormatter = (val) =>
            {
                try { return $"{val} kg"; }
                catch { return "None"; }
            };

            ResetZoomingModeCommand = new ResetZoomingModeCommand(this);
            ToggleZoomingModeCommand = new ToggleZoomingModeCommand(this);

            ChartValues<DateTimePoint> weightStatistics = GetTimeData();
            AddNewSerie(Colors.Blue, "Weights", weightStatistics);
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
        private ChartValues<DateTimePoint> GetTimeData()
        {
            ChartValues<DateTimePoint> valuesPoints = new ChartValues<DateTimePoint>();
            foreach (StatisticEntity entity in AccountManager.LoginedAccount.StatisticEntities!)
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
        }
        #endregion
    }
}
