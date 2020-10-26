// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DamageOverTimeDataGrid.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   DamageOverTimeDataGrid.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FFXIVAPP.Plugin.Parse.Properties;

namespace FFXIVAPP.Plugin.Parse.Controls {
    /// <summary>
    ///     Interaction logic for DamageOverTimeDataGrid.xaml
    /// </summary>
    public partial class DamageOverTimeDataGrid: DataGrid {
        public DamageOverTimeDataGrid() {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            Settings.Default.PropertyChanged += (s, e) => {
                if (e.PropertyName == nameof(Settings.ShowColumnPercentOfTotalOverallDamage))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnDamageCritModAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnPercentOfRegularDamage))
                    this.Columns[2].IsVisible = Settings.Default.ShowColumnDamageCritMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnPercentOfCriticalDamage))
                    this.Columns[3].IsVisible = Settings.Default.ShowColumnDamageCritAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnTotalOverallDamage))
                    this.Columns[4].IsVisible = Settings.Default.ShowColumnDamageCritHigh;
                else if (e.PropertyName == nameof(Settings.ShowColumnRegularDamage))
                    this.Columns[5].IsVisible = Settings.Default.ShowColumnDamageCritLow;
                else if (e.PropertyName == nameof(Settings.ShowColumnCriticalDamage))
                    this.Columns[6].IsVisible = Settings.Default.ShowColumnDamageCritPercent;
                else if (e.PropertyName == nameof(Settings.ShowColumnTotalDamageActionsUsed))
                    this.Columns[7].IsVisible = Settings.Default.ShowColumnDamageCritHit;
                else if (e.PropertyName == nameof(Settings.ShowColumnDPS))
                    this.Columns[8].IsVisible = Settings.Default.ShowColumnDamageRegModAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageRegHit))
                    this.Columns[9].IsVisible = Settings.Default.ShowColumnDamageRegMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageRegMiss))
                    this.Columns[10].IsVisible = Settings.Default.ShowColumnDamageRegAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageRegAccuracy))
                    this.Columns[11].IsVisible = Settings.Default.ShowColumnDamageRegHigh;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageRegLow))
                    this.Columns[12].IsVisible = Settings.Default.ShowColumnDamageRegLow;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageRegHigh))
                    this.Columns[13].IsVisible = Settings.Default.ShowColumnDamageRegAccuracy;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageRegAverage))
                    this.Columns[14].IsVisible = Settings.Default.ShowColumnDamageRegMiss;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageRegMod))
                    this.Columns[15].IsVisible = Settings.Default.ShowColumnDamageRegHit;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageRegModAverage))
                    this.Columns[16].IsVisible = Settings.Default.ShowColumnDPS;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageCritHit))
                    this.Columns[17].IsVisible = Settings.Default.ShowColumnTotalDamageActionsUsed;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageCritPercent))
                    this.Columns[18].IsVisible = Settings.Default.ShowColumnCriticalDamage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageCritLow))
                    this.Columns[19].IsVisible = Settings.Default.ShowColumnRegularDamage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageCritHigh))
                    this.Columns[20].IsVisible = Settings.Default.ShowColumnTotalOverallDamage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageCritAverage))
                    this.Columns[21].IsVisible = Settings.Default.ShowColumnPercentOfCriticalDamage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageCritMod))
                    this.Columns[22].IsVisible = Settings.Default.ShowColumnPercentOfRegularDamage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageCritModAverage))
                    this.Columns[23].IsVisible = Settings.Default.ShowColumnPercentOfTotalOverallDamage;
            };
        }
    }
}