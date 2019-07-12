using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Spain
    /// </summary>
    public static class SpainRegions
    {
         #region Gets regions

        /// <summary>
        /// Comunidad de Madrid
        /// </summary>
        public static EnumValues ComunidadDeMadrid => EnumValues.ComunidadDeMadrid;

        /// <summary>
        /// Andalucía
        /// </summary>
        public static EnumValues Andalucía => EnumValues.Andalucía;

        /// <summary>
        /// Aragón
        /// </summary>
        public static EnumValues Aragón => EnumValues.Aragón;

        /// <summary>
        /// Asturias
        /// </summary>
        public static EnumValues Asturias => EnumValues.Asturias;

        /// <summary>
        /// Cantabria
        /// </summary>
        public static EnumValues Cantabria => EnumValues.Cantabria;

        /// <summary>
        /// Ceuta
        /// </summary>
        public static EnumValues Ceuta => EnumValues.Ceuta;

        /// <summary>
        /// Castile and León
        /// </summary>
        public static EnumValues CastileAndLeón => EnumValues.CastileAndLeón;

        /// <summary>
        /// Castile-La Mancha
        /// </summary>
        public static EnumValues CastileLaMancha => EnumValues.CastileLaMancha;

        /// <summary>
        /// Canary Islands
        /// </summary>
        public static EnumValues CanaryIslands => EnumValues.CanaryIslands;

        /// <summary>
        /// Catalonia
        /// </summary>
        public static EnumValues Catalonia => EnumValues.Catalonia;

        /// <summary>
        /// Extremadura
        /// </summary>
        public static EnumValues Extremadura => EnumValues.Extremadura;

        /// <summary>
        /// Galicia
        /// </summary>
        public static EnumValues Galicia => EnumValues.Galicia;

        /// <summary>
        /// Balearic Islands
        /// </summary>
        public static EnumValues BalearicIslands => EnumValues.BalearicIslands;

        /// <summary>
        /// Murcia Region
        /// </summary>
        public static EnumValues MurciaRegion => EnumValues.MurciaRegion;

        /// <summary>
        /// Melilla
        /// </summary>
        public static EnumValues Melilla => EnumValues.Melilla;

        /// <summary>
        /// Navarra Chartered Community
        /// </summary>
        public static EnumValues NavarraCharteredCommunity => EnumValues.NavarraCharteredCommunity;

        /// <summary>
        /// Basque Country
        /// </summary>
        public static EnumValues BasqueCountry => EnumValues.BasqueCountry;

        /// <summary>
        /// La Rioja
        /// </summary>
        public static EnumValues LaRioja => EnumValues.LaRioja;

        /// <summary>
        /// Valencian Community
        /// </summary>
        public static EnumValues ValencianCommunity => EnumValues.ValencianCommunity;

        #endregion

        /// <summary>
        /// Enum values for Spain regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Comunidad de Madrid
            /// </summary>
            [AliasInShort("MD")]
            ComunidadDeMadrid,

            /// <summary>
            /// Andalucía
            /// </summary>
            [AliasInShort("AN")]
            Andalucía,

            /// <summary>
            /// Aragón
            /// </summary>
            [AliasInShort("AR")]
            Aragón,

            /// <summary>
            /// Asturias
            /// </summary>
            [AliasInShort("AS")]
            Asturias,

            /// <summary>
            /// Cantabria
            /// </summary>
            [AliasInShort("CB")]
            Cantabria,

            /// <summary>
            /// Ceuta
            /// </summary>
            [AliasInShort("CE")]
            Ceuta,

            /// <summary>
            /// Castile and León
            /// </summary>
            [AliasInShort("CL")]
            CastileAndLeón,

            /// <summary>
            /// Castile-La Mancha
            /// </summary>
            [AliasInShort("CM")]
            CastileLaMancha,

            /// <summary>
            /// Canary Islands
            /// </summary>
            [AliasInShort("CN")]
            CanaryIslands,

            /// <summary>
            /// Catalonia
            /// </summary>
            [AliasInShort("CT")]
            Catalonia,

            /// <summary>
            /// Extremadura
            /// </summary>
            [AliasInShort("EX")]
            Extremadura,

            /// <summary>
            /// Galicia
            /// </summary>
            [AliasInShort("GA")]
            Galicia,

            /// <summary>
            /// Balearic Islands
            /// </summary>
            [AliasInShort("IB")]
            BalearicIslands,

            /// <summary>
            /// Murcia Region
            /// </summary>
            [AliasInShort("MC")]
            MurciaRegion,

            /// <summary>
            /// Melilla
            /// </summary>
            [AliasInShort("ML")]
            Melilla,

            /// <summary>
            /// Navarra Chartered Community
            /// </summary>
            [AliasInShort("NC")]
            NavarraCharteredCommunity,

            /// <summary>
            /// Basque Country
            /// </summary>
            [AliasInShort("PV")]
            BasqueCountry,
            
            /// <summary>
            /// La Rioja
            /// </summary>
            [AliasInShort("RI")]
            LaRioja,
            
            /// <summary>
            /// Valencian Community
            /// </summary>
            [AliasInShort("VC")]
            ValencianCommunity,
            
            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SpainRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SpainRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"ES-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Spain;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.ES;
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