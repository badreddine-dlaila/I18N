using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// Liberia Regions
    /// </summary>
    public static class LiberiaRegions {

        #region Gets regions

        /// <summary>
        /// Bong
        /// </summary>
        public static EnumValues Bong => EnumValues.Bong;

        /// <summary>
        /// Bomi
        /// </summary>
        public static EnumValues Bomi => EnumValues.Bomi;

        /// <summary>
        /// Grand Cape Mount
        /// </summary>
        public static EnumValues GrandCapeMount => EnumValues.GrandCapeMount;

        /// <summary>
        /// Grand Bassa
        /// </summary>
        public static EnumValues GrandBassa => EnumValues.GrandBassa;

        /// <summary>
        /// Grand Gedeh
        /// </summary>
        public static EnumValues GrandGedeh => EnumValues.GrandGedeh;

        /// <summary>
        /// Grand Kru
        /// </summary>
        public static EnumValues GrandKru => EnumValues.GrandKru;

        /// <summary>
        /// Gbarpolu
        /// </summary>
        public static EnumValues Gbarpolu => EnumValues.Gbarpolu;

        /// <summary>
        /// Lofa 
        /// </summary>
        public static EnumValues Lofa => EnumValues.Lofa;

        /// <summary>
        /// Margibi
        /// </summary>
        public static EnumValues Margibi => EnumValues.Margibi;

        /// <summary>
        /// Montserrado
        /// </summary>
        public static EnumValues Montserrado => EnumValues.Montserrado;

        /// <summary>
        /// Maryland
        /// </summary>
        public static EnumValues Maryland => EnumValues.Maryland;

        /// <summary>
        /// Nimba
        /// </summary>
        public static EnumValues Nimba => EnumValues.Nimba;

        /// <summary>
        /// River Gee
        /// </summary>
        public static EnumValues RiverGee => EnumValues.RiverGee;

        /// <summary>
        /// Rivercess
        /// </summary>
        public static EnumValues Rivercess => EnumValues.Rivercess;

        /// <summary>
        /// Sinoe
        /// </summary>
        public static EnumValues Sinoe => EnumValues.Sinoe;

        #endregion

        /// <summary>
        /// Enum values for Liberia regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Bong
            /// </summary>
            [AliasInShort("BG")]
            Bong,

            /// <summary>
            /// Bomi
            /// </summary>
            [AliasInShort("BM")]
            Bomi,

            /// <summary>
            /// Grand Cape Mount
            /// </summary>
            [AliasInShort("CM")]
            GrandCapeMount,

            /// <summary>
            /// Grand Bassa
            /// </summary>
            [AliasInShort("GB")]
            GrandBassa,

            /// <summary>
            /// Grand Gedeh
            /// </summary>
            [AliasInShort("GG")]
            GrandGedeh,

            /// <summary>
            /// Grand Kru
            /// </summary>
            [AliasInShort("GK")]
            GrandKru,

            /// <summary>
            /// Gbarpolu
            /// </summary>
            [AliasInShort("GP")]
            Gbarpolu,

            /// <summary>
            /// Lofa
            /// </summary>
            [AliasInShort("LO")]
            Lofa,

            /// <summary>
            /// Margibi
            /// </summary>
            [AliasInShort("MG")]
            Margibi,

            /// <summary>
            /// Montserrado
            /// </summary>
            [AliasInShort("MO")]
            Montserrado,

            /// <summary>
            /// Maryland
            /// </summary>
            [AliasInShort("MY")]
            Maryland,

            /// <summary>
            /// Nimba
            /// </summary>
            [AliasInShort("NI")]
            Nimba,

            /// <summary>
            /// River Gee
            /// </summary>
            [AliasInShort("RG")]
            RiverGee,

            /// <summary>
            /// Rivercess
            /// </summary>
            [AliasInShort("RI")]
            Rivercess,

            /// <summary>
            /// Sinoe
            /// </summary>
            [AliasInShort("SI")]
            Sinoe,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="LiberiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="LiberiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"LR-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Liberia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.LR;
        }

        #endregion

        #region Getters

        private static List<EnumMember<EnumValues>> InternalEnumMembersCache { get; }
            = Enums.GetMembers<EnumValues>().Where(x => !x.Attributes.Has<IgnoreRegionAttribute>()).ToList();

        /// <summary>
        /// Get all region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAllRegonCodes() {
            foreach (var member in InternalEnumMembersCache)
                yield return member.Value.ToFullRegionCode();
        }

        #endregion

    }
}