// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CombinedHealingDataGrid.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   CombinedHealingDataGrid.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FFXIVAPP.Plugin.Parse.Properties;

namespace FFXIVAPP.Plugin.Parse.Controls {
    /// <summary>
    ///     Interaction logic for CombinedHealingDataGrid.xaml
    /// </summary>
    public partial class CombinedHealingDataGrid: DataGrid {
        public CombinedHealingDataGrid() {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            Settings.Default.PropertyChanged += (s, e) => {
                if (e.PropertyName == nameof(Settings.ShowColumnTotalOverallHealing))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnTotalOverallHealing;
                else if (e.PropertyName == nameof(Settings.ShowColumnRegularHealing))
                    this.Columns[2].IsVisible = Settings.Default.ShowColumnRegularHealing;
                else if (e.PropertyName == nameof(Settings.ShowColumnCriticalHealing))
                    this.Columns[3].IsVisible = Settings.Default.ShowColumnCriticalHealing;
                else if (e.PropertyName == nameof(Settings.ShowColumnHPS))
                    this.Columns[4].IsVisible = Settings.Default.ShowColumnHPS;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingRegLow))
                    this.Columns[5].IsVisible = Settings.Default.ShowColumnHealingRegLow;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingRegHigh))
                    this.Columns[6].IsVisible = Settings.Default.ShowColumnHealingRegHigh;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingRegAverage))
                    this.Columns[7].IsVisible = Settings.Default.ShowColumnHealingRegAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingRegMod))
                    this.Columns[8].IsVisible = Settings.Default.ShowColumnHealingRegMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingRegModAverage))
                    this.Columns[9].IsVisible = Settings.Default.ShowColumnHealingRegModAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingCritLow))
                    this.Columns[10].IsVisible = Settings.Default.ShowColumnHealingCritLow;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingCritHigh))
                    this.Columns[11].IsVisible = Settings.Default.ShowColumnHealingCritHigh;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingCritAverage))
                    this.Columns[12].IsVisible = Settings.Default.ShowColumnHealingCritAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingCritMod))
                    this.Columns[13].IsVisible = Settings.Default.ShowColumnHealingCritMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnHealingCritModAverage))
                    this.Columns[14].IsVisible = Settings.Default.ShowColumnHealingCritModAverage;
            };
        }
    }
}