// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainView.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   MainView.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FFXIVAPP.Plugin.Parse.ViewModels;

namespace FFXIVAPP.Plugin.Parse.Views {
    /// <summary>
    ///     Interaction logic for MainView.xaml
    /// </summary>
    public class MainView: BaseUserControl {
        public static MainView View;

        public DropDown InfoViewType { get; set; }

        public TabControl InfoViewResults { get; set; }

        public MainView() {
            this.InitializeComponent();
            View = this;
            this.InfoViewType = this.FindControl<DropDown>("InfoViewType");
            this.InfoViewResults = this.FindControl<TabControl>("InfoViewResults");
            var advanced = this.FindControl<CheckBox>("ShowHideAdvanced");
            var grid = this.FindControl<Grid>("MainGrid");
            var advCol = grid.ColumnDefinitions.First();
            var defaultWidth = advCol.MinWidth;

            ShowHideAdvanced(advanced.IsChecked ?? false, advCol, defaultWidth);
            advanced.PropertyChanged += (o ,e) => {
                if (e.Property.Name == nameof(CheckBox.IsChecked)) {
                    ShowHideAdvanced((e.NewValue is bool) && ((bool)e.NewValue) == true, advCol, defaultWidth);
                }
            };
        }

        private void ShowHideAdvanced(bool chk, ColumnDefinition column, double visibleWidth)
        {
            if (chk) {
                column.MinWidth = column.MaxWidth = visibleWidth;
            }
            else {
                column.MinWidth = column.MaxWidth = 0;
            }
        }

        private void InitializeComponent() {
            AvaloniaXamlLoader.Load(this);
        }
    }
}