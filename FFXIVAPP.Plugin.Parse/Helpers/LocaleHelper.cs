// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocaleHelper.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   LocaleHelper.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Parse.Helpers {
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    
    using FFXIVAPP.Plugin.Parse.Localization;

    internal static class LocaleHelper {
        /// <summary>
        /// </summary>
        /// <param name="cultureInfo"> </param>
        public static Dictionary<string, string> Update(CultureInfo cultureInfo) {
            var culture = cultureInfo.TwoLetterISOLanguageName;
            Dictionary<string, string> dictionary;
            if (Constants.Supported.Contains(culture)) {
                switch (culture) {
                    case "fr":
                        dictionary = French.Context();
                        break;
                    case "ja":
                        dictionary = Japanese.Context();
                        break;
                    case "de":
                        dictionary = German.Context();
                        break;
                    case "zh":
                        dictionary = Chinese.Context();
                        break;
                    case "ru":
                        dictionary = Russian.Context();
                        break;
                    default:
                        dictionary = English.Context();
                        break;
                }
            }
            else {
                dictionary = English.Context();
            }

            var e = dictionary.ToDictionary(val => val.Key, val => val.Value);
            return e;
        }
    }
}