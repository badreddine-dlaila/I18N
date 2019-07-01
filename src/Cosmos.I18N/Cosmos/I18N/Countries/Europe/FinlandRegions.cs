using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Finland Regions
    /// </summary>
    public static class FinlandRegions
    {

        #region Gets regions

        /// <summary>
        /// South Karelia
        /// </summary>
        public static EnumValues SouthKarelia => EnumValues.SouthKarelia;

        /// <summary>
        /// Southern Ostrobothnia
        /// </summary>
        public static EnumValues SouthernOstrobothnia => EnumValues.SouthernOstrobothnia;

        /// <summary>
        /// Southern Savonia
        /// </summary>
        public static EnumValues SouthernSavonia => EnumValues.SouthernSavonia;

        /// <summary>
        /// Kainuu
        /// </summary>
        public static EnumValues Kainuu => EnumValues.Kainuu;

        /// <summary>
        /// Tavastia Proper
        /// </summary>
        public static EnumValues TavastiaProper => EnumValues.TavastiaProper;

        /// <summary>
        /// Central Ostrobothnia
        /// </summary>
        public static EnumValues CentralOstrobothnia => EnumValues.CentralOstrobothnia;

        /// <summary>
        /// Central Finland
        /// </summary>
        public static EnumValues CentralFinland => EnumValues.CentralFinland;

        /// <summary>
        /// Kymenlaakso
        /// </summary>
        public static EnumValues Kymenlaakso => EnumValues.Kymenlaakso;

        /// <summary>
        /// Lapland
        /// </summary>
        public static EnumValues Lapland => EnumValues.Lapland;

        /// <summary>
        /// Pirkanmaa
        /// </summary>
        public static EnumValues Pirkanmaa => EnumValues.Pirkanmaa;

        /// <summary>
        /// Ostrobothnia
        /// </summary>
        public static EnumValues Ostrobothnia => EnumValues.Ostrobothnia;

        /// <summary>
        /// North Karelia
        /// </summary>
        public static EnumValues NorthKarelia => EnumValues.NorthKarelia;

        /// <summary>
        /// Northern Ostrobothnia
        /// </summary>
        public static EnumValues NorthernOstrobothnia => EnumValues.NorthernOstrobothnia;

        /// <summary>
        /// Northern Savonia
        /// </summary>
        public static EnumValues NorthernSavonia => EnumValues.NorthernSavonia;

        /// <summary>
        /// Päijänne Tavastia
        /// </summary>
        public static EnumValues PäijänneTavastia => EnumValues.PäijänneTavastia;

        /// <summary>
        /// Satakunta
        /// </summary>
        public static EnumValues Satakunta => EnumValues.Satakunta;

        /// <summary>
        /// Uusimaa
        /// </summary>
        public static EnumValues Uusimaa => EnumValues.Uusimaa;

        /// <summary>
        /// Southwest Finland
        /// </summary>
        public static EnumValues SouthwestFinland => EnumValues.SouthwestFinland;

        /// <summary>
        /// Aland Islands
        /// </summary>
        public static EnumValues AlandIslands => EnumValues.Aland;

        #endregion

        /// <summary>
        /// Special regions
        /// </summary>
        public static class Special
        {
            /// <summary>
            /// Aland Island
            /// </summary>
            public static Country Aland => Country.AlandIslands;

            /// <summary>
            /// Aland Island
            /// </summary>
            public static CountryCode AlandCode => CountryCode.AX;
        }

        /// <summary>
        /// Cnum values for China regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// South Karelia
            /// </summary>
            [AliasInShort("02")]
            [RegionFlag("main")]
            SouthKarelia,

            /// <summary>
            /// Southern Ostrobothnia
            /// </summary>
            [AliasInShort("03")]
            [RegionFlag("main")]
            SouthernOstrobothnia,

            /// <summary>
            /// Southern Savonia
            /// </summary>
            [AliasInShort("04")]
            [RegionFlag("main")]
            SouthernSavonia,

            /// <summary>
            /// Kainuu
            /// </summary>
            [AliasInShort("05")]
            [RegionFlag("main")]
            Kainuu,

            /// <summary>
            /// Tavastia Proper
            /// </summary>
            [AliasInShort("06")]
            [RegionFlag("main")]
            TavastiaProper,

            /// <summary>
            /// Central Ostrobothnia
            /// </summary>
            [AliasInShort("07")]
            [RegionFlag("main")]
            CentralOstrobothnia,

            /// <summary>
            /// Central Finland
            /// </summary>
            [AliasInShort("08")]
            [RegionFlag("main")]
            CentralFinland,

            /// <summary>
            /// Kymenlaakso
            /// </summary>
            [AliasInShort("09")]
            [RegionFlag("main")]
            Kymenlaakso,

            /// <summary>
            /// Lapland
            /// </summary>
            [AliasInShort("10")]
            [RegionFlag("main")]
            Lapland,

            /// <summary>
            /// Pirkanmaa
            /// </summary>
            [AliasInShort("11")]
            [RegionFlag("main")]
            Pirkanmaa,

            /// <summary>
            /// Ostrobothnia
            /// </summary>
            [AliasInShort("12")]
            [RegionFlag("main")]
            Ostrobothnia,

            /// <summary>
            /// North Karelia
            /// </summary>
            [AliasInShort("13")]
            [RegionFlag("main")]
            NorthKarelia,

            /// <summary>
            /// Northern Ostrobothnia
            /// </summary>
            [AliasInShort("14")]
            [RegionFlag("main")]
            NorthernOstrobothnia,

            /// <summary>
            /// Northern Savonia
            /// </summary>
            [AliasInShort("15")]
            [RegionFlag("main")]
            NorthernSavonia,

            /// <summary>
            /// Päijänne Tavastia
            /// </summary>
            [AliasInShort("16")]
            [RegionFlag("main")]
            PäijänneTavastia,

            /// <summary>
            /// Satakunta
            /// </summary>
            [AliasInShort("17")]
            [RegionFlag("main")]
            Satakunta,

            /// <summary>
            /// Uusimaa
            /// </summary>
            [AliasInShort("18")]
            [RegionFlag("main")]
            Uusimaa,

            /// <summary>
            /// Southwest Finland
            /// </summary>
            [AliasInShort("19")]
            [RegionFlag("main")]
            SouthwestFinland,

            /// <summary>
            /// Aland Island
            /// <br />
            /// FI-AX, also, FI-01
            /// </summary>
            [AliasInShort("AX")]
            [RegionFlag("overseas")]
            Aland,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="FinlandRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="FinlandRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"FI-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            switch (value)
            {
                case EnumValues.Aland:
                    return Country.AlandIslands;
                default:
                    return Country.Finland;
            }
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            switch (value)
            {
                case EnumValues.Aland:
                    return CountryCode.AX;
                default:
                    return CountryCode.FI;
            }
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Convert from special regions of Finland
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(Country country)
        {
            switch (country)
            {
                case Country.AlandIslands:
                    return EnumValues.Aland;
                default:
                    return EnumValues.Unknown;
            }
        }

        /// <summary>
        /// Convert from special regions of Finland
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(CountryCode code)
        {
            switch (code)
            {
                case CountryCode.AX:
                    return EnumValues.Aland;
                default:
                    return EnumValues.Unknown;
            }
        }

        #endregion

        #region Getters

        private static List<EnumMember<EnumValues>> InternalEnumMembersCache { get; }
            = Enums.GetMembers<EnumValues>().Where(x => !x.Attributes.Has<IgnoreRegionAttribute>()).ToList();

        private static IEnumerable<EnumMember<EnumValues>> Filter(string flag) =>
            InternalEnumMembersCache.Where(x => x.Attributes.GetAll<RegionFlagAttribute>().Any(attr => attr.Flag == flag));

        /// <summary>
        /// Get all region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAllRegonCodes()
        {
            foreach (var member in InternalEnumMembersCache)
                yield return member.Value.ToFullRegionCode();
        }

        /// <summary>
        /// 获得主要地区的地区代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetMainRegionCodes()
        {
            foreach (var member in Filter("main"))
                yield return member.Value.ToFullRegionCode();
        }

        /// <summary>
        /// 获得海外地区代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetOverseasRegionCodes()
        {
            foreach (var member in Filter("overseas"))
                yield return member.Value.ToFullRegionCode();
        }

        #endregion

    }
}