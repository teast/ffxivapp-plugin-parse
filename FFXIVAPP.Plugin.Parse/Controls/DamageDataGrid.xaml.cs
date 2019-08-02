// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DamageDataGrid.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   DamageDataGrid.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Avalonia.Markup.Xaml;

namespace FFXIVAPP.Plugin.Parse.Controls {
    /// <summary>
    ///     Interaction logic for DamageDataGrid.xaml
    /// </summary>
    public class DamageDataGrid: DataGrid {
        public DamageDataGrid() {
            this.InitializeComponent();
        }
        
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}