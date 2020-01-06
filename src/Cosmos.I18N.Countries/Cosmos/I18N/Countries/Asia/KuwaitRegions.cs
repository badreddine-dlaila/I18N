using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// Kuwait Regions
    /// </summary>
    public static class KuwaitRegions {

        #region Gets regions

        /// <summary>
        /// Al Ahmadi
        /// </summary>
        public static EnumValues AlAhmadi => EnumValues.AlAhmadi;

        /// <summary>
        /// Al Farwaniyah
        /// </summary>
        public static EnumValues AlFarwaniyah => EnumValues.AlFarwaniyah;

        /// <summary>
        /// Hawalli
        /// </summary>
        public static EnumValues Hawalli => EnumValues.Hawalli;

        /// <summary>
        /// Al Jahra
        /// </summary>
        public static EnumValues AlJahra => EnumValues.AlJahra;

        /// <summary>
        /// Al Asimah
        /// </summary>
        public static EnumValues AlAsimah => EnumValues.AlAsimah;

        /// <summary>
        /// Mubarak Al-Kabeer
        /// </summary>
        public static EnumValues MubarakAlKabeer => EnumValues.MubarakAlKabeer;

        #endregion

        /// <summary>
        /// Enum values for Kuwait regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Al Ahmadi
            /// </summary>
            [AliasInShort("AH")]
            AlAhmadi,

            /// <summary>
            /// Al Farwaniyah
            /// </summary>
            [AliasInShort("FA")]
            AlFarwaniyah,

            /// <summary>
            /// Hawalli
            /// </summary>
            [AliasInShort("HA")]
            Hawalli,

            /// <summary>
            /// Al Jahra
            /// </summary>
            [AliasInShort("JA")]
            AlJahra,

            /// <summary>
            /// Al Asimah
            /// </summary>
            [AliasInShort("KU")]
            AlAsimah,

            /// <summary>
            /// Mubarak Al-Kabeer
            /// </summary>
            [AliasInShort("MU")]
            MubarakAlKabeer,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="KuwaitRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="KuwaitRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"KW-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Kuwait;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.KW;
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