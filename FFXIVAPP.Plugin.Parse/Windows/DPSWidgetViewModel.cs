// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DPSWidgetViewModel.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   DPSWidgetViewModel.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Parse.Windows {
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using FFXIVAPP.Plugin.Parse.Models;

    internal sealed class DPSWidgetViewModel : INotifyPropertyChanged {
        private static Lazy<DPSWidgetViewModel> _instance = new Lazy<DPSWidgetViewModel>(() => new DPSWidgetViewModel());

        private ParseEntity _parseEntity;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public static DPSWidgetViewModel Instance {
            get {
                return _instance.Value;
            }
        }

        public ParseEntity ParseEntity {
            get {
                var t = this._parseEntity ?? (this._parseEntity = new ParseEntity());
Console.WriteLine($"¤¤¤¤¤¤¤¤¤¤¤ ParseEntity.get (nil? {(t == null)}, nil2? {(t?.Players == null)})");
                return t;
            }

            set {
                this._parseEntity = value;
                if (value?.Players != null)
                {
Console.WriteLine($"########### ParseEntity {value.Players.Count} player(s)");
foreach(var p in value.Players) {
    Console.WriteLine($"   name: \"{p.Name}\" DPS: \"{p.DPS}\" ");
}
                }

                this.RaisePropertyChanged();
            }
        }

        private void RaisePropertyChanged([CallerMemberName] string caller = "") {
            this.PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }
    }
}