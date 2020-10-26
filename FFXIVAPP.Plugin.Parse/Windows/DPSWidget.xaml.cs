// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DPSWidget.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   DPSWidget.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Parse.Windows
{
    using System.Runtime.InteropServices;
    using Avalonia.Controls;
    using Avalonia.Interactivity;
    using Avalonia.Markup.Xaml;
    using FFXIVAPP.Plugin.Parse.Interop;
    using FFXIVAPP.Plugin.Parse.Properties;

    /// <summary>
    ///     Interaction logic for DPSWidget.xaml
    /// </summary>
    public partial class DPSWidget: Window {
        public static DPSWidget View;

        public DPSWidget() {
            View = this;
            this.InitializeComponent();

            Party.DataContext = DPSWidgetViewModel.Instance.ParseEntity.Players;
            WidgetClose.Click += WidgetClose_OnClick;
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                WinAPI.ToggleClickThrough(this.VisualRoot);
        }

        /* TODO: Implement this
        private void TitleBar_OnPreviewMouseDown(object sender, MouseButtonEventArgs e) {
            if (Mouse.LeftButton == MouseButtonState.Pressed) {
                this.DragMove();
            }
        }
        */

        /* TODO: Implement this
        private void Widget_OnClosing(object sender, CancelEventArgs e) {
            e.Cancel = true;
            this.Hide();
        }
        */

        private void WidgetClose_OnClick(object sender, RoutedEventArgs e) {
            Settings.Default.ShowDPSWidgetOnLoad = false;
            this.Close();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            LayoutRoot = this.FindControl<Grid>("LayoutRoot");
            WidgetClose = this.FindControl<Button>("WidgetClose");
            Party = this.FindControl<ItemsControl>("Party");
        }

        public Grid LayoutRoot { get; private set; }
        public Button WidgetClose { get; private set; }
        public ItemsControl Party { get; private set; }
    }
}