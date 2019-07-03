﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Kefka.Utilities
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility rv = Visibility.Visible;
            try
            {
                if (value != null)
                {
                    rv = (bool)value ? Visibility.Visible : Visibility.Collapsed;
                }
            }
            catch (Exception)
            {
                // ignored
            }
            return rv;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value != null) && (value == (object)Visibility.Visible);
        }
    }
}