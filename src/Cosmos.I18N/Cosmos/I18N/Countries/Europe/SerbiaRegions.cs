using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Serbia Regions
    /// </summary>
    public static class SerbiaRegions
    {

        #region Gets regions

        /// <summary>
        /// Podunavlje
        /// </summary>
        public static EnumValues Podunavlje => EnumValues.Podunavlje;

        /// <summary>
        /// Braničevo
        /// </summary>
        public static EnumValues Braničevo => EnumValues.Braničevo;

        /// <summary>
        /// Šumadija
        /// </summary>
        public static EnumValues Šumadija => EnumValues.Šumadija;

        /// <summary>
        /// Pomoravlje
        /// </summary>
        public static EnumValues Pomoravlje => EnumValues.Pomoravlje;

        /// <summary>
        /// Bor
        /// </summary>
        public static EnumValues Bor => EnumValues.Bor;

        /// <summary>
        /// Zaječar
        /// </summary>
        public static EnumValues Zaječar => EnumValues.Zaječar;

        /// <summary>
        /// Zlatibor
        /// </summary>
        public static EnumValues Zlatibor => EnumValues.Zlatibor;

        /// <summary>
        /// Moravica
        /// </summary>
        public static EnumValues Moravica => EnumValues.Moravica;

        /// <summary>
        /// Raška
        /// </summary>
        public static EnumValues Raška => EnumValues.Raška;

        /// <summary>
        /// Rasina
        /// </summary>
        public static EnumValues Rasina => EnumValues.Rasina;

        /// <summary>
        /// Nišava
        /// </summary>
        public static EnumValues Nišava => EnumValues.Nišava;

        /// <summary>
        /// Toplica
        /// </summary>
        public static EnumValues Toplica => EnumValues.Toplica;

        /// <summary>
        /// Pirot
        /// </summary>
        public static EnumValues Pirot => EnumValues.Pirot;

        /// <summary>
        /// Jablanica
        /// </summary>
        public static EnumValues Jablanica => EnumValues.Jablanica;

        /// <summary>
        /// Pčinja
        /// </summary>
        public static EnumValues Pčinja => EnumValues.Pčinja;

        /// <summary>
        /// Beograd
        /// </summary>
        public static EnumValues Beograd => EnumValues.Beograd;

        /// <summary>
        /// Mačva
        /// </summary>
        public static EnumValues Mačva => EnumValues.Mačva;

        /// <summary>
        /// Wasit
        /// </summary>
        public static EnumValues Wasit => EnumValues.Wasit;

        /// <summary>
        /// Kosovo-Metohija
        /// </summary>
        public static EnumValues KosovoMetohija => EnumValues.KosovoMetohija;

        /// <summary>
        /// Vojvodina
        /// </summary>
        public static EnumValues Vojvodina => EnumValues.Vojvodina;

        #endregion

        /// <summary>
        /// Enum values for Serbia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Podunavlje
            /// </summary>
            [AliasInShort("10")]
            Podunavlje,

            /// <summary>
            /// Braničevo
            /// </summary>
            [AliasInShort("11")]
            Braničevo,

            /// <summary>
            /// Šumadija
            /// </summary>
            [AliasInShort("12")]
            Šumadija,

            /// <summary>
            /// Pomoravlje
            /// </summary>
            [AliasInShort("13")]
            Pomoravlje,

            /// <summary>
            /// Bor
            /// </summary>
            [AliasInShort("14")]
            Bor,

            /// <summary>
            /// Zaječar
            /// </summary>
            [AliasInShort("15")]
            Zaječar,

            /// <summary>
            /// Zlatibor
            /// </summary>
            [AliasInShort("16")]
            Zlatibor,

            /// <summary>
            /// Moravica
            /// </summary>
            [AliasInShort("17")]
            Moravica,

            /// <summary>
            /// Raška
            /// </summary>
            [AliasInShort("18")]
            Raška,

            /// <summary>
            /// Rasina
            /// </summary>
            [AliasInShort("19")]
            Rasina,

            /// <summary>
            /// Nišava
            /// </summary>
            [AliasInShort("20")]
            Nišava,

            /// <summary>
            /// Toplica
            /// </summary>
            [AliasInShort("21")]
            Toplica,

            /// <summary>
            /// Pirot
            /// </summary>
            [AliasInShort("22")]
            Pirot,

            /// <summary>
            /// Jablanica
            /// </summary>
            [AliasInShort("23")]
            Jablanica,

            /// <summary>
            /// Pčinja
            /// </summary>
            [AliasInShort("24")]
            Pčinja,

            /// <summary>
            /// Beograd
            /// </summary>
            [AliasInShort("00")]
            Beograd,

            /// <summary>
            /// Mačva
            /// </summary>
            [AliasInShort("08")]
            Mačva,

            /// <summary>
            /// Kolubara
            /// </summary>
            [AliasInShort("09")]
            Wasit,

            /// <summary>
            /// Kosovo-Metohija
            /// </summary>
            [AliasInShort("KM")]
            KosovoMetohija,

            /// <summary>
            /// Vojvodina
            /// </summary>
            [AliasInShort("VO")]
            Vojvodina,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SerbiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SerbiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"RS-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Serbia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.RS;
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