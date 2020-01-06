using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// Guinea Bissau regions
    /// </summary>
    public static class GuineaBissauRegions {

        #region Gets regions

        /// <summary>
        /// Bissau
        /// </summary>
        public static EnumValues Bissau => EnumValues.Bissau;

        /// <summary>
        /// Leste
        /// </summary>
        public static EnumValues Leste => EnumValues.Leste;

        /// <summary>
        /// Norte
        /// </summary>
        public static EnumValues Norte => EnumValues.Norte;

        /// <summary>
        /// Sul
        /// </summary>
        public static EnumValues Sul => EnumValues.Sul;

        #endregion

        /// <summary>
        /// Enum values for GuineaBissau regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Bissau
            /// </summary>
            [AliasInShort("BS")]
            Bissau,

            /// <summary>
            /// Leste
            /// </summary>
            [AliasInShort("L")]
            Leste,

            /// <summary>
            /// Norte
            /// </summary>
            [AliasInShort("N")]
            Norte,

            /// <summary>
            /// Sul
            /// </summary>
            [AliasInShort("S")]
            Sul,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="GuineaBissauRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="GuineaBissauRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"GW-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.GuineaBissau;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.GW;
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