// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DPSWidget.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   DPSWidget.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Parse.Windows {
    using System;
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Input;
    using Avalonia;
    using Avalonia.Controls;
    using Avalonia.Input;
    using Avalonia.Interactivity;
    using Avalonia.Markup.Xaml;
    using FFXIVAPP.Plugin.Parse.Helpers;
    using FFXIVAPP.Plugin.Parse.Interop;
    using FFXIVAPP.Plugin.Parse.Properties;

    /// <summary>
    ///     Interaction logic for DPSWidget.xaml
    /// </summary>
    public class DPSWidget: BaseWindow {
        public static DPSWidget View;
        private CustomDragHelper dragable;

        public DPSWidget() {
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

            this.FindControl<Button>("WidgetClose").Click += WidgetClose_OnClick;
            var titleBar = this.FindControl<DockPanel>("TitleBar");
            titleBar.PointerPressed += delegate
            {
                PlatformImpl?.BeginMoveDrag();
            };
        }

        private void WidgetClose_OnClick(object sender, RoutedEventArgs e) {
            System.Console.WriteLine("Hello2 onClosing");
            Settings.Default.ShowDPSWidgetOnLoad = false;
            this.Hide();
        }
    }
}