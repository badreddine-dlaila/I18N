using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// Bonaire Regions
    /// </summary>
    public static class BonaireRegions {

        #region Gets region

        /// <summary>
        /// Bonaire
        /// </summary>
        public static EnumValues Bonaire => EnumValues.Bonaire;

        /// <summary>
        /// Saba
        /// </summary>
        public static EnumValues Saba => EnumValues.Saba;

        /// <summary>
        /// Sint Eustatius
        /// </summary>
        public static EnumValues SintEustatius => EnumValues.SintEustatius;

        #endregion

        /// <summary>
        /// Enum values for Bonaire regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Bonaire
            /// </summary>
            [AliasInShort("BO")]
            Bonaire,

            /// <summary>
            /// Saba
            /// </summary>
            [AliasInShort("SA")]
            Saba,

            /// <summary>
            /// Sint Eustatius
            /// </summary>
            [AliasInShort("SE")]
            SintEustatius,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BonaireRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BonaireRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"BQ-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Bonaire;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.BQ;
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