using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// Ghana Regions
    /// </summary>
    public static class GhanaRegions {

        #region Gets regions

        /// <summary>
        /// Greater Accra
        /// </summary>
        public static EnumValues GreaterAccra => EnumValues.GreaterAccra;

        /// <summary>
        /// Ashanti
        /// </summary>
        public static EnumValues Ashanti => EnumValues.Ashanti;

        /// <summary>
        /// Brong-Ahafo
        /// </summary>
        public static EnumValues BrongAhafo => EnumValues.BrongAhafo;

        /// <summary>
        /// Central
        /// </summary>
        public static EnumValues Central => EnumValues.Central;

        /// <summary>
        /// Eastern
        /// </summary>
        public static EnumValues Eastern => EnumValues.Eastern;

        /// <summary>
        /// Northern
        /// </summary>
        public static EnumValues Northern => EnumValues.Northern;

        /// <summary>
        /// Volta
        /// </summary>
        public static EnumValues Volta => EnumValues.Volta;

        /// <summary>
        /// Upper East
        /// </summary>
        public static EnumValues UpperEast => EnumValues.UpperEast;

        /// <summary>
        /// Upper West
        /// </summary>
        public static EnumValues UpperWest => EnumValues.UpperWest;

        /// <summary>
        /// Western
        /// </summary>
        public static EnumValues Western => EnumValues.Western;

        #endregion

        /// <summary>
        /// Enum values for Ghana regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Greater Accra
            /// </summary>
            [AliasInShort("AA")]
            GreaterAccra,

            /// <summary>
            /// Ashanti
            /// </summary>
            [AliasInShort("AH")]
            Ashanti,

            /// <summary>
            /// Brong-Ahafo
            /// </summary>
            [AliasInShort("BA")]
            BrongAhafo,

            /// <summary>
            /// Central
            /// </summary>
            [AliasInShort("CP")]
            Central,

            /// <summary>
            /// Eastern
            /// </summary>
            [AliasInShort("EP")]
            Eastern,

            /// <summary>
            /// Northern
            /// </summary>
            [AliasInShort("NP")]
            Northern,

            /// <summary>
            /// Volta
            /// </summary>
            [AliasInShort("TV")]
            Volta,

            /// <summary>
            /// Upper East
            /// </summary>
            [AliasInShort("UE")]
            UpperEast,

            /// <summary>
            /// Upper West
            /// </summary>
            [AliasInShort("UW")]
            UpperWest,

            /// <summary>
            /// Western
            /// </summary>
            [AliasInShort("WP")]
            Western,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="GhanaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="GhanaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"GH-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Ghana;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.GH;
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