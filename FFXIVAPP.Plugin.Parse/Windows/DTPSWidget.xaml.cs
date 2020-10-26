// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DTPSWidget.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   DTPSWidget.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Parse.Windows
{
    using System;
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using Avalonia;
    using Avalonia.Controls;
    using Avalonia.Interactivity;
    using Avalonia.Layout;
    using Avalonia.Markup.Xaml;
    using Avalonia.VisualTree;
    using FFXIVAPP.Plugin.Parse.Interop;
    using FFXIVAPP.Plugin.Parse.Properties;

    /// <summary>
    ///     Interaction logic for DTPSWidget.xaml
    /// </summary>
    public partial class DTPSWidget: Window {
        public static DTPSWidget View;

        public DTPSWidget() {
            View = this;
            this.InitializeComponent();
            Party.DataContext = DTPSWidgetViewModel.Instance.ParseEntity.Players;
            WidgetClose.Click += WidgetClose_OnClick;
            Titlebar.PointerPressed += (s, e) =>
            {
                if (e.GetCurrentPoint(this).Properties.IsLeftButtonPressed)
                    BeginMoveDrag(e);
            };
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                WinAPI.ToggleClickThrough(this.VisualRoot);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            // TODO: This do not work in AvaloniaUI because when user tries to close main window this window will be focus and closed and user have to re-close main window again...
            //e.Cancel = true;
            //base.OnClosing(e);
            this.Hide();
        }

        /// <summary>
        /// Make sure our window is growing with its content
        /// </summary>
        protected override Size MeasureOverride(Size availableSize)
        {
            double width = this.MinWidth, height = this.MinHeight;
            for (var i = 0; i < this.VisualChildren.Count; i++)
            {
                IVisual visual = this.VisualChildren[i];
                if (visual is ILayoutable layoutable)
                {
                    layoutable.Measure(Size.Infinity);
                    width = Math.Max(layoutable.DesiredSize.Width, width);
                    height = Math.Max(layoutable.DesiredSize.Height, height);
                }
            }

            return new Size(width, height);
        }
        private void WidgetClose_OnClick(object sender, RoutedEventArgs e) {
            Settings.Default.ShowDTPSWidgetOnLoad = false;
            this.Close();
        }
 
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            LayoutRoot = this.FindControl<Grid>("LayoutRoot");
            WidgetClose = this.FindControl<Button>("WidgetClose");
            Party = this.FindControl<ItemsControl>("Party");
            Titlebar = this.FindControl<DockPanel>("Titlebar");
        }

        public DockPanel Titlebar { get; private set; }
        public Grid LayoutRoot { get; private set; }
        public Button WidgetClose { get; private set; }
        public ItemsControl Party { get; private set; }
   }
}