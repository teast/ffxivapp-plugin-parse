// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringToBrushConverter.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   StringToBrushConverter.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Parse.Converters {
    using System;
    using System.Globalization;
    using System.Linq;
    using Avalonia.Data.Converters;
    using Avalonia.Media;
    using FFXIVAPP.Common.Models;
    using FFXIVAPP.Common.Utilities;
    using FFXIVAPP.Plugin.Parse.Properties;

    using NLog;

    public class StringToBrushConverter : IValueConverter {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            var param = "DEFAULT";
            try {
                param = value.ToString().ToUpperInvariant();
            }
            catch (Exception ex) {
                Logging.Log(Logger, new LogItem(ex, true));
            }

            ISolidColorBrush brush = ColorStringToBrush(Settings.Default.DefaultProgressBarForeground);
            switch (param) {
                case "PLD":
                    brush = ColorStringToBrush(Settings.Default.PLDProgressBarForeground);
                    break;
                case "DRG":
                    brush = ColorStringToBrush(Settings.Default.DRGProgressBarForeground);
                    break;
                case "BLM":
                    brush = ColorStringToBrush(Settings.Default.BLMProgressBarForeground);
                    break;
                case "WAR":
                    brush = ColorStringToBrush(Settings.Default.WARProgressBarForeground);
                    break;
                case "WHM":
                    brush = ColorStringToBrush(Settings.Default.WHMProgressBarForeground);
                    break;
                case "SCH":
                    brush = ColorStringToBrush(Settings.Default.SCHProgressBarForeground);
                    break;
                case "MNK":
                    brush = ColorStringToBrush(Settings.Default.MNKProgressBarForeground);
                    break;
                case "BRD":
                    brush = ColorStringToBrush(Settings.Default.BRDProgressBarForeground);
                    break;
                case "SMN":
                    brush = ColorStringToBrush(Settings.Default.SMNProgressBarForeground);
                    break;
            }

            return brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }

        private static ISolidColorBrush ColorStringToBrush(string color) {
            Func<char, bool> isHex = c => (c >= '0' && c <= '9') ||
                                          (c >= 'a' && c <= 'f') ||
                                          (c >= 'A' && c <= 'F');
            if (color?.Length == 8 && color[0] != '#' && color.All(isHex)) {
                color = "#" + color;
            }

            try {
                return new SolidColorBrush(Color.Parse(color));
            }
            catch (Exception ex) {
                Logging.Log(Logger, new LogItem(ex, true));
            }

            try {
                switch (color.Length) {
                    case 8:
                        return new SolidColorBrush(Color.FromArgb(byte.Parse(color.Substring(0, 2), NumberStyles.HexNumber), byte.Parse(color.Substring(2, 2), NumberStyles.HexNumber), byte.Parse(color.Substring(4, 2), NumberStyles.HexNumber), byte.Parse(color.Substring(6, 2), NumberStyles.HexNumber)));
                    case 6:
                        return new SolidColorBrush(Color.FromRgb(byte.Parse(color.Substring(0, 2), NumberStyles.HexNumber), byte.Parse(color.Substring(2, 2), NumberStyles.HexNumber), byte.Parse(color.Substring(4, 2), NumberStyles.HexNumber)));
                    default:
                        return Brushes.Green;
                }
            }
            catch (Exception) {
                return Brushes.Green;
            }
        }
    }
}