// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainView.xaml.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   MainView.xaml.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FFXIVAPP.Plugin.Parse.Controls;
using Teast.Controls;

namespace FFXIVAPP.Plugin.Parse.Views
{
    /// <summary>
    ///     Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public static MainView View;

        public MainView()
        {
            View = this;
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            LayoutRoot = this.FindControl<Grid>("LayoutRoot");
            MainViewTC = this.FindControl<TabControl>("MainViewTC");
            InfoViewSource = this.FindControl<ComboBox>("InfoViewSource");
            InfoViewType = this.FindControl<ComboBox>("InfoViewType");
            RefreshSelectedButton = this.FindControl<Button>("RefreshSelectedButton");
            SelectedPlayerName = this.FindControl<TextBlock>("SelectedPlayerName");
            PlayerInfoListView = this.FindControl<ListBox>("PlayerInfoListView");
            SelectedMonsterName = this.FindControl<TextBlock>("SelectedMonsterName");
            MonsterInfoListView = this.FindControl<ListBox>("MonsterInfoListView");
            PartyScoreCards = this.FindControl<Border>("PartyScoreCards");
            OverallInfoScoreCard = this.FindControl<GroupBox>("OverallInfoScoreCard");
            PlayerInfoScoreCard = this.FindControl<ItemsControl>("PlayerInfoScoreCard");
            PartyBreakDownInfo = this.FindControl<Border>("PartyBreakDownInfo");
            PlayerResults = this.FindControl<TabControl>("PlayerResults");
            PlayerDamageByAction = this.FindControl<DamageDataGrid>("PlayerDamageByAction");
            PlayerDamageOverTimeByAction = this.FindControl<DamageOverTimeDataGrid>("PlayerDamageOverTimeByAction");
            PlayerDamageToMonsters = this.FindControl<DamageDataGrid>("PlayerDamageToMonsters");
            PlayerDamageToMonstersByAction = this.FindControl<DamageDataGrid>("PlayerDamageToMonstersByAction");
            PlayerDamageOverTimeToMonsters = this.FindControl<DamageOverTimeDataGrid>("PlayerDamageOverTimeToMonsters");
            PlayerDamageOverTimeToMonstersByAction = this.FindControl<DamageOverTimeDataGrid>("PlayerDamageOverTimeToMonstersByAction");
            PlayerHealingByAction = this.FindControl<HealingDataGrid>("PlayerHealingByAction");
            PlayerHealingOverHealingByAction = this.FindControl<HealingOverHealingDataGrid>("PlayerHealingOverHealingByAction");
            PlayerHealingOverTimeByAction = this.FindControl<HealingOverTimeDataGrid>("PlayerHealingOverTimeByAction");
            PlayerHealingMitigatedByAction = this.FindControl<HealingMitigatedDataGrid>("PlayerHealingMitigatedByAction");
            PlayerHealingToPlayers = this.FindControl<HealingDataGrid>("PlayerHealingToPlayers");
            PlayerHealingToPlayersByAction = this.FindControl<HealingDataGrid>("PlayerHealingToPlayersByAction");
            PlayerHealingOverHealingToPlayers = this.FindControl<HealingOverHealingDataGrid>("PlayerHealingOverHealingToPlayers");
            PlayerHealingOverHealingToPlayersByAction = this.FindControl<HealingOverHealingDataGrid>("PlayerHealingOverHealingToPlayersByAction");
            PlayerHealingOverTimeToPlayers = this.FindControl<HealingOverTimeDataGrid>("PlayerHealingOverTimeToPlayers");
            PlayerHealingOverTimeToPlayersByAction = this.FindControl<HealingOverTimeDataGrid>("PlayerHealingOverTimeToPlayersByAction");
            PlayerHealingMitigatedToPlayers = this.FindControl<HealingMitigatedDataGrid>("PlayerHealingMitigatedToPlayers");
            PlayerHealingMitigatedToPlayersByAction = this.FindControl<HealingMitigatedDataGrid>("PlayerHealingMitigatedToPlayersByAction");
            PlayerBuffByAction = this.FindControl<BuffDataGrid>("PlayerBuffByAction");
            PlayerBuffToPlayers = this.FindControl<BuffDataGrid>("PlayerBuffToPlayers");
            PlayerBuffToPlayersByAction = this.FindControl<BuffDataGrid>("PlayerBuffToPlayersByAction");
            PlayerDamageTakenByAction = this.FindControl<DamageTakenDataGrid>("PlayerDamageTakenByAction");
            PlayerDamageTakenOverTimeByAction = this.FindControl<DamageTakenOverTimeDataGrid>("PlayerDamageTakenOverTimeByAction");
            PlayerDamageTakenByMonsters = this.FindControl<DamageTakenDataGrid>("PlayerDamageTakenByMonsters");
            PlayerDamageTakenByMonstersByAction = this.FindControl<DamageTakenDataGrid>("PlayerDamageTakenByMonstersByAction");
            PlayerDamageTakenOverTimeByMonsters = this.FindControl<DamageTakenOverTimeDataGrid>("PlayerDamageTakenOverTimeByMonsters");
            PlayerDamageTakenOverTimeByMonstersByAction = this.FindControl<DamageTakenOverTimeDataGrid>("PlayerDamageTakenOverTimeByMonstersByAction");
            PartyTotalInfo = this.FindControl<Border>("PartyTotalInfo");
            PlayerCombinedDamageStats = this.FindControl<CombinedDamageDataGrid>("PlayerCombinedDamageStats");
            PlayerCombinedHealingStats = this.FindControl<CombinedHealingDataGrid>("PlayerCombinedHealingStats");
            PlayerCombinedDamageTakenStats = this.FindControl<CombinedDamageTakenDataGrid>("PlayerCombinedDamageTakenStats");
            MonsterBreakDownInfo = this.FindControl<Border>("MonsterBreakDownInfo");
            MonsterDamageByAction = this.FindControl<DamageDataGrid>("MonsterDamageByAction");
            MonsterDamageOverTimeByAction = this.FindControl<DamageOverTimeDataGrid>("MonsterDamageOverTimeByAction");
            MonsterDamageToPlayers = this.FindControl<DamageDataGrid>("MonsterDamageToPlayers");
            MonsterDamageToPlayersByAction = this.FindControl<DamageDataGrid>("MonsterDamageToPlayersByAction");
            MonsterDamageOverTimeToPlayers = this.FindControl<DamageOverTimeDataGrid>("MonsterDamageOverTimeToPlayers");
            MonsterDamageOverTimeToPlayersByAction = this.FindControl<DamageOverTimeDataGrid>("MonsterDamageOverTimeToPlayersByAction");
            MonsterDamageTakenByAction = this.FindControl<DamageTakenDataGrid>("MonsterDamageTakenByAction");
            MonsterDamageTakenOverTimeByAction = this.FindControl<DamageTakenOverTimeDataGrid>("MonsterDamageTakenOverTimeByAction");
            MonsterDamageTakenByPlayers = this.FindControl<DamageTakenDataGrid>("MonsterDamageTakenByPlayers");
            MonsterDamageTakenByPlayersByAction = this.FindControl<DamageTakenDataGrid>("MonsterDamageTakenByPlayersByAction");
            MonsterDamageTakenOverTimeByPlayers = this.FindControl<DamageTakenOverTimeDataGrid>("MonsterDamageTakenOverTimeByPlayers");
            MonsterDamageTakenOverTimeByPlayersByAction = this.FindControl<DamageTakenOverTimeDataGrid>("MonsterDamageTakenOverTimeByPlayersByAction");
            MonsterTotalInfo = this.FindControl<Border>("MonsterTotalInfo");
            MonsterCombinedDamageStats = this.FindControl<CombinedDamageDataGrid>("MonsterCombinedDamageStats");
            MonsterCombinedHealingStats = this.FindControl<CombinedHealingDataGrid>("MonsterCombinedHealingStats");
            MonsterCombinedDamageTakenStats = this.FindControl<CombinedDamageTakenDataGrid>("MonsterCombinedDamageTakenStats");
        }

        public Grid LayoutRoot { get; private set; }
        public TabControl MainViewTC { get; private set; }
        public ComboBox InfoViewSource { get; private set; }
        public ComboBox InfoViewType { get; private set; }
        public Button RefreshSelectedButton { get; private set; }
        public TextBlock SelectedPlayerName { get; private set; }
        public ListBox PlayerInfoListView { get; private set; }
        public TextBlock SelectedMonsterName { get; private set; }
        public ListBox MonsterInfoListView { get; private set; }
        public Border PartyScoreCards { get; private set; }
        public GroupBox OverallInfoScoreCard { get; private set; }
        public ItemsControl PlayerInfoScoreCard { get; private set; }
        public Border PartyBreakDownInfo { get; private set; }
        public TabControl PlayerResults { get; private set; }
        public DamageDataGrid PlayerDamageByAction { get; private set; }
        public DamageOverTimeDataGrid PlayerDamageOverTimeByAction { get; private set; }
        public DamageDataGrid PlayerDamageToMonsters { get; private set; }
        public DamageDataGrid PlayerDamageToMonstersByAction { get; private set; }
        public DamageOverTimeDataGrid PlayerDamageOverTimeToMonsters { get; private set; }
        public DamageOverTimeDataGrid PlayerDamageOverTimeToMonstersByAction { get; private set; }
        public HealingDataGrid PlayerHealingByAction { get; private set; }
        public HealingOverHealingDataGrid PlayerHealingOverHealingByAction { get; private set; }
        public HealingOverTimeDataGrid PlayerHealingOverTimeByAction { get; private set; }
        public HealingMitigatedDataGrid PlayerHealingMitigatedByAction { get; private set; }
        public HealingDataGrid PlayerHealingToPlayers { get; private set; }
        public HealingDataGrid PlayerHealingToPlayersByAction { get; private set; }
        public HealingOverHealingDataGrid PlayerHealingOverHealingToPlayers { get; private set; }
        public HealingOverHealingDataGrid PlayerHealingOverHealingToPlayersByAction { get; private set; }
        public HealingOverTimeDataGrid PlayerHealingOverTimeToPlayers { get; private set; }
        public HealingOverTimeDataGrid PlayerHealingOverTimeToPlayersByAction { get; private set; }
        public HealingMitigatedDataGrid PlayerHealingMitigatedToPlayers { get; private set; }
        public HealingMitigatedDataGrid PlayerHealingMitigatedToPlayersByAction { get; private set; }
        public BuffDataGrid PlayerBuffByAction { get; private set; }
        public BuffDataGrid PlayerBuffToPlayers { get; private set; }
        public BuffDataGrid PlayerBuffToPlayersByAction { get; private set; }
        public DamageTakenDataGrid PlayerDamageTakenByAction { get; private set; }
        public DamageTakenOverTimeDataGrid PlayerDamageTakenOverTimeByAction { get; private set; }
        public DamageTakenDataGrid PlayerDamageTakenByMonsters { get; private set; }
        public DamageTakenDataGrid PlayerDamageTakenByMonstersByAction { get; private set; }
        public DamageTakenOverTimeDataGrid PlayerDamageTakenOverTimeByMonsters { get; private set; }
        public DamageTakenOverTimeDataGrid PlayerDamageTakenOverTimeByMonstersByAction { get; private set; }
        public Border PartyTotalInfo { get; private set; }
        public CombinedDamageDataGrid PlayerCombinedDamageStats { get; private set; }
        public CombinedHealingDataGrid PlayerCombinedHealingStats { get; private set; }
        public CombinedDamageTakenDataGrid PlayerCombinedDamageTakenStats { get; private set; }
        public Border MonsterBreakDownInfo { get; private set; }
        public DamageDataGrid MonsterDamageByAction { get; private set; }
        public DamageOverTimeDataGrid MonsterDamageOverTimeByAction { get; private set; }
        public DamageDataGrid MonsterDamageToPlayers { get; private set; }
        public DamageDataGrid MonsterDamageToPlayersByAction { get; private set; }
        public DamageOverTimeDataGrid MonsterDamageOverTimeToPlayers { get; private set; }
        public DamageOverTimeDataGrid MonsterDamageOverTimeToPlayersByAction { get; private set; }
        public DamageTakenDataGrid MonsterDamageTakenByAction { get; private set; }
        public DamageTakenOverTimeDataGrid MonsterDamageTakenOverTimeByAction { get; private set; }
        public DamageTakenDataGrid MonsterDamageTakenByPlayers { get; private set; }
        public DamageTakenDataGrid MonsterDamageTakenByPlayersByAction { get; private set; }
        public DamageTakenOverTimeDataGrid MonsterDamageTakenOverTimeByPlayers { get; private set; }
        public DamageTakenOverTimeDataGrid MonsterDamageTakenOverTimeByPlayersByAction { get; private set; }
        public Border MonsterTotalInfo { get; private set; }
        public CombinedDamageDataGrid MonsterCombinedDamageStats { get; private set; }
        public CombinedHealingDataGrid MonsterCombinedHealingStats { get; private set; }
        public CombinedDamageTakenDataGrid MonsterCombinedDamageTakenStats { get; private set; }
    }
}