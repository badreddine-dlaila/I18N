using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// Ethiopia regions
    /// </summary>
    public static class EthiopiaRegions {

        #region Gets regions

        /// <summary>
        /// Addis Ababa
        /// </summary>
        public static EnumValues AddisAbaba => EnumValues.AddisAbaba;

        /// <summary>
        /// Afar
        /// </summary>
        public static EnumValues Afar => EnumValues.Afar;

        /// <summary>
        /// Amhara
        /// </summary>
        public static EnumValues Amhara => EnumValues.Amhara;

        /// <summary>
        /// Benishangul-Gumuz
        /// </summary>
        public static EnumValues BenishangulGumuz => EnumValues.BenishangulGumuz;

        /// <summary>
        /// Dire Dawa
        /// </summary>
        public static EnumValues DireDawa => EnumValues.DireDawa;

        /// <summary>
        /// Gambela
        /// </summary>
        public static EnumValues Gambela => EnumValues.Gambela;

        /// <summary>
        /// Harari
        /// </summary>
        public static EnumValues Harari => EnumValues.Harari;

        /// <summary>
        /// Oromia
        /// </summary>
        public static EnumValues Oromia => EnumValues.Oromia;

        /// <summary>
        /// Southern Nations, Nationalities, and Peoples
        /// </summary>
        public static EnumValues SouthernNationsAndNationalitiesAndPeoples => EnumValues.SouthernNationsAndNationalitiesAndPeoples;

        /// <summary>
        /// Somali
        /// </summary>
        public static EnumValues Somali => EnumValues.Somali;

        /// <summary>
        /// Tigray
        /// </summary>
        public static EnumValues Tigray => EnumValues.Tigray;

        #endregion

        /// <summary>
        /// Enum values for Ethiopia regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Addis Ababa
            /// </summary>
            [AliasInShort("AA")]
            AddisAbaba,

            /// <summary>
            /// Afar
            /// </summary>
            [AliasInShort("AF")]
            Afar,

            /// <summary>
            /// Amhara
            /// </summary>
            [AliasInShort("AM")]
            Amhara,

            /// <summary>
            /// Benishangul-Gumuz
            /// </summary>
            [AliasInShort("BE")]
            BenishangulGumuz,

            /// <summary>
            /// Dire Dawa
            /// </summary>
            [AliasInShort("DD")]
            DireDawa,

            /// <summary>
            /// Gambela
            /// </summary>
            [AliasInShort("GA")]
            Gambela,

            /// <summary>
            /// Harari
            /// </summary>
            [AliasInShort("HA")]
            Harari,

            /// <summary>
            /// Oromia
            /// </summary>
            [AliasInShort("OR")]
            Oromia,

            /// <summary>
            /// Southern Nations, Nationalities, and Peoples
            /// </summary>
            [AliasInShort("SN")]
            SouthernNationsAndNationalitiesAndPeoples,

            /// <summary>
            /// Somali
            /// </summary>
            [AliasInShort("SO")]
            Somali,

            /// <summary>
            /// Tigray
            /// </summary>
            [AliasInShort("TI")]
            Tigray,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="EthiopiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="EthiopiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"ET-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Ethiopia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.ET;
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