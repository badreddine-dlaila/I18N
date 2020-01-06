using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// Vanuatu regions
    /// </summary>
    public static class VanuatuRegions {

        #region Gets region

        /// <summary>
        /// Malampa
        /// </summary>
        /// <returns></returns>
        public static EnumValues Malampa => EnumValues.Malampa;

        /// <summary>
        /// Penama
        /// </summary>
        public static EnumValues Penama => EnumValues.Penama;

        /// <summary>
        /// Sanma
        /// </summary>
        public static EnumValues Sanma => EnumValues.Sanma;

        /// <summary>
        /// Shefa
        /// </summary>
        public static EnumValues Shefa => EnumValues.Shefa;

        /// <summary>
        /// Tafea
        /// </summary>
        public static EnumValues Tafea => EnumValues.Tafea;

        /// <summary>
        /// Torba
        /// </summary>
        public static EnumValues Torba => EnumValues.Torba;

        #endregion

        /// <summary>
        /// Enum values for Vanuatu regions
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Malampa
            /// </summary>
            [AliasInShort("MAP")]
            Malampa,

            /// <summary>
            /// Penama
            /// </summary>
            [AliasInShort("PAM")]
            Penama,

            /// <summary>
            /// Sanma
            /// </summary>
            [AliasInShort("SAM")]
            Sanma,

            /// <summary>
            /// Shefa
            /// </summary>
            [AliasInShort("SEE")]
            Shefa,

            /// <summary>
            /// Tafea
            /// </summary>
            [AliasInShort("TAE")]
            Tafea,

            /// <summary>
            /// Torba
            /// </summary>
            [AliasInShort("TOB")]
            Torba,

            /// <summary>
            /// Unknown<br />未知
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="VanuatuRegions.EnumValues"/> to region code likes 'MAP'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="VanuatuRegions.EnumValues"/> to full region code likes 'VU-MAP'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"VU-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Vanuatu;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.VU;
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