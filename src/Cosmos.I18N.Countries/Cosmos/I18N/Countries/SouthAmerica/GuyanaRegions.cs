using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.SouthAmerica {
    /// <summary>
    /// Guyana Regions
    /// </summary>
    public static class GuyanaRegions {

        #region Gets regions

        /// <summary>
        /// Barima-Waini
        /// </summary>
        public static EnumValues BarimaWaini => EnumValues.BarimaWaini;

        /// <summary>
        /// Cuyuni-Mazaruni
        /// </summary>
        public static EnumValues CuyuniMazaruni => EnumValues.CuyuniMazaruni;

        /// <summary>
        /// Demerara-Mahaica
        /// </summary>
        public static EnumValues DemeraraMahaica => EnumValues.DemeraraMahaica;

        /// <summary>
        /// East Berbice-Corentyne
        /// </summary>
        public static EnumValues EastBerbiceCorentyne => EnumValues.EastBerbiceCorentyne;

        /// <summary>
        /// Essequibo Islands-West Demerara
        /// </summary>
        public static EnumValues EssequiboIslandsWestDemerara => EnumValues.EssequiboIslandsWestDemerara;

        /// <summary>
        /// Mahaica-Berbice
        /// </summary>
        public static EnumValues MahaicaBerbice => EnumValues.MahaicaBerbice;

        /// <summary>
        /// Pomeroon-Supenaam
        /// </summary>
        public static EnumValues PomeroonSupenaam => EnumValues.PomeroonSupenaam;

        /// <summary>
        /// Potaro-Siparuni
        /// </summary>
        public static EnumValues PotaroSiparuni => EnumValues.PotaroSiparuni;

        /// <summary>
        /// Upper Demerara-Berbice
        /// </summary>
        public static EnumValues UpperDemeraraBerbice => EnumValues.UpperDemeraraBerbice;

        /// <summary>
        /// Upper Takutu-Upper Essequibo
        /// </summary>
        public static EnumValues UpperTakutuUpperEssequibo => EnumValues.UpperTakutuUpperEssequibo;

        #endregion

        /// <summary>
        /// Enum values for Guyana regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Barima-Waini
            /// </summary>
            [AliasInShort("BA")]
            BarimaWaini,

            /// <summary>
            /// Cuyuni-Mazaruni
            /// </summary>
            [AliasInShort("CU")]
            CuyuniMazaruni,

            /// <summary>
            /// Demerara-Mahaica
            /// </summary>
            [AliasInShort("DE")]
            DemeraraMahaica,

            /// <summary>
            /// East Berbice-Corentyne
            /// </summary>
            [AliasInShort("EB")]
            EastBerbiceCorentyne,

            /// <summary>
            /// Essequibo Islands-West Demerara
            /// </summary>
            [AliasInShort("ES")]
            EssequiboIslandsWestDemerara,

            /// <summary>
            /// Mahaica-Berbice
            /// </summary>
            [AliasInShort("MA")]
            MahaicaBerbice,

            /// <summary>
            /// Pomeroon-Supenaam
            /// </summary>
            [AliasInShort("PM")]
            PomeroonSupenaam,

            /// <summary>
            /// Potaro-Siparuni
            /// </summary>
            [AliasInShort("PT")]
            PotaroSiparuni,

            /// <summary>
            /// Upper Demerara-Berbice
            /// </summary>
            [AliasInShort("UD")]
            UpperDemeraraBerbice,

            /// <summary>
            /// Upper Takutu-Upper Essequibo
            /// </summary>
            [AliasInShort("UT")]
            UpperTakutuUpperEssequibo,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="GuyanaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="GuyanaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"GY-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Guyana;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.GY;
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