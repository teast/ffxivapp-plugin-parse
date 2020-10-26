// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Widgets.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   Widgets.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Parse {
    using System;
    using Avalonia;
    using Avalonia.Controls.ApplicationLifetimes;
    using FFXIVAPP.Common.Models;
    using FFXIVAPP.Common.Utilities;
    using FFXIVAPP.Plugin.Parse.Windows;

    using NLog;

    public class Widgets {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private static Lazy<Widgets> _instance = new Lazy<Widgets>(() => new Widgets());

        private DPSWidget _dpsWidget;

        private DTPSWidget _dtpsWidget;

        private HPSWidget _hpsWidget;

        public static Widgets Instance {
            get {
                return _instance.Value;
            }
        }

        public DPSWidget DPSWidget {
            get {
                return this._dpsWidget ?? (this._dpsWidget = new DPSWidget());
            }
        }

        public DTPSWidget DTPSWidget {
            get {
                return this._dtpsWidget ?? (this._dtpsWidget = new DTPSWidget());
            }
        }

        public HPSWidget HPSWidget {
            get {
                return this._hpsWidget ?? (this._hpsWidget = new HPSWidget());
            }
        }

        public void ShowDPSWidget() {
            try {
                var mainWindow = (Avalonia.Application.Current.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime)?.MainWindow;
                this.DPSWidget.Show(mainWindow);
            }
            catch (Exception ex) {
                Logging.Log(Logger, new LogItem(ex, true));
            }
        }

        public void ShowDTPSWidget() {
            try {
                var mainWindow = (Avalonia.Application.Current.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime)?.MainWindow;
                this.DTPSWidget.Show(mainWindow);
            }
            catch (Exception ex) {
                Logging.Log(Logger, new LogItem(ex, true));
            }
        }

        public void ShowHPSWidget() {
            try {
                var mainWindow = (Avalonia.Application.Current.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime)?.MainWindow;
                this.HPSWidget.Show(mainWindow);
            }
            catch (Exception ex) {
                Logging.Log(Logger, new LogItem(ex, true));
            }
        }
    }
}