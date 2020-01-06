using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// Coted Ivoire regions
    /// </summary>
    public static class CotedIvoireRegions {

        #region Gets regions

        /// <summary>
        /// Abidjan
        /// </summary>
        public static EnumValues Abidjan => EnumValues.Abidjan;

        /// <summary>
        /// Bas-Sassandra
        /// </summary>
        public static EnumValues BasSassandra => EnumValues.BasSassandra;

        /// <summary>
        /// Comoé
        /// </summary>
        public static EnumValues Comoé => EnumValues.Comoé;

        /// <summary>
        /// Denguélé
        /// </summary>
        public static EnumValues Denguélé => EnumValues.Denguélé;

        /// <summary>
        /// Gôh-Djiboua
        /// </summary>
        public static EnumValues GôhDjiboua => EnumValues.GôhDjiboua;

        /// <summary>
        /// Lacs
        /// </summary>
        public static EnumValues Lacs => EnumValues.Lacs;

        /// <summary>
        /// Lagunes
        /// </summary>
        public static EnumValues Lagunes => EnumValues.Lagunes;

        /// <summary>
        /// Montagnes
        /// </summary>
        public static EnumValues Montagnes => EnumValues.Montagnes;

        /// <summary>
        /// Sassandra-Marahoué
        /// </summary>
        public static EnumValues SassandraMarahoué => EnumValues.SassandraMarahoué;

        /// <summary>
        /// Savanes
        /// </summary>
        public static EnumValues Savanes => EnumValues.Savanes;

        /// <summary>
        /// Vallée du Bandama
        /// </summary>
        public static EnumValues ValléeDuBandama => EnumValues.ValléeDuBandama;

        /// <summary>
        /// Woroba
        /// </summary>
        public static EnumValues Woroba => EnumValues.Woroba;

        /// <summary>
        /// Yamoussoukro
        /// </summary>
        public static EnumValues Yamoussoukro => EnumValues.Yamoussoukro;

        /// <summary>
        /// Zanzan
        /// </summary>
        public static EnumValues Zanzan => EnumValues.Zanzan;

        #endregion

        /// <summary>
        /// Enum values for CotedIvoire regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Abidjan
            /// </summary>
            [AliasInShort("AB")]
            Abidjan,

            /// <summary>
            /// Bas-Sassandra
            /// </summary>
            [AliasInShort("BS")]
            BasSassandra,

            /// <summary>
            /// Comoé
            /// </summary>
            [AliasInShort("CM")]
            Comoé,

            /// <summary>
            /// Denguélé
            /// </summary>
            [AliasInShort("DN")]
            Denguélé,

            /// <summary>
            /// Gôh-Djiboua
            /// </summary>
            [AliasInShort("GD")]
            GôhDjiboua,

            /// <summary>
            /// Lacs
            /// </summary>
            [AliasInShort("LC")]
            Lacs,

            /// <summary>
            /// Lagunes
            /// </summary>
            [AliasInShort("LG")]
            Lagunes,

            /// <summary>
            /// Montagnes
            /// </summary>
            [AliasInShort("MG")]
            Montagnes,

            /// <summary>
            /// Sassandra-Marahoué
            /// </summary>
            [AliasInShort("SM")]
            SassandraMarahoué,

            /// <summary>
            /// Savanes
            /// </summary>
            [AliasInShort("SV")]
            Savanes,

            /// <summary>
            /// Vallée du Bandama
            /// </summary>
            [AliasInShort("VB")]
            ValléeDuBandama,

            /// <summary>
            /// Woroba
            /// </summary>
            [AliasInShort("WR")]
            Woroba,

            /// <summary>
            /// Yamoussoukro
            /// </summary>
            [AliasInShort("YM")]
            Yamoussoukro,

            /// <summary>
            /// Zanzan
            /// </summary>
            [AliasInShort("ZZ")]
            Zanzan,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="CotedIvoireRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="CotedIvoireRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"CI-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.CotedIvoire;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.CI;
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