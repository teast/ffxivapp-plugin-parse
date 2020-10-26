// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CombinedDamageTakenDataGrid.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   CombinedDamageTakenDataGrid.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FFXIVAPP.Plugin.Parse.Properties;

namespace FFXIVAPP.Plugin.Parse.Controls {
    /// <summary>
    ///     Interaction logic for CombinedDamageTakenDataGrid.xaml
    /// </summary>
    public partial class CombinedDamageTakenDataGrid: DataGrid {
        public CombinedDamageTakenDataGrid() {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            Settings.Default.PropertyChanged += (s, e) => {
                if (e.PropertyName == nameof(Settings.ShowColumnTotalOverallDamageTaken))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnTotalOverallDamageTaken;
                else if (e.PropertyName == nameof(Settings.ShowColumnRegularDamageTaken))
                    this.Columns[2].IsVisible = Settings.Default.ShowColumnRegularDamageTaken;
                else if (e.PropertyName == nameof(Settings.ShowColumnCriticalDamageTaken))
                    this.Columns[3].IsVisible = Settings.Default.ShowColumnCriticalDamageTaken;
                else if (e.PropertyName == nameof(Settings.ShowColumnDTPS))
                    this.Columns[4].IsVisible = Settings.Default.ShowColumnDTPS;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegLow))
                    this.Columns[5].IsVisible = Settings.Default.ShowColumnDamageTakenRegLow;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegHigh))
                    this.Columns[6].IsVisible = Settings.Default.ShowColumnDamageTakenRegHigh;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegAverage))
                    this.Columns[7].IsVisible = Settings.Default.ShowColumnDamageTakenRegAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegMod))
                    this.Columns[8].IsVisible = Settings.Default.ShowColumnDamageTakenRegMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegModAverage))
                    this.Columns[9].IsVisible = Settings.Default.ShowColumnDamageTakenRegModAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritLow))
                    this.Columns[10].IsVisible = Settings.Default.ShowColumnDamageTakenCritLow;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritHigh))
                    this.Columns[11].IsVisible = Settings.Default.ShowColumnDamageTakenCritHigh;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritAverage))
                    this.Columns[12].IsVisible = Settings.Default.ShowColumnDamageTakenCritAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritMod))
                    this.Columns[13].IsVisible = Settings.Default.ShowColumnDamageTakenCritMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritModAverage))
                    this.Columns[14].IsVisible = Settings.Default.ShowColumnDamageTakenCritModAverage;
            };
        }
    }
}