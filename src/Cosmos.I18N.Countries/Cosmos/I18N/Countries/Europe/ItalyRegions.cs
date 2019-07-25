using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Italy Regions
    /// </summary>
    public static class ItalyRegions
    {

        #region Gets regions

        /// <summary>
        /// Piedmont
        /// </summary>
        public static EnumValues Piedmont => EnumValues.Piedmont;

        /// <summary>
        /// Aosta Valley
        /// </summary>
        public static EnumValues AostaValley => EnumValues.AostaValley;

        /// <summary>
        /// Lombardy
        /// </summary>
        public static EnumValues Lombardy => EnumValues.Lombardy;

        /// <summary>
        /// Südtirol, Alto Adige
        /// </summary>
        public static EnumValues SüdtirolAltoAdige => EnumValues.SüdtirolAltoAdige;

        /// <summary>
        /// Veneto
        /// </summary>
        public static EnumValues Veneto => EnumValues.Veneto;

        /// <summary>
        /// Friuli–Venezia Giulia
        /// </summary>
        public static EnumValues FriuliVeneziaGiulia => EnumValues.FriuliVeneziaGiulia;

        /// <summary>
        /// Liguria
        /// </summary>
        public static EnumValues Liguria => EnumValues.Liguria;

        /// <summary>
        /// Emilia-Romagna
        /// </summary>
        public static EnumValues EmiliaRomagna => EnumValues.EmiliaRomagna;

        /// <summary>
        /// Tuscany
        /// </summary>
        public static EnumValues Tuscany => EnumValues.Tuscany;

        /// <summary>
        /// Umbria
        /// </summary>
        public static EnumValues Umbria => EnumValues.Umbria;

        /// <summary>
        /// Marche
        /// </summary>
        public static EnumValues Marche => EnumValues.Marche;

        /// <summary>
        /// Lazio
        /// </summary>
        public static EnumValues Lazio => EnumValues.Lazio;

        /// <summary>
        /// Abruzzo
        /// </summary>
        public static EnumValues Abruzzo => EnumValues.Abruzzo;

        /// <summary>
        /// Molise
        /// </summary>
        public static EnumValues Molise => EnumValues.Molise;

        /// <summary>
        /// Campania
        /// </summary>
        public static EnumValues Campania => EnumValues.Campania;

        /// <summary>
        /// Apulia
        /// </summary>
        public static EnumValues Apulia => EnumValues.Apulia;

        /// <summary>
        /// Basilicata
        /// </summary>
        public static EnumValues Basilicata => EnumValues.Basilicata;

        /// <summary>
        /// Calabria
        /// </summary>
        public static EnumValues Calabria => EnumValues.Calabria;


        /// <summary>
        /// Sicily
        /// </summary>
        public static EnumValues Sicily => EnumValues.Sicily;

        /// <summary>
        /// Sardinia
        /// </summary>
        public static EnumValues Sardinia => EnumValues.Sardinia;

        #endregion

        /// <summary>
        /// Enum values for Italy regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Piedmont
            /// </summary>
            [AliasInShort("21")]
            Piedmont,

            /// <summary>
            /// Aosta Valley
            /// </summary>
            [AliasInShort("23")]
            AostaValley,

            /// <summary>
            /// Lombardy
            /// </summary>
            [AliasInShort("25")]
            Lombardy,

            /// <summary>
            /// Südtirol, Alto Adige
            /// </summary>
            [AliasInShort("32")]
            SüdtirolAltoAdige,

            /// <summary>
            /// Veneto
            /// </summary>
            [AliasInShort("34")]
            Veneto,

            /// <summary>
            /// Friuli–Venezia Giulia
            /// </summary>
            [AliasInShort("36")]
            FriuliVeneziaGiulia,

            /// <summary>
            /// Liguria
            /// </summary>
            [AliasInShort("42")]
            Liguria,

            /// <summary>
            /// Emilia-Romagna
            /// </summary>
            [AliasInShort("45")]
            EmiliaRomagna,

            /// <summary>
            /// Tuscany
            /// </summary>
            [AliasInShort("52")]
            Tuscany,

            /// <summary>
            /// Umbria
            /// </summary>
            [AliasInShort("55")]
            Umbria,

            /// <summary>
            /// Marche
            /// </summary>
            [AliasInShort("57")]
            Marche,

            /// <summary>
            /// Lazio
            /// </summary>
            [AliasInShort("62")]
            Lazio,

            /// <summary>
            /// Abruzzo
            /// </summary>
            [AliasInShort("65")]
            Abruzzo,

            /// <summary>
            /// Molise
            /// </summary>
            [AliasInShort("67")]
            Molise,

            /// <summary>
            /// Campania
            /// </summary>
            [AliasInShort("72")]
            Campania,

            /// <summary>
            /// Apulia
            /// </summary>
            [AliasInShort("75")]
            Apulia,

            /// <summary>
            /// Basilicata
            /// </summary>
            [AliasInShort("77")]
            Basilicata,

            /// <summary>
            /// Calabria
            /// </summary>
            [AliasInShort("78")]
            Calabria,

            /// <summary>
            /// Sicily
            /// </summary>
            [AliasInShort("82")]
            Sicily,

            /// <summary>
            /// Sardinia
            /// </summary>
            [AliasInShort("88")]
            Sardinia,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="ItalyRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="ItalyRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"IT-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Italy;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.IT;
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