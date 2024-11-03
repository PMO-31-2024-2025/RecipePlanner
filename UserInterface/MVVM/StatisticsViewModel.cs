using BusinessLogic;
using DataAccess;
using DataAccess.Models;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows;
using System.Windows.Media;

namespace UserInterface.MVVM
{
    public class StatisticsViewModel : BaseViewModel
    {
        #region Fields
        private SeriesCollection _series = new SeriesCollection();
        #endregion

        #region Properties
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
        #endregion

        #region Constructor
        public StatisticsViewModel()
        {
            ChartValues<int> weightStatistic = new ChartValues<int>();
            foreach (StatisticEntity entity in AccountManager.LoginedAccount.StatisticEntities!)
            {
                weightStatistic.Add(entity.Weight);
            } 
            AddNewSerie(Colors.Blue, "Weights", weightStatistic);
        }
        #endregion

        #region Methods
        private void AddNewSerie(Color color, string title, ChartValues<int> values)
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
        #endregion
    }
}
