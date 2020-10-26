// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DamageDataGrid.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   DamageDataGrid.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FFXIVAPP.Plugin.Parse.Properties;

namespace FFXIVAPP.Plugin.Parse.Controls {
    /// <summary>
    ///     Interaction logic for DamageDataGrid.xaml
    /// </summary>
    public partial class DamageDataGrid: DataGrid {
        public DamageDataGrid() {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            Settings.Default.PropertyChanged += (s, e) => {
                if (e.PropertyName == nameof(Settings.ShowColumnPercentOfTotalOverallDamage))
                    this.Columns[1].IsVisible = Settings.Default.ShowColumnPercentOfTotalOverallDamage;
                else if (e.PropertyName == nameof(Settings.ShowColumnPercentOfRegularDamage))
                    this.Columns[2].IsVisible = Settings.Default.ShowColumnPercentOfRegularDamage;
                else if (e.PropertyName == nameof(Settings.ShowColumnPercentOfCriticalDamage))
                    this.Columns[3].IsVisible = Settings.Default.ShowColumnPercentOfCriticalDamage;
                else if (e.PropertyName == nameof(Settings.ShowColumnTotalOverallDamage))
                    this.Columns[4].IsVisible = Settings.Default.ShowColumnTotalOverallDamage;
                else if (e.PropertyName == nameof(Settings.ShowColumnRegularDamage))
                    this.Columns[5].IsVisible = Settings.Default.ShowColumnRegularDamage;
                else if (e.PropertyName == nameof(Settings.ShowColumnCriticalDamage))
                    this.Columns[6].IsVisible = Settings.Default.ShowColumnCriticalDamage;
                else if (e.PropertyName == nameof(Settings.ShowColumnTotalDamageActionsUsed))
                    this.Columns[7].IsVisible = Settings.Default.ShowColumnTotalDamageActionsUsed;
                else if (e.PropertyName == nameof(Settings.ShowColumnDPS))
                    this.Columns[8].IsVisible = Settings.Default.ShowColumnDPS;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageRegHit))
                    this.Columns[9].IsVisible = Settings.Default.ShowColumnDamageRegHit;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageRegMiss))
                    this.Columns[10].IsVisible = Settings.Default.ShowColumnDamageRegMiss;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageRegAccuracy))
                    this.Columns[11].IsVisible = Settings.Default.ShowColumnDamageRegAccuracy;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageRegLow))
                    this.Columns[12].IsVisible = Settings.Default.ShowColumnDamageRegLow;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageRegHigh))
                    this.Columns[13].IsVisible = Settings.Default.ShowColumnDamageRegHigh;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageRegAverage))
                    this.Columns[14].IsVisible = Settings.Default.ShowColumnDamageRegAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageRegMod))
                    this.Columns[15].IsVisible = Settings.Default.ShowColumnDamageRegMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageRegModAverage))
                    this.Columns[16].IsVisible = Settings.Default.ShowColumnDamageRegModAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageCritHit))
                    this.Columns[17].IsVisible = Settings.Default.ShowColumnDamageCritHit;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageCritPercent))
                    this.Columns[18].IsVisible = Settings.Default.ShowColumnDamageCritPercent;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageCritLow))
                    this.Columns[19].IsVisible = Settings.Default.ShowColumnDamageCritLow;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageCritHigh))
                    this.Columns[20].IsVisible = Settings.Default.ShowColumnDamageCritHigh;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageCritAverage))
                    this.Columns[21].IsVisible = Settings.Default.ShowColumnDamageCritAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageCritMod))
                    this.Columns[22].IsVisible = Settings.Default.ShowColumnDamageCritMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageCritModAverage))
                    this.Columns[23].IsVisible = Settings.Default.ShowColumnDamageCritModAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageCounter))
                    this.Columns[24].IsVisible = Settings.Default.ShowColumnDamageCounter;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageCounterPercent))
                    this.Columns[25].IsVisible = Settings.Default.ShowColumnDamageCounterPercent;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageCounterMod))
                    this.Columns[26].IsVisible = Settings.Default.ShowColumnDamageCounterMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageCounterModAverage))
                    this.Columns[27].IsVisible = Settings.Default.ShowColumnDamageCounterModAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageBlock))
                    this.Columns[28].IsVisible = Settings.Default.ShowColumnDamageBlock;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageBlockPercent))
                    this.Columns[29].IsVisible = Settings.Default.ShowColumnDamageBlockPercent;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageBlockMod))
                    this.Columns[30].IsVisible = Settings.Default.ShowColumnDamageBlockMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageBlockModAverage))
                    this.Columns[31].IsVisible = Settings.Default.ShowColumnDamageBlockModAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageParry))
                    this.Columns[32].IsVisible = Settings.Default.ShowColumnDamageParry;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageParryPercent))
                    this.Columns[33].IsVisible = Settings.Default.ShowColumnDamageParryPercent;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageParryMod))
                    this.Columns[34].IsVisible = Settings.Default.ShowColumnDamageParryMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageParryModAverage))
                    this.Columns[35].IsVisible = Settings.Default.ShowColumnDamageParryModAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageResist))
                    this.Columns[36].IsVisible = Settings.Default.ShowColumnDamageResist;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageResistPercent))
                    this.Columns[37].IsVisible = Settings.Default.ShowColumnDamageResistPercent;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageResistMod))
                    this.Columns[38].IsVisible = Settings.Default.ShowColumnDamageResistMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageResistModAverage))
                    this.Columns[39].IsVisible = Settings.Default.ShowColumnDamageResistModAverage;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageEvade))
                    this.Columns[40].IsVisible = Settings.Default.ShowColumnDamageEvade;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageEvadePercent))
                    this.Columns[41].IsVisible = Settings.Default.ShowColumnDamageEvadePercent;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageEvadeMod))
                    this.Columns[42].IsVisible = Settings.Default.ShowColumnDamageEvadeMod;
                else if (e.PropertyName == nameof(Settings.ShowColumnDamageEvadeModAverage))
                    this.Columns[43].IsVisible = Settings.Default.ShowColumnDamageEvadeModAverage;
};
        }
    }
}