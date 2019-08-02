using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using FFXIVAPP.Common.Models;
using FFXIVAPP.Common.Utilities;
using Newtonsoft.Json;
using NLog;

namespace FFXIVAPP.Plugin.Parse.Properties
{
    public class Settings
    {
        private static string settingsPath;

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private static Lazy<SettingsModel> _default = new Lazy<SettingsModel>(() => {
            if (string.IsNullOrEmpty(settingsPath)) {
                settingsPath = Path.Combine(Common.Constants.PluginsSettingsPath, "FFXIVAPP.Plugin.Parse.json");
            }

            var config = new SettingsModel();
            if (File.Exists(settingsPath)) {
                config = JsonConvert.DeserializeObject<SettingsModel>(File.ReadAllText(settingsPath));
            }

            return config;
        });

        public static SettingsModel Default => _default.Value;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        [Obsolete("Try not to use this. instead set property directly")]
        public object this[string propertyName]
        {
            get
            {
                var prop = this.GetType().GetProperty(propertyName);
                return prop.GetValue(this);
            }
            set
            {
                var prop = this.GetType().GetProperty(propertyName);
                prop.SetValue(this, value, null);
            }
        }

        [Obsolete("Try not to use this. instead set property directly")]
        public static void SetValue(string key, string value, CultureInfo cultureInfo) {
            try {
                /*
                var type = Default[key].GetType().Name;
                switch (type) {
                    case "Boolean":
                        Default[key] = bool.Parse(value);
                        break;
                    case "Color":
                        var cc = new ColorConverter();
                        object color = cc.ConvertFrom(value);
                        Default[key] = color ?? Colors.Black;
                        break;
                    case "Double":
                        Default[key] = double.Parse(value, cultureInfo);
                        break;
                    case "Font":
                        var fc = new FontConverter();
                        object font = fc.ConvertFromString(value);
                        Default[key] = font ?? new Font(new FontFamily("Microsoft Sans Serif"), 12);
                        break;
                    case "Int32":
                        Default[key] = int.Parse(value, cultureInfo);
                        break;
                    default:
                        Default[key] = value;
                        break;
                }
                */
            }
            catch (Exception ex) {
                Logging.Log(Logger, new LogItem(ex, true));
            }
        }

        public void Reset() {
            //_default = new Lazy<Settings>(() => new Settings());
            Default.DefaultSettings();
        }

        public static void Save() {
            File.WriteAllText(settingsPath, JsonConvert.SerializeObject(Default, Formatting.Indented));
        }

        private void RaisePropertyChanged([CallerMemberName] string caller = "") {
            this.PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }

        private void SaveSettingsNode() {
            /* TODO: SavesettingsNode, switch over to json
            if (Constants.XSettings == null) {
                return;
            }

            IEnumerable<XElement> xElements = Constants.XSettings.Descendants().Elements("Setting");
            XElement[] enumerable = xElements as XElement[] ?? xElements.ToArray();
            foreach (var setting in Constants.Settings) {
                XElement element = enumerable.FirstOrDefault(e => e.Attribute("Key").Value == setting);
                var xKey = setting;
                if (Default[xKey] == null) {
                    continue;
                }

                if (element == null) {
                    var xValue = Default[xKey].ToString();
                    List<XValuePair> keyPairList = new List<XValuePair> {
                        new XValuePair {
                            Key = "Value",
                            Value = xValue
                        }
                    };
                    XmlHelper.SaveXmlNode(Constants.XSettings, "Settings", "Setting", xKey, keyPairList);
                }
                else {
                    XElement xElement = element.Element("Value");
                    if (xElement != null) {
                        xElement.Value = Default[setting].ToString();
                    }
                }
            }
            */
        }
    }
}