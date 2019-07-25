using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// China regions
    /// </summary>
    public static class ChinaRegions
    {

        #region Gets regions

        /// <summary>
        /// 北京
        /// </summary>
        public static EnumValues Beijing => EnumValues.Beijing;

        /// <summary>
        /// 天津
        /// </summary>
        public static EnumValues Tianjin => EnumValues.Tianjin;

        /// <summary>
        /// 河北
        /// </summary>
        public static EnumValues Hebei => EnumValues.Hebei;

        /// <summary>
        /// 山西
        /// </summary>
        public static EnumValues Shanxi => EnumValues.Shanxi;

        /// <summary>
        /// 内蒙古
        /// </summary>
        public static EnumValues InnerMongoria => EnumValues.InnerMongoria;

        /// <summary>
        /// 内蒙古
        /// </summary>
        public static EnumValues Neimenggu => InnerMongoria;

        /// <summary>
        /// 辽宁
        /// </summary>
        public static EnumValues Liaoning => EnumValues.Liaoning;

        /// <summary>
        /// 吉林
        /// </summary>
        public static EnumValues Jilin => EnumValues.Jilin;

        /// <summary>
        /// 黑龙江
        /// </summary>
        public static EnumValues Heilongjiang => EnumValues.Heilongjiang;

        /// <summary>
        /// 上海
        /// </summary>
        public static EnumValues Shanghai => EnumValues.Shanghai;

        /// <summary>
        /// 江苏
        /// </summary>
        public static EnumValues Jiangsu => EnumValues.Jiangsu;

        /// <summary>
        /// 浙江
        /// </summary>
        public static EnumValues Zhejiang => EnumValues.Zhejiang;

        /// <summary>
        /// 安徽
        /// </summary>
        public static EnumValues Anhui => EnumValues.Anhui;

        /// <summary>
        /// 福建
        /// </summary>
        public static EnumValues Fjian => EnumValues.Fujian;

        /// <summary>
        /// 江西
        /// </summary>
        public static EnumValues Jianxi => EnumValues.Jiangxi;

        /// <summary>
        /// 河南
        /// </summary>
        public static EnumValues Henan => EnumValues.Henan;

        /// <summary>
        /// 山东
        /// </summary>
        public static EnumValues Shandong => EnumValues.Shandong;

        /// <summary>
        /// 湖北
        /// </summary>
        public static EnumValues Hubei => EnumValues.Hubei;

        /// <summary>
        /// 湖南
        /// </summary>
        public static EnumValues Hunan => EnumValues.Hunan;

        /// <summary>
        /// 广东
        /// </summary>
        public static EnumValues Guangdong => EnumValues.Guangdong;

        /// <summary>
        /// 广西
        /// </summary>
        public static EnumValues Guangxi => EnumValues.Guangxi;

        /// <summary>
        /// 海南
        /// </summary>
        public static EnumValues Hainan => EnumValues.Hainan;

        /// <summary>
        /// 重庆
        /// </summary>
        public static EnumValues Chongqing => EnumValues.Chongqing;

        /// <summary>
        /// 四川
        /// </summary>
        public static EnumValues Sichuan => EnumValues.Sichuan;

        /// <summary>
        /// 贵州
        /// </summary>
        public static EnumValues Guizhou => EnumValues.Guizhou;

        /// <summary>
        /// 云南
        /// </summary>
        public static EnumValues Yunnan => EnumValues.Yunnan;

        /// <summary>
        /// 西藏
        /// </summary>
        public static EnumValues Tibet => EnumValues.Tibet;

        /// <summary>
        /// 西藏
        /// </summary>
        public static EnumValues Xizang => Tibet;

        /// <summary>
        /// 陕西
        /// </summary>
        public static EnumValues Shaanxi => EnumValues.Shaanxi;

        /// <summary>
        /// 甘肃
        /// </summary>
        public static EnumValues Gansu => EnumValues.Gansu;

        /// <summary>
        /// 青海
        /// </summary>
        public static EnumValues Qinghai => EnumValues.Qinghai;

        /// <summary>
        /// 宁夏
        /// </summary>
        public static EnumValues Ningxia => EnumValues.Ningxia;

        /// <summary>
        /// Taiwan, a part of China.
        /// </summary>
        public static EnumValues Taiwan => EnumValues.Taiwan;


        /// <summary>
        /// HongKong, a part of China.
        /// </summary>
        public static EnumValues HongKong => EnumValues.HongKong;

        /// <summary>
        /// 香港
        /// </summary>
        public static EnumValues Xianggang => HongKong;

        /// <summary>
        /// Macao, a part of China.
        /// </summary>
        public static EnumValues Macao => EnumValues.Macao;

        /// <summary>
        /// 澳门
        /// </summary>
        public static EnumValues Aomen => Macao;

        #endregion

        /// <summary>
        /// Special regions
        /// </summary>
        public static class Special
        {
            /// <summary>
            /// HongKong, a part of China.
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country HongKong => Country.HongKong;

            /// <summary>
            /// Code of HongKong, a part of China.
            /// </summary>
            public static CountryCode HongKongCode => CountryCode.HK;

            /// <summary>
            /// Macao, a part of China.
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Macao => Country.Macao;

            /// <summary>
            /// Code of Macao, a part of China.
            /// </summary>
            public static CountryCode MacaoCode => CountryCode.MO;

            /// <summary>
            /// Taiwan, a part of China.
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Taiwan => Country.Taiwan;

            /// <summary>
            /// Code of Taiwan, a part of China.
            /// </summary>
            public static CountryCode TaiwanCode => CountryCode.TW;
        }

        /// <summary>
        /// Enum values for China regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// 北京
            /// </summary>
            [AliasInShort("BJ")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Beijing = 1,

            /// <summary>
            /// 天津
            /// </summary>
            [AliasInShort("TJ")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Tianjin = 2,

            /// <summary>
            /// 河北
            /// </summary>
            [AliasInShort("HE")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Hebei = 3,

            /// <summary>
            /// 山西
            /// </summary>
            [AliasInShort("SX")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Shanxi = 4,

            /// <summary>
            /// 内蒙古自治区
            /// </summary>
            [AliasInShort("NM")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            InnerMongoria = 5,

            /// <summary>
            /// 辽宁
            /// </summary>
            [AliasInShort("LN")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Liaoning = 6,

            /// <summary>
            /// 吉林
            /// </summary>
            [AliasInShort("JL")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Jilin = 7,

            /// <summary>
            /// 黑龙江
            /// </summary>
            [AliasInShort("HL")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Heilongjiang = 8,

            /// <summary>
            /// 上海
            /// </summary>
            [AliasInShort("SH")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Shanghai = 9,

            /// <summary>
            /// 江苏
            /// </summary>
            [AliasInShort("JS")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Jiangsu = 10,

            /// <summary>
            /// 浙江
            /// </summary>
            [AliasInShort("ZJ")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Zhejiang = 11,

            /// <summary>
            /// 安徽
            /// </summary>
            [AliasInShort("AH")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Anhui = 12,

            /// <summary>
            /// 福建
            /// </summary>
            [AliasInShort("FJ")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Fujian = 13,

            /// <summary>
            /// 江西
            /// </summary>
            [AliasInShort("JX")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Jiangxi = 14,

            /// <summary>
            /// 河南
            /// </summary>
            [AliasInShort("HA")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Henan = 16,

            /// <summary>
            /// 山东
            /// </summary>
            [AliasInShort("SD")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Shandong = 15,

            /// <summary>
            /// 湖北
            /// </summary>
            [AliasInShort("HB")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Hubei = 17,

            /// <summary>
            /// 湖南
            /// </summary>
            [AliasInShort("HN")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Hunan = 18,

            /// <summary>
            /// 广东
            /// </summary>
            [AliasInShort("GD")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Guangdong = 19,

            /// <summary>
            /// 广西
            /// </summary>
            [AliasInShort("GX")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Guangxi = 20,

            /// <summary>
            /// 海南
            /// </summary>
            [AliasInShort("HI")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Hainan = 21,

            /// <summary>
            /// 重庆
            /// </summary>
            [AliasInShort("CQ")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Chongqing = 22,

            /// <summary>
            /// 四川
            /// </summary>
            [AliasInShort("SC")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Sichuan = 23,

            /// <summary>
            /// 贵州
            /// </summary>
            [AliasInShort("GZ")]
            [RegionFlag("mainland")]
            Guizhou = 24,

            /// <summary>
            /// 云南
            /// </summary>
            [AliasInShort("YN")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Yunnan = 25,

            /// <summary>
            /// 西藏
            /// </summary>
            [AliasInShort("XZ")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Tibet = 26,

            /// <summary>
            /// 陕西
            /// </summary>
            [AliasInShort("SN")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Shaanxi = 27,


            /// <summary>
            /// 甘肃
            /// </summary>
            [AliasInShort("GS")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Gansu = 28,

            /// <summary>
            /// 青海
            /// </summary>
            [AliasInShort("QH")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Qinghai = 29,

            /// <summary>
            /// 宁夏
            /// </summary>
            [AliasInShort("NX")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Ningxia = 30,

            /// <summary>
            /// 新疆
            /// </summary>
            [AliasInShort("XJ")]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Xinjiang = 31,

            /// <summary>
            /// Taiwan, China<br />
            /// 中华人民共和国台湾省
            /// </summary>
            [AliasInShort("TW")]
            Taiwan = 32,

            /// <summary>
            /// HongKong, China<br />
            /// 中华人民共和国香港特别行政区
            /// </summary>
            [AliasInShort("HK")]
            [RegionFlag("mainland")]
            [RegionFlag(" special_district")]
            HongKong = 33,

            /// <summary>
            /// Macao, China<br />
            /// 中华人民共和国澳门特别行政区
            /// </summary>
            [AliasInShort("MO")]
            [RegionFlag("mainland")]
            [RegionFlag(" special_district")]
            Macao = 34,

            /// <summary>
            /// Unknown<br />未知
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown = 99,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="ChinaRegions.EnumValues"/> to region code likes 'TW', 'SH'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="ChinaRegions.EnumValues"/> to full region code likes 'CN-TW', 'CN-SH'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"CN-{values.ToRegionCode()}";
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
                case EnumValues.HongKong:
                    return Country.HongKong;
                case EnumValues.Macao:
                    return Country.Macao;
                case EnumValues.Taiwan:
                    return Country.Taiwan;
                default:
                    return Country.China;
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
                case EnumValues.HongKong:
                    return CountryCode.HK;
                case EnumValues.Macao:
                    return CountryCode.MO;
                case EnumValues.Taiwan:
                    return CountryCode.TW;
                default:
                    return CountryCode.CN;
            }
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Convert from special regions of China
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(Country country)
        {
            switch (country)
            {
                case Country.HongKong:
                    return EnumValues.HongKong;
                case Country.Macao:
                    return EnumValues.Macao;
                case Country.Taiwan:
                    return EnumValues.Taiwan;
                default:
                    return EnumValues.Unknown;
            }
        }

        /// <summary>
        /// Convert from special regions of China
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(CountryCode code)
        {
            switch (code)
            {
                case CountryCode.HK:
                    return EnumValues.HongKong;
                case CountryCode.MO:
                    return EnumValues.Macao;
                case CountryCode.TW:
                    return EnumValues.Taiwan;
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
        /// 获得大陆地区的地区代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetMainlandRegionCodes()
        {
            foreach (var member in Filter("mainland"))
                yield return member.Value.ToFullRegionCode();
        }

        /// <summary>
        /// 获得特别行政区地区代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetSpecialDistrictRegionCodes()
        {
            foreach (var member in Filter("special_district"))
                yield return member.Value.ToFullRegionCode();
        }

        /// <summary>
        /// 获得内陆地区的地区代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetEndolandRegionCodes()
        {
            foreach (var member in Filter("endoland"))
                yield return member.Value.ToFullRegionCode();
        }

        #endregion

    }
}