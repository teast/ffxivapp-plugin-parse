// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AboutView.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   AboutView.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FFXIVAPP.Plugin.Parse.Views {
    /// <summary>
    ///     Interaction logic for AboutView.xaml
    /// </summary>
    public class AboutView: BaseUserControl {
        public static AboutView View;

        public AboutView() {
            this.InitializeComponent();
            View = this;
        }

        private void InitializeComponent() {
            AvaloniaXamlLoader.Load(this);
        }
    }
}