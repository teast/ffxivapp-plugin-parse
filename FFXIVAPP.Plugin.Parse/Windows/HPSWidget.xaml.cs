// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HPSWidget.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   HPSWidget.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Parse.Windows {
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Input;
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;
    using FFXIVAPP.Plugin.Parse.Interop;
    using FFXIVAPP.Plugin.Parse.Properties;

    /// <summary>
    ///     Interaction logic for HPSWidget.xaml
    /// </summary>
    public class HPSWidget: BaseWindow {
        public static HPSWidget View;

        public HPSWidget() {
            View = this;
            this.InitializeComponent();
            /* TODO: View access + WinAPI ClickThrough
            View.SourceInitialized += delegate {
                WinAPI.ToggleClickThrough(this);
            };
            */
        }

        private void InitializeComponent() {
            AvaloniaXamlLoader.Load(this);
        }

        /* TODO: LeftClick event on TitleBar
        private void TitleBar_OnPreviewMouseDown(object sender, MouseButtonEventArgs e) {
            if (Mouse.LeftButton == MouseButtonState.Pressed) {
                this.DragMove();
            }
        }
        */

        private void Widget_OnClosing(object sender, CancelEventArgs e) {
            e.Cancel = true;
            this.Hide();
        }

        /* TODO: Click on Close
        private void WidgetClose_OnClick(object sender, RoutedEventArgs e) {
            Settings.Default.ShowHPSWidgetOnLoad = false;
            this.Close();
        }
        */
    }
}