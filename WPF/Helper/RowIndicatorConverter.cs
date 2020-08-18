using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace SfDataGridDemo
{
    public class RowIndicatorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && (bool)value)
            {
                string str = "M6.8007798,1.7332839 L8.97791,3.9143763 2.8868401,10.034073 0,10.666874 0.70837402,7.8491302 z M9.1967516,0.00016105175 C9.5903473,-0.0053596497 9.9693098,0.13107061 10.251301,0.41431141 10.856801,1.0224026 10.794301,2.067961 10.110801,2.7515601 L7.9219999,0.5588423 C8.2858057,0.19500291 8.7506762,0.0064178705 9.1967516,0.00016105175z";
                return Geometry.Parse(str);
            }
            return Geometry.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
