using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// Tuvalu Regions
    /// </summary>
    public static class TuvaluRegions {

        #region Gets regions

        /// <summary>
        /// Funafuti
        /// </summary>
        public static EnumValues Funafuti => EnumValues.Funafuti;

        /// <summary>
        /// Niutao
        /// </summary>
        public static EnumValues Niutao => EnumValues.Niutao;

        /// <summary>
        /// Nukufetau
        /// </summary>
        public static EnumValues Nukufetau => EnumValues.Nukufetau;

        /// <summary>
        /// Nukulaelae
        /// </summary>
        public static EnumValues Nukulaelae => EnumValues.Nukulaelae;

        /// <summary>
        /// Nanumea
        /// </summary>
        public static EnumValues Nanumea => EnumValues.Nanumea;

        /// <summary>
        /// Nanumanga
        /// </summary>
        public static EnumValues Nanumanga => EnumValues.Nanumanga;

        /// <summary>
        /// Nui
        /// </summary>
        public static EnumValues Nui => EnumValues.Nui;

        /// <summary>
        /// Vaitupu
        /// </summary>
        public static EnumValues Vaitupu => EnumValues.Vaitupu;

        #endregion

        /// <summary>
        /// Enum values for Tuvalu regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Funafuti
            /// </summary>
            [AliasInShort("FUN")]
            Funafuti,

            /// <summary>
            /// Niutao
            /// </summary>
            [AliasInShort("NIT")]
            Niutao,

            /// <summary>
            /// Nukufetau
            /// </summary>
            [AliasInShort("NKF")]
            Nukufetau,

            /// <summary>
            /// Nukulaelae
            /// </summary>
            [AliasInShort("NKL")]
            Nukulaelae,

            /// <summary>
            /// Nanumea
            /// </summary>
            [AliasInShort("NMA")]
            Nanumea,

            /// <summary>
            /// Nanumanga
            /// </summary>
            [AliasInShort("NMG")]
            Nanumanga,

            /// <summary>
            /// Nui
            /// </summary>
            [AliasInShort("NUI")]
            Nui,

            /// <summary>
            /// Vaitupu
            /// </summary>
            [AliasInShort("VAI")]
            Vaitupu,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="TuvaluRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="TuvaluRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"TV-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Tuvalu;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.TV;
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