using System;
using System.Windows.Data;

namespace IceCreamOrderForm
{
    internal class RadioButtonConverter : IValueConverter
    {
        public object Convert (object value, Type targetType,  object parameter, System.Globalization.CultureInfo culture)
        {
            int integer = (int)value;
            if (integer == int.Parse(parameter.ToString()))
                return true;
            else
                return false;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return parameter;
        }
    }
}
