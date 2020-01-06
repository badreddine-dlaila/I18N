using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// SaintHelena Regions
    /// </summary>
    public static class SaintHelenaRegions {

        #region Gets regions

        /// <summary>
        /// Ascension Island
        /// </summary>
        public static EnumValues AscensionIsland => EnumValues.AscensionIsland;

        /// <summary>
        /// Saint Helena
        /// </summary>
        public static EnumValues SaintHelena => EnumValues.SaintHelena;

        /// <summary>
        /// Tristan da Cunha
        /// </summary>
        public static EnumValues TristanDaCunha => EnumValues.TristanDaCunha;

        #endregion

        /// <summary>
        /// Enum values for SaintHelena regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Ascension Island
            /// </summary>
            [AliasInShort("AC")]
            AscensionIsland,

            /// <summary>
            /// Saint Helena
            /// </summary>
            [AliasInShort("HL")]
            SaintHelena,

            /// <summary>
            /// Tristan da Cunha
            /// </summary>
            [AliasInShort("TA")]
            TristanDaCunha,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SaintHelenaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SaintHelenaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"SH-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.SaintHelena;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.SH;
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