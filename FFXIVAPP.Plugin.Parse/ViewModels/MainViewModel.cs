// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainViewModel.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   MainViewModel.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Parse.ViewModels {
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Input;
    using Avalonia.Controls;
    using FFXIVAPP.Common;
    using FFXIVAPP.Common.Helpers;
    using FFXIVAPP.Common.Models;
    using FFXIVAPP.Common.RegularExpressions;
    using FFXIVAPP.Common.Utilities;
    using FFXIVAPP.Common.ViewModelBase;
    using FFXIVAPP.Plugin.Parse.Helpers;
    using FFXIVAPP.Plugin.Parse.Models;
    using FFXIVAPP.Plugin.Parse.Models.History;
    using FFXIVAPP.Plugin.Parse.Models.StatGroups;
    using FFXIVAPP.Plugin.Parse.Models.Stats;
    using FFXIVAPP.Plugin.Parse.Views;
    using FFXIVAPP.Plugin.Parse.Windows;

    using Microsoft.Win32;

    using NLog;

    using Constants = FFXIVAPP.Plugin.Parse.Constants;

    internal sealed class MainViewModel : INotifyPropertyChanged {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private static Lazy<MainViewModel> _instance = new Lazy<MainViewModel>(() => new MainViewModel());

        private bool _isCurrent;

        private bool _isHistory;

        private CustomTypeDescriptor _monsterInfoSource;

        private CustomTypeDescriptor _overallInfoSource;

        private ObservableCollection<ParseHistoryItem> _parseHistory;

        private CustomTypeDescriptor _playerInfoSource;

        private bool _partyScoreCardsIsVisible;
        private bool _partyBreakDownInfoIsVisible;
        private bool _partyTotalInfoIsVisible;
        private bool _monsterBreakDownInfoIsVisible;
        private bool _monsterTotalInfoIsVisible;
        private ParseHistoryItem _infoViewSourceItem = null;
        private int _infoViewSourceIndex = -1;
        private string _infoViewTypeItem = "";
        private int _infoViewTypeIndex = -1;
        private bool _playerInfoListViewIsVisible;
        private bool _monsterInfoListViewIsVisible;
        private bool _refreshSelectedButtonIsVisible;

        public MainViewModel() {
            this.InfoViewTypeItems = new List<string>
            {
                PluginViewModel.Instance.Locale["parse_ScoreCardsComboBoxItemText"],
                PluginViewModel.Instance.Locale["parse_PartyComboBoxItemText"],
                PluginViewModel.Instance.Locale["parse_PartyAllComboBoxItemText"],
                PluginViewModel.Instance.Locale["parse_MonsterComboBoxItemText"],
                PluginViewModel.Instance.Locale["parse_MonsterAllComboBoxItemText"],
            };
            
            this.IsCurrent = true;
            this.InfoViewSourceIndex = 0;
            this.InfoViewTypeIndex = 0;
            this.InfoViewSourceItem = this.ParseHistory[0];
            this.InfoViewTypeItem = this.InfoViewTypeItems[0];

            this.ShowLast20PlayerActionsCommand = new DelegateCommand<string>(this.ShowLast20PlayerActions);
            this.ShowLast20MonsterActionsCommand = new DelegateCommand<string>(this.ShowLast20MonsterActions);
            this.ShowLast20PlayerItemsUsedCommand = new DelegateCommand(this.ShowLast20PlayerItemsUsed);
            this.RefreshSelectedCommand = new DelegateCommand(this.RefreshSelected);
            this.ProcessSampleCommand = new DelegateCommand(this.ProcessSample);
            this.ResetStatsCommand = new DelegateCommand(this.ResetStats);
            this.Convert2JsonCommand = new DelegateCommand(this.Convert2Json);
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public static MainViewModel Instance {
            get {
                return _instance.Value;
            }
        }

        public List<string> InfoViewTypeItems { get; }

        public ICommand Convert2JsonCommand { get; private set; }

        public bool IsCurrent {
            get {
                return this._isCurrent;
            }

            set {
                this._isCurrent = value;
                this.RaisePropertyChanged();
            }
        }

        public bool IsHistory {
            get {
                return this._isHistory;
            }

            set {
                this._isHistory = value;
                this.RaisePropertyChanged();
            }
        }

        public CustomTypeDescriptor MonsterInfoSource {
            get {
                return this._monsterInfoSource ?? ParseControl.Instance.Timeline.Monster;
            }

            set {
                this._monsterInfoSource = value;
                this.RaisePropertyChanged();
            }
        }

        public CustomTypeDescriptor OverallInfoSource {
            get {
                return this._overallInfoSource ?? ParseControl.Instance.Timeline.Overall;
            }

            set {
                this._overallInfoSource = value;
                this.RaisePropertyChanged();
            }
        }

        public ObservableCollection<ParseHistoryItem> ParseHistory {
            get {
                return this._parseHistory ?? (this._parseHistory = new ObservableCollection<ParseHistoryItem> {
                    new ParseHistoryItem {
                        Name = "Current"
                    }
                });
            }

            set {
                if (this._parseHistory == null) {
                    this._parseHistory = new ObservableCollection<ParseHistoryItem> {
                        new ParseHistoryItem {
                            Name = "Current"
                        }
                    };
                }

                this._parseHistory = value;
                this.RaisePropertyChanged();
            }
        }

        public CustomTypeDescriptor PlayerInfoSource {
            get {
                return this._playerInfoSource ?? ParseControl.Instance.Timeline.Party;
            }

            set {
                this._playerInfoSource = value;
                this.RaisePropertyChanged();
            }
        }

        public bool PartyScoreCardsIsVisible {
            get {
                return _partyScoreCardsIsVisible;
            }
            set {
                if (this._partyScoreCardsIsVisible == value)
                    return;
                this._partyScoreCardsIsVisible = value;
                this.RaisePropertyChanged();
            }
        }

        public bool PartyBreakDownInfoIsVisible {
            get {
                return _partyBreakDownInfoIsVisible;
            }
            set {
                if (this._partyBreakDownInfoIsVisible == value)
                    return;
                this._partyBreakDownInfoIsVisible = value;
                this.RaisePropertyChanged();
            }
        }

        public bool PartyTotalInfoIsVisible {
            get {
                return _partyTotalInfoIsVisible;
            }
            set {
                if (this._partyTotalInfoIsVisible == value)
                    return;
                this._partyTotalInfoIsVisible = value;
                this.RaisePropertyChanged();
            }
        }

        public bool MonsterBreakDownInfoIsVisible {
            get {
                return _monsterBreakDownInfoIsVisible;
            }
            set {
                if (this._monsterBreakDownInfoIsVisible == value)
                    return;
                this._monsterBreakDownInfoIsVisible = value;
                this.RaisePropertyChanged();
            }
        }

        public bool MonsterTotalInfoIsVisible {
            get {
                return _monsterTotalInfoIsVisible;
            }
            set {
                if (this._monsterTotalInfoIsVisible == value)
                    return;
                this._monsterTotalInfoIsVisible = value;
                this.RaisePropertyChanged();
            }
        }

        public ParseHistoryItem InfoViewSourceItem {
            get {
                return _infoViewSourceItem;
            }
            set {
                if (this._infoViewSourceItem == value)
                    return;
                this._infoViewSourceItem = value;
            }
        }

        public int InfoViewSourceIndex {
            get {
                return _infoViewSourceIndex;
            }
            set {
                if (this._infoViewSourceIndex == value)
                    return;
                this._infoViewSourceIndex = value;
                this.RaisePropertyChanged();
                SwitchInfoViewSource();
            }
        }

        public string InfoViewTypeItem {
            get {
                return _infoViewTypeItem;
            }
            set {
                if (this._infoViewTypeItem == value)
                    return;
                this._infoViewTypeItem = value;
            }
        }

        public int InfoViewTypeIndex {
            get {
                return _infoViewTypeIndex;
            }
            set {
                if (this._infoViewTypeIndex == value)
                    return;
                this._infoViewTypeIndex = value;
                this.RaisePropertyChanged();
                SwitchInfoViewType();
            }
        }

        public bool PlayerInfoListViewIsVisible {
            get {
                return _playerInfoListViewIsVisible;
            }
            set {
                if (this._playerInfoListViewIsVisible == value)
                    return;
                this._playerInfoListViewIsVisible = value;
                this.RaisePropertyChanged();
                SwitchInfoViewType();
            }
        }

        public bool MonsterInfoListViewIsVisible {
            get {
                return _monsterInfoListViewIsVisible;
            }
            set {
                if (this._monsterInfoListViewIsVisible == value)
                    return;
                this._monsterInfoListViewIsVisible = value;
                this.RaisePropertyChanged();
                SwitchInfoViewType();
            }
        }

        public bool RefreshSelectedButtonIsVisible {
            get {
                return _refreshSelectedButtonIsVisible;
            }
            set {
                if (this._refreshSelectedButtonIsVisible == value)
                    return;
                this._refreshSelectedButtonIsVisible = value;
                this.RaisePropertyChanged();
                SwitchInfoViewType();
            }
        }

        public ICommand ProcessSampleCommand { get; private set; }

        public ICommand RefreshSelectedCommand { get; private set; }

        public ICommand ResetStatsCommand { get; private set; }

        public ICommand ShowLast20MonsterActionsCommand { get; private set; }

        public ICommand ShowLast20PlayerActionsCommand { get; private set; }

        public ICommand ShowLast20PlayerItemsUsedCommand { get; private set; }


        private void Convert2Json() {
            // var results = JsonHelper.ToJson.ConvertParse();
            // DispatcherHelper.Invoke(() => Clipboard.SetText(results));
        }

        private void ProcessSample() {
            /* TODO: Implement this openFileDialog
            var openFileDialog = new OpenFileDialog {
                Directory = Path.Combine(Common.Constants.LogsPath, "Parser"),
                AllowMultiple = false,
                Filters = new List<FileDialogFilter> {
                    new FileDialogFilter { Name = "JSON Files (*.json)", Extensions = new List<string> { "json" }}
                }
            };

            openFileDialog.FileOk += delegate {
                try {
                    var parse = File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);
                    JsonHelper.ToParseControl.ConvertJson(openFileDialog.FileName, parse);
                }
                catch (Exception ex) {
                    var popupContent = new PopupContent {
                        Title = PluginViewModel.Instance.Locale["app_WarningMessage"],
                        Message = ex.Message
                    };
                    Plugin.PHost.PopupMessage(Plugin.PName, popupContent);
                }
            };
            openFileDialog.ShowDialog();
            */
        }

        private void RaisePropertyChanged([CallerMemberName] string caller = "") {
            this.PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }

        private void RefreshSelected() {
            DispatcherHelper.Invoke(
                delegate {
                    try {
                        var index = MainView.View.PlayerInfoListView.SelectedIndex;
                        MainView.View.PlayerInfoListView.SelectedIndex = -1;
                        MainView.View.PlayerInfoListView.SelectedIndex = index;
                    }
                    catch (Exception ex) {
                        Logging.Log(Logger, new LogItem(ex, true));
                    }

                    try {
                        var index = MainView.View.MonsterInfoListView.SelectedIndex;
                        MainView.View.MonsterInfoListView.SelectedIndex = -1;
                        MainView.View.MonsterInfoListView.SelectedIndex = index;
                    }
                    catch (Exception ex) {
                        Logging.Log(Logger, new LogItem(ex, true));
                    }
                });
        }

        /// <summary>
        /// </summary>
        private void ResetStats() {
            ParseControl.Instance.Reset();

            // var title = PluginViewModel.Instance.Locale["app_WarningMessage"];
            // var message = PluginViewModel.Instance.Locale["parse_ResetStatsMessage"];
            // MessageBoxHelper.ShowMessageAsync(title, message, () => ParseControl.Instance.Reset(), delegate { });
        }

        private void ShowLast20MonsterActions(string actionType) {
            var title = "UNKNOWN";
            List<ActionHistoryItem> source = new List<ActionHistoryItem>();
            IEnumerable<CustomTypeDescriptor> monsters = null;
            var last20DamageActions = new List<LineHistory>();
            var last20DamageTakenActions = new List<LineHistory>();
            var last20HealingActions = new List<LineHistory>();

            if (this.IsHistory) {
                monsters = ((HistoryGroup) Instance.MonsterInfoSource).Children;
            }

            if (this.IsCurrent) {
                monsters = ((StatGroup) Instance.MonsterInfoSource).Children;
            }

            if (this.IsHistory) {
                HistoryGroup monster = monsters.Select(p => p as HistoryGroup).Where(p => p != null).Where(p => string.Equals(p.Name, MainView.View.SelectedMonsterName.Text.ToString(CultureInfo.InvariantCulture), Constants.InvariantComparer)).FirstOrDefault();
                if (monster == null) {
                    return;
                }

                title = monster.Name;
                last20DamageActions = monster.Last20DamageActions;
                last20DamageTakenActions = monster.Last20DamageTakenActions;
                last20HealingActions = monster.Last20HealingActions;
            }

            if (this.IsCurrent) {
                Monster monster = monsters.Select(p => p as Monster).Where(p => p != null).Where(p => string.Equals(p.Name, MainView.View.SelectedMonsterName.Text.ToString(CultureInfo.InvariantCulture), Constants.InvariantComparer)).FirstOrDefault();
                if (monster == null) {
                    return;
                }

                title = monster.Name;
                last20DamageActions = monster.Last20DamageActions;
                last20DamageTakenActions = monster.Last20DamageTakenActions;
                last20HealingActions = monster.Last20HealingActions;
            }

            switch (actionType) {
                case "Damage":
                    foreach (var action in last20DamageActions) {
                        source.Add(
                            new ActionHistoryItem {
                                Action = action.Line.Action,
                                Amount = action.Line.Amount,
                                Critical = action.Line.Crit.ToString(),
                                Source = action.Line.Source,
                                Target = action.Line.Target,
                                TimeStamp = action.TimeStamp
                            });
                    }

                    break;
                case "DamageTaken":
                    foreach (var action in last20DamageTakenActions) {
                        source.Add(
                            new ActionHistoryItem {
                                Action = action.Line.Action,
                                Amount = action.Line.Amount,
                                Critical = action.Line.Crit.ToString(),
                                Source = action.Line.Source,
                                Target = action.Line.Target,
                                TimeStamp = action.TimeStamp
                            });
                    }

                    break;
                case "Healing":
                    foreach (var action in last20HealingActions) {
                        source.Add(
                            new ActionHistoryItem {
                                Action = action.Line.Action,
                                Amount = action.Line.Amount,
                                Critical = action.Line.Crit.ToString(),
                                Source = action.Line.Source,
                                Target = action.Line.Target,
                                TimeStamp = action.TimeStamp
                            });
                    }

                    break;
            }

            if (!source.Any()) {
                return;
            }

            Logging.Log(Logger, $"TODO: xMetroWindowDataGrid should be shown with title \"{title}\".");
            /* TODO: Implement this
            var x = new xMetroWindowDataGrid {
                Title = title,
                xMetroWindowDG = {
                    ItemsSource = source
                }
            };
            x.Show();
            */
        }

        private void ShowLast20PlayerActions(string actionType) {
            var title = "UNKNOWN";
            List<ActionHistoryItem> source = new List<ActionHistoryItem>();
            IEnumerable<CustomTypeDescriptor> players = null;
            var last20DamageActions = new List<LineHistory>();
            var last20DamageTakenActions = new List<LineHistory>();
            var last20HealingActions = new List<LineHistory>();

            if (this.IsHistory) {
                players = ((HistoryGroup) Instance.PlayerInfoSource).Children;
            }

            if (this.IsCurrent) {
                players = ((StatGroup) Instance.PlayerInfoSource).Children;
            }

            if (this.IsHistory) {
                HistoryGroup player = players.Select(p => p as HistoryGroup).Where(p => p != null).Where(p => string.Equals(p.Name, MainView.View.SelectedPlayerName.Text.ToString(CultureInfo.InvariantCulture), Constants.InvariantComparer)).FirstOrDefault();
                if (player == null) {
                    return;
                }

                title = player.Name;
                last20DamageActions = player.Last20DamageActions;
                last20DamageTakenActions = player.Last20DamageTakenActions;
                last20HealingActions = player.Last20HealingActions;
            }

            if (this.IsCurrent) {
                Player player = players.Select(p => p as Player).Where(p => p != null).Where(p => string.Equals(p.Name, MainView.View.SelectedPlayerName.Text.ToString(CultureInfo.InvariantCulture), Constants.InvariantComparer)).FirstOrDefault();
                if (player == null) {
                    return;
                }

                title = player.Name;
                last20DamageActions = player.Last20DamageActions;
                last20DamageTakenActions = player.Last20DamageTakenActions;
                last20HealingActions = player.Last20HealingActions;
            }

            switch (actionType) {
                case "Damage":
                    foreach (var action in last20DamageActions) {
                        source.Add(
                            new ActionHistoryItem {
                                Action = action.Line.Action,
                                Amount = action.Line.Amount,
                                Critical = action.Line.Crit.ToString(),
                                Source = action.Line.Source,
                                Target = action.Line.Target,
                                TimeStamp = action.TimeStamp
                            });
                    }

                    break;
                case "DamageTaken":
                    foreach (var action in last20DamageTakenActions) {
                        source.Add(
                            new ActionHistoryItem {
                                Action = action.Line.Action,
                                Amount = action.Line.Amount,
                                Critical = action.Line.Crit.ToString(),
                                Source = action.Line.Source,
                                Target = action.Line.Target,
                                TimeStamp = action.TimeStamp
                            });
                    }

                    break;
                case "Healing":
                    foreach (var action in last20HealingActions) {
                        source.Add(
                            new ActionHistoryItem {
                                Action = action.Line.Action,
                                Amount = action.Line.Amount,
                                Critical = action.Line.Crit.ToString(),
                                Source = action.Line.Source,
                                Target = action.Line.Target,
                                TimeStamp = action.TimeStamp
                            });
                    }

                    break;
            }

            if (!source.Any()) {
                return;
            }

            Logging.Log(Logger, $"TODO: xMetroWindowDataGrid should be shown with title \"{title}\".");
            /* TODO: Implement this
            var x = new xMetroWindowDataGrid {
                Title = title,
                xMetroWindowDG = {
                    ItemsSource = source
                }
            };
            x.Show();
            */
        }

        private void ShowLast20PlayerItemsUsed() {
            var title = "UNKNOWN";
            List<ItemUsedHistoryItem> source = new List<ItemUsedHistoryItem>();
            IEnumerable<CustomTypeDescriptor> players = null;
            var last20Items = new List<LineHistory>();

            if (this.IsHistory) {
                players = ((HistoryGroup) Instance.PlayerInfoSource).Children;
            }

            if (this.IsCurrent) {
                players = ((StatGroup) Instance.PlayerInfoSource).Children;
            }

            if (this.IsHistory) {
                var player = players.Select(p => p as HistoryGroup).Where(p => p != null).Where(p => string.Equals(p.Name, MainView.View.SelectedPlayerName.Text.ToString(CultureInfo.InvariantCulture), Constants.InvariantComparer)).FirstOrDefault();
                if (player == null) {
                    return;
                }

                title = player.Name;
                last20Items = player.Last20Items;
            }

            if (this.IsCurrent) {
                var player = players.Select(p => p as Player).Where(p => p != null).Where(p => string.Equals(p.Name, MainView.View.SelectedPlayerName.Text.ToString(CultureInfo.InvariantCulture), Constants.InvariantComparer)).FirstOrDefault();
                if (player == null) {
                    return;
                }

                title = player.Name;
                last20Items = player.Last20Items;
            }

            foreach (var item in last20Items) {
                source.Add(
                    new ItemUsedHistoryItem {
                        Item = Regex.Replace(item.Line.Action, @"\[Hq\]", "[HQ]", SharedRegEx.DefaultOptions),
                        TimeStamp = item.TimeStamp
                    });
            }

            if (!source.Any()) {
                return;
            }

            Logging.Log(Logger, $"TODO: xMetroWindowDataGrid should be shown with title \"{title}\".");
            /* TODO: Implement this
            var x = new xMetroWindowDataGrid {
                Title = title,
                xMetroWindowDG = {
                    ItemsSource = source
                }
            };
            x.Show();
            */
        }

        private void SwitchInfoViewSource() {
            try {
                var index = this.InfoViewSourceIndex;
                if (index == -1)
                    return;
                    
                switch (index) {
                    case 0:
                        this.PlayerInfoSource = null;
                        this.MonsterInfoSource = null;
                        this.OverallInfoSource = null;
                        this.IsCurrent = true;
                        this.IsHistory = false;
                        break;
                    default:
                        this.PlayerInfoSource = this.ParseHistory[index].HistoryControl.Timeline.Party;
                        this.MonsterInfoSource = this.ParseHistory[index].HistoryControl.Timeline.Monster;
                        this.OverallInfoSource = this.ParseHistory[index].HistoryControl.Timeline.Overall;
                        this.IsCurrent = false;
                        this.IsHistory = true;
                        break;
                }
            }
            catch (Exception ex) {
                Logging.Log(Logger, new LogItem(ex, true));
            }
        }

        private void SwitchInfoViewType() {
            try {
                this.PartyScoreCardsIsVisible = false;
                this.PartyBreakDownInfoIsVisible = false;
                this.PartyTotalInfoIsVisible = false;
                this.MonsterBreakDownInfoIsVisible = false;
                this.MonsterTotalInfoIsVisible = false;

                var index = InfoViewTypeIndex;
                switch (InfoViewTypeIndex) {
                    case 0:
                        this.PlayerInfoListViewIsVisible = false;
                        this.MonsterInfoListViewIsVisible = false;
                        this.RefreshSelectedButtonIsVisible = false;
                        this.PartyScoreCardsIsVisible = true;
                        break;
                    case 1:
                        this.PlayerInfoListViewIsVisible = true;
                        this.MonsterInfoListViewIsVisible = false;
                        this.RefreshSelectedButtonIsVisible = true;
                        this.PartyBreakDownInfoIsVisible = true;
                        break;
                    case 2:
                        this.PlayerInfoListViewIsVisible = false;
                        this.MonsterInfoListViewIsVisible = false;
                        this.RefreshSelectedButtonIsVisible = false;
                        this.PartyTotalInfoIsVisible = true;
                        break;
                    case 3:
                        this.PlayerInfoListViewIsVisible = false;
                        this.MonsterInfoListViewIsVisible = true;
                        this.RefreshSelectedButtonIsVisible = true;
                        this.MonsterBreakDownInfoIsVisible = true;
                        break;
                    case 4:
                        this.PlayerInfoListViewIsVisible = false;
                        this.MonsterInfoListViewIsVisible = false;
                        this.RefreshSelectedButtonIsVisible = false;
                        this.MonsterTotalInfoIsVisible = true;
                        break;
                }
            }
            catch (Exception ex) {
                Logging.Log(Logger, new LogItem(ex, true));
            }
        }
    }
}