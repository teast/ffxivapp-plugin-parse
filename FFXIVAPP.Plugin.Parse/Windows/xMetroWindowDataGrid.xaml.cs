// --------------------------------------------------------------------------------------------------------------------
// <copyright file="xMetroWindowDataGrid.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   xMetroWindowDataGrid.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Parse.Windows {
    using System.Collections.Generic;
    using System.Windows;
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;
    using FFXIVAPP.Common.Helpers;

    /// <summary>
    ///     Interaction logic for xMetroWindowDataGrid.xaml
    /// </summary>
    public class xMetroWindowDataGrid: BaseWindow {
        public xMetroWindowDataGrid() {
            this.InitializeComponent();
        }

        private void InitializeComponent() {
            AvaloniaXamlLoader.Load(this);
        }

        /* TODO: xMetroWindow OnLoaded event
        private void XMetroWindowDataGrid_OnLoaded(object sender, RoutedEventArgs e) {
            ThemeHelper.ChangeTheme(
                Constants.Theme,
                new List<MetroWindow> {
                    this
                });
        }
        */
    }
}