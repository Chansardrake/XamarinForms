using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace MyPro2
{
    public class CheckBoxStateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null)
            {
                return false;
            }

            var p = value as Person;
            bool ans = false;
            if((string)parameter == "0" && p.CheckboxStatus[0] == 't')
            {
                ans = true;
            }
            else if ((string)parameter == "1"  && p.CheckboxStatus[1] == 't')
            {
                ans = true;
            }
            else if ((string)parameter == "2" && p.CheckboxStatus[2] == 't')
            {
                ans = true;
            }
            else if ((string)parameter == "3" && p.CheckboxStatus[3] == 't')
            {
                ans = true;
            }

            return ans;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
