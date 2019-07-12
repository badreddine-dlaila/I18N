using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Mongolia Regions
    /// </summary>
    public static class MongoliaRegions
    {

        #region Gets regions

        /// <summary>
        /// Ulaanbaatar
        /// </summary>
        public static EnumValues Ulaanbaatar => EnumValues.Ulaanbaatar;

        /// <summary>
        /// Orkhon
        /// </summary>
        public static EnumValues Orkhon => EnumValues.Orkhon;

        /// <summary>
        /// Darkhan-Uul
        /// </summary>
        public static EnumValues DarkhanUul => EnumValues.DarkhanUul;

        /// <summary>
        /// Khentii
        /// </summary>
        public static EnumValues Khentii => EnumValues.Khentii;

        /// <summary>
        /// Khövsgöl
        /// </summary>
        public static EnumValues Khövsgöl => EnumValues.Khövsgöl;

        /// <summary>
        /// Khovd
        /// </summary>
        public static EnumValues Khovd => EnumValues.Khovd;

        /// <summary>
        /// Uvs
        /// </summary>
        public static EnumValues Uvs => EnumValues.Uvs;

        /// <summary>
        /// Töv
        /// </summary>
        public static EnumValues Töv => EnumValues.Töv;

        /// <summary>
        /// Selenge
        /// </summary>
        public static EnumValues Selenge => EnumValues.Selenge;

        /// <summary>
        /// Loja
        /// </summary>
        public static EnumValues Sükhbaatar => EnumValues.Sükhbaatar;

        /// <summary>
        /// Ömnögovi
        /// </summary>
        public static EnumValues Ömnögovi => EnumValues.Ömnögovi;

        /// <summary>
        /// Övörkhangai
        /// </summary>
        public static EnumValues Övörkhangai => EnumValues.Övörkhangai;

        /// <summary>
        /// Zavkhan
        /// </summary>
        public static EnumValues Zavkhan => EnumValues.Zavkhan;

        /// <summary>
        /// Dundgovi
        /// </summary>
        public static EnumValues Dundgovi => EnumValues.Dundgovi;

        /// <summary>
        /// Dornod
        /// </summary>
        public static EnumValues Dornod => EnumValues.Dornod;

        /// <summary>
        /// Dornogovi
        /// </summary>
        public static EnumValues Dornogovi => EnumValues.Dornogovi;

        /// <summary>
        /// Govisümber
        /// </summary>
        public static EnumValues Govisümber => EnumValues.Govisümber;

        /// <summary>
        /// Govi-Altai
        /// </summary>
        public static EnumValues GoviAltai => EnumValues.GoviAltai;

        /// <summary>
        /// Bulgan
        /// </summary>
        public static EnumValues Bulgan => EnumValues.Bulgan;

        /// <summary>
        /// Bayankhongor
        /// </summary>
        public static EnumValues Bayankhongor => EnumValues.Bayankhongor;

        /// <summary>
        /// Bayan-Ölgii
        /// </summary>
        public static EnumValues BayanÖlgii => EnumValues.BayanÖlgii;

        /// <summary>
        /// Arkhangai
        /// </summary>
        public static EnumValues Arkhangai => EnumValues.Arkhangai;

        #endregion

        /// <summary>
        /// Enum values for Mongolia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Ulaanbaatar
            /// </summary>
            [AliasInShort("1")]
            Ulaanbaatar,

            /// <summary>
            /// Orkhon
            /// </summary>
            [AliasInShort("035")]
            Orkhon,

            /// <summary>
            /// Darkhan-Uul
            /// </summary>
            [AliasInShort("037")]
            DarkhanUul,

            /// <summary>
            /// Khentii
            /// </summary>
            [AliasInShort("039")]
            Khentii,

            /// <summary>
            /// Khövsgöl
            /// </summary>
            [AliasInShort("041")]
            Khövsgöl,

            /// <summary>
            /// Khovd
            /// </summary>
            [AliasInShort("043")]
            Khovd,

            /// <summary>
            /// Uvs
            /// </summary>
            [AliasInShort("046")]
            Uvs,

            /// <summary>
            /// Töv
            /// </summary>
            [AliasInShort("047")]
            Töv,

            /// <summary>
            /// Selenge
            /// </summary>
            [AliasInShort("049")]
            Selenge,

            /// <summary>
            /// Sükhbaatar
            /// </summary>
            [AliasInShort("051")]
            Sükhbaatar,

            /// <summary>
            /// Ömnögovi
            /// </summary>
            [AliasInShort("053")]
            Ömnögovi,

            /// <summary>
            /// Övörkhangai
            /// </summary>
            [AliasInShort("055")]
            Övörkhangai,

            /// <summary>
            /// Zavkhan
            /// </summary>
            [AliasInShort("057")]
            Zavkhan,

            /// <summary>
            /// Dundgovi
            /// </summary>
            [AliasInShort("059")]
            Dundgovi,

            /// <summary>
            /// Dornod
            /// </summary>
            [AliasInShort("061")]
            Dornod,

            /// <summary>
            /// Dornogovi
            /// </summary>
            [AliasInShort("063")]
            Dornogovi,

            /// <summary>
            /// Govisümber
            /// </summary>
            [AliasInShort("064")]
            Govisümber,

            /// <summary>
            /// Govi-Altai
            /// </summary>
            [AliasInShort("065")]
            GoviAltai,

            /// <summary>
            /// Bulgan
            /// </summary>
            [AliasInShort("067")]
            Bulgan,

            /// <summary>
            /// Bayankhongor
            /// </summary>
            [AliasInShort("069")]
            Bayankhongor,

            /// <summary>
            /// Bayan-Ölgii
            /// </summary>
            [AliasInShort("071")]
            BayanÖlgii,

            /// <summary>
            /// Arkhangai
            /// </summary>
            [AliasInShort("073")]
            Arkhangai,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="MongoliaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="MongoliaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"MN-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Mongolia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.MN;
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