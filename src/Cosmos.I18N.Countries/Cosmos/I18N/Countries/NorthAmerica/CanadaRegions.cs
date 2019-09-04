using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// Canada Regions
    /// <br />
    /// Reference to: https://baike.baidu.com/item/%E5%8A%A0%E6%8B%BF%E5%A4%A7/145973
    /// </summary>
    public static class CanadaRegions
    {

        #region Gets regions

        /// <summary>
        /// Alberta
        /// </summary>
        public static EnumValues Alberta => EnumValues.Alberta;

        /// <summary>
        /// British Columbia
        /// </summary>
        public static EnumValues BritishColumbia => EnumValues.BritishColumbia;

        /// <summary>
        /// Manitoba
        /// </summary>
        public static EnumValues Manitoba => EnumValues.Manitoba;

        /// <summary>
        /// New Brunswick
        /// </summary>
        public static EnumValues NewBrunswick => EnumValues.NewBrunswick;

        /// <summary>
        /// Neufundland and Labrador
        /// </summary>
        public static EnumValues NewfoundlandAndLabrador => EnumValues.NewfoundlandAndLabrador;

        /// <summary>
        /// Nova Scotia
        /// </summary>
        public static EnumValues NovaScotia => EnumValues.NovaScotia;

        /// <summary>
        /// Ontario
        /// </summary>
        public static EnumValues Ontario => EnumValues.Ontario;

        /// <summary>
        /// Prince Edward Island
        /// </summary>
        public static EnumValues PrinceEdwardIsland => EnumValues.PrinceEdwardIsland;

        /// <summary>
        /// Québec
        /// </summary>
        public static EnumValues Québec => EnumValues.Québec;

        /// <summary>
        /// Saskatchewan
        /// </summary>
        public static EnumValues Saskatchewan => EnumValues.Saskatchewan;

        /// <summary>
        /// Northwest Territories
        /// </summary>
        public static EnumValues NorthwestTerritories => EnumValues.NorthwestTerritories;

        /// <summary>
        /// Nunavut
        /// </summary>
        public static EnumValues Nunavut => EnumValues.Nunavut;

        /// <summary>
        /// Yukon
        /// </summary>
        public static EnumValues Yukon => EnumValues.Yukon;

        #endregion

        /// <summary>
        /// Enum values for Canada regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Alberta
            /// <br />
            /// 阿尔伯塔省
            /// </summary>
            [AliasInShort("AB")]
            [RegionFlag("provinces")]
            Alberta,

            /// <summary>
            /// British Columbia
            /// <br />
            /// 不列颠哥伦比亚省
            /// </summary>
            [AliasInShort("BC")]
            [RegionFlag("provinces")]
            BritishColumbia,

            /// <summary>
            /// Manitoba
            /// <br />
            /// 曼尼托巴省
            /// </summary>
            [AliasInShort("MB")]
            [RegionFlag("provinces")]
            Manitoba,

            /// <summary>
            /// New Brunswick
            /// <br />
            /// 新不伦瑞克省
            /// </summary>
            [AliasInShort("NB")]
            [RegionFlag("provinces")]
            NewBrunswick,

            /// <summary>
            /// Newfoundland and Labrador
            /// <br />
            /// 纽芬兰与拉布拉多省
            /// </summary>
            [AliasInShort("NL")]
            [RegionFlag("provinces")]
            NewfoundlandAndLabrador,

            /// <summary>
            /// Nova Scotia
            /// <br />
            /// 新斯科舍省
            /// </summary>
            [AliasInShort("NS")]
            [RegionFlag("provinces")]
            NovaScotia,

            /// <summary>
            /// Ontario
            /// <br />
            /// 安大略省
            /// </summary>
            [AliasInShort("ON")]
            [RegionFlag("provinces")]
            Ontario,

            /// <summary>
            /// Prince Edward Island
            /// <br />
            /// 爱德华王子岛省
            /// </summary>
            [AliasInShort("PE")]
            [RegionFlag("provinces")]
            PrinceEdwardIsland,

            /// <summary>
            /// Québec
            /// <br />
            /// 魁北克省
            /// </summary>
            [AliasInShort("QC")]
            [RegionFlag("provinces")]
            Québec,

            /// <summary>
            /// Saskatchewan
            /// <br />
            /// 萨斯喀彻温省
            /// </summary>
            [AliasInShort("SK")]
            [RegionFlag("provinces")]
            Saskatchewan,

            /// <summary>
            /// Northwest Territories
            /// <br />
            /// 西北地区
            /// </summary>
            [AliasInShort("NT")]
            [RegionFlag("territories")]
            NorthwestTerritories,

            /// <summary>
            /// Nunavut
            /// <br />
            /// 努纳武特地区
            /// </summary>
            [AliasInShort("NU")]
            [RegionFlag("territories")]
            Nunavut,

            /// <summary>
            /// Yukon
            /// <br />
            /// 育空地区
            /// </summary>
            [AliasInShort("YT")]
            [RegionFlag("territories")]
            Yukon,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="CanadaRegions.EnumValues"/> to region code likes 'AB', 'YT'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="CanadaRegions.EnumValues"/> to full region code likes 'CA-AB', 'CA-YT'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"CA-{values.ToRegionCode()}";
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
        /// 获得加拿大省代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetProvincesRegionCodes()
        {
            foreach (var member in Filter("provinces"))
                yield return member.Value.ToFullRegionCode();
        }

        /// <summary>
        /// 获得加拿大地区号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetTerritoriesRegionCodes()
        {
            foreach (var member in Filter("territories"))
                yield return member.Value.ToFullRegionCode();
        }

        #endregion

    }
}