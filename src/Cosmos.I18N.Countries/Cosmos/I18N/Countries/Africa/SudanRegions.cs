using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// Sudan Regions
    /// </summary>
    public static class SudanRegions {

        #region Gets regions

        /// <summary>
        /// Central Darfur
        /// </summary>
        public static EnumValues CentralDarfur => EnumValues.CentralDarfur;

        /// <summary>
        /// East Darfur
        /// </summary>
        public static EnumValues EastDarfur => EnumValues.EastDarfur;

        /// <summary>
        /// North Darfur
        /// </summary>
        public static EnumValues NorthDarfur => EnumValues.NorthDarfur;

        /// <summary>
        /// South Darfur
        /// </summary>
        public static EnumValues SouthDarfur => EnumValues.SouthDarfur;

        /// <summary>
        /// West Darfur
        /// </summary>
        public static EnumValues WestDarfur => EnumValues.WestDarfur;

        /// <summary>
        /// Al Qadarif
        /// </summary>
        public static EnumValues AlQadarif => EnumValues.AlQadarif;

        /// <summary>
        /// West Kurdufan
        /// </summary>
        public static EnumValues WestKurdufan => EnumValues.WestKurdufan;

        /// <summary>
        /// Al Jazirah
        /// </summary>
        public static EnumValues AlJazirah => EnumValues.AlJazirah;

        /// <summary>
        /// Kassala
        /// </summary>
        public static EnumValues Kassala => EnumValues.Kassala;

        /// <summary>
        /// Khartoum
        /// </summary>
        public static EnumValues Khartoum => EnumValues.Khartoum;

        /// <summary>
        /// North Kurdufan
        /// </summary>
        public static EnumValues NorthKurdufan => EnumValues.NorthKurdufan;

        /// <summary>
        /// South Kurdufan
        /// </summary>
        public static EnumValues SouthKurdufan => EnumValues.SouthKurdufan;

        /// <summary>
        /// Blue Nile
        /// </summary>
        public static EnumValues BlueNile => EnumValues.BlueNile;

        /// <summary>
        /// Northern
        /// </summary>
        public static EnumValues Northern => EnumValues.Northern;

        /// <summary>
        /// River Nile
        /// </summary>
        public static EnumValues RiverNile => EnumValues.RiverNile;

        /// <summary>
        /// White Nile
        /// </summary>
        public static EnumValues WhiteNile => EnumValues.WhiteNile;

        /// <summary>
        /// Red Sea
        /// </summary>
        public static EnumValues RedSea => EnumValues.RedSea;

        /// <summary>
        /// Sennar
        /// </summary>
        public static EnumValues Sennar => EnumValues.Sennar;

        #endregion

        /// <summary>
        /// Enum values for Sudan regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Central Darfur
            /// </summary>
            [AliasInShort("DC")]
            CentralDarfur,

            /// <summary>
            /// East Darfur
            /// </summary>
            [AliasInShort("DE")]
            EastDarfur,

            /// <summary>
            /// North Darfur
            /// </summary>
            [AliasInShort("DN")]
            NorthDarfur,

            /// <summary>
            /// South Darfur
            /// </summary>
            [AliasInShort("DS")]
            SouthDarfur,

            /// <summary>
            /// West Darfur
            /// </summary>
            [AliasInShort("DW")]
            WestDarfur,

            /// <summary>
            /// Al Qadarif
            /// </summary>
            [AliasInShort("GD")]
            AlQadarif,

            /// <summary>
            /// West Kurdufan
            /// </summary>
            [AliasInShort("GK")]
            WestKurdufan,

            /// <summary>
            /// Al Jazirah
            /// </summary>
            [AliasInShort("GZ")]
            AlJazirah,

            /// <summary>
            /// Kassala
            /// </summary>
            [AliasInShort("KA")]
            Kassala,

            /// <summary>
            /// Khartoum
            /// </summary>
            [AliasInShort("KH")]
            Khartoum,

            /// <summary>
            /// North Kurdufan
            /// </summary>
            [AliasInShort("KN")]
            NorthKurdufan,

            /// <summary>
            /// South Kurdufan
            /// </summary>
            [AliasInShort("KS")]
            SouthKurdufan,

            /// <summary>
            /// Blue Nile
            /// </summary>
            [AliasInShort("NB")]
            BlueNile,

            /// <summary>
            /// Northern
            /// </summary>
            [AliasInShort("NO")]
            Northern,

            /// <summary>
            /// River Nile
            /// </summary>
            [AliasInShort("NR")]
            RiverNile,

            /// <summary>
            /// White Nile
            /// </summary>
            [AliasInShort("NW")]
            WhiteNile,

            /// <summary>
            /// Red Sea
            /// </summary>
            [AliasInShort("RS")]
            RedSea,

            /// <summary>
            /// Sennar
            /// </summary>
            [AliasInShort("SI")]
            Sennar,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SudanRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SudanRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"SD-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Sudan;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.SD;
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