// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SettingsViewModel.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   SettingsViewModel.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Parse.ViewModels {
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;

    using FFXIVAPP.Common.ViewModelBase;
    using FFXIVAPP.Plugin.Parse.Properties;

    internal sealed class SettingsViewModel : INotifyPropertyChanged {
        private static Lazy<SettingsViewModel> _instance = new Lazy<SettingsViewModel>(() => new SettingsViewModel());

        public SettingsViewModel() {
            this.ResetDPSWidgetCommand = new DelegateCommand(this.ResetDPSWidget);
            this.OpenDPSWidgetCommand = new DelegateCommand(this.OpenDPSWidget);
            this.ResetDTPSWidgetCommand = new DelegateCommand(this.ResetDTPSWidget);
            this.OpenDTPSWidgetCommand = new DelegateCommand(this.OpenDTPSWidget);
            this.ResetHPSWidgetCommand = new DelegateCommand(this.ResetHPSWidget);
            this.OpenHPSWidgetCommand = new DelegateCommand(this.OpenHPSWidget);
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public static SettingsViewModel Instance {
            get {
                return _instance.Value;
            }
        }

        public ICommand OpenDPSWidgetCommand { get; private set; }

        public ICommand OpenDTPSWidgetCommand { get; private set; }

        public ICommand OpenHPSWidgetCommand { get; private set; }

        public ICommand ResetDPSWidgetCommand { get; private set; }

        public ICommand ResetDTPSWidgetCommand { get; private set; }

        public ICommand ResetHPSWidgetCommand { get; private set; }

        public void OpenDPSWidget() {
            Settings.Default.ShowDPSWidgetOnLoad = true;
            Widgets.Instance.ShowDPSWidget();
        }

        public void OpenDTPSWidget() {
            Settings.Default.ShowDTPSWidgetOnLoad = true;
            Widgets.Instance.ShowDTPSWidget();
        }

        public void OpenHPSWidget() {
            Settings.Default.ShowHPSWidgetOnLoad = true;
            Widgets.Instance.ShowHPSWidget();
        }

        public void ResetDPSWidget() {
            Settings.Default.DPSWidgetUIScale = Settings.Default.Properties.DPSWidgetUIScale;
            Settings.Default.DPSWidgetTop = Settings.Default.Properties.DPSWidgetTop;
            Settings.Default.DPSWidgetLeft = Settings.Default.Properties.DPSWidgetLeft;
            Settings.Default.DPSWidgetHeight = Settings.Default.Properties.DPSWidgetHeight;
            Settings.Default.DPSWidgetWidth = Settings.Default.Properties.DPSWidgetWidth;
            Settings.Default.DPSVisibility = Settings.Default.Properties.DPSVisibility;
            Settings.Default.DPSWidgetSortDirection = Settings.Default.Properties.DPSWidgetSortDirection;
            Settings.Default.DPSWidgetSortProperty = Settings.Default.Properties.DPSWidgetSortProperty;
        }

        public void ResetDTPSWidget() {
            Settings.Default.DTPSWidgetUIScale = Settings.Default.Properties.DTPSWidgetUIScale;
            Settings.Default.DTPSWidgetTop = Settings.Default.Properties.DTPSWidgetTop;
            Settings.Default.DTPSWidgetLeft = Settings.Default.Properties.DTPSWidgetLeft;
            Settings.Default.DTPSWidgetHeight = Settings.Default.Properties.DTPSWidgetHeight;
            Settings.Default.DTPSWidgetWidth = Settings.Default.Properties.DTPSWidgetWidth;
            Settings.Default.DTPSVisibility = Settings.Default.Properties.DTPSVisibility;
            Settings.Default.DTPSWidgetSortDirection = Settings.Default.Properties.DTPSWidgetSortDirection;
            Settings.Default.DTPSWidgetSortProperty = Settings.Default.Properties.DTPSWidgetSortProperty;
        }

        public void ResetHPSWidget() {
            Settings.Default.HPSWidgetUIScale = Settings.Default.Properties.HPSWidgetUIScale;
            Settings.Default.HPSWidgetTop = Settings.Default.Properties.HPSWidgetTop;
            Settings.Default.HPSWidgetLeft = Settings.Default.Properties.HPSWidgetLeft;
            Settings.Default.HPSWidgetHeight = Settings.Default.Properties.HPSWidgetHeight;
            Settings.Default.HPSWidgetWidth = Settings.Default.Properties.HPSWidgetWidth;
            Settings.Default.HPSVisibility = Settings.Default.Properties.HPSVisibility;
            Settings.Default.HPSWidgetSortDirection = Settings.Default.Properties.HPSWidgetSortDirection;
            Settings.Default.HPSWidgetSortProperty = Settings.Default.Properties.HPSWidgetSortProperty;
        }

        private void RaisePropertyChanged([CallerMemberName] string caller = "") {
            this.PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }
    }
}