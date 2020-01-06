using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// United States regions
    /// </summary>
    public static class UnitedStatesRegions {

        #region Gets regions

        /// <summary>
        /// 亚拉巴马州
        /// </summary>
        public static EnumValues Alabama => EnumValues.Alabama;

        /// <summary>
        /// 阿拉斯加州
        /// </summary>
        public static EnumValues Alaska => EnumValues.Alaska;

        /// <summary>
        /// 阿肯色州
        /// </summary>
        public static EnumValues Arkansas => EnumValues.Arkansas;

        /// <summary>
        /// 加利福尼亚州
        /// </summary>
        public static EnumValues California => EnumValues.California;

        /// <summary>
        /// 科罗拉多州
        /// </summary>
        public static EnumValues Colorado => EnumValues.Colorado;

        /// <summary>
        /// 康涅狄格州
        /// </summary>
        public static EnumValues Connecticut => EnumValues.Connecticut;

        /// <summary>
        /// 特拉华州
        /// </summary>
        public static EnumValues Delaware => EnumValues.Delaware;

        /// <summary>
        /// 佛罗里达州
        /// </summary>
        public static EnumValues Florida => EnumValues.Florida;

        /// <summary>
        /// 乔治亚州
        /// </summary>
        public static EnumValues Georgia => EnumValues.Georgia;

        /// <summary>
        /// 夏威夷州
        /// </summary>
        public static EnumValues Hawaii => EnumValues.Hawaii;

        /// <summary>
        /// 爱德华州
        /// </summary>
        public static EnumValues Idaho => EnumValues.Idaho;

        /// <summary>
        /// 伊利诺伊州
        /// </summary>
        public static EnumValues Illinois => EnumValues.Illinois;

        /// <summary>
        /// 印第安纳州
        /// </summary>
        public static EnumValues Indiana => EnumValues.Indiana;

        /// <summary>
        /// 衣阿华州
        /// </summary>
        public static EnumValues Iowa => EnumValues.Iowa;

        /// <summary>
        /// 堪萨斯州
        /// </summary>
        public static EnumValues Kansas => EnumValues.Kansas;

        /// <summary>
        /// 肯塔基州
        /// </summary>
        public static EnumValues Kentucky => EnumValues.Kentucky;

        /// <summary>
        /// 路易斯安那州
        /// </summary>
        public static EnumValues Louisiana => EnumValues.Louisiana;

        /// <summary>
        /// 缅因州
        /// </summary>
        public static EnumValues Maine => EnumValues.Maine;

        /// <summary>
        /// 马里兰州
        /// </summary>
        public static EnumValues Maryland => EnumValues.Maryland;

        /// <summary>
        /// 马塞诸塞州
        /// </summary>
        public static EnumValues Massachusetts => EnumValues.Massachusetts;

        /// <summary>
        /// 密歇根州
        /// </summary>
        public static EnumValues Michigan => EnumValues.Michigan;

        /// <summary>
        /// 明尼苏达州
        /// </summary>
        public static EnumValues Minnesota => EnumValues.Minnesota;

        /// <summary>
        /// 密西西比州
        /// </summary>
        public static EnumValues Mississippi => EnumValues.Mississippi;

        /// <summary>
        /// 蒙大拿州
        /// </summary>
        public static EnumValues Montana => EnumValues.Montana;

        /// <summary>
        /// 内布拉斯加州
        /// </summary>
        public static EnumValues Nebraska => EnumValues.Nebraska;

        /// <summary>
        /// 内华达州
        /// </summary>
        public static EnumValues Nevada => EnumValues.Nevada;

        /// <summary>
        /// 新罕布什尔州
        /// </summary>
        public static EnumValues NewHampshire => EnumValues.NewHampshire;

        /// <summary>
        /// 新泽西州
        /// </summary>
        public static EnumValues NewJersey => EnumValues.NewJersey;

        /// <summary>
        /// 新墨西哥州
        /// </summary>
        public static EnumValues NewMexico => EnumValues.NewMexico;

        /// <summary>
        /// 纽约州
        /// </summary>
        public static EnumValues NewYork => EnumValues.NewYork;

        /// <summary>
        /// 北卡罗来纳州
        /// </summary>
        public static EnumValues NorthCarolina => EnumValues.NorthCarolina;

        /// <summary>
        /// 北达科他州
        /// </summary>
        public static EnumValues NorthDakota => EnumValues.NorthDakota;

        /// <summary>
        /// 俄亥俄州
        /// </summary>
        public static EnumValues Ohio => EnumValues.Ohio;

        /// <summary>
        /// 俄克拉荷马州
        /// </summary>
        public static EnumValues Oklahoma => EnumValues.Oklahoma;

        /// <summary>
        /// 俄勒冈州
        /// </summary>
        public static EnumValues Oregon => EnumValues.Oregon;

        /// <summary>
        /// 宾夕法尼亚州
        /// </summary>
        public static EnumValues Pennsylvania => EnumValues.Pennsylvania;

        /// <summary>
        /// 罗德岛州
        /// </summary>
        public static EnumValues RhodeIsland => EnumValues.RhodeIsland;

        /// <summary>
        /// 南卡罗来纳州
        /// </summary>
        public static EnumValues SouthCarolina => EnumValues.SouthCarolina;

        /// <summary>
        /// 南达科他州
        /// </summary>
        public static EnumValues SouthDakota => EnumValues.SouthDakota;

        /// <summary>
        /// 田纳西州
        /// </summary>
        public static EnumValues Tennessee => EnumValues.Tennessee;

        /// <summary>
        /// 得克萨斯州
        /// </summary>
        public static EnumValues Texas => EnumValues.Texas;

        /// <summary>
        /// 犹他州
        /// </summary>
        public static EnumValues Utah => EnumValues.Utah;

        /// <summary>
        /// 佛蒙特州
        /// </summary>
        public static EnumValues Vermont => EnumValues.Vermont;

        /// <summary>
        /// 弗吉尼亚州
        /// </summary>
        public static EnumValues Virginia => EnumValues.Virginia;

        /// <summary>
        /// 华盛顿州
        /// </summary>
        public static EnumValues Washington => EnumValues.Washington;

        /// <summary>
        /// 华盛顿哥伦比亚特区（首都）
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public static EnumValues WashingtonDC => EnumValues.WashingtonDC;

        /// <summary>
        /// 西弗吉尼亚州
        /// </summary>\
        public static EnumValues WestVirginia => EnumValues.WestVirginia;

        /// <summary>
        /// 威斯康辛州
        /// </summary>
        public static EnumValues Wisconsin => EnumValues.Wisconsin;

        /// <summary>
        /// 怀俄明州
        /// </summary>
        public static EnumValues Wyoming => EnumValues.Wyoming;

        /// <summary>
        /// The United States Virgin Islands<br />
        /// 美属维尔金群岛
        /// </summary>
        public static EnumValues VirginIslands => EnumValues.VirginIslands;

        /// <summary>
        /// Commonwealth of the Northern Mariana Islands<br />
        /// 北马里亚纳群岛自由邦
        /// </summary>
        public static EnumValues NorthernMarianaIslands => EnumValues.NorthernMarianaIslands;

        /// <summary>
        /// The Commonwealth of Puerto Rico<br />
        /// 波多黎各自治邦
        /// </summary>
        public static EnumValues PuertoRico => EnumValues.PuertoRico;

        /// <summary>
        /// The Territory of Guam<br />
        /// 关岛
        /// </summary>
        public static EnumValues Guam => EnumValues.Guam;

        /// <summary>
        /// American Samoa / Eastern Samoa<br />
        /// 美属萨摩亚群岛
        /// </summary>
        public static EnumValues EasternSamoa => EnumValues.EasternSamoa;

        /// <summary>
        /// United States Minor Outlying Islands<br />
        /// 美国本土外小岛屿
        /// </summary>
        public static EnumValues MinorOutlyingIslands => EnumValues.MinorOutlyingIslands;

        #endregion

        /// <summary>
        /// Special regions
        /// </summary>
        public static class Special {
            /// <summary>
            /// The United States Virgin Islands
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country VirginIslands => Country.VirginIslandsUS;

            /// <summary>
            /// The United States Virgin Islands
            /// </summary>
            public static CountryCode VirginIslandsCode => CountryCode.VI;

            /// <summary>
            /// Commonwealth of the Northern Mariana Islands
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country NorthernMarianaIslands => Country.NorthernMarianaIslands;

            /// <summary>
            /// Commonwealth of the Northern Mariana Islands
            /// </summary>
            public static CountryCode NorthernMarianaIslandsCode => CountryCode.MP;

            /// <summary>
            /// The Commonwealth of Puerto Rico
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country PuertoRico => Country.PuertoRico;

            /// <summary>
            /// The Commonwealth of Puerto Rico
            /// </summary>
            public static CountryCode PuertoRicoCode => CountryCode.PR;

            /// <summary>
            /// The Territory of Guam
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Guam => Country.Guam;

            /// <summary>
            /// The Territory of Guam
            /// </summary>
            public static CountryCode GuamCode => CountryCode.GU;

            /// <summary>
            /// American Samoa / Eastern Samoa
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country EasternSamoa => Country.AmericanSamoa;

            /// <summary>
            /// American Samoa / Eastern Samoa
            /// </summary>
            public static CountryCode EasternSamoaCode => CountryCode.AS;

            /// <summary>
            /// United States Minor Outlying Islands
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country MinorOutlyingIslands => Country.UnitedStatesMinorOutlyingIslands;

            /// <summary>
            /// United States Minor Outlying Islands
            /// </summary>
            public static CountryCode MinorOutlyingIslandsCode => CountryCode.UM;
        }

        /// <summary>
        /// Enum values for United States regions
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// 亚拉巴马州
            /// </summary>
            [AliasInShort("AL")]
            [RegionFlag("main")]
            Alabama,

            /// <summary>
            /// 阿拉斯加州
            /// </summary>
            [AliasInShort("AK")]
            [RegionFlag("main")]
            Alaska,

            /// <summary>
            /// 阿肯色州
            /// </summary>
            [AliasInShort("AR")]
            [RegionFlag("main")]
            Arkansas,

            /// <summary>
            /// 加利福尼亚州
            /// </summary>
            [AliasInShort("CA")]
            [RegionFlag("main")]
            California,

            /// <summary>
            /// 科罗拉多州
            /// </summary>
            [AliasInShort("CO")]
            [RegionFlag("main")]
            Colorado,

            /// <summary>
            /// 康涅狄格州
            /// </summary>
            [AliasInShort("CT")]
            [RegionFlag("main")]
            Connecticut,

            /// <summary>
            /// 特拉华州
            /// </summary>
            [AliasInShort("DE")]
            [RegionFlag("main")]
            Delaware,

            /// <summary>
            /// 佛罗里达州
            /// </summary>
            [AliasInShort("FL")]
            [RegionFlag("main")]
            Florida,

            /// <summary>
            /// 乔治亚州
            /// </summary>
            [AliasInShort("GA")]
            [RegionFlag("main")]
            Georgia,

            /// <summary>
            /// 夏威夷州
            /// </summary>
            [AliasInShort("HI")]
            [RegionFlag("main")]
            Hawaii,

            /// <summary>
            /// 爱德华州
            /// </summary>
            [AliasInShort("ID")]
            [RegionFlag("main")]
            Idaho,

            /// <summary>
            /// 伊利诺伊州
            /// </summary>
            [AliasInShort("IL")]
            [RegionFlag("main")]
            Illinois,

            /// <summary>
            /// 印第安纳州
            /// </summary>
            [AliasInShort("IN")]
            [RegionFlag("main")]
            Indiana,

            /// <summary>
            /// 衣阿华州
            /// </summary>
            [AliasInShort("IA")]
            [RegionFlag("main")]
            Iowa,

            /// <summary>
            /// 堪萨斯州
            /// </summary>
            [AliasInShort("KS")]
            [RegionFlag("main")]
            Kansas,

            /// <summary>
            /// 肯塔基州
            /// </summary>
            [AliasInShort("KY")]
            [RegionFlag("main")]
            Kentucky,

            /// <summary>
            /// 路易斯安那州
            /// </summary>
            [AliasInShort("LA")]
            [RegionFlag("main")]
            Louisiana,

            /// <summary>
            /// 缅因州
            /// </summary>
            [AliasInShort("ME")]
            [RegionFlag("main")]
            Maine,

            /// <summary>
            /// 马里兰州
            /// </summary>
            [AliasInShort("MD")]
            [RegionFlag("main")]
            Maryland,

            /// <summary>
            /// 马塞诸塞州
            /// </summary>
            [AliasInShort("MA")]
            [RegionFlag("main")]
            Massachusetts,

            /// <summary>
            /// 密歇根州
            /// </summary>
            [AliasInShort("MI")]
            [RegionFlag("main")]
            Michigan,

            /// <summary>
            /// 明尼苏达州
            /// </summary>
            [AliasInShort("MN")]
            [RegionFlag("main")]
            Minnesota,

            /// <summary>
            /// 密西西比州
            /// </summary>
            [AliasInShort("MO")]
            [RegionFlag("main")]
            Mississippi,

            /// <summary>
            /// 蒙大拿州
            /// </summary>
            [AliasInShort("MT")]
            [RegionFlag("main")]
            Montana,

            /// <summary>
            /// 内布拉斯加州
            /// </summary>
            [AliasInShort("NE")]
            [RegionFlag("main")]
            Nebraska,

            /// <summary>
            /// 内华达州
            /// </summary>
            [AliasInShort("NV")]
            [RegionFlag("main")]
            Nevada,

            /// <summary>
            /// 新罕布什尔州
            /// </summary>
            [AliasInShort("NH")]
            [RegionFlag("main")]
            NewHampshire,

            /// <summary>
            /// 新泽西州
            /// </summary>
            [AliasInShort("NJ")]
            [RegionFlag("main")]
            NewJersey,

            /// <summary>
            /// 新墨西哥州
            /// </summary>
            [AliasInShort("NM")]
            [RegionFlag("main")]
            NewMexico,

            /// <summary>
            /// 纽约州
            /// </summary>
            [AliasInShort("NY")]
            [RegionFlag("main")]
            NewYork,

            /// <summary>
            /// 北卡罗来纳州
            /// </summary>
            [AliasInShort("NC")]
            [RegionFlag("main")]
            NorthCarolina,

            /// <summary>
            /// 北达科他州
            /// </summary>
            [AliasInShort("ND")]
            [RegionFlag("main")]
            NorthDakota,

            /// <summary>
            /// 俄亥俄州
            /// </summary>
            [AliasInShort("OH")]
            [RegionFlag("main")]
            Ohio,

            /// <summary>
            /// 俄克拉荷马州
            /// </summary>
            [AliasInShort("OK")]
            [RegionFlag("main")]
            Oklahoma,

            /// <summary>
            /// 俄勒冈州
            /// </summary>
            [AliasInShort("OR")]
            [RegionFlag("main")]
            Oregon,

            /// <summary>
            /// 宾夕法尼亚州
            /// </summary>
            [AliasInShort("PA")]
            [RegionFlag("main")]
            Pennsylvania,

            /// <summary>
            /// 罗德岛州
            /// </summary>
            [AliasInShort("RI")]
            [RegionFlag("main")]
            RhodeIsland,

            /// <summary>
            /// 南卡罗来纳州
            /// </summary>
            [AliasInShort("SC")]
            [RegionFlag("main")]
            SouthCarolina,

            /// <summary>
            /// 南达科他州
            /// </summary>
            [AliasInShort("SD")]
            [RegionFlag("main")]
            SouthDakota,

            /// <summary>
            /// 田纳西州
            /// </summary>
            [AliasInShort("TN")]
            [RegionFlag("main")]
            Tennessee,

            /// <summary>
            /// 得克萨斯州
            /// </summary>
            [AliasInShort("TX")]
            [RegionFlag("main")]
            Texas,

            /// <summary>
            /// 犹他州
            /// </summary>
            [AliasInShort("UT")]
            [RegionFlag("main")]
            Utah,

            /// <summary>
            /// 佛蒙特州
            /// </summary>
            [AliasInShort("VT")]
            [RegionFlag("main")]
            Vermont,

            /// <summary>
            /// 弗吉尼亚州
            /// </summary>
            [AliasInShort("VA")]
            [RegionFlag("main")]
            Virginia,

            /// <summary>
            /// 华盛顿州
            /// </summary>
            [AliasInShort("WA")]
            [RegionFlag("main")]
            Washington,

            /// <summary>
            /// 华盛顿哥伦比亚特区（首都）
            /// </summary>
            [AliasInShort("WDC")]
            [RegionFlag("main")]
            // ReSharper disable once InconsistentNaming
            WashingtonDC,

            /// <summary>
            /// 西弗吉尼亚州
            /// </summary>
            [AliasInShort("WV")]
            [RegionFlag("main")]
            WestVirginia,

            /// <summary>
            /// 威斯康辛州
            /// </summary>
            [AliasInShort("WI")]
            [RegionFlag("main")]
            Wisconsin,

            /// <summary>
            /// 怀俄明州
            /// </summary>
            [AliasInShort("WY")]
            [RegionFlag("main")]
            Wyoming,

            /// <summary>
            /// The United States Virgin Islands<br />
            /// 美属维尔金群岛
            /// </summary>
            [AliasInShort("VI")]
            [RegionFlag("overseas")]
            VirginIslands,

            /// <summary>
            /// Commonwealth of the Northern Mariana Islands<br />
            /// 北马里亚纳群岛自由邦
            /// </summary>
            [AliasInShort("MP")]
            [RegionFlag("overseas")]
            NorthernMarianaIslands,

            /// <summary>
            /// The Commonwealth of Puerto Rico<br />
            /// 波多黎各自治邦
            /// </summary>
            [AliasInShort("PR")]
            [RegionFlag("overseas")]
            PuertoRico,

            /// <summary>
            /// The Territory of Guam<br />
            /// 关岛
            /// </summary>
            [AliasInShort("GU")]
            [RegionFlag("overseas")]
            Guam,

            /// <summary>
            /// American Samoa / Eastern Samoa<br />
            /// 美属萨摩亚群岛
            /// </summary>
            [AliasInShort("AS")]
            [RegionFlag("overseas")]
            EasternSamoa,

            /// <summary>
            /// United States Minor Outlying Islands<br />
            /// 美国本土外小岛屿
            /// </summary>
            [AliasInShort("UM")]
            [RegionFlag("overseas")]
            MinorOutlyingIslands,

            /// <summary>
            /// 未知
            /// </summary>
            [IgnoreRegionAttribute]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="UnitedStatesRegions.EnumValues"/> to region code likes 'NY', 'GU', 'WDC'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="UnitedStatesRegions.EnumValues"/> to full region code likes 'US-NY', 'US-GU', 'US-WDC'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"US-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            switch (value) {
                case EnumValues.VirginIslands:
                    return Country.VirginIslandsUS;
                case EnumValues.NorthernMarianaIslands:
                    return Country.NorthernMarianaIslands;
                case EnumValues.PuertoRico:
                    return Country.PuertoRico;
                case EnumValues.Guam:
                    return Country.Guam;
                case EnumValues.EasternSamoa:
                    return Country.AmericanSamoa;
                case EnumValues.MinorOutlyingIslands:
                    return Country.UnitedStatesMinorOutlyingIslands;
                default:
                    return Country.UnitedStates;
            }
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            switch (value) {
                case EnumValues.VirginIslands:
                    return CountryCode.VI;
                case EnumValues.NorthernMarianaIslands:
                    return CountryCode.MP;
                case EnumValues.PuertoRico:
                    return CountryCode.PR;
                case EnumValues.Guam:
                    return CountryCode.GU;
                case EnumValues.EasternSamoa:
                    return CountryCode.AS;
                case EnumValues.MinorOutlyingIslands:
                    return CountryCode.UM;
                default:
                    return CountryCode.US;
            }
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Convert from special regions of United States
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(Country country) {
            switch (country) {
                case Country.VirginIslandsUS:
                    return EnumValues.VirginIslands;
                case Country.NorthernMarianaIslands:
                    return EnumValues.NorthernMarianaIslands;
                case Country.PuertoRico:
                    return EnumValues.PuertoRico;
                case Country.Guam:
                    return EnumValues.Guam;
                case Country.AmericanSamoa:
                    return EnumValues.EasternSamoa;
                case Country.UnitedStatesMinorOutlyingIslands:
                    return EnumValues.MinorOutlyingIslands;
                default:
                    return EnumValues.Unknown;
            }
        }

        /// <summary>
        /// Convert from special regions of United States
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(CountryCode code) {
            switch (code) {
                case CountryCode.VI:
                    return EnumValues.VirginIslands;
                case CountryCode.MP:
                    return EnumValues.NorthernMarianaIslands;
                case CountryCode.PR:
                    return EnumValues.PuertoRico;
                case CountryCode.GU:
                    return EnumValues.Guam;
                case CountryCode.AS:
                    return EnumValues.EasternSamoa;
                case CountryCode.UM:
                    return EnumValues.MinorOutlyingIslands;
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
        /// Get overseas region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetOverseasRegionCodes() {
            foreach (var member in Filter("overseas"))
                yield return member.Value.ToFullRegionCode();
        }

        /// <summary>
        /// Get main region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetMainRegionCodes() {
            foreach (var member in Filter("main"))
                yield return member.Value.ToFullRegionCode();
        }

        #endregion

    }
}