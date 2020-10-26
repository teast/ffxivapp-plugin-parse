﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ColumnDisplaySettings.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   ColumnDisplaySettings.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FFXIVAPP.Plugin.Parse.Controls {
    /// <summary>
    ///     Interaction logic for BasicCardSettings.xaml
    /// </summary>
    public partial class ColumnDisplaySettings: StackPanel {
        public ColumnDisplaySettings() {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}