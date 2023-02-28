using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace Edsofta.Converters
{
    public class RadioButtonCheckedConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string selectedAnswer = values[0].ToString();
            RadioButton radio = (RadioButton)values[1];
            return (string)radio.Content == selectedAnswer ? true : (object)false;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
