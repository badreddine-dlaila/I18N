using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// Myanmar Regions
    /// </summary>
    public static class MyanmarRegions {

        #region Gets regions

        /// <summary>
        /// Kachin
        /// </summary>
        public static EnumValues Kachin => EnumValues.Kachin;

        /// <summary>
        /// Kayah
        /// </summary>
        public static EnumValues Kayah => EnumValues.Kayah;

        /// <summary>
        /// Kayin
        /// </summary>
        public static EnumValues Kayin => EnumValues.Kayin;

        /// <summary>
        /// Chin
        /// </summary>
        public static EnumValues Chin => EnumValues.Chin;

        /// <summary>
        /// Mon
        /// </summary>
        public static EnumValues Mon => EnumValues.Mon;

        /// <summary>
        /// Rakhine
        /// </summary>
        public static EnumValues Rakhine => EnumValues.Rakhine;

        /// <summary>
        /// Shan
        /// </summary>
        public static EnumValues Shan => EnumValues.Shan;

        /// <summary>
        /// Naypyidaw
        /// </summary>
        public static EnumValues Naypyidaw => EnumValues.Naypyidaw;

        /// <summary>
        /// Sagaing
        /// </summary>
        public static EnumValues Sagaing => EnumValues.Sagaing;

        /// <summary>
        /// Bago
        /// </summary>
        public static EnumValues Bago => EnumValues.Bago;

        /// <summary>
        /// Magway
        /// </summary>
        public static EnumValues Magway => EnumValues.Magway;

        /// <summary>
        /// Mandalay
        /// </summary>
        public static EnumValues Mandalay => EnumValues.Mandalay;

        /// <summary>
        /// Tanintharyi
        /// </summary>
        public static EnumValues Tanintharyi => EnumValues.Tanintharyi;

        /// <summary>
        /// Yangon
        /// </summary>
        public static EnumValues Yangon => EnumValues.Yangon;

        /// <summary>
        /// Ayeyarwady
        /// </summary>
        public static EnumValues Ayeyarwady => EnumValues.Ayeyarwady;

        #endregion

        /// <summary>
        /// Enum values for Myanmar regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Kachin
            /// </summary>
            [AliasInShort("11")]
            Kachin,

            /// <summary>
            /// Kayah
            /// </summary>
            [AliasInShort("12")]
            Kayah,

            /// <summary>
            /// Kayin
            /// </summary>
            [AliasInShort("13")]
            Kayin,

            /// <summary>
            /// Chin
            /// </summary>
            [AliasInShort("14")]
            Chin,

            /// <summary>
            /// Mon
            /// </summary>
            [AliasInShort("15")]
            Mon,

            /// <summary>
            /// Rakhine
            /// </summary>
            [AliasInShort("16")]
            Rakhine,

            /// <summary>
            /// Shan
            /// </summary>
            [AliasInShort("17")]
            Shan,

            /// <summary>
            /// Naypyidaw
            /// </summary>
            [AliasInShort("18")]
            Naypyidaw,

            /// <summary>
            /// Sagaing
            /// </summary>
            [AliasInShort("01")]
            Sagaing,

            /// <summary>
            /// Bago
            /// </summary>
            [AliasInShort("02")]
            Bago,

            /// <summary>
            /// Magway
            /// </summary>
            [AliasInShort("03")]
            Magway,

            /// <summary>
            /// Mandalay
            /// </summary>
            [AliasInShort("04")]
            Mandalay,

            /// <summary>
            /// Tanintharyi
            /// </summary>
            [AliasInShort("05")]
            Tanintharyi,

            /// <summary>
            /// Yangon
            /// </summary>
            [AliasInShort("06")]
            Yangon,

            /// <summary>
            /// Ayeyarwady
            /// </summary>
            [AliasInShort("07")]
            Ayeyarwady,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="MyanmarRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="MyanmarRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"MM-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Myanmar;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.MM;
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