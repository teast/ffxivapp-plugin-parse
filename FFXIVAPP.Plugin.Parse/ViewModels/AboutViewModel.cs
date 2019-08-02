// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AboutViewModel.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   AboutViewModel.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Parse.ViewModels {
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using FFXIVAPP.Common.Models;
    using FFXIVAPP.Common.ViewModelBase;

    internal sealed class AboutViewModel : INotifyPropertyChanged {
        private static Lazy<AboutViewModel> _instance = new Lazy<AboutViewModel>(() => new AboutViewModel());

        public AboutViewModel() {
            this.OpenWebSiteCommand = new DelegateCommand(this.OpenWebSite);
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public static AboutViewModel Instance {
            get {
                return _instance.Value;
            }
        }

        public DelegateCommand OpenWebSiteCommand { get; private set; }

        public void OpenWebSite() {
            try {
                var url = "https://github.com/FFXIVAPP/ffxivapp-plugin-parse";
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
            }
            catch (Exception ex) {
                var popupContent = new PopupContent();
                popupContent.Title = PluginViewModel.Instance.Locale["app_WarningMessage"];
                popupContent.Message = ex.Message;
                Plugin.PHost.PopupMessage(Plugin.PName, popupContent);
            }
        }

        private void RaisePropertyChanged([CallerMemberName] string caller = "") {
            this.PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }
    }
}