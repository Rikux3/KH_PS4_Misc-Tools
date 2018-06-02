﻿using System;
using System.Windows.Data;

namespace GnfHelper
{
    public class EnumConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
                              System.Globalization.CultureInfo culture)
        {
            Enum enumValue = default(Enum);
            if (parameter is Type)
            {
                enumValue = (Enum)Enum.Parse((Type)parameter, value.ToString());
            }
            return enumValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
                                  System.Globalization.CultureInfo culture)
        {
            Enum returnValue = default(Enum);
            if (parameter is Type)
            {
                returnValue = (Enum)Enum.Parse((Type)parameter, value.ToString());
            }
            return returnValue;
        }
    }
}
