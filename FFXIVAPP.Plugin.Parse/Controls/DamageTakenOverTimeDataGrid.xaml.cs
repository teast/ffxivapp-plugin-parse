// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DamageTakenOverTimeDataGrid.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   DamageTakenOverTimeDataGrid.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FFXIVAPP.Plugin.Parse.Properties;

namespace FFXIVAPP.Plugin.Parse.Controls {
    /// <summary>
    ///     Interaction logic for DamageTakenOverTimeDataGrid.xaml
    /// </summary>
    public partial class DamageTakenOverTimeDataGrid: DataGrid {
        public DamageTakenOverTimeDataGrid() {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            Settings.Default.PropertyChanged += (s, e) => {
                if (e.PropertyName == nameof(Settings.ShowColumnPercentOfTotalOverallDamageTaken))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnPercentOfTotalOverallDamageTaken;
                else if (e.PropertyName == nameof(Settings.ShowColumnPercentOfRegularDamageTaken))
                    this.Columns[2].IsVisible = Settings.Default.ShowColumnPercentOfRegularDamageTaken;
                else if (e.PropertyName == nameof(Settings.ShowColumnPercentOfCriticalDamageTaken))
                    this.Columns[3].IsVisible = Settings.Default.ShowColumnPercentOfCriticalDamageTaken;
                else if (e.PropertyName == nameof(Settings.ShowColumnTotalOverallDamageTaken))
                    this.Columns[4].IsVisible = Settings.Default.ShowColumnTotalOverallDamageTaken;
                else if (e.PropertyName == nameof(Settings.ShowColumnRegularDamageTaken))
                    this.Columns[5].IsVisible = Settings.Default.ShowColumnRegularDamageTaken;
                else if (e.PropertyName == nameof(Settings.ShowColumnCriticalDamageTaken))
                    this.Columns[6].IsVisible = Settings.Default.ShowColumnCriticalDamageTaken;
                else if (e.PropertyName == nameof(Settings.ShowColumnTotalDamageTakenActionsUsed))
                    this.Columns[7].IsVisible = Settings.Default.ShowColumnTotalDamageTakenActionsUsed;
                else if (e.PropertyName == nameof(Settings.ShowColumnDTPS))
                    this.Columns[8].IsVisible = Settings.Default.ShowColumnDTPS;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegHit))
                    this.Columns[9].IsVisible = Settings.Default.ShowColumnDamageTakenRegHit;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegMiss))
                    this.Columns[10].IsVisible = Settings.Default.ShowColumnDamageTakenRegMiss;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegAccuracy))
                    this.Columns[11].IsVisible = Settings.Default.ShowColumnDamageTakenRegAccuracy;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegLow))
                    this.Columns[12].IsVisible = Settings.Default.ShowColumnDamageTakenRegLow;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegHigh))
                    this.Columns[13].IsVisible = Settings.Default.ShowColumnDamageTakenRegHigh;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegAverage))
                    this.Columns[14].IsVisible = Settings.Default.ShowColumnDamageTakenRegAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegMod))
                    this.Columns[15].IsVisible = Settings.Default.ShowColumnDamageTakenRegMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegModAverage))
                    this.Columns[16].IsVisible = Settings.Default.ShowColumnDamageTakenRegModAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritHit))
                    this.Columns[17].IsVisible = Settings.Default.ShowColumnDamageTakenCritHit;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritPercent))
                    this.Columns[18].IsVisible = Settings.Default.ShowColumnDamageTakenCritPercent;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritLow))
                    this.Columns[19].IsVisible = Settings.Default.ShowColumnDamageTakenCritLow;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritHigh))
                    this.Columns[20].IsVisible = Settings.Default.ShowColumnDamageTakenCritHigh;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritAverage))
                    this.Columns[21].IsVisible = Settings.Default.ShowColumnDamageTakenCritAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritMod))
                    this.Columns[22].IsVisible = Settings.Default.ShowColumnDamageTakenCritMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritModAverage))
                    this.Columns[23].IsVisible = Settings.Default.ShowColumnDamageTakenCritModAverage;
            };
        }
    }
}