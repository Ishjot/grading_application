using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Grading_App.Converters
{
    public class PercentageToGradeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (!(value is double)) return DependencyProperty.UnsetValue;
            double percentage = (double) value;
            if (percentage >= 0.9)
            {
                return 'A';
            }
            else if (percentage >= 0.8)
            {
                return 'B';
            }
            else if (percentage >= 0.7)
            {
                return 'C';
            }
            else if (percentage >= 0.6)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
