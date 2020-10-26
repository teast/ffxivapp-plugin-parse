// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DamageTakenDataGrid.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   DamageTakenDataGrid.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FFXIVAPP.Plugin.Parse.Properties;

namespace FFXIVAPP.Plugin.Parse.Controls {
    /// <summary>
    ///     Interaction logic for DamageTakenDataGrid.xaml
    /// </summary>
    public partial class DamageTakenDataGrid: DataGrid {
        public DamageTakenDataGrid() {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            Settings.Default.PropertyChanged += (s, e) => {
                if (e.PropertyName == nameof(Settings.ShowColumnPercentOfTotalOverallDamageTaken))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnPercentOfTotalOverallDamageTaken;
                else if (e.PropertyName == nameof(Settings.ShowColumnPercentOfRegularDamageTaken))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnPercentOfRegularDamageTaken;
                else if (e.PropertyName == nameof(Settings.ShowColumnPercentOfCriticalDamageTaken))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnPercentOfCriticalDamageTaken;
                else if (e.PropertyName == nameof(Settings.ShowColumnTotalOverallDamageTaken))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnTotalOverallDamageTaken;
                else if (e.PropertyName == nameof(Settings.ShowColumnRegularDamageTaken))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnRegularDamageTaken;
                else if (e.PropertyName == nameof(Settings.ShowColumnCriticalDamageTaken))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnCriticalDamageTaken;
                else if (e.PropertyName == nameof(Settings.ShowColumnTotalDamageTakenActionsUsed))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnTotalDamageTakenActionsUsed;
                else if (e.PropertyName == nameof(Settings.ShowColumnDTPS))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDTPS;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegHit))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenRegHit;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegMiss))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenRegMiss;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegAccuracy))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenRegAccuracy;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegLow))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenRegLow;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegHigh))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenRegHigh;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegAverage))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenRegAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegMod))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenRegMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenRegModAverage))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenRegModAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritHit))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenCritHit;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritPercent))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenCritPercent;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritLow))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenCritLow;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritHigh))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenCritHigh;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritAverage))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenCritAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritMod))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenCritMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCritModAverage))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenCritModAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCounter))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenCounter;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCounterPercent))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenCounterPercent;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCounterMod))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenCounterMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenCounterModAverage))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenCounterModAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenBlock))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenBlock;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenBlockPercent))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenBlockPercent;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenBlockMod))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenBlockMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenBlockModAverage))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenBlockModAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenParry))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenParry;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenParryPercent))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenParryPercent;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenParryMod))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenParryMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenParryModAverage))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenParryModAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenResist))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenResist;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenResistPercent))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenResistPercent;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenResistMod))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenResistMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenResistModAverage))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenResistModAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenEvade))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenEvade;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenEvadePercent))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenEvadePercent;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenEvadeMod))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenEvadeMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageTakenEvadeModAverage))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageTakenEvadeModAverage;
            };
        }
    }
}