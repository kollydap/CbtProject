using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;


namespace Edsofta.Converters
{
    public class IsCheckedAndSelectedAnsToBoolConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
            
            RadioButton radio = (RadioButton)values[1];
            string selectedAnswer = values[0].ToString();
            return (string)radio.Content == selectedAnswer ? true : (object)false;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
            return null;
    }
}
}
