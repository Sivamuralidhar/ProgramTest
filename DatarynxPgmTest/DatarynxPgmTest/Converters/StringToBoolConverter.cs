using System;
using System.Globalization;
using Xamarin.Forms;

namespace DatarynxPgmTest.Converters
{
    public class StringToBoolConverter : IValueConverter
    {
        string CompareValue = "Not Started";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString() == CompareValue)
            {
                return true;
            }

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
