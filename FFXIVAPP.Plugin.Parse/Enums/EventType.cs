// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventType.cs" company="SyndicatedLife">
//   Copyright(c) 2018 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (http://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   EventType.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Parse.Enums {
    public enum EventType : long {
        Unknown = 0x0,

        Damage = 0x00002000000,

        Failed = 0x00004000000,

        Actions = 0x00008000000,

        Items = 0x00010000000,

        Cure = 0x00020000000,

        Beneficial = 0x00040000000,

        Detrimental = 0x00080000000,

        System = 0x00100000000,

        Battle = 0x00200000000,

        Synthesis = 0x00400000000,

        Gathering = 0x00800000000,

        Error = 0x01000000000,

        Echo = 0x02000000000,

        Dialogue = 0x04000000000,

        Loot = 0x08000000000,

        Progression = 0x10000000000,

        Defeats = 0x20000000000
    }
}