using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Mauritania Regions
    /// </summary>
    public static class MauritaniaRegions
    {

        #region Gets regions

        /// <summary>
        /// Guidimaka
        /// </summary>
        public static EnumValues Guidimaka => EnumValues.Guidimaka;

        /// <summary>
        /// Tiris Zemmour
        /// </summary>
        public static EnumValues TirisZemmour => EnumValues.TirisZemmour;

        /// <summary>
        /// Inchiri
        /// </summary>
        public static EnumValues Inchiri => EnumValues.Inchiri;

        /// <summary>
        /// Nouakchott Ouest
        /// </summary>
        public static EnumValues NouakchottOuest => EnumValues.NouakchottOuest;

        /// <summary>
        /// Nouakchott Nord
        /// </summary>
        public static EnumValues NouakchottNord => EnumValues.NouakchottNord;

        /// <summary>
        /// Nouakchott Sud
        /// </summary>
        public static EnumValues NouakchottSud => EnumValues.NouakchottSud;

        /// <summary>
        /// Hodh Ech Chargui
        /// </summary>
        public static EnumValues HodhEchChargui => EnumValues.HodhEchChargui;

        /// <summary>
        /// Hodh El Gharbi
        /// </summary>
        public static EnumValues HodhElGharbi => EnumValues.HodhElGharbi;

        /// <summary>
        /// Assaba
        /// </summary>
        public static EnumValues Assaba => EnumValues.Assaba;

        /// <summary>
        /// Gorgol
        /// </summary>
        public static EnumValues Gorgol => EnumValues.Gorgol;

        /// <summary>
        /// Brakna
        /// </summary>
        public static EnumValues Brakna => EnumValues.Brakna;

        /// <summary>
        /// Trarza
        /// </summary>
        public static EnumValues Trarza => EnumValues.Trarza;

        /// <summary>
        /// Adrar
        /// </summary>
        public static EnumValues Adrar => EnumValues.Adrar;

        /// <summary>
        /// Dakhlet Nouadhibou
        /// </summary>
        public static EnumValues DakhletNouadhibou => EnumValues.DakhletNouadhibou;

        /// <summary>
        /// Tagant
        /// </summary>
        public static EnumValues Tagant => EnumValues.Tagant;

        #endregion

        /// <summary>
        /// Enum values for Mauritania regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Guidimaka
            /// </summary>
            [AliasInShort("10")]
            Guidimaka,

            /// <summary>
            /// Tiris Zemmour
            /// </summary>
            [AliasInShort("11")]
            TirisZemmour,

            /// <summary>
            /// Inchiri
            /// </summary>
            [AliasInShort("12")]
            Inchiri,

            /// <summary>
            /// Nouakchott Ouest
            /// </summary>
            [AliasInShort("13")]
            NouakchottOuest,

            /// <summary>
            /// Nouakchott Nord
            /// </summary>
            [AliasInShort("14")]
            NouakchottNord,

            /// <summary>
            /// Nouakchott Sud
            /// </summary>
            [AliasInShort("15")]
            NouakchottSud,

            /// <summary>
            /// Hodh Ech Chargui
            /// </summary>
            [AliasInShort("01")]
            HodhEchChargui,

            /// <summary>
            /// Hodh El Gharbi
            /// </summary>
            [AliasInShort("02")]
            HodhElGharbi,

            /// <summary>
            /// Assaba
            /// </summary>
            [AliasInShort("03")]
            Assaba,

            /// <summary>
            /// Gorgol
            /// </summary>
            [AliasInShort("04")]
            Gorgol,

            /// <summary>
            /// Brakna
            /// </summary>
            [AliasInShort("05")]
            Brakna,

            /// <summary>
            /// Trarza
            /// </summary>
            [AliasInShort("06")]
            Trarza,

            /// <summary>
            /// Adrar
            /// </summary>
            [AliasInShort("07")]
            Adrar,

            /// <summary>
            /// Dakhlet Nouadhibou
            /// </summary>
            [AliasInShort("08")]
            DakhletNouadhibou,

            /// <summary>
            /// Tagant
            /// </summary>
            [AliasInShort("09")]
            Tagant,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="MauritaniaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="MauritaniaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"MR-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Mauritania;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.MR;
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