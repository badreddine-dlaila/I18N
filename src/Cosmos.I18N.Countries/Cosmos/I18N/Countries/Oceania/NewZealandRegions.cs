using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// NewZealand Regions
    /// </summary>
    public static class NewZealandRegions {

        #region Gets regions

        /// <summary>
        /// Auckland Province
        /// </summary>
        public static EnumValues AucklandProvince => EnumValues.AucklandProvince;

        /// <summary>
        /// Canterbury
        /// </summary>
        public static EnumValues Canterbury => EnumValues.Canterbury;

        /// <summary>
        /// Chatham Islands
        /// </summary>
        public static EnumValues ChathamIslands => EnumValues.ChathamIslands;

        /// <summary>
        /// Hawke's Bay
        /// </summary>
        public static EnumValues HawkesBay => EnumValues.HawkesBay;

        /// <summary>
        /// Marlborough
        /// </summary>
        public static EnumValues Marlborough => EnumValues.Marlborough;

        /// <summary>
        /// Nelson
        /// </summary>
        public static EnumValues Nelson => EnumValues.Nelson;

        /// <summary>
        /// Northland
        /// </summary>
        public static EnumValues Northland => EnumValues.Northland;

        /// <summary>
        /// Otago Province
        /// </summary>
        public static EnumValues OtagoProvince => EnumValues.OtagoProvince;

        /// <summary>
        /// Southland
        /// </summary>
        public static EnumValues Southland => EnumValues.Southland;

        /// <summary>
        /// Taranaki
        /// </summary>
        public static EnumValues Taranaki => EnumValues.Taranaki;

        /// <summary>
        /// Wellington Province
        /// </summary>
        public static EnumValues WellingtonProvince => EnumValues.WellingtonProvince;

        /// <summary>
        /// Westland
        /// </summary>
        public static EnumValues Westland => EnumValues.Westland;

        #endregion

        /// <summary>
        /// Enum values for NewZealand regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Auckland Province
            /// </summary>
            [AliasInShort("AUK")]
            AucklandProvince,

            /// <summary>
            /// Canterbury
            /// </summary>
            [AliasInShort("CAN")]
            Canterbury,

            /// <summary>
            /// Chatham Islands
            /// </summary>
            [AliasInShort("CIT")]
            ChathamIslands,

            /// <summary>
            /// Hawke's Bay
            /// </summary>
            [AliasInShort("HKB")]
            HawkesBay,

            /// <summary>
            /// Marlborough
            /// </summary>
            [AliasInShort("MBH")]
            Marlborough,

            /// <summary>
            /// Nelson
            /// </summary>
            [AliasInShort("NSN")]
            Nelson,

            /// <summary>
            /// Northland
            /// </summary>
            [AliasInShort("NTL")]
            Northland,

            /// <summary>
            /// Otago Province
            /// </summary>
            [AliasInShort("OTA")]
            OtagoProvince,

            /// <summary>
            /// Southland
            /// </summary>
            [AliasInShort("STL")]
            Southland,

            /// <summary>
            /// Taranaki
            /// </summary>
            [AliasInShort("TKI")]
            Taranaki,

            /// <summary>
            /// Wellington Province
            /// </summary>
            [AliasInShort("WGN")]
            WellingtonProvince,

            /// <summary>
            /// Westland
            /// </summary>
            [AliasInShort("WTC")]
            Westland,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="NewZealandRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="NewZealandRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"NZ-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.NewZealand;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.NZ;
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