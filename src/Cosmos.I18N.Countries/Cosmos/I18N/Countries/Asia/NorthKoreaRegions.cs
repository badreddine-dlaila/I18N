using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// North Korea Regions
    /// </summary>
    public static class NorthKoreaRegions {

        #region Gets regions

        /// <summary>
        /// Ryanggang
        /// </summary>
        public static EnumValues Ryanggang => EnumValues.Ryanggang;

        /// <summary>
        /// Rason
        /// </summary>
        public static EnumValues Rason => EnumValues.Rason;

        /// <summary>
        /// Pyongyang
        /// </summary>
        public static EnumValues Pyongyang => EnumValues.Pyongyang;

        /// <summary>
        /// South Pyongan
        /// </summary>
        public static EnumValues SouthPyongan => EnumValues.SouthPyongan;

        /// <summary>
        /// North Pyongan
        /// </summary>
        public static EnumValues NorthPyongan => EnumValues.NorthPyongan;

        /// <summary>
        /// Chagang
        /// </summary>
        public static EnumValues Chagang => EnumValues.Chagang;

        /// <summary>
        /// South Hwanghae
        /// </summary>
        public static EnumValues SouthHwanghae => EnumValues.SouthHwanghae;

        /// <summary>
        /// North Hwanghae
        /// </summary>
        public static EnumValues NorthHwanghae => EnumValues.NorthHwanghae;

        /// <summary>
        /// Kangwon
        /// </summary>
        public static EnumValues Kangwon => EnumValues.Kangwon;

        /// <summary>
        /// South Hamgyong
        /// </summary>
        public static EnumValues SouthHamgyong => EnumValues.SouthHamgyong;

        /// <summary>
        /// North Hamgyong
        /// </summary>
        public static EnumValues NorthHamgyong => EnumValues.NorthHamgyong;

        #endregion

        /// <summary>
        /// Enum values for NorthKorea regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Ryanggang
            /// </summary>
            [AliasInShort("10")]
            Ryanggang,

            /// <summary>
            /// Rason
            /// </summary>
            [AliasInShort("13")]
            Rason,

            /// <summary>
            /// Pyongyang
            /// </summary>
            [AliasInShort("01")]
            Pyongyang,

            /// <summary>
            /// South Pyongan
            /// </summary>
            [AliasInShort("02")]
            SouthPyongan,

            /// <summary>
            /// North Pyongan
            /// </summary>
            [AliasInShort("03")]
            NorthPyongan,

            /// <summary>
            /// Chagang
            /// </summary>
            [AliasInShort("04")]
            Chagang,

            /// <summary>
            /// South Hwanghae
            /// </summary>
            [AliasInShort("05")]
            SouthHwanghae,

            /// <summary>
            /// North Hwanghae
            /// </summary>
            [AliasInShort("06")]
            NorthHwanghae,

            /// <summary>
            /// Kangwon
            /// </summary>
            [AliasInShort("07")]
            Kangwon,

            /// <summary>
            /// South Hamgyong
            /// </summary>
            [AliasInShort("08")]
            SouthHamgyong,

            /// <summary>
            /// North Hamgyong
            /// </summary>
            [AliasInShort("09")]
            NorthHamgyong,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="NorthKoreaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="NorthKoreaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"KP-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.NorthKorea;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.KP;
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