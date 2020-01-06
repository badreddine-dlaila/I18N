using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// Regions of Lao People's Democratic Republic
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static class LaoPDRRegions {

        #region Gets regions

        /// <summary>
        /// Attapeu
        /// </summary>
        public static EnumValues Attapeu => EnumValues.Attapeu;

        /// <summary>
        /// Bokeo
        /// </summary>
        public static EnumValues Bokeo => EnumValues.Bokeo;

        /// <summary>
        /// Bolikhamsai
        /// </summary>
        public static EnumValues Bolikhamsai => EnumValues.Bolikhamsai;

        /// <summary>
        /// Champasak
        /// </summary>
        public static EnumValues Champasak => EnumValues.Champasak;

        /// <summary>
        /// Houaphanh
        /// </summary>
        public static EnumValues Houaphanh => EnumValues.Houaphanh;

        /// <summary>
        /// Khammouane
        /// </summary>
        public static EnumValues Khammouane => EnumValues.Khammouane;

        /// <summary>
        /// Luang Namtha
        /// </summary>
        public static EnumValues LuangNamtha => EnumValues.LuangNamtha;

        /// <summary>
        /// Luang Prabang  
        /// </summary>
        public static EnumValues LuangPrabang => EnumValues.LuangPrabang;

        /// <summary>
        /// Oudomxay
        /// </summary>
        public static EnumValues Oudomxay => EnumValues.Oudomxay;

        /// <summary>
        /// Phongsaly
        /// </summary>
        public static EnumValues Phongsaly => EnumValues.Phongsaly;

        /// <summary>
        /// Salavan
        /// </summary>
        public static EnumValues Salavan => EnumValues.Salavan;

        /// <summary>
        /// Savannakhet
        /// </summary>
        public static EnumValues Savannakhet => EnumValues.Savannakhet;

        /// <summary>
        /// Vientiane Province
        /// </summary>
        public static EnumValues VientianeProvince => EnumValues.VientianeProvince;

        /// <summary>
        /// Vientiane
        /// </summary>
        public static EnumValues Vientiane => EnumValues.Vientiane;

        /// <summary>
        /// Sainyabuli
        /// </summary>
        public static EnumValues Sainyabuli => EnumValues.Sainyabuli;

        /// <summary>
        /// Sekong
        /// </summary>
        public static EnumValues Sekong => EnumValues.Sekong;

        /// <summary>
        /// Xiangkhouang
        /// </summary>
        public static EnumValues Xiangkhouang => EnumValues.Xiangkhouang;

        /// <summary>
        /// Xaisomboun
        /// </summary>
        public static EnumValues Xaisomboun => EnumValues.Xaisomboun;

        #endregion

        /// <summary>
        /// Enum values for LaoPDR regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Attapeu
            /// </summary>
            [AliasInShort("AT")]
            Attapeu,

            /// <summary>
            /// Bokeo
            /// </summary>
            [AliasInShort("BK")]
            Bokeo,

            /// <summary>
            /// Bolikhamsai
            /// </summary>
            [AliasInShort("BL")]
            Bolikhamsai,

            /// <summary>
            /// Babylon
            /// </summary>
            [AliasInShort("CH")]
            Champasak,

            /// <summary>
            /// Houaphanh
            /// </summary>
            [AliasInShort("HO")]
            Houaphanh,

            /// <summary>
            /// Khammouane
            /// </summary>
            [AliasInShort("KH")]
            Khammouane,

            /// <summary>
            /// Luang Namtha
            /// </summary>
            [AliasInShort("LM")]
            LuangNamtha,

            /// <summary>
            /// Luang Prabang
            /// </summary>
            [AliasInShort("LP")]
            LuangPrabang,

            /// <summary>
            /// Oudomxay
            /// </summary>
            [AliasInShort("OU")]
            Oudomxay,

            /// <summary>
            /// Phongsaly
            /// </summary>
            [AliasInShort("PH")]
            Phongsaly,

            /// <summary>
            /// Salavan
            /// </summary>
            [AliasInShort("SL")]
            Salavan,

            /// <summary>
            /// Savannakhet
            /// </summary>
            [AliasInShort("SV")]
            Savannakhet,

            /// <summary>
            /// Vientiane Province
            /// </summary>
            [AliasInShort("VI")]
            VientianeProvince,

            /// <summary>
            /// Vientiane
            /// </summary>
            [AliasInShort("VT")]
            Vientiane,

            /// <summary>
            /// Sainyabuli
            /// </summary>
            [AliasInShort("XA")]
            Sainyabuli,

            /// <summary>
            /// Sekong
            /// </summary>
            [AliasInShort("XE")]
            Sekong,

            /// <summary>
            /// Xiangkhouang
            /// </summary>
            [AliasInShort("XI")]
            Xiangkhouang,

            /// <summary>
            /// Xaisomboun
            /// </summary>
            [AliasInShort("XS")]
            Xaisomboun,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="LaoPDRRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="LaoPDRRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"LA-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.LaoPDR;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.LA;
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