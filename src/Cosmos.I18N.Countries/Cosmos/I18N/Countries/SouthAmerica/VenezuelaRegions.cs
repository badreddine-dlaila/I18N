using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.SouthAmerica {
    /// <summary>
    /// Venezuela Regions
    /// </summary>
    public static class VenezuelaRegions {

        #region Gets regions

        /// <summary>
        /// Anzoátegui
        /// </summary>
        public static EnumValues Anzoátegui => EnumValues.Anzoátegui;

        /// <summary>
        /// Carabobo
        /// </summary>
        public static EnumValues Carabobo => EnumValues.Carabobo;

        /// <summary>
        /// Lara
        /// </summary>
        public static EnumValues Lara => EnumValues.Lara;

        /// <summary>
        /// Miranda
        /// </summary>
        public static EnumValues Miranda => EnumValues.Miranda;

        /// <summary>
        /// Monagas
        /// </summary>
        public static EnumValues Monagas => EnumValues.Monagas;

        /// <summary>
        /// Táchira
        /// </summary>
        public static EnumValues Táchira => EnumValues.Táchira;

        /// <summary>
        /// Zulia
        /// </summary>
        public static EnumValues Zulia => EnumValues.Zulia;

        #endregion

        /// <summary>
        /// Enum values for Venezuela regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Anzoátegui
            /// </summary>
            [AliasInShort("B")]
            Anzoátegui,

            /// <summary>
            /// Carabobo
            /// </summary>
            [AliasInShort("G")]
            Carabobo,

            /// <summary>
            /// Lara
            /// </summary>
            [AliasInShort("K")]
            Lara,

            /// <summary>
            /// Miranda
            /// </summary>
            [AliasInShort("M")]
            Miranda,

            /// <summary>
            /// Monagas
            /// </summary>
            [AliasInShort("N")]
            Monagas,

            /// <summary>
            /// Táchira
            /// </summary>
            [AliasInShort("S")]
            Táchira,

            /// <summary>
            /// Zulia
            /// </summary>
            [AliasInShort("V")]
            Zulia,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="VenezuelaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="VenezuelaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"VE-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Venezuela;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.VE;
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