using Cimbalino.Toolkit.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using System.Globalization;
using Windows.UI.Xaml;

namespace Grading_App.Converters
{
    public class PointsToPercentageConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Any(value => value == null)) return DependencyProperty.UnsetValue;

            var achievedPoints = (int)values[0];
            var totalPoints = (int)values[1];
            return (double)achievedPoints / totalPoints;
        }


        public override object[] ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
