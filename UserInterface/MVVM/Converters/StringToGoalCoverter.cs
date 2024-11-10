using DataAccess;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace UserInterface.MVVM.Converters
{
    class StringToGoalCoverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString()!;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string res = value.ToString()!.Replace(" ", "").Split(":")[1];
            switch (res)
            {
                case "Gain":
                    return WeightGoal.Gain;
                case "Lose":
                    return WeightGoal.Lose;
                case "Maintain":
                    return WeightGoal.Maintain;
                default:
                    return WeightGoal.Maintain;
            }
        }
    }
}
