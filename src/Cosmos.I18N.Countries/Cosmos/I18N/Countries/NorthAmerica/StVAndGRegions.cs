using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// StVAndG Regions
    /// </summary>
    public static class StVAndGRegions {

        #region Gets regions

        /// <summary>
        /// Charlotte
        /// </summary>
        public static EnumValues Charlotte => EnumValues.Charlotte;

        /// <summary>
        /// Saint Andrew
        /// </summary>
        public static EnumValues SaintAndrew => EnumValues.SaintAndrew;

        /// <summary>
        /// Saint David
        /// </summary>
        public static EnumValues SaintDavid => EnumValues.SaintDavid;

        /// <summary>
        /// Saint George
        /// </summary>
        public static EnumValues SaintGeorge => EnumValues.SaintGeorge;

        /// <summary>
        /// Saint Patrick
        /// </summary>
        public static EnumValues SaintPatrick => EnumValues.SaintPatrick;

        /// <summary>
        /// Grenadines
        /// </summary>
        public static EnumValues Grenadines => EnumValues.Grenadines;

        #endregion

        /// <summary>
        /// Enum values for StVAndG regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Charlotte
            /// </summary>
            [AliasInShort("01")]
            Charlotte,

            /// <summary>
            /// Saint Andrew
            /// </summary>
            [AliasInShort("02")]
            SaintAndrew,

            /// <summary>
            /// Saint David
            /// </summary>
            [AliasInShort("03")]
            SaintDavid,

            /// <summary>
            /// Saint George
            /// </summary>
            [AliasInShort("04")]
            SaintGeorge,

            /// <summary>
            /// Saint Patrick
            /// </summary>
            [AliasInShort("05")]
            SaintPatrick,

            /// <summary>
            /// Grenadines
            /// </summary>
            [AliasInShort("06")]
            Grenadines,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="StVAndGRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="StVAndGRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"VC-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.StVAndG;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.VC;
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