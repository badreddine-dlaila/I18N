using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// Australia regions
    /// </summary>
    public static class AustraliaRegions {

        #region Gets regions

        /// <summary>
        /// Australian Capital Territory
        /// </summary>
        public static EnumValues AustralianCapitalTerritory => EnumValues.AustralianCapitalTerritory;

        /// <summary>
        /// New South Wales
        /// </summary>
        public static EnumValues NewSouthWales => EnumValues.NewSouthWales;

        /// <summary>
        /// Northern Territory
        /// </summary>
        public static EnumValues NorthernTerritory => EnumValues.NorthernTerritory;

        /// <summary>
        /// Queensland
        /// </summary>
        public static EnumValues Queensland => EnumValues.Queensland;

        /// <summary>
        /// South Australia
        /// </summary>
        public static EnumValues SouthAustralia => EnumValues.SouthAustralia;

        /// <summary>
        /// Tasmania
        /// </summary>
        public static EnumValues Tasmania => EnumValues.Tasmania;

        /// <summary>
        /// Victoria
        /// </summary>
        public static EnumValues Victoria => EnumValues.Victoria;

        /// <summary>
        /// Western Australia
        /// </summary>
        public static EnumValues WesternAustralia => EnumValues.WesternAustralia;

        /// <summary>
        /// 删除海群岛
        /// </summary>
        public static EnumValues CoralSeaIslands => EnumValues.CoralSeaIslands;

        /// <summary>
        /// 阿什莫尔和卡捷岛
        /// </summary>
        public static EnumValues AshmoreAndCartierIslands => EnumValues.AshmoreAndCartierIslands;

        /// <summary>
        /// 科科斯群岛
        /// </summary>
        public static EnumValues CocosIslands => EnumValues.CocosIslands;

        /// <summary>
        /// 赫德岛及麦唐纳群岛
        /// </summary>
        public static EnumValues HeardIslandAndMcDonaldIslands => EnumValues.HeardIslandAndMcDonaldIslands;

        /// <summary>
        /// Christmas Island
        /// </summary>
        public static EnumValues ChristmasIsland => EnumValues.ChristmasIsland;

        /// <summary>
        /// Norfolk Island
        /// </summary>
        public static EnumValues NorfolkIsland => EnumValues.NorfolkIsland;

        #endregion

        /// <summary>
        /// Special regions
        /// </summary>
        public static class Special {
            /// <summary>
            /// NorfolkIsland
            /// </summary>
            public static Country NorfolkIsland => Country.NorfolkIsland;

            /// <summary>
            /// NorfolkIsland
            /// </summary>
            public static CountryCode NorfolkIslandCode => CountryCode.NF;

            /// <summary>
            /// ChristmasIsland
            /// </summary>
            public static Country ChristmasIsland => Country.ChristmasIsland;

            /// <summary>
            /// ChristmasIsland
            /// </summary>
            public static CountryCode ChristmasIslandCode => CountryCode.CX;

            /// <summary>
            /// CocosIslands
            /// </summary>
            public static Country CocosIslands => Country.CocosIslands;

            /// <summary>
            /// CocosIslands
            /// </summary>
            public static CountryCode CocosIslandsCode => CountryCode.CC;
        }

        /// <summary>
        /// Enum values for Australia regions
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Australian Capital Territory
            /// </summary>
            [AliasInShort("ACT")]
            [RegionFlag("mainland")]
            AustralianCapitalTerritory,

            /// <summary>
            /// New South Wales
            /// </summary>
            [AliasInShort("NSW")]
            [RegionFlag("mainland")]
            NewSouthWales,

            /// <summary>
            /// Northern Territory
            /// </summary>
            [AliasInShort("NT")]
            [RegionFlag("mainland")]
            NorthernTerritory,

            /// <summary>
            /// Queensland
            /// </summary>
            [AliasInShort("QLD")]
            [RegionFlag("mainland")]
            Queensland,

            /// <summary>
            /// South Australia
            /// </summary>
            [AliasInShort("SA")]
            [RegionFlag("mainland")]
            SouthAustralia,

            /// <summary>
            /// Tasmania
            /// </summary>
            [AliasInShort("TAS")]
            [RegionFlag("mainland")]
            Tasmania,

            /// <summary>
            /// Victoria
            /// </summary>
            [AliasInShort("VIC")]
            [RegionFlag("mainland")]
            Victoria,

            /// <summary>
            /// Western Australia
            /// </summary>
            [AliasInShort("WA")]
            [RegionFlag("mainland")]
            WesternAustralia,

            /// <summary>
            /// 删除海群岛
            /// </summary>
            [AliasInShort("CSI")]
            [RegionFlag("overseas")]
            CoralSeaIslands,

            /// <summary>
            /// 阿什莫尔和卡捷岛
            /// </summary>
            [AliasInShort("ACI")]
            [RegionFlag("overseas")]
            AshmoreAndCartierIslands,

            /// <summary>
            /// 科科斯群岛
            /// </summary>
            [AliasInShort("CC")]
            [RegionFlag("overseas")]
            CocosIslands,

            /// <summary>
            /// 赫德岛及麦唐纳群岛
            /// </summary>
            [AliasInShort("HMD")]
            [RegionFlag("overseas")]
            HeardIslandAndMcDonaldIslands,

            /// <summary>
            /// Christmas Island
            /// </summary>
            [AliasInShort("CX")]
            [RegionFlag("overseas")]
            ChristmasIsland,

            /// <summary>
            /// Norfolk Island
            /// </summary>
            [AliasInShort("NF")]
            [RegionFlag("overseas")]
            NorfolkIsland,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="AustraliaRegions.EnumValues"/> to region code likes 'ACT', 'NT'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="AustraliaRegions.EnumValues"/> to full region code likes 'AU-ACT', 'AU-NT'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"AU-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            switch (value) {
                case EnumValues.ChristmasIsland:
                    return Country.ChristmasIsland;
                case EnumValues.CocosIslands:
                    return Country.CocosIslands;
                case EnumValues.NorfolkIsland:
                    return Country.NorfolkIsland;
                default:
                    return Country.Australia;
            }
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            switch (value) {
                case EnumValues.CocosIslands:
                    return CountryCode.CC;
                case EnumValues.ChristmasIsland:
                    return CountryCode.CX;
                case EnumValues.NorfolkIsland:
                    return CountryCode.NF;
                default:
                    return CountryCode.AU;
            }
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Convert from special regions of Australia
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(Country country) {
            switch (country) {
                case Country.CocosIslands:
                    return EnumValues.CocosIslands;
                case Country.ChristmasIsland:
                    return EnumValues.ChristmasIsland;
                case Country.NorfolkIsland:
                    return EnumValues.NorfolkIsland;
                default:
                    return EnumValues.Unknown;
            }
        }

        /// <summary>
        /// Convert from special regions of Australia
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(CountryCode code) {
            switch (code) {
                case CountryCode.CC:
                    return EnumValues.CocosIslands;
                case CountryCode.CX:
                    return EnumValues.ChristmasIsland;
                case CountryCode.NF:
                    return EnumValues.NorfolkIsland;
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
        public static IEnumerable<string> GetAllRegonCodes() {
            foreach (var member in InternalEnumMembersCache)
                yield return member.Value.ToFullRegionCode();
        }

        /// <summary>
        /// 获得本土地区的地区代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetMainlandRegionCodes() {
            foreach (var member in Filter("mainland"))
                yield return member.Value.ToFullRegionCode();
        }

        /// <summary>
        /// 获得海外属地地区代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetOverseasRegionCodes() {
            foreach (var member in Filter("overseas"))
                yield return member.Value.ToFullRegionCode();
        }

        #endregion

    }
}