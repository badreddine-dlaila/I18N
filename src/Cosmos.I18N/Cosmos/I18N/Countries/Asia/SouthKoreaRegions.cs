using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// South Korea Regions
    /// </summary>
    public static class SouthKoreaRegions
    {

        #region Gets regions

        /// <summary>
        /// Seoul
        /// </summary>
        public static EnumValues Seoul => EnumValues.Seoul;

        /// <summary>
        /// Busan
        /// </summary>
        public static EnumValues Busan => EnumValues.Busan;

        /// <summary>
        /// Daegu
        /// </summary>
        public static EnumValues Daegu => EnumValues.Daegu;

        /// <summary>
        /// Incheon
        /// </summary>
        public static EnumValues Incheon => EnumValues.Incheon;

        /// <summary>
        /// Gwangju City
        /// </summary>
        public static EnumValues GwangjuCity => EnumValues.GwangjuCity;

        /// <summary>
        /// Daejeon
        /// </summary>
        public static EnumValues Daejeon => EnumValues.Daejeon;

        /// <summary>
        /// Ulsan
        /// </summary>
        public static EnumValues Ulsan => EnumValues.Ulsan;

        /// <summary>
        /// Gyeonggi
        /// </summary>
        public static EnumValues Gyeonggi => EnumValues.Gyeonggi;

        /// <summary>
        /// Gangwon
        /// </summary>
        public static EnumValues Gangwon => EnumValues.Gangwon;

        /// <summary>
        /// North Chungcheong
        /// </summary>
        public static EnumValues NorthChungcheong => EnumValues.NorthChungcheong;

        /// <summary>
        /// South Chungcheong
        /// </summary>
        public static EnumValues SouthChungcheong => EnumValues.SouthChungcheong;

        /// <summary>
        /// North Jeolla
        /// </summary>
        public static EnumValues NorthJeolla => EnumValues.NorthJeolla;

        /// <summary>
        /// South Jeolla
        /// </summary>
        public static EnumValues SouthJeolla => EnumValues.SouthJeolla;

        /// <summary>
        /// North Gyeongsang
        /// </summary>
        public static EnumValues NorthGyeongsang => EnumValues.NorthGyeongsang;

        /// <summary>
        /// South Gyeongsang
        /// </summary>
        public static EnumValues SouthGyeongsang => EnumValues.SouthGyeongsang;

        /// <summary>
        /// Jeju
        /// </summary>
        public static EnumValues Jeju => EnumValues.Jeju;

        /// <summary>
        /// Sejong
        /// </summary>
        public static EnumValues Sejong => EnumValues.Sejong;

        #endregion

        /// <summary>
        /// Enum values for SouthKorea regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Seoul
            /// </summary>
            [AliasInShort("11")]
            Seoul,

            /// <summary>
            /// Busan
            /// </summary>
            [AliasInShort("26")]
            Busan,

            /// <summary>
            /// Daegu
            /// </summary>
            [AliasInShort("27")]
            Daegu,

            /// <summary>
            /// Incheon
            /// </summary>
            [AliasInShort("28")]
            Incheon,

            /// <summary>
            /// Gwangju City
            /// </summary>
            [AliasInShort("29")]
            GwangjuCity,

            /// <summary>
            /// Daejeon
            /// </summary>
            [AliasInShort("30")]
            Daejeon,

            /// <summary>
            /// Ulsan
            /// </summary>
            [AliasInShort("31")]
            Ulsan,

            /// <summary>
            /// Gyeonggi
            /// </summary>
            [AliasInShort("41")]
            Gyeonggi,

            /// <summary>
            /// Gangwon
            /// </summary>
            [AliasInShort("42")]
            Gangwon,

            /// <summary>
            /// North Chungcheong
            /// </summary>
            [AliasInShort("43")]
            NorthChungcheong,

            /// <summary>
            /// South Chungcheong
            /// </summary>
            [AliasInShort("44")]
            SouthChungcheong,

            /// <summary>
            /// North Jeolla
            /// </summary>
            [AliasInShort("45")]
            NorthJeolla,

            /// <summary>
            /// South Jeolla
            /// </summary>
            [AliasInShort("46")]
            SouthJeolla,

            /// <summary>
            /// North Gyeongsang
            /// </summary>
            [AliasInShort("47")]
            NorthGyeongsang,

            /// <summary>
            /// South Gyeongsang
            /// </summary>
            [AliasInShort("48")]
            SouthGyeongsang,

            /// <summary>
            /// Jeju
            /// </summary>
            [AliasInShort("49")]
            Jeju,

            /// <summary>
            /// Sejong
            /// </summary>
            [AliasInShort("50")]
            Sejong,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SouthKoreaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SouthKoreaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"KR-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.SouthKorea;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.KR;
        }

        #endregion

        #region Getters

        private static List<EnumMember<EnumValues>> InternalEnumMembersCache { get; }
            = Enums.GetMembers<EnumValues>().Where(x => !x.Attributes.Has<IgnoreRegionAttribute>()).ToList();

        /// <summary>
        /// Get all region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAllRegonCodes()
        {
            foreach (var member in InternalEnumMembersCache)
                yield return member.Value.ToFullRegionCode();
        }

        #endregion

    }
}