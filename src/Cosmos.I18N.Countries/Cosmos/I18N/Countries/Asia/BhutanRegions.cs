using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// Bhutan regions
    /// </summary>
    public static class BhutanRegions {

        #region Gets regions

        /// <summary>
        /// Paro
        /// </summary>
        public static EnumValues Paro => EnumValues.Paro;

        /// <summary>
        /// Chukha
        /// </summary>
        public static EnumValues Chukha => EnumValues.Chukha;

        /// <summary>
        /// Haa
        /// </summary>
        public static EnumValues Haa => EnumValues.Haa;

        /// <summary>
        /// Samtse
        /// </summary>
        public static EnumValues Samtse => EnumValues.Samtse;

        /// <summary>
        /// Thimphu
        /// </summary>
        public static EnumValues Thimphu => EnumValues.Thimphu;

        /// <summary>
        /// Tsirang
        /// </summary>
        public static EnumValues Tsirang => EnumValues.Tsirang;

        /// <summary>
        /// Dagana
        /// </summary>
        public static EnumValues Dagana => EnumValues.Dagana;

        /// <summary>
        /// Punakha
        /// </summary>
        public static EnumValues Punakha => EnumValues.Punakha;

        /// <summary>
        /// Wangdue Phodrang
        /// </summary>
        public static EnumValues WangduePhodrang => EnumValues.WangduePhodrang;

        /// <summary>
        /// Sarpang
        /// </summary>
        public static EnumValues Sarpang => EnumValues.Sarpang;

        /// <summary>
        /// Trongsa
        /// </summary>
        public static EnumValues Trongsa => EnumValues.Trongsa;

        /// <summary>
        /// Bumthang
        /// </summary>
        public static EnumValues Bumthang => EnumValues.Bumthang;

        /// <summary>
        /// Zhemgang
        /// </summary>
        public static EnumValues Zhemgang => EnumValues.Zhemgang;

        /// <summary>
        /// Trashigang
        /// </summary>
        public static EnumValues Trashigang => EnumValues.Trashigang;

        /// <summary>
        /// Mongar
        /// </summary>
        public static EnumValues Mongar => EnumValues.Mongar;

        /// <summary>
        /// Pemagatshel
        /// </summary>
        public static EnumValues Pemagatshel => EnumValues.Pemagatshel;

        /// <summary>
        /// Lhuntse
        /// </summary>
        public static EnumValues Lhuntse => EnumValues.Lhuntse;

        /// <summary>
        /// Samdrup Jongkhar
        /// </summary>
        public static EnumValues SamdrupJongkhar => EnumValues.SamdrupJongkhar;

        /// <summary>
        /// Gasa
        /// </summary>
        public static EnumValues Gasa => EnumValues.Gasa;

        /// <summary>
        /// Trashiyangtse
        /// </summary>
        public static EnumValues Trashiyangtse => EnumValues.Trashiyangtse;

        #endregion

        /// <summary>
        /// Enum values for Bhutan regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Paro
            /// </summary>
            [AliasInShort("11")]
            Paro,

            /// <summary>
            /// Chukha
            /// </summary>
            [AliasInShort("12")]
            Chukha,

            /// <summary>
            /// Haa
            /// </summary>
            [AliasInShort("13")]
            Haa,

            /// <summary>
            /// Samtse
            /// </summary>
            [AliasInShort("14")]
            Samtse,

            /// <summary>
            /// Thimphu
            /// </summary>
            [AliasInShort("15")]
            Thimphu,

            /// <summary>
            /// Tsirang
            /// </summary>
            [AliasInShort("21")]
            Tsirang,

            /// <summary>
            /// Dagana
            /// </summary>
            [AliasInShort("22")]
            Dagana,

            /// <summary>
            /// Punakha
            /// </summary>
            [AliasInShort("23")]
            Punakha,

            /// <summary>
            /// Wangdue Phodrang
            /// </summary>
            [AliasInShort("24")]
            WangduePhodrang,

            /// <summary>
            /// Sarpang
            /// </summary>
            [AliasInShort("31")]
            Sarpang,

            /// <summary>
            /// Trongsa
            /// </summary>
            [AliasInShort("32")]
            Trongsa,

            /// <summary>
            /// Bumthang
            /// </summary>
            [AliasInShort("33")]
            Bumthang,

            /// <summary>
            /// Zhemgang
            /// </summary>
            [AliasInShort("34")]
            Zhemgang,

            /// <summary>
            /// Trashigang
            /// </summary>
            [AliasInShort("41")]
            Trashigang,

            /// <summary>
            /// Mongar
            /// </summary>
            [AliasInShort("42")]
            Mongar,

            /// <summary>
            /// Pemagatshel
            /// </summary>
            [AliasInShort("43")]
            Pemagatshel,

            /// <summary>
            /// Lhuntse
            /// </summary>
            [AliasInShort("44")]
            Lhuntse,

            /// <summary>
            /// Samdrup Jongkhar
            /// </summary>
            [AliasInShort("45")]
            SamdrupJongkhar,

            /// <summary>
            /// Gasa
            /// </summary>
            [AliasInShort("GA")]
            Gasa,

            /// <summary>
            /// Trashiyangtse
            /// </summary>
            [AliasInShort("TY")]
            Trashiyangtse,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BhutanRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BhutanRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"BT-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Bhutan;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.BT;
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