using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// Cyprus regions
    /// </summary>
    public static class CyprusRegions {

        #region Gets region

        /// <summary>
        /// Nicosia
        /// </summary>
        public static EnumValues Nicosia => EnumValues.Nicosia;

        /// <summary>
        /// Limassol
        /// </summary>
        public static EnumValues Limassol => EnumValues.Limassol;

        /// <summary>
        /// Larnaca
        /// </summary>
        public static EnumValues Larnaca => EnumValues.Larnaca;

        /// <summary>
        /// Famagusta
        /// </summary>
        public static EnumValues Famagusta => EnumValues.Famagusta;

        /// <summary>
        /// Paphos
        /// </summary>
        public static EnumValues Paphos => EnumValues.Paphos;

        /// <summary>
        /// Kyrenia
        /// </summary>
        public static EnumValues Kyrenia => EnumValues.Kyrenia;

        #endregion


        /// <summary>
        /// Enum values for Cyprus regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Nicosia
            /// </summary>
            [AliasInShort("01")]
            Nicosia,

            /// <summary>
            /// Limassol
            /// </summary>
            [AliasInShort("02")]
            Limassol,

            /// <summary>
            /// Larnaca
            /// </summary>
            [AliasInShort("03")]
            Larnaca,

            /// <summary>
            /// Famagusta
            /// </summary>
            [AliasInShort("04")]
            Famagusta,

            /// <summary>
            /// Paphos
            /// </summary>
            [AliasInShort("05")]
            Paphos,

            /// <summary>
            /// Kyrenia
            /// </summary>
            [AliasInShort("06")]
            Kyrenia,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="CyprusRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="CyprusRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"CY-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Cyprus;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.CY;
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