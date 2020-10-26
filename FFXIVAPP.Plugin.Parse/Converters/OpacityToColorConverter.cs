// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OpacityToColorConverter.cs" company="Teast">
//   Copyright(c) 2020 Niklas Jansson.
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   OpacityToColorConverter.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Media;

namespace FFXIVAPP.Plugin.Parse.Converters {
    public class OpacityToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string str && double.TryParse(str, NumberStyles.Any, CultureInfo.InvariantCulture, out var opacity))
            {
                var hex = (int)(255*opacity);
                Console.WriteLine($"opacity {opacity} == {hex} == {hex:X2}");
                var clr = Color.Parse($"#{hex:X2}FFFFFF");
                return clr;
            }

            return Color.Parse("#FFFFFFFF");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}