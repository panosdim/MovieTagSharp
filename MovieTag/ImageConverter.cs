﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace MovieTagSharp
{
    internal class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string poster = (string)value;

            return MainWindow.BaseUrl + "w92" + poster;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}