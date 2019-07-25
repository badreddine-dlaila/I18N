using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// Bahamas Regions
    /// </summary>
    public static class BahamasRegions
    {

        #region Gets regions

        /// <summary>
        /// Acklins
        /// </summary>
        public static EnumValues Acklins => EnumValues.Acklins;

        /// <summary>
        /// Bimini
        /// </summary>
        public static EnumValues Bimini => EnumValues.Bimini;

        /// <summary>
        /// Black Point
        /// </summary>
        public static EnumValues BlackPoint => EnumValues.BlackPoint;

        /// <summary>
        /// Berry Islands
        /// </summary>
        public static EnumValues BerryIslands => EnumValues.BerryIslands;

        /// <summary>
        /// Central Eleuthera
        /// </summary>
        public static EnumValues CentralEleuthera => EnumValues.CentralEleuthera;

        /// <summary>
        /// Cat Island
        /// </summary>
        public static EnumValues CatIsland => EnumValues.CatIsland;

        /// <summary>
        /// Crooked Island
        /// </summary>
        public static EnumValues CrookedIsland => EnumValues.CrookedIsland;

        /// <summary>
        /// Central Abaco
        /// </summary>
        public static EnumValues CentralAbaco => EnumValues.CentralAbaco;

        /// <summary>
        /// Central Andros
        /// </summary>
        public static EnumValues CentralAndros => EnumValues.CentralAndros;

        /// <summary>
        /// East Grand Bahama
        /// </summary>
        public static EnumValues EastGrandBahama => EnumValues.EastGrandBahama;

        /// <summary>
        /// Exuma
        /// </summary>
        public static EnumValues Exuma => EnumValues.Exuma;

        /// <summary>
        /// Freeport
        /// </summary>
        public static EnumValues Freeport => EnumValues.Freeport;

        /// <summary>
        /// Grand Cay
        /// </summary>
        public static EnumValues GrandCay => EnumValues.GrandCay;

        /// <summary>
        /// Harbour Island
        /// </summary>
        public static EnumValues HarbourIsland => EnumValues.HarbourIsland;

        /// <summary>
        /// Hope Town
        /// </summary>
        public static EnumValues HopeTown => EnumValues.HopeTown;

        /// <summary>
        /// Inagua
        /// </summary>
        public static EnumValues Inagua => EnumValues.Inagua;

        /// <summary>
        /// Long Island
        /// </summary>
        public static EnumValues LongIsland => EnumValues.LongIsland;

        /// <summary>
        /// Mangrove Cay
        /// </summary>
        public static EnumValues MangroveCay => EnumValues.MangroveCay;

        /// <summary>
        /// Mayaguana
        /// </summary>
        public static EnumValues Mayaguana => EnumValues.Mayaguana;

        /// <summary>
        /// Moore’s Island
        /// </summary>
        public static EnumValues MooresIsland => EnumValues.MooresIsland;

        /// <summary>
        /// North Eleuthera
        /// </summary>
        public static EnumValues NorthEleuthera => EnumValues.NorthEleuthera;

        /// <summary>
        /// North Abaco
        /// </summary>
        public static EnumValues NorthAbaco => EnumValues.NorthAbaco;

        /// <summary>
        /// North Andros
        /// </summary>
        public static EnumValues NorthAndros => EnumValues.NorthAndros;

        /// <summary>
        /// Rum Cay
        /// </summary>
        public static EnumValues RumCay => EnumValues.RumCay;

        /// <summary>
        /// Ragged Island
        /// </summary>
        public static EnumValues RaggedIsland => EnumValues.RaggedIsland;

        /// <summary>
        /// South Andros
        /// </summary>
        public static EnumValues SouthAndros => EnumValues.SouthAndros;

        /// <summary>
        /// South Eleuthera
        /// </summary>
        public static EnumValues SouthEleuthera => EnumValues.SouthEleuthera;

        /// <summary>
        /// South Abaco
        /// </summary>
        public static EnumValues SouthAbaco => EnumValues.SouthAbaco;


        /// <summary>
        /// San Salvador
        /// </summary>
        public static EnumValues SanSalvador => EnumValues.SanSalvador;

        /// <summary>
        /// Spanish Wells
        /// </summary>
        public static EnumValues SpanishWells => EnumValues.SpanishWells;

        /// <summary>
        /// West Grand Bahama
        /// </summary>
        public static EnumValues WestGrandBahama => EnumValues.WestGrandBahama;

        #endregion

        /// <summary>
        /// Enum values for Bahamas regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Acklins
            /// </summary>
            [AliasInShort("AK")]
            Acklins,

            /// <summary>
            /// Bimini
            /// </summary>
            [AliasInShort("BI")]
            Bimini,

            /// <summary>
            /// Black Point
            /// </summary>
            [AliasInShort("BP")]
            BlackPoint,

            /// <summary>
            /// Berry Islands
            /// </summary>
            [AliasInShort("BY")]
            BerryIslands,

            /// <summary>
            /// Central Eleuthera
            /// </summary>
            [AliasInShort("CE")]
            CentralEleuthera,

            /// <summary>
            /// Cat Island
            /// </summary>
            [AliasInShort("CI")]
            CatIsland,

            /// <summary>
            /// Crooked Island
            /// </summary>
            [AliasInShort("CK")]
            CrookedIsland,

            /// <summary>
            /// Central Abaco
            /// </summary>
            [AliasInShort("CO")]
            CentralAbaco,

            /// <summary>
            /// Central Andros
            /// </summary>
            [AliasInShort("CS")]
            CentralAndros,

            /// <summary>
            /// East Grand Bahama
            /// </summary>
            [AliasInShort("EG")]
            EastGrandBahama,

            /// <summary>
            /// Exuma
            /// </summary>
            [AliasInShort("EX")]
            Exuma,

            /// <summary>
            /// Freeport
            /// </summary>
            [AliasInShort("FP")]
            Freeport,

            /// <summary>
            /// Grand Cay
            /// </summary>
            [AliasInShort("GC")]
            GrandCay,

            /// <summary>
            /// Harbour Island
            /// </summary>
            [AliasInShort("HI")]
            HarbourIsland,

            /// <summary>
            /// Hope Town
            /// </summary>
            [AliasInShort("HT")]
            HopeTown,

            /// <summary>
            /// Inagua
            /// </summary>
            [AliasInShort("IN")]
            Inagua,

            /// <summary>
            /// Long Island
            /// </summary>
            [AliasInShort("LI")]
            LongIsland,

            /// <summary>
            /// Mangrove Cay
            /// </summary>
            [AliasInShort("MC")]
            MangroveCay,

            /// <summary>
            /// Mayaguana
            /// </summary>
            [AliasInShort("MG")]
            Mayaguana,

            /// <summary>
            /// Moore’s Island
            /// </summary>
            [AliasInShort("MI")]
            MooresIsland,

            /// <summary>
            /// North Eleuthera
            /// </summary>
            [AliasInShort("NE")]
            NorthEleuthera,

            /// <summary>
            /// North Abaco
            /// </summary>
            [AliasInShort("NO")]
            NorthAbaco,

            /// <summary>
            /// North Andros
            /// </summary>
            [AliasInShort("NS")]
            NorthAndros,

            /// <summary>
            /// Rum Cay
            /// </summary>
            [AliasInShort("RC")]
            RumCay,

            /// <summary>
            /// Ragged Island
            /// </summary>
            [AliasInShort("RI")]
            RaggedIsland,

            /// <summary>
            /// South Andros
            /// </summary>
            [AliasInShort("SA")]
            SouthAndros,

            /// <summary>
            /// South Eleuthera
            /// </summary>
            [AliasInShort("SE")]
            SouthEleuthera,

            /// <summary>
            /// South Abaco
            /// </summary>
            [AliasInShort("SO")]
            SouthAbaco,


            /// <summary>
            /// San Salvador
            /// </summary>
            [AliasInShort("SS")]
            SanSalvador,

            /// <summary>
            /// Spanish Wells
            /// </summary>
            [AliasInShort("SW")]
            SpanishWells,

            /// <summary>
            /// West Grand Bahama
            /// </summary>
            [AliasInShort("WG")]
            WestGrandBahama,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BahamasRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BahamasRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"BS-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Bahamas;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.BS;
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