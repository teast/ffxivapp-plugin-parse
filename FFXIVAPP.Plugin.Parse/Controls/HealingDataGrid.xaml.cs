// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HealingDataGrid.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   HealingDataGrid.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FFXIVAPP.Plugin.Parse.Properties;

namespace FFXIVAPP.Plugin.Parse.Controls {
    /// <summary>
    ///     Interaction logic for HealingDataGrid.xaml
    /// </summary>
    public partial class HealingDataGrid: DataGrid {
        public HealingDataGrid() {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            Settings.Default.PropertyChanged += (s, e) => {
                if (e.PropertyName == nameof(Settings.ShowColumnPercentOfTotalOverallHealing))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnPercentOfTotalOverallHealing;
                else if (e.PropertyName == nameof(Settings.ShowColumnPercentOfRegularHealing))
                    this.Columns[2].IsVisible = Settings.Default.ShowColumnPercentOfRegularHealing;
                else if (e.PropertyName == nameof(Settings.ShowColumnPercentOfCriticalHealing))
                    this.Columns[3].IsVisible = Settings.Default.ShowColumnPercentOfCriticalHealing;
                else if (e.PropertyName == nameof(Settings.ShowColumnTotalOverallHealing))
                    this.Columns[4].IsVisible = Settings.Default.ShowColumnTotalOverallHealing;
                else if (e.PropertyName == nameof(Settings.ShowColumnRegularHealing))
                    this.Columns[5].IsVisible = Settings.Default.ShowColumnRegularHealing;
                else if (e.PropertyName == nameof(Settings.ShowColumnCriticalHealing))
                    this.Columns[6].IsVisible = Settings.Default.ShowColumnCriticalHealing;
                else if (e.PropertyName == nameof(Settings.ShowColumnTotalHealingActionsUsed))
                    this.Columns[7].IsVisible = Settings.Default.ShowColumnTotalHealingActionsUsed;
                else if (e.PropertyName == nameof(Settings.ShowColumnHPS))
                    this.Columns[8].IsVisible = Settings.Default.ShowColumnHPS;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingRegHit))
                    this.Columns[9].IsVisible = Settings.Default.ShowColumnHealingRegHit;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingRegLow))
                    this.Columns[10].IsVisible = Settings.Default.ShowColumnHealingRegLow;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingRegHigh))
                    this.Columns[11].IsVisible = Settings.Default.ShowColumnHealingRegHigh;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingRegAverage))
                    this.Columns[12].IsVisible = Settings.Default.ShowColumnHealingRegAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingRegMod))
                    this.Columns[13].IsVisible = Settings.Default.ShowColumnHealingRegMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingRegModAverage))
                    this.Columns[14].IsVisible = Settings.Default.ShowColumnHealingRegModAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingCritHit))
                    this.Columns[15].IsVisible = Settings.Default.ShowColumnHealingCritHit;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingCritPercent))
                    this.Columns[16].IsVisible = Settings.Default.ShowColumnHealingCritPercent;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingCritLow))
                    this.Columns[17].IsVisible = Settings.Default.ShowColumnHealingCritLow;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingCritHigh))
                    this.Columns[18].IsVisible = Settings.Default.ShowColumnHealingCritHigh;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingCritAverage))
                    this.Columns[19].IsVisible = Settings.Default.ShowColumnHealingCritAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingCritMod))
                    this.Columns[20].IsVisible = Settings.Default.ShowColumnHealingCritMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingCritModAverage))
                    this.Columns[21].IsVisible = Settings.Default.ShowColumnHealingCritModAverage;
            };
        }
    }
}