// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShellView.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   ShellView.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FFXIVAPP.Plugin.Parse {
    /// <summary>
    ///     Interaction logic for ShellView.xaml
    /// </summary>
    public class ShellView: BaseUserControl {
        public static ShellView View;

        public ShellView() {
            this.InitializeComponent();
            View = this;
        }

        public override void EndInit()
        {
            base.EndInit();
            // TODO: Me testing to get ParseControl active...
            Models.ParseControl.Instance.Reset();
        }


        private void InitializeComponent()
        {
            this.DataContext = PluginViewModel.Instance;
            AvaloniaXamlLoader.Load(this);
        }
    }
}