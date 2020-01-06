using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// Burundi regions
    /// </summary>
    public static class BurundiRegions {

        #region Gets regions

        /// <summary>
        /// Bubanza
        /// </summary>
        public static EnumValues Bubanza => EnumValues.Bubanza;

        /// <summary>
        /// Bujumbura Rural
        /// </summary>
        public static EnumValues BujumburaRural => EnumValues.BujumburaRural;

        /// <summary>
        /// Bujumbura
        /// </summary>
        public static EnumValues Bujumbura => EnumValues.Bujumbura;

        /// <summary>
        /// Bururi
        /// </summary>
        public static EnumValues Bururi => EnumValues.Bururi;

        /// <summary>
        /// Cankuzo
        /// </summary>
        public static EnumValues Cankuzo => EnumValues.Cankuzo;

        /// <summary>
        /// Cibitoke
        /// </summary>
        public static EnumValues Cibitoke => EnumValues.Cibitoke;

        /// <summary>
        /// Gitega
        /// </summary>
        public static EnumValues Gitega => EnumValues.Gitega;

        /// <summary>
        /// Kirundo
        /// </summary>
        public static EnumValues Kirundo => EnumValues.Kirundo;

        /// <summary>
        /// Karuzi
        /// </summary>
        public static EnumValues Karuzi => EnumValues.Karuzi;

        /// <summary>
        /// Kayanza
        /// </summary>
        public static EnumValues Kayanza => EnumValues.Kayanza;

        /// <summary>
        /// Makamba
        /// </summary>
        public static EnumValues Makamba => EnumValues.Makamba;

        /// <summary>
        /// Muramvya
        /// </summary>
        public static EnumValues Muramvya => EnumValues.Muramvya;

        /// <summary>
        /// Mwaro
        /// </summary>
        public static EnumValues Mwaro => EnumValues.Mwaro;

        /// <summary>
        /// Muyinga
        /// </summary>
        public static EnumValues Muyinga => EnumValues.Muyinga;

        /// <summary>
        /// Ngozi
        /// </summary>
        public static EnumValues Ngozi => EnumValues.Ngozi;

        /// <summary>
        /// Rumonge
        /// </summary>
        public static EnumValues Rumonge => EnumValues.Rumonge;

        /// <summary>
        /// Rutana
        /// </summary>
        public static EnumValues Rutana => EnumValues.Rutana;

        /// <summary>
        /// Ruyigi
        /// </summary>
        public static EnumValues Ruyigi => EnumValues.Ruyigi;

        #endregion

        /// <summary>
        /// Enum values for Burundi regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Bubanza
            /// </summary>
            [AliasInShort("BB")]
            Bubanza,

            /// <summary>
            /// Bujumbura Rural
            /// </summary>
            [AliasInShort("BL")]
            BujumburaRural,

            /// <summary>
            /// Bujumbura
            /// </summary>
            [AliasInShort("BM")]
            Bujumbura,

            /// <summary>
            /// Bururi
            /// </summary>
            [AliasInShort("BR")]
            Bururi,

            /// <summary>
            /// Cankuzo
            /// </summary>
            [AliasInShort("CA")]
            Cankuzo,

            /// <summary>
            /// Cibitoke
            /// </summary>
            [AliasInShort("CI")]
            Cibitoke,

            /// <summary>
            /// Gitega
            /// </summary>
            [AliasInShort("GI")]
            Gitega,

            /// <summary>
            /// Kirundo
            /// </summary>
            [AliasInShort("KI")]
            Kirundo,

            /// <summary>
            /// Karuzi
            /// </summary>
            [AliasInShort("KR")]
            Karuzi,

            /// <summary>
            /// Kayanza
            /// </summary>
            [AliasInShort("KY")]
            Kayanza,

            /// <summary>
            /// Makamba
            /// </summary>
            [AliasInShort("MA")]
            Makamba,

            /// <summary>
            /// Muramvya
            /// </summary>
            [AliasInShort("MU")]
            Muramvya,

            /// <summary>
            /// Mwaro
            /// </summary>
            [AliasInShort("MW")]
            Mwaro,

            /// <summary>
            /// Muyinga
            /// </summary>
            [AliasInShort("MY")]
            Muyinga,

            /// <summary>
            /// Ngozi
            /// </summary>
            [AliasInShort("NG")]
            Ngozi,

            /// <summary>
            /// Rumonge
            /// </summary>
            [AliasInShort("RM")]
            Rumonge,

            /// <summary>
            /// Rutana
            /// </summary>
            [AliasInShort("RT")]
            Rutana,

            /// <summary>
            /// Ruyigi
            /// </summary>
            [AliasInShort("RY")]
            Ruyigi,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BurundiRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BurundiRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"BI-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Burundi;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.BI;
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