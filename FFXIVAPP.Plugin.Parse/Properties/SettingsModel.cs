using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace FFXIVAPP.Plugin.Parse.Properties
{
    [JsonObject(MemberSerialization.OptOut)]
    public class SettingsModel: INotifyPropertyChanged
    {
       public new event PropertyChangedEventHandler PropertyChanged = delegate { };

        public SettingsModel()
        {
            DefaultSettings();
        }

        public void DefaultSettings()
        {
            this.StoreHistoryEvent = "Damage Only";
            this.StoreHistoryInterval = 10000;
            this.EnableStoreHistoryReset = false;
            this.IgnoreLimitBreaks = false;
            this.TrackXPSFromParseStartEvent = true;
            this.ParseYou = true;
            this.ParseParty = true;
            this.ParseAlliance = false;
            this.ParseOther = false;
            this.ParseAdvanced = false;
            this.ShowBasicTotalOverallDamage = false;
            this.ShowBasicRegularDamage = false;
            this.ShowBasicCriticalDamage = false;
            this.ShowBasicTotalDamageActionsUsed = false;
            this.ShowBasicDPS = false;
            this.ShowBasicDamageRegHit = false;
            this.ShowBasicDamageRegMiss = false;
            this.ShowBasicDamageRegAccuracy = true;
            this.ShowBasicDamageRegLow = false;
            this.ShowBasicDamageRegHigh = false;
            this.ShowBasicDamageRegAverage = false;
            this.ShowBasicDamageRegMod = false;
            this.ShowBasicDamageRegModAverage = false;
            this.ShowBasicDamageCritHit = false;
            this.ShowBasicDamageCritPercent = true;
            this.ShowBasicDamageCritLow = false;
            this.ShowBasicDamageCritHigh = false;
            this.ShowBasicDamageCritAverage = false;
            this.ShowBasicDamageCritMod = false;
            this.ShowBasicDamageCritModAverage = false;
            this.ShowBasicDamageCounter = false;
            this.ShowBasicDamageCounterPercent = false;
            this.ShowBasicDamageCounterMod = false;
            this.ShowBasicDamageCounterModAverage = false;
            this.ShowBasicDamageBlock = false;
            this.ShowBasicDamageBlockPercent = false;
            this.ShowBasicDamageBlockMod = false;
            this.ShowBasicDamageBlockModAverage = false;
            this.ShowBasicDamageParry = false;
            this.ShowBasicDamageParryPercent = false;
            this.ShowBasicDamageParryMod = false;
            this.ShowBasicDamageParryModAverage = false;
            this.ShowBasicDamageResist = false;
            this.ShowBasicDamageResistPercent = false;
            this.ShowBasicDamageResistMod = false;
            this.ShowBasicDamageResistModAverage = false;
            this.ShowBasicDamageEvade = false;
            this.ShowBasicDamageEvadePercent = false;
            this.ShowBasicDamageEvadeMod = false;
            this.ShowBasicDamageEvadeModAverage = false;
            this.ShowBasicPercentOfTotalOverallDamage = false;
            this.ShowBasicPercentOfRegularDamage = false;
            this.ShowBasicPercentOfCriticalDamage = false;
            this.ShowBasicTotalOverallDamageOverTime = false;
            this.ShowBasicRegularDamageOverTime = false;
            this.ShowBasicCriticalDamageOverTime = false;
            this.ShowBasicTotalDamageOverTimeActionsUsed = false;
            this.ShowBasicDOTPS = false;
            this.ShowBasicDamageOverTimeRegHit = false;
            this.ShowBasicDamageOverTimeRegMiss = false;
            this.ShowBasicDamageOverTimeRegAccuracy = false;
            this.ShowBasicDamageOverTimeRegLow = false;
            this.ShowBasicDamageOverTimeRegHigh = false;
            this.ShowBasicDamageOverTimeRegAverage = false;
            this.ShowBasicDamageOverTimeRegMod = false;
            this.ShowBasicDamageOverTimeRegModAverage = false;
            this.ShowBasicDamageOverTimeCritHit = false;
            this.ShowBasicDamageOverTimeCritPercent = false;
            this.ShowBasicDamageOverTimeCritLow = false;
            this.ShowBasicDamageOverTimeCritHigh = false;
            this.ShowBasicDamageOverTimeCritAverage = false;
            this.ShowBasicDamageOverTimeCritMod = false;
            this.ShowBasicDamageOverTimeCritModAverage = false;
            this.ShowBasicPercentOfTotalOverallDamageOverTime = false;
            this.ShowBasicPercentOfRegularDamageOverTime = false;
            this.ShowBasicPercentOfCriticalDamageOverTime = false;
            this.ShowBasicTotalOverallHealing = false;
            this.ShowBasicRegularHealing = false;
            this.ShowBasicCriticalHealing = false;
            this.ShowBasicTotalHealingActionsUsed = false;
            this.ShowBasicHPS = false;
            this.ShowBasicHealingRegHit = false;
            this.ShowBasicHealingRegLow = false;
            this.ShowBasicHealingRegHigh = false;
            this.ShowBasicHealingRegAverage = false;
            this.ShowBasicHealingRegMod = false;
            this.ShowBasicHealingRegModAverage = false;
            this.ShowBasicHealingCritHit = false;
            this.ShowBasicHealingCritPercent = false;
            this.ShowBasicHealingCritLow = false;
            this.ShowBasicHealingCritHigh = false;
            this.ShowBasicHealingCritAverage = false;
            this.ShowBasicHealingCritMod = false;
            this.ShowBasicHealingCritModAverage = false;
            this.ShowBasicPercentOfTotalOverallHealing = false;
            this.ShowBasicPercentOfRegularHealing = false;
            this.ShowBasicPercentOfCriticalHealing = false;
            this.ShowBasicTotalOverallHealingOverTime = false;
            this.ShowBasicRegularHealingOverTime = false;
            this.ShowBasicCriticalHealingOverTime = false;
            this.ShowBasicTotalHealingOverTimeActionsUsed = false;
            this.ShowBasicHOTPS = false;
            this.ShowBasicHealingOverTimeRegHit = false;
            this.ShowBasicHealingOverTimeRegLow = false;
            this.ShowBasicHealingOverTimeRegHigh = false;
            this.ShowBasicHealingOverTimeRegAverage = false;
            this.ShowBasicHealingOverTimeRegMod = false;
            this.ShowBasicHealingOverTimeRegModAverage = false;
            this.ShowBasicHealingOverTimeCritHit = false;
            this.ShowBasicHealingOverTimeCritPercent = false;
            this.ShowBasicHealingOverTimeCritLow = false;
            this.ShowBasicHealingOverTimeCritHigh = false;
            this.ShowBasicHealingOverTimeCritAverage = false;
            this.ShowBasicHealingOverTimeCritMod = false;
            this.ShowBasicHealingOverTimeCritModAverage = false;
            this.ShowBasicPercentOfTotalOverallHealingOverTime = false;
            this.ShowBasicPercentOfRegularHealingOverTime = false;
            this.ShowBasicPercentOfCriticalHealingOverTime = false;
            this.ShowBasicTotalOverallHealingOverHealing = false;
            this.ShowBasicRegularHealingOverHealing = false;
            this.ShowBasicCriticalHealingOverHealing = false;
            this.ShowBasicTotalHealingOverHealingActionsUsed = false;
            this.ShowBasicHOHPS = false;
            this.ShowBasicHealingOverHealingRegHit = false;
            this.ShowBasicHealingOverHealingRegLow = false;
            this.ShowBasicHealingOverHealingRegHigh = false;
            this.ShowBasicHealingOverHealingRegAverage = false;
            this.ShowBasicHealingOverHealingRegMod = false;
            this.ShowBasicHealingOverHealingRegModAverage = false;
            this.ShowBasicHealingOverHealingCritHit = false;
            this.ShowBasicHealingOverHealingCritPercent = false;
            this.ShowBasicHealingOverHealingCritLow = false;
            this.ShowBasicHealingOverHealingCritHigh = false;
            this.ShowBasicHealingOverHealingCritAverage = false;
            this.ShowBasicHealingOverHealingCritMod = false;
            this.ShowBasicHealingOverHealingCritModAverage = false;
            this.ShowBasicPercentOfTotalOverallHealingOverHealing = false;
            this.ShowBasicPercentOfRegularHealingOverHealing = false;
            this.ShowBasicPercentOfCriticalHealingOverHealing = false;
            this.ShowBasicTotalOverallHealingMitigated = false;
            this.ShowBasicRegularHealingMitigated = false;
            this.ShowBasicCriticalHealingMitigated = false;
            this.ShowBasicTotalHealingMitigatedActionsUsed = false;
            this.ShowBasicHMPS = false;
            this.ShowBasicHealingMitigatedRegHit = false;
            this.ShowBasicHealingMitigatedRegLow = false;
            this.ShowBasicHealingMitigatedRegHigh = false;
            this.ShowBasicHealingMitigatedRegAverage = false;
            this.ShowBasicHealingMitigatedRegMod = false;
            this.ShowBasicHealingMitigatedRegModAverage = false;
            this.ShowBasicHealingMitigatedCritHit = false;
            this.ShowBasicHealingMitigatedCritPercent = false;
            this.ShowBasicHealingMitigatedCritLow = false;
            this.ShowBasicHealingMitigatedCritHigh = false;
            this.ShowBasicHealingMitigatedCritAverage = false;
            this.ShowBasicHealingMitigatedCritMod = false;
            this.ShowBasicHealingMitigatedCritModAverage = false;
            this.ShowBasicPercentOfTotalOverallHealingMitigated = false;
            this.ShowBasicPercentOfRegularHealingMitigated = false;
            this.ShowBasicPercentOfCriticalHealingMitigated = false;
            this.ShowBasicTotalOverallDamageTaken = false;
            this.ShowBasicRegularDamageTaken = false;
            this.ShowBasicCriticalDamageTaken = false;
            this.ShowBasicTotalDamageTakenActionsUsed = false;
            this.ShowBasicDTPS = false;
            this.ShowBasicDamageTakenRegHit = false;
            this.ShowBasicDamageTakenRegMiss = false;
            this.ShowBasicDamageTakenRegAccuracy = false;
            this.ShowBasicDamageTakenRegLow = false;
            this.ShowBasicDamageTakenRegHigh = false;
            this.ShowBasicDamageTakenRegAverage = false;
            this.ShowBasicDamageTakenRegMod = false;
            this.ShowBasicDamageTakenRegModAverage = false;
            this.ShowBasicDamageTakenCritHit = false;
            this.ShowBasicDamageTakenCritPercent = false;
            this.ShowBasicDamageTakenCritLow = false;
            this.ShowBasicDamageTakenCritHigh = false;
            this.ShowBasicDamageTakenCritAverage = false;
            this.ShowBasicDamageTakenCritMod = false;
            this.ShowBasicDamageTakenCritModAverage = false;
            this.ShowBasicDamageTakenCounter = false;
            this.ShowBasicDamageTakenCounterPercent = false;
            this.ShowBasicDamageTakenCounterMod = false;
            this.ShowBasicDamageTakenCounterModAverage = false;
            this.ShowBasicDamageTakenBlock = false;
            this.ShowBasicDamageTakenBlockPercent = false;
            this.ShowBasicDamageTakenBlockMod = false;
            this.ShowBasicDamageTakenBlockModAverage = false;
            this.ShowBasicDamageTakenParry = false;
            this.ShowBasicDamageTakenParryPercent = false;
            this.ShowBasicDamageTakenParryMod = false;
            this.ShowBasicDamageTakenParryModAverage = false;
            this.ShowBasicDamageTakenResist = false;
            this.ShowBasicDamageTakenResistPercent = false;
            this.ShowBasicDamageTakenResistMod = false;
            this.ShowBasicDamageTakenResistModAverage = false;
            this.ShowBasicDamageTakenEvade = false;
            this.ShowBasicDamageTakenEvadePercent = false;
            this.ShowBasicDamageTakenEvadeMod = false;
            this.ShowBasicDamageTakenEvadeModAverage = false;
            this.ShowBasicPercentOfTotalOverallDamageTaken = false;
            this.ShowBasicPercentOfRegularDamageTaken = false;
            this.ShowBasicPercentOfCriticalDamageTaken = false;
            this.ShowBasicTotalOverallDamageTakenOverTime = false;
            this.ShowBasicRegularDamageTakenOverTime = false;
            this.ShowBasicCriticalDamageTakenOverTime = false;
            this.ShowBasicTotalDamageTakenOverTimeActionsUsed = false;
            this.ShowBasicDTOTPS = false;
            this.ShowBasicDamageTakenOverTimeRegHit = false;
            this.ShowBasicDamageTakenOverTimeRegMiss = false;
            this.ShowBasicDamageTakenOverTimeRegAccuracy = false;
            this.ShowBasicDamageTakenOverTimeRegLow = false;
            this.ShowBasicDamageTakenOverTimeRegHigh = false;
            this.ShowBasicDamageTakenOverTimeRegAverage = false;
            this.ShowBasicDamageTakenOverTimeRegMod = false;
            this.ShowBasicDamageTakenOverTimeRegModAverage = false;
            this.ShowBasicDamageTakenOverTimeCritHit = false;
            this.ShowBasicDamageTakenOverTimeCritPercent = false;
            this.ShowBasicDamageTakenOverTimeCritLow = false;
            this.ShowBasicDamageTakenOverTimeCritHigh = false;
            this.ShowBasicDamageTakenOverTimeCritAverage = false;
            this.ShowBasicDamageTakenOverTimeCritMod = false;
            this.ShowBasicDamageTakenOverTimeCritModAverage = false;
            this.ShowBasicPercentOfTotalOverallDamageTakenOverTime = false;
            this.ShowBasicPercentOfRegularDamageTakenOverTime = false;
            this.ShowBasicPercentOfCriticalDamageTakenOverTime = false;
            this.ShowBasicCombinedTotalOverallDamage = true;
            this.ShowBasicCombinedRegularDamage = false;
            this.ShowBasicCombinedCriticalDamage = false;
            this.ShowBasicCombinedTotalDamageActionsUsed = false;
            this.ShowBasicCombinedDPS = true;
            this.ShowBasicCombinedDamageRegHit = false;
            this.ShowBasicCombinedDamageRegMiss = false;
            this.ShowBasicCombinedDamageRegAccuracy = false;
            this.ShowBasicCombinedDamageRegLow = false;
            this.ShowBasicCombinedDamageRegHigh = false;
            this.ShowBasicCombinedDamageRegAverage = false;
            this.ShowBasicCombinedDamageRegMod = false;
            this.ShowBasicCombinedDamageRegModAverage = false;
            this.ShowBasicCombinedDamageCritHit = false;
            this.ShowBasicCombinedDamageCritPercent = false;
            this.ShowBasicCombinedDamageCritLow = false;
            this.ShowBasicCombinedDamageCritHigh = false;
            this.ShowBasicCombinedDamageCritAverage = false;
            this.ShowBasicCombinedDamageCritMod = false;
            this.ShowBasicCombinedDamageCritModAverage = false;
            this.ShowBasicCombinedDamageCounter = false;
            this.ShowBasicCombinedDamageCounterPercent = false;
            this.ShowBasicCombinedDamageCounterMod = false;
            this.ShowBasicCombinedDamageCounterModAverage = false;
            this.ShowBasicCombinedDamageBlock = false;
            this.ShowBasicCombinedDamageBlockPercent = false;
            this.ShowBasicCombinedDamageBlockMod = false;
            this.ShowBasicCombinedDamageBlockModAverage = false;
            this.ShowBasicCombinedDamageParry = false;
            this.ShowBasicCombinedDamageParryPercent = false;
            this.ShowBasicCombinedDamageParryMod = false;
            this.ShowBasicCombinedDamageParryModAverage = false;
            this.ShowBasicCombinedDamageResist = false;
            this.ShowBasicCombinedDamageResistPercent = false;
            this.ShowBasicCombinedDamageResistMod = false;
            this.ShowBasicCombinedDamageResistModAverage = false;
            this.ShowBasicCombinedDamageEvade = false;
            this.ShowBasicCombinedDamageEvadePercent = false;
            this.ShowBasicCombinedDamageEvadeMod = false;
            this.ShowBasicCombinedDamageEvadeModAverage = false;
            this.ShowBasicCombinedTotalOverallHealing = false;
            this.ShowBasicCombinedRegularHealing = false;
            this.ShowBasicCombinedCriticalHealing = false;
            this.ShowBasicCombinedTotalHealingActionsUsed = false;
            this.ShowBasicCombinedHPS = false;
            this.ShowBasicCombinedHealingRegHit = false;
            this.ShowBasicCombinedHealingRegLow = false;
            this.ShowBasicCombinedHealingRegHigh = false;
            this.ShowBasicCombinedHealingRegAverage = false;
            this.ShowBasicCombinedHealingRegMod = false;
            this.ShowBasicCombinedHealingRegModAverage = false;
            this.ShowBasicCombinedHealingCritHit = false;
            this.ShowBasicCombinedHealingCritPercent = false;
            this.ShowBasicCombinedHealingCritLow = false;
            this.ShowBasicCombinedHealingCritHigh = false;
            this.ShowBasicCombinedHealingCritAverage = false;
            this.ShowBasicCombinedHealingCritMod = false;
            this.ShowBasicCombinedHealingCritModAverage = false;
            this.ShowBasicCombinedTotalOverallDamageTaken = false;
            this.ShowBasicCombinedRegularDamageTaken = false;
            this.ShowBasicCombinedCriticalDamageTaken = false;
            this.ShowBasicCombinedTotalDamageTakenActionsUsed = false;
            this.ShowBasicCombinedDTPS = false;
            this.ShowBasicCombinedDamageTakenRegHit = false;
            this.ShowBasicCombinedDamageTakenRegMiss = false;
            this.ShowBasicCombinedDamageTakenRegAccuracy = false;
            this.ShowBasicCombinedDamageTakenRegLow = false;
            this.ShowBasicCombinedDamageTakenRegHigh = false;
            this.ShowBasicCombinedDamageTakenRegAverage = false;
            this.ShowBasicCombinedDamageTakenRegMod = false;
            this.ShowBasicCombinedDamageTakenRegModAverage = false;
            this.ShowBasicCombinedDamageTakenCritHit = false;
            this.ShowBasicCombinedDamageTakenCritPercent = false;
            this.ShowBasicCombinedDamageTakenCritLow = false;
            this.ShowBasicCombinedDamageTakenCritHigh = false;
            this.ShowBasicCombinedDamageTakenCritAverage = false;
            this.ShowBasicCombinedDamageTakenCritMod = false;
            this.ShowBasicCombinedDamageTakenCritModAverage = false;
            this.ShowBasicCombinedDamageTakenCounter = false;
            this.ShowBasicCombinedDamageTakenCounterPercent = false;
            this.ShowBasicCombinedDamageTakenCounterMod = false;
            this.ShowBasicCombinedDamageTakenCounterModAverage = false;
            this.ShowBasicCombinedDamageTakenBlock = false;
            this.ShowBasicCombinedDamageTakenBlockPercent = false;
            this.ShowBasicCombinedDamageTakenBlockMod = false;
            this.ShowBasicCombinedDamageTakenBlockModAverage = false;
            this.ShowBasicCombinedDamageTakenParry = false;
            this.ShowBasicCombinedDamageTakenParryPercent = false;
            this.ShowBasicCombinedDamageTakenParryMod = false;
            this.ShowBasicCombinedDamageTakenParryModAverage = false;
            this.ShowBasicCombinedDamageTakenResist = false;
            this.ShowBasicCombinedDamageTakenResistPercent = false;
            this.ShowBasicCombinedDamageTakenResistMod = false;
            this.ShowBasicCombinedDamageTakenResistModAverage = false;
            this.ShowBasicCombinedDamageTakenEvade = false;
            this.ShowBasicCombinedDamageTakenEvadePercent = false;
            this.ShowBasicCombinedDamageTakenEvadeMod = false;
            this.ShowBasicCombinedDamageTakenEvadeModAverage = false;
            this.ShowColumnTotalOverallDamage = true;
            this.ShowColumnRegularDamage = true;
            this.ShowColumnCriticalDamage = true;
            this.ShowColumnTotalDamageActionsUsed = true;
            this.ShowColumnDPS = true;
            this.ShowColumnDamageRegHit = true;
            this.ShowColumnDamageRegMiss = true;
            this.ShowColumnDamageRegAccuracy = true;
            this.ShowColumnDamageRegLow = true;
            this.ShowColumnDamageRegHigh = true;
            this.ShowColumnDamageRegAverage = true;
            this.ShowColumnDamageRegMod = true;
            this.ShowColumnDamageRegModAverage = true;
            this.ShowColumnDamageCritHit = true;
            this.ShowColumnDamageCritPercent = true;
            this.ShowColumnDamageCritLow = true;
            this.ShowColumnDamageCritHigh = true;
            this.ShowColumnDamageCritAverage = true;
            this.ShowColumnDamageCritMod = true;
            this.ShowColumnDamageCritModAverage = true;
            this.ShowColumnDamageCounter = true;
            this.ShowColumnDamageCounterPercent = true;
            this.ShowColumnDamageCounterMod = true;
            this.ShowColumnDamageCounterModAverage = true;
            this.ShowColumnDamageBlock = true;
            this.ShowColumnDamageBlockPercent = true;
            this.ShowColumnDamageBlockMod = true;
            this.ShowColumnDamageBlockModAverage = true;
            this.ShowColumnDamageParry = true;
            this.ShowColumnDamageParryPercent = true;
            this.ShowColumnDamageParryMod = true;
            this.ShowColumnDamageParryModAverage = true;
            this.ShowColumnDamageResist = true;
            this.ShowColumnDamageResistPercent = true;
            this.ShowColumnDamageResistMod = true;
            this.ShowColumnDamageResistModAverage = true;
            this.ShowColumnDamageEvade = true;
            this.ShowColumnDamageEvadePercent = true;
            this.ShowColumnDamageEvadeMod = true;
            this.ShowColumnDamageEvadeModAverage = true;
            this.ShowColumnPercentOfTotalOverallDamage = true;
            this.ShowColumnPercentOfRegularDamage = true;
            this.ShowColumnPercentOfCriticalDamage = true;
            this.ShowColumnTotalOverallHealing = true;
            this.ShowColumnRegularHealing = true;
            this.ShowColumnCriticalHealing = true;
            this.ShowColumnTotalHealingActionsUsed = true;
            this.ShowColumnHPS = true;
            this.ShowColumnHealingRegHit = true;
            this.ShowColumnHealingRegLow = true;
            this.ShowColumnHealingRegHigh = true;
            this.ShowColumnHealingRegAverage = true;
            this.ShowColumnHealingRegMod = true;
            this.ShowColumnHealingRegModAverage = true;
            this.ShowColumnHealingCritHit = true;
            this.ShowColumnHealingCritPercent = true;
            this.ShowColumnHealingCritLow = true;
            this.ShowColumnHealingCritHigh = true;
            this.ShowColumnHealingCritAverage = true;
            this.ShowColumnHealingCritMod = true;
            this.ShowColumnHealingCritModAverage = true;
            this.ShowColumnPercentOfTotalOverallHealing = true;
            this.ShowColumnPercentOfRegularHealing = true;
            this.ShowColumnPercentOfCriticalHealing = true;
            this.ShowColumnTotalOverallDamageTaken = true;
            this.ShowColumnRegularDamageTaken = true;
            this.ShowColumnCriticalDamageTaken = true;
            this.ShowColumnTotalDamageTakenActionsUsed = true;
            this.ShowColumnDTPS = true;
            this.ShowColumnDamageTakenRegHit = true;
            this.ShowColumnDamageTakenRegMiss = true;
            this.ShowColumnDamageTakenRegAccuracy = true;
            this.ShowColumnDamageTakenRegLow = true;
            this.ShowColumnDamageTakenRegHigh = true;
            this.ShowColumnDamageTakenRegAverage = true;
            this.ShowColumnDamageTakenRegMod = true;
            this.ShowColumnDamageTakenRegModAverage = true;
            this.ShowColumnDamageTakenCritHit = true;
            this.ShowColumnDamageTakenCritPercent = true;
            this.ShowColumnDamageTakenCritLow = true;
            this.ShowColumnDamageTakenCritHigh = true;
            this.ShowColumnDamageTakenCritAverage = true;
            this.ShowColumnDamageTakenCritMod = true;
            this.ShowColumnDamageTakenCritModAverage = true;
            this.ShowColumnDamageTakenCounter = true;
            this.ShowColumnDamageTakenCounterPercent = true;
            this.ShowColumnDamageTakenCounterMod = true;
            this.ShowColumnDamageTakenCounterModAverage = true;
            this.ShowColumnDamageTakenBlock = true;
            this.ShowColumnDamageTakenBlockPercent = true;
            this.ShowColumnDamageTakenBlockMod = true;
            this.ShowColumnDamageTakenBlockModAverage = true;
            this.ShowColumnDamageTakenParry = true;
            this.ShowColumnDamageTakenParryPercent = true;
            this.ShowColumnDamageTakenParryMod = true;
            this.ShowColumnDamageTakenParryModAverage = true;
            this.ShowColumnDamageTakenResist = true;
            this.ShowColumnDamageTakenResistPercent = true;
            this.ShowColumnDamageTakenResistMod = true;
            this.ShowColumnDamageTakenResistModAverage = true;
            this.ShowColumnDamageTakenEvade = true;
            this.ShowColumnDamageTakenEvadePercent = true;
            this.ShowColumnDamageTakenEvadeMod = true;
            this.ShowColumnDamageTakenEvadeModAverage = true;
            this.ShowColumnPercentOfTotalOverallDamageTaken = true;
            this.ShowColumnPercentOfRegularDamageTaken = true;
            this.ShowColumnPercentOfCriticalDamageTaken = true;
            this.DPSWidgetWidth = 250;
            this.DPSWidgetHeight = 450;
            this.DPSWidgetSortDirection = "Descending";
            this.DPSWidgetSortDirectionList = new ObservableCollection<string> { "Ascending", "Descending" };
            this.DPSWidgetSortProperty = "CombinedDPS";
            this.DPSWidgetSortPropertyList = new ObservableCollection<string> { "Name", "Job", "DPS", "CombinedDPS", "TotalOverallDamage", "CombinedTotalOverallDamage", "PercentOfOverallDamage" };
            this.DPSWidgetDisplayProperty = "Combined";
            this.DPSWidgetDisplayPropertyList = new ObservableCollection<string> { "Combined", "Individual" };
            this.DPSWidgetUIScale = "1.0";
            this.ShowDPSWidgetOnLoad = true;
            this.DPSWidgetTop = 0;
            this.DPSWidgetLeft = 186;
            this.DPSVisibility = 0;
            this.DPSVisibilityList = new ObservableCollection<double> { 0, 50, 100, 150, 200, 250, 300 };
            this.HPSWidgetWidth = 250;
            this.HPSWidgetHeight = 450;
            this.HPSWidgetSortDirection = "Descending";
            this.HPSWidgetSortProperty = "CombinedHPS";
            this.HPSWidgetDisplayProperty = "Combined";
            this.HPSWidgetUIScale = "1.0";
            this.ShowHPSWidgetOnLoad = true;
            this.HPSWidgetTop = 0;
            this.HPSWidgetLeft = 186;
            this.HPSVisibility = 0;
            this.DTPSWidgetWidth = 250;
            this.DTPSWidgetHeight = 450;
            this.DTPSWidgetSortDirection = "Descending";
            this.DTPSWidgetSortProperty = "CombinedDTPS";
            this.DTPSWidgetDisplayProperty = "Combined";
            this.DTPSWidgetUIScale = "1.0";
            this.ShowDTPSWidgetOnLoad = true;
            this.DTPSWidgetTop = 0;
            this.DTPSWidgetLeft = 186;
            this.DTPSVisibility = 0;
            this.ShowJobNameInWidgets = true;
            this.WidgetClickThroughEnabled = false;
            this.ShowTitlesOnWidgets = true;
            this.WidgetOpacity = "0.7";
            this.DefaultProgressBarForeground = "FF00FF00";
            this.PLDProgressBarForeground = "SkyBlue";
            this.DRGProgressBarForeground = "DarkSlateBlue";
            this.BLMProgressBarForeground = "Purple";
            this.WARProgressBarForeground = "Red";
            this.WHMProgressBarForeground = "White";
            this.SCHProgressBarForeground = "MediumPurple";
            this.MNKProgressBarForeground = "GoldenRod";
            this.BRDProgressBarForeground = "GreenYellow";
            this.SMNProgressBarForeground = "LimeGreen";
        }

        public string StoreHistoryEvent { get; set; }
        public double StoreHistoryInterval { get; set; }
        public bool EnableStoreHistoryReset { get; set; }
        public bool IgnoreLimitBreaks { get; set; }
        public bool TrackXPSFromParseStartEvent { get; set; }
        public bool ParseYou { get; set; }
        public bool ParseParty { get; set; }
        public bool ParseAlliance { get; set; }
        public bool ParseOther { get; set; }
        public bool ParseAdvanced { get; set; }
        public bool ShowBasicTotalOverallDamage { get; set; }
        public bool ShowBasicRegularDamage { get; set; }
        public bool ShowBasicCriticalDamage { get; set; }
        public bool ShowBasicTotalDamageActionsUsed { get; set; }
        public bool ShowBasicDPS { get; set; }
        public bool ShowBasicDamageRegHit { get; set; }
        public bool ShowBasicDamageRegMiss { get; set; }
        public bool ShowBasicDamageRegAccuracy { get; set; }
        public bool ShowBasicDamageRegLow { get; set; }
        public bool ShowBasicDamageRegHigh { get; set; }
        public bool ShowBasicDamageRegAverage { get; set; }
        public bool ShowBasicDamageRegMod { get; set; }
        public bool ShowBasicDamageRegModAverage { get; set; }
        public bool ShowBasicDamageCritHit { get; set; }
        public bool ShowBasicDamageCritPercent { get; set; }
        public bool ShowBasicDamageCritLow { get; set; }
        public bool ShowBasicDamageCritHigh { get; set; }
        public bool ShowBasicDamageCritAverage { get; set; }
        public bool ShowBasicDamageCritMod { get; set; }
        public bool ShowBasicDamageCritModAverage { get; set; }
        public bool ShowBasicDamageCounter { get; set; }
        public bool ShowBasicDamageCounterPercent { get; set; }
        public bool ShowBasicDamageCounterMod { get; set; }
        public bool ShowBasicDamageCounterModAverage { get; set; }
        public bool ShowBasicDamageBlock { get; set; }
        public bool ShowBasicDamageBlockPercent { get; set; }
        public bool ShowBasicDamageBlockMod { get; set; }
        public bool ShowBasicDamageBlockModAverage { get; set; }
        public bool ShowBasicDamageParry { get; set; }
        public bool ShowBasicDamageParryPercent { get; set; }
        public bool ShowBasicDamageParryMod { get; set; }
        public bool ShowBasicDamageParryModAverage { get; set; }
        public bool ShowBasicDamageResist { get; set; }
        public bool ShowBasicDamageResistPercent { get; set; }
        public bool ShowBasicDamageResistMod { get; set; }
        public bool ShowBasicDamageResistModAverage { get; set; }
        public bool ShowBasicDamageEvade { get; set; }
        public bool ShowBasicDamageEvadePercent { get; set; }
        public bool ShowBasicDamageEvadeMod { get; set; }
        public bool ShowBasicDamageEvadeModAverage { get; set; }
        public bool ShowBasicPercentOfTotalOverallDamage { get; set; }
        public bool ShowBasicPercentOfRegularDamage { get; set; }
        public bool ShowBasicPercentOfCriticalDamage { get; set; }
        public bool ShowBasicTotalOverallDamageOverTime { get; set; }
        public bool ShowBasicRegularDamageOverTime { get; set; }
        public bool ShowBasicCriticalDamageOverTime { get; set; }
        public bool ShowBasicTotalDamageOverTimeActionsUsed { get; set; }
        public bool ShowBasicDOTPS { get; set; }
        public bool ShowBasicDamageOverTimeRegHit { get; set; }
        public bool ShowBasicDamageOverTimeRegMiss { get; set; }
        public bool ShowBasicDamageOverTimeRegAccuracy { get; set; }
        public bool ShowBasicDamageOverTimeRegLow { get; set; }
        public bool ShowBasicDamageOverTimeRegHigh { get; set; }
        public bool ShowBasicDamageOverTimeRegAverage { get; set; }
        public bool ShowBasicDamageOverTimeRegMod { get; set; }
        public bool ShowBasicDamageOverTimeRegModAverage { get; set; }
        public bool ShowBasicDamageOverTimeCritHit { get; set; }
        public bool ShowBasicDamageOverTimeCritPercent { get; set; }
        public bool ShowBasicDamageOverTimeCritLow { get; set; }
        public bool ShowBasicDamageOverTimeCritHigh { get; set; }
        public bool ShowBasicDamageOverTimeCritAverage { get; set; }
        public bool ShowBasicDamageOverTimeCritMod { get; set; }
        public bool ShowBasicDamageOverTimeCritModAverage { get; set; }
        public bool ShowBasicPercentOfTotalOverallDamageOverTime { get; set; }
        public bool ShowBasicPercentOfRegularDamageOverTime { get; set; }
        public bool ShowBasicPercentOfCriticalDamageOverTime { get; set; }
        public bool ShowBasicTotalOverallHealing { get; set; }
        public bool ShowBasicRegularHealing { get; set; }
        public bool ShowBasicCriticalHealing { get; set; }
        public bool ShowBasicTotalHealingActionsUsed { get; set; }
        public bool ShowBasicHPS { get; set; }
        public bool ShowBasicHealingRegHit { get; set; }
        public bool ShowBasicHealingRegLow { get; set; }
        public bool ShowBasicHealingRegHigh { get; set; }
        public bool ShowBasicHealingRegAverage { get; set; }
        public bool ShowBasicHealingRegMod { get; set; }
        public bool ShowBasicHealingRegModAverage { get; set; }
        public bool ShowBasicHealingCritHit { get; set; }
        public bool ShowBasicHealingCritPercent { get; set; }
        public bool ShowBasicHealingCritLow { get; set; }
        public bool ShowBasicHealingCritHigh { get; set; }
        public bool ShowBasicHealingCritAverage { get; set; }
        public bool ShowBasicHealingCritMod { get; set; }
        public bool ShowBasicHealingCritModAverage { get; set; }
        public bool ShowBasicPercentOfTotalOverallHealing { get; set; }
        public bool ShowBasicPercentOfRegularHealing { get; set; }
        public bool ShowBasicPercentOfCriticalHealing { get; set; }
        public bool ShowBasicTotalOverallHealingOverTime { get; set; }
        public bool ShowBasicRegularHealingOverTime { get; set; }
        public bool ShowBasicCriticalHealingOverTime { get; set; }
        public bool ShowBasicTotalHealingOverTimeActionsUsed { get; set; }
        public bool ShowBasicHOTPS { get; set; }
        public bool ShowBasicHealingOverTimeRegHit { get; set; }
        public bool ShowBasicHealingOverTimeRegLow { get; set; }
        public bool ShowBasicHealingOverTimeRegHigh { get; set; }
        public bool ShowBasicHealingOverTimeRegAverage { get; set; }
        public bool ShowBasicHealingOverTimeRegMod { get; set; }
        public bool ShowBasicHealingOverTimeRegModAverage { get; set; }
        public bool ShowBasicHealingOverTimeCritHit { get; set; }
        public bool ShowBasicHealingOverTimeCritPercent { get; set; }
        public bool ShowBasicHealingOverTimeCritLow { get; set; }
        public bool ShowBasicHealingOverTimeCritHigh { get; set; }
        public bool ShowBasicHealingOverTimeCritAverage { get; set; }
        public bool ShowBasicHealingOverTimeCritMod { get; set; }
        public bool ShowBasicHealingOverTimeCritModAverage { get; set; }
        public bool ShowBasicPercentOfTotalOverallHealingOverTime { get; set; }
        public bool ShowBasicPercentOfRegularHealingOverTime { get; set; }
        public bool ShowBasicPercentOfCriticalHealingOverTime { get; set; }
        public bool ShowBasicTotalOverallHealingOverHealing { get; set; }
        public bool ShowBasicRegularHealingOverHealing { get; set; }
        public bool ShowBasicCriticalHealingOverHealing { get; set; }
        public bool ShowBasicTotalHealingOverHealingActionsUsed { get; set; }
        public bool ShowBasicHOHPS { get; set; }
        public bool ShowBasicHealingOverHealingRegHit { get; set; }
        public bool ShowBasicHealingOverHealingRegLow { get; set; }
        public bool ShowBasicHealingOverHealingRegHigh { get; set; }
        public bool ShowBasicHealingOverHealingRegAverage { get; set; }
        public bool ShowBasicHealingOverHealingRegMod { get; set; }
        public bool ShowBasicHealingOverHealingRegModAverage { get; set; }
        public bool ShowBasicHealingOverHealingCritHit { get; set; }
        public bool ShowBasicHealingOverHealingCritPercent { get; set; }
        public bool ShowBasicHealingOverHealingCritLow { get; set; }
        public bool ShowBasicHealingOverHealingCritHigh { get; set; }
        public bool ShowBasicHealingOverHealingCritAverage { get; set; }
        public bool ShowBasicHealingOverHealingCritMod { get; set; }
        public bool ShowBasicHealingOverHealingCritModAverage { get; set; }
        public bool ShowBasicPercentOfTotalOverallHealingOverHealing { get; set; }
        public bool ShowBasicPercentOfRegularHealingOverHealing { get; set; }
        public bool ShowBasicPercentOfCriticalHealingOverHealing { get; set; }
        public bool ShowBasicTotalOverallHealingMitigated { get; set; }
        public bool ShowBasicRegularHealingMitigated { get; set; }
        public bool ShowBasicCriticalHealingMitigated { get; set; }
        public bool ShowBasicTotalHealingMitigatedActionsUsed { get; set; }
        public bool ShowBasicHMPS { get; set; }
        public bool ShowBasicHealingMitigatedRegHit { get; set; }
        public bool ShowBasicHealingMitigatedRegLow { get; set; }
        public bool ShowBasicHealingMitigatedRegHigh { get; set; }
        public bool ShowBasicHealingMitigatedRegAverage { get; set; }
        public bool ShowBasicHealingMitigatedRegMod { get; set; }
        public bool ShowBasicHealingMitigatedRegModAverage { get; set; }
        public bool ShowBasicHealingMitigatedCritHit { get; set; }
        public bool ShowBasicHealingMitigatedCritPercent { get; set; }
        public bool ShowBasicHealingMitigatedCritLow { get; set; }
        public bool ShowBasicHealingMitigatedCritHigh { get; set; }
        public bool ShowBasicHealingMitigatedCritAverage { get; set; }
        public bool ShowBasicHealingMitigatedCritMod { get; set; }
        public bool ShowBasicHealingMitigatedCritModAverage { get; set; }
        public bool ShowBasicPercentOfTotalOverallHealingMitigated { get; set; }
        public bool ShowBasicPercentOfRegularHealingMitigated { get; set; }
        public bool ShowBasicPercentOfCriticalHealingMitigated { get; set; }
        public bool ShowBasicTotalOverallDamageTaken { get; set; }
        public bool ShowBasicRegularDamageTaken { get; set; }
        public bool ShowBasicCriticalDamageTaken { get; set; }
        public bool ShowBasicTotalDamageTakenActionsUsed { get; set; }
        public bool ShowBasicDTPS { get; set; }
        public bool ShowBasicDamageTakenRegHit { get; set; }
        public bool ShowBasicDamageTakenRegMiss { get; set; }
        public bool ShowBasicDamageTakenRegAccuracy { get; set; }
        public bool ShowBasicDamageTakenRegLow { get; set; }
        public bool ShowBasicDamageTakenRegHigh { get; set; }
        public bool ShowBasicDamageTakenRegAverage { get; set; }
        public bool ShowBasicDamageTakenRegMod { get; set; }
        public bool ShowBasicDamageTakenRegModAverage { get; set; }
        public bool ShowBasicDamageTakenCritHit { get; set; }
        public bool ShowBasicDamageTakenCritPercent { get; set; }
        public bool ShowBasicDamageTakenCritLow { get; set; }
        public bool ShowBasicDamageTakenCritHigh { get; set; }
        public bool ShowBasicDamageTakenCritAverage { get; set; }
        public bool ShowBasicDamageTakenCritMod { get; set; }
        public bool ShowBasicDamageTakenCritModAverage { get; set; }
        public bool ShowBasicDamageTakenCounter { get; set; }
        public bool ShowBasicDamageTakenCounterPercent { get; set; }
        public bool ShowBasicDamageTakenCounterMod { get; set; }
        public bool ShowBasicDamageTakenCounterModAverage { get; set; }
        public bool ShowBasicDamageTakenBlock { get; set; }
        public bool ShowBasicDamageTakenBlockPercent { get; set; }
        public bool ShowBasicDamageTakenBlockMod { get; set; }
        public bool ShowBasicDamageTakenBlockModAverage { get; set; }
        public bool ShowBasicDamageTakenParry { get; set; }
        public bool ShowBasicDamageTakenParryPercent { get; set; }
        public bool ShowBasicDamageTakenParryMod { get; set; }
        public bool ShowBasicDamageTakenParryModAverage { get; set; }
        public bool ShowBasicDamageTakenResist { get; set; }
        public bool ShowBasicDamageTakenResistPercent { get; set; }
        public bool ShowBasicDamageTakenResistMod { get; set; }
        public bool ShowBasicDamageTakenResistModAverage { get; set; }
        public bool ShowBasicDamageTakenEvade { get; set; }
        public bool ShowBasicDamageTakenEvadePercent { get; set; }
        public bool ShowBasicDamageTakenEvadeMod { get; set; }
        public bool ShowBasicDamageTakenEvadeModAverage { get; set; }
        public bool ShowBasicPercentOfTotalOverallDamageTaken { get; set; }
        public bool ShowBasicPercentOfRegularDamageTaken { get; set; }
        public bool ShowBasicPercentOfCriticalDamageTaken { get; set; }
        public bool ShowBasicTotalOverallDamageTakenOverTime { get; set; }
        public bool ShowBasicRegularDamageTakenOverTime { get; set; }
        public bool ShowBasicCriticalDamageTakenOverTime { get; set; }
        public bool ShowBasicTotalDamageTakenOverTimeActionsUsed { get; set; }
        public bool ShowBasicDTOTPS { get; set; }
        public bool ShowBasicDamageTakenOverTimeRegHit { get; set; }
        public bool ShowBasicDamageTakenOverTimeRegMiss { get; set; }
        public bool ShowBasicDamageTakenOverTimeRegAccuracy { get; set; }
        public bool ShowBasicDamageTakenOverTimeRegLow { get; set; }
        public bool ShowBasicDamageTakenOverTimeRegHigh { get; set; }
        public bool ShowBasicDamageTakenOverTimeRegAverage { get; set; }
        public bool ShowBasicDamageTakenOverTimeRegMod { get; set; }
        public bool ShowBasicDamageTakenOverTimeRegModAverage { get; set; }
        public bool ShowBasicDamageTakenOverTimeCritHit { get; set; }
        public bool ShowBasicDamageTakenOverTimeCritPercent { get; set; }
        public bool ShowBasicDamageTakenOverTimeCritLow { get; set; }
        public bool ShowBasicDamageTakenOverTimeCritHigh { get; set; }
        public bool ShowBasicDamageTakenOverTimeCritAverage { get; set; }
        public bool ShowBasicDamageTakenOverTimeCritMod { get; set; }
        public bool ShowBasicDamageTakenOverTimeCritModAverage { get; set; }
        public bool ShowBasicPercentOfTotalOverallDamageTakenOverTime { get; set; }
        public bool ShowBasicPercentOfRegularDamageTakenOverTime { get; set; }
        public bool ShowBasicPercentOfCriticalDamageTakenOverTime { get; set; }
        public bool ShowBasicCombinedTotalOverallDamage { get; set; }
        public bool ShowBasicCombinedRegularDamage { get; set; }
        public bool ShowBasicCombinedCriticalDamage { get; set; }
        public bool ShowBasicCombinedTotalDamageActionsUsed { get; set; }
        public bool ShowBasicCombinedDPS { get; set; }
        public bool ShowBasicCombinedDamageRegHit { get; set; }
        public bool ShowBasicCombinedDamageRegMiss { get; set; }
        public bool ShowBasicCombinedDamageRegAccuracy { get; set; }
        public bool ShowBasicCombinedDamageRegLow { get; set; }
        public bool ShowBasicCombinedDamageRegHigh { get; set; }
        public bool ShowBasicCombinedDamageRegAverage { get; set; }
        public bool ShowBasicCombinedDamageRegMod { get; set; }
        public bool ShowBasicCombinedDamageRegModAverage { get; set; }
        public bool ShowBasicCombinedDamageCritHit { get; set; }
        public bool ShowBasicCombinedDamageCritPercent { get; set; }
        public bool ShowBasicCombinedDamageCritLow { get; set; }
        public bool ShowBasicCombinedDamageCritHigh { get; set; }
        public bool ShowBasicCombinedDamageCritAverage { get; set; }
        public bool ShowBasicCombinedDamageCritMod { get; set; }
        public bool ShowBasicCombinedDamageCritModAverage { get; set; }
        public bool ShowBasicCombinedDamageCounter { get; set; }
        public bool ShowBasicCombinedDamageCounterPercent { get; set; }
        public bool ShowBasicCombinedDamageCounterMod { get; set; }
        public bool ShowBasicCombinedDamageCounterModAverage { get; set; }
        public bool ShowBasicCombinedDamageBlock { get; set; }
        public bool ShowBasicCombinedDamageBlockPercent { get; set; }
        public bool ShowBasicCombinedDamageBlockMod { get; set; }
        public bool ShowBasicCombinedDamageBlockModAverage { get; set; }
        public bool ShowBasicCombinedDamageParry { get; set; }
        public bool ShowBasicCombinedDamageParryPercent { get; set; }
        public bool ShowBasicCombinedDamageParryMod { get; set; }
        public bool ShowBasicCombinedDamageParryModAverage { get; set; }
        public bool ShowBasicCombinedDamageResist { get; set; }
        public bool ShowBasicCombinedDamageResistPercent { get; set; }
        public bool ShowBasicCombinedDamageResistMod { get; set; }
        public bool ShowBasicCombinedDamageResistModAverage { get; set; }
        public bool ShowBasicCombinedDamageEvade { get; set; }
        public bool ShowBasicCombinedDamageEvadePercent { get; set; }
        public bool ShowBasicCombinedDamageEvadeMod { get; set; }
        public bool ShowBasicCombinedDamageEvadeModAverage { get; set; }
        public bool ShowBasicCombinedTotalOverallHealing { get; set; }
        public bool ShowBasicCombinedRegularHealing { get; set; }
        public bool ShowBasicCombinedCriticalHealing { get; set; }
        public bool ShowBasicCombinedTotalHealingActionsUsed { get; set; }
        public bool ShowBasicCombinedHPS { get; set; }
        public bool ShowBasicCombinedHealingRegHit { get; set; }
        public bool ShowBasicCombinedHealingRegLow { get; set; }
        public bool ShowBasicCombinedHealingRegHigh { get; set; }
        public bool ShowBasicCombinedHealingRegAverage { get; set; }
        public bool ShowBasicCombinedHealingRegMod { get; set; }
        public bool ShowBasicCombinedHealingRegModAverage { get; set; }
        public bool ShowBasicCombinedHealingCritHit { get; set; }
        public bool ShowBasicCombinedHealingCritPercent { get; set; }
        public bool ShowBasicCombinedHealingCritLow { get; set; }
        public bool ShowBasicCombinedHealingCritHigh { get; set; }
        public bool ShowBasicCombinedHealingCritAverage { get; set; }
        public bool ShowBasicCombinedHealingCritMod { get; set; }
        public bool ShowBasicCombinedHealingCritModAverage { get; set; }
        public bool ShowBasicCombinedTotalOverallDamageTaken { get; set; }
        public bool ShowBasicCombinedRegularDamageTaken { get; set; }
        public bool ShowBasicCombinedCriticalDamageTaken { get; set; }
        public bool ShowBasicCombinedTotalDamageTakenActionsUsed { get; set; }
        public bool ShowBasicCombinedDTPS { get; set; }
        public bool ShowBasicCombinedDamageTakenRegHit { get; set; }
        public bool ShowBasicCombinedDamageTakenRegMiss { get; set; }
        public bool ShowBasicCombinedDamageTakenRegAccuracy { get; set; }
        public bool ShowBasicCombinedDamageTakenRegLow { get; set; }
        public bool ShowBasicCombinedDamageTakenRegHigh { get; set; }
        public bool ShowBasicCombinedDamageTakenRegAverage { get; set; }
        public bool ShowBasicCombinedDamageTakenRegMod { get; set; }
        public bool ShowBasicCombinedDamageTakenRegModAverage { get; set; }
        public bool ShowBasicCombinedDamageTakenCritHit { get; set; }
        public bool ShowBasicCombinedDamageTakenCritPercent { get; set; }
        public bool ShowBasicCombinedDamageTakenCritLow { get; set; }
        public bool ShowBasicCombinedDamageTakenCritHigh { get; set; }
        public bool ShowBasicCombinedDamageTakenCritAverage { get; set; }
        public bool ShowBasicCombinedDamageTakenCritMod { get; set; }
        public bool ShowBasicCombinedDamageTakenCritModAverage { get; set; }
        public bool ShowBasicCombinedDamageTakenCounter { get; set; }
        public bool ShowBasicCombinedDamageTakenCounterPercent { get; set; }
        public bool ShowBasicCombinedDamageTakenCounterMod { get; set; }
        public bool ShowBasicCombinedDamageTakenCounterModAverage { get; set; }
        public bool ShowBasicCombinedDamageTakenBlock { get; set; }
        public bool ShowBasicCombinedDamageTakenBlockPercent { get; set; }
        public bool ShowBasicCombinedDamageTakenBlockMod { get; set; }
        public bool ShowBasicCombinedDamageTakenBlockModAverage { get; set; }
        public bool ShowBasicCombinedDamageTakenParry { get; set; }
        public bool ShowBasicCombinedDamageTakenParryPercent { get; set; }
        public bool ShowBasicCombinedDamageTakenParryMod { get; set; }
        public bool ShowBasicCombinedDamageTakenParryModAverage { get; set; }
        public bool ShowBasicCombinedDamageTakenResist { get; set; }
        public bool ShowBasicCombinedDamageTakenResistPercent { get; set; }
        public bool ShowBasicCombinedDamageTakenResistMod { get; set; }
        public bool ShowBasicCombinedDamageTakenResistModAverage { get; set; }
        public bool ShowBasicCombinedDamageTakenEvade { get; set; }
        public bool ShowBasicCombinedDamageTakenEvadePercent { get; set; }
        public bool ShowBasicCombinedDamageTakenEvadeMod { get; set; }
        public bool ShowBasicCombinedDamageTakenEvadeModAverage { get; set; }
        public bool ShowColumnTotalOverallDamage { get; set; }
        public bool ShowColumnRegularDamage { get; set; }
        public bool ShowColumnCriticalDamage { get; set; }
        public bool ShowColumnTotalDamageActionsUsed { get; set; }
        public bool ShowColumnDPS { get; set; }
        public bool ShowColumnDamageRegHit { get; set; }
        public bool ShowColumnDamageRegMiss { get; set; }
        public bool ShowColumnDamageRegAccuracy { get; set; }
        public bool ShowColumnDamageRegLow { get; set; }
        public bool ShowColumnDamageRegHigh { get; set; }
        public bool ShowColumnDamageRegAverage { get; set; }
        public bool ShowColumnDamageRegMod { get; set; }
        public bool ShowColumnDamageRegModAverage { get; set; }
        public bool ShowColumnDamageCritHit { get; set; }
        public bool ShowColumnDamageCritPercent { get; set; }
        public bool ShowColumnDamageCritLow { get; set; }
        public bool ShowColumnDamageCritHigh { get; set; }
        public bool ShowColumnDamageCritAverage { get; set; }
        public bool ShowColumnDamageCritMod { get; set; }
        public bool ShowColumnDamageCritModAverage { get; set; }
        public bool ShowColumnDamageCounter { get; set; }
        public bool ShowColumnDamageCounterPercent { get; set; }
        public bool ShowColumnDamageCounterMod { get; set; }
        public bool ShowColumnDamageCounterModAverage { get; set; }
        public bool ShowColumnDamageBlock { get; set; }
        public bool ShowColumnDamageBlockPercent { get; set; }
        public bool ShowColumnDamageBlockMod { get; set; }
        public bool ShowColumnDamageBlockModAverage { get; set; }
        public bool ShowColumnDamageParry { get; set; }
        public bool ShowColumnDamageParryPercent { get; set; }
        public bool ShowColumnDamageParryMod { get; set; }
        public bool ShowColumnDamageParryModAverage { get; set; }
        public bool ShowColumnDamageResist { get; set; }
        public bool ShowColumnDamageResistPercent { get; set; }
        public bool ShowColumnDamageResistMod { get; set; }
        public bool ShowColumnDamageResistModAverage { get; set; }
        public bool ShowColumnDamageEvade { get; set; }
        public bool ShowColumnDamageEvadePercent { get; set; }
        public bool ShowColumnDamageEvadeMod { get; set; }
        public bool ShowColumnDamageEvadeModAverage { get; set; }
        public bool ShowColumnPercentOfTotalOverallDamage { get; set; }
        public bool ShowColumnPercentOfRegularDamage { get; set; }
        public bool ShowColumnPercentOfCriticalDamage { get; set; }
        public bool ShowColumnTotalOverallHealing { get; set; }
        public bool ShowColumnRegularHealing { get; set; }
        public bool ShowColumnCriticalHealing { get; set; }
        public bool ShowColumnTotalHealingActionsUsed { get; set; }
        public bool ShowColumnHPS { get; set; }
        public bool ShowColumnHealingRegHit { get; set; }
        public bool ShowColumnHealingRegLow { get; set; }
        public bool ShowColumnHealingRegHigh { get; set; }
        public bool ShowColumnHealingRegAverage { get; set; }
        public bool ShowColumnHealingRegMod { get; set; }
        public bool ShowColumnHealingRegModAverage { get; set; }
        public bool ShowColumnHealingCritHit { get; set; }
        public bool ShowColumnHealingCritPercent { get; set; }
        public bool ShowColumnHealingCritLow { get; set; }
        public bool ShowColumnHealingCritHigh { get; set; }
        public bool ShowColumnHealingCritAverage { get; set; }
        public bool ShowColumnHealingCritMod { get; set; }
        public bool ShowColumnHealingCritModAverage { get; set; }
        public bool ShowColumnPercentOfTotalOverallHealing { get; set; }
        public bool ShowColumnPercentOfRegularHealing { get; set; }
        public bool ShowColumnPercentOfCriticalHealing { get; set; }
        public bool ShowColumnTotalOverallDamageTaken { get; set; }
        public bool ShowColumnRegularDamageTaken { get; set; }
        public bool ShowColumnCriticalDamageTaken { get; set; }
        public bool ShowColumnTotalDamageTakenActionsUsed { get; set; }
        public bool ShowColumnDTPS { get; set; }
        public bool ShowColumnDamageTakenRegHit { get; set; }
        public bool ShowColumnDamageTakenRegMiss { get; set; }
        public bool ShowColumnDamageTakenRegAccuracy { get; set; }
        public bool ShowColumnDamageTakenRegLow { get; set; }
        public bool ShowColumnDamageTakenRegHigh { get; set; }
        public bool ShowColumnDamageTakenRegAverage { get; set; }
        public bool ShowColumnDamageTakenRegMod { get; set; }
        public bool ShowColumnDamageTakenRegModAverage { get; set; }
        public bool ShowColumnDamageTakenCritHit { get; set; }
        public bool ShowColumnDamageTakenCritPercent { get; set; }
        public bool ShowColumnDamageTakenCritLow { get; set; }
        public bool ShowColumnDamageTakenCritHigh { get; set; }
        public bool ShowColumnDamageTakenCritAverage { get; set; }
        public bool ShowColumnDamageTakenCritMod { get; set; }
        public bool ShowColumnDamageTakenCritModAverage { get; set; }
        public bool ShowColumnDamageTakenCounter { get; set; }
        public bool ShowColumnDamageTakenCounterPercent { get; set; }
        public bool ShowColumnDamageTakenCounterMod { get; set; }
        public bool ShowColumnDamageTakenCounterModAverage { get; set; }
        public bool ShowColumnDamageTakenBlock { get; set; }
        public bool ShowColumnDamageTakenBlockPercent { get; set; }
        public bool ShowColumnDamageTakenBlockMod { get; set; }
        public bool ShowColumnDamageTakenBlockModAverage { get; set; }
        public bool ShowColumnDamageTakenParry { get; set; }
        public bool ShowColumnDamageTakenParryPercent { get; set; }
        public bool ShowColumnDamageTakenParryMod { get; set; }
        public bool ShowColumnDamageTakenParryModAverage { get; set; }
        public bool ShowColumnDamageTakenResist { get; set; }
        public bool ShowColumnDamageTakenResistPercent { get; set; }
        public bool ShowColumnDamageTakenResistMod { get; set; }
        public bool ShowColumnDamageTakenResistModAverage { get; set; }
        public bool ShowColumnDamageTakenEvade { get; set; }
        public bool ShowColumnDamageTakenEvadePercent { get; set; }
        public bool ShowColumnDamageTakenEvadeMod { get; set; }
        public bool ShowColumnDamageTakenEvadeModAverage { get; set; }
        public bool ShowColumnPercentOfTotalOverallDamageTaken { get; set; }
        public bool ShowColumnPercentOfRegularDamageTaken { get; set; }
        public bool ShowColumnPercentOfCriticalDamageTaken { get; set; }
        public int DPSWidgetWidth { get; set; }
        public int DPSWidgetHeight { get; set; }
        public string DPSWidgetSortDirection { get; set; }
        public ObservableCollection<string> DPSWidgetSortDirectionList { get; set; }
        public string DPSWidgetSortProperty { get; set; }
        public ObservableCollection<string> DPSWidgetSortPropertyList { get; set; }
        public string DPSWidgetDisplayProperty { get; set; }
        public ObservableCollection<string> DPSWidgetDisplayPropertyList { get; set; }
        public string DPSWidgetUIScale { get; set; }
        public bool ShowDPSWidgetOnLoad { get; set; }
        public int DPSWidgetTop { get; set; }
        public int DPSWidgetLeft { get; set; }
        public double DPSVisibility { get; set; }
        public ObservableCollection<double> DPSVisibilityList { get; set; }
        public int HPSWidgetWidth { get; set; }
        public int HPSWidgetHeight { get; set; }
        public string HPSWidgetSortDirection { get; set; }
        public string HPSWidgetSortProperty { get; set; }
        public string HPSWidgetDisplayProperty { get; set; }
        public string HPSWidgetUIScale { get; set; }
        public bool ShowHPSWidgetOnLoad { get; set; }
        public int HPSWidgetTop { get; set; }
        public int HPSWidgetLeft { get; set; }
        public double HPSVisibility { get; set; }
        public int DTPSWidgetWidth { get; set; }
        public int DTPSWidgetHeight { get; set; }
        public string DTPSWidgetSortDirection { get; set; }
        public string DTPSWidgetSortProperty { get; set; }
        public string DTPSWidgetDisplayProperty { get; set; }
        public string DTPSWidgetUIScale { get; set; }
        public bool ShowDTPSWidgetOnLoad { get; set; }
        public int DTPSWidgetTop { get; set; }
        public int DTPSWidgetLeft { get; set; }
        public double DTPSVisibility { get; set; }
        public bool ShowJobNameInWidgets { get; set; }
        public bool WidgetClickThroughEnabled { get; set; }
        public bool ShowTitlesOnWidgets { get; set; }
        public string WidgetOpacity { get; set; }
        public string DefaultProgressBarForeground { get; set; }
        public string PLDProgressBarForeground { get; set; }
        public string DRGProgressBarForeground { get; set; }
        public string BLMProgressBarForeground { get; set; }
        public string WARProgressBarForeground { get; set; }
        public string WHMProgressBarForeground { get; set; }
        public string SCHProgressBarForeground { get; set; }
        public string MNKProgressBarForeground { get; set; }
        public string BRDProgressBarForeground { get; set; }
        public string SMNProgressBarForeground { get; set; }

        private void RaisePropertyChanged([CallerMemberName] string caller = "") {
            this.PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }
   }
}