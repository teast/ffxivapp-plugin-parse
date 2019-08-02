// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CombinedHealingDataGrid.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   CombinedHealingDataGrid.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Avalonia.Markup.Xaml;

namespace FFXIVAPP.Plugin.Parse.Controls {
    /// <summary>
    ///     Interaction logic for CombinedHealingDataGrid.xaml
    /// </summary>
    public class CombinedHealingDataGrid: DataGrid {
        public CombinedHealingDataGrid() {
            this.InitializeComponent();
        }
        
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}