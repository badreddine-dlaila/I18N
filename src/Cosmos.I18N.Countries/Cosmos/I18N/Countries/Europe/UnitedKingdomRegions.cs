using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// United Kingdom Regions
    /// </summary>
    public static class UnitedKingdomRegions {

        #region Gets regions

        /// <summary>
        /// 英格兰
        /// </summary>
        public static EnumValues England => EnumValues.England;

        /// <summary>
        /// 北爱尔兰
        /// </summary>
        public static EnumValues NorthernIreland => EnumValues.NorthernIreland;

        /// <summary>
        /// 苏格兰
        /// </summary>
        public static EnumValues Scottland => EnumValues.Scottland;

        /// <summary>
        /// 威尔士
        /// </summary>
        public static EnumValues Wales => EnumValues.Wales;

        /// <summary>
        /// 奥尔德尼岛
        /// </summary>
        public static EnumValues Alderney => EnumValues.Alderney;

        /// <summary>
        /// Bailiwick of Guernsey
        /// <br />
        /// 根西岛
        /// </summary>
        public static EnumValues Guernsey => EnumValues.Guernsey;

        /// <summary>
        /// Bailiwick of Jersey
        /// <br />
        /// 泽西
        /// </summary>
        public static EnumValues Jersey => EnumValues.Jersey;

        /// <summary>
        /// Isle of Man
        /// <br />
        /// 英属马恩岛
        /// </summary>
        public static EnumValues Mann => EnumValues.Mann;

        /// <summary>
        /// Gibraltar
        /// <br />
        /// 直布罗陀
        /// </summary>
        public static EnumValues Gibraltar => EnumValues.Gibraltar;

        /// <summary>
        /// The Bermuda Islands
        /// <br />
        /// 百慕大群岛
        /// </summary>
        public static EnumValues Bermuda => EnumValues.Bermuda;

        /// <summary>
        /// Cayman Islands
        /// <br />
        /// 开曼群岛
        /// </summary>
        public static EnumValues CaymanIslands => EnumValues.CaymanIslands;

        /// <summary>
        /// The Turks and Caicos Islands
        /// <br />
        /// 特克斯和凯科斯群岛
        /// </summary>
        public static EnumValues TurksAndCaicosIslands => EnumValues.TurksAndCaicosIslands;

        /// <summary>
        /// The British Virgin Islands
        /// <br />
        /// 英属维尔金群岛
        /// </summary>
        public static EnumValues BritishVirginIslands => EnumValues.BritishVirginIslands;

        /// <summary>
        /// Anguilla
        /// <br />
        /// 安圭拉
        /// </summary>
        public static EnumValues Anguilla => EnumValues.Anguilla;

        /// <summary>
        /// Montserrat
        /// <br />
        /// 蒙特塞拉特
        /// </summary>
        public static EnumValues Montserrat => EnumValues.Montserrat;

        /// <summary>
        /// Saint Helena, Ascension and Tristan da Cunha
        /// <br />
        /// 圣赫勒拿、阿森松与特里斯坦达库尼亚
        /// </summary>
        public static EnumValues SaintHelena => EnumValues.SaintHelena;

        /// <summary>
        /// South Georgia and The South Sandwich Islands
        /// <br />
        /// 南乔治亚岛和南桑威奇群岛
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public static EnumValues SGSSI => EnumValues.SGSSI;

        /// <summary>
        /// British Indian Ocean Territory
        /// <br />
        /// 英属印度洋领地
        /// </summary>
        public static EnumValues BritishIndianOceanTerritory => EnumValues.BritishIndianOceanTerritory;

        /// <summary>
        /// Pitcairn Islands
        /// <br />
        /// 皮特凯恩群岛
        /// </summary>
        public static EnumValues Pitcairn => EnumValues.Pitcairn;

        #endregion

        /// <summary>
        /// Special regions
        /// </summary>
        public static class Special {
            /// <summary>
            /// Bailiwick of Guernsey
            /// <br />
            /// 根西岛
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Guernsey => Country.Guernsey;

            /// <summary>
            /// Bailiwick of Guernsey
            /// <br />
            /// 根西岛
            /// </summary>
            public static CountryCode GuernseyCode => CountryCode.GG;

            /// <summary>
            /// Bailiwick of Jersey
            /// <br />
            /// 泽西
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Jersey => Country.Jersey;

            /// <summary>
            /// Bailiwick of Jersey
            /// <br />
            /// 泽西
            /// </summary>
            public static CountryCode JerseyCode => CountryCode.JE;

            /// <summary>
            /// Isle of Man
            /// <br />
            /// 英属马恩岛
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Mann = Country.Mann;

            /// <summary>
            /// Isle of Man
            /// <br />
            /// 英属马恩岛
            /// </summary>
            public static CountryCode MannCode => CountryCode.IM;

            /// <summary>
            /// Gibraltar
            /// <br />
            /// 直布罗陀
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Gibraltar => Country.Gibraltar;

            /// <summary>
            /// Gibraltar
            /// <br />
            /// 直布罗陀
            /// </summary>
            public static CountryCode GibraltarCode => CountryCode.GI;

            /// <summary>
            /// The Bermuda Islands
            /// <br />
            /// 百慕大群岛
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Bermuda => Country.Bermuda;

            /// <summary>
            /// The Bermuda Islands
            /// <br />
            /// 百慕大群岛
            /// </summary>
            public static CountryCode BermudaCode => CountryCode.BM;

            /// <summary>
            /// Cayman Islands
            /// <br />
            /// 开曼群岛
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country CaymanIslands => Country.CaymanIslands;

            /// <summary>
            /// Cayman Islands
            /// <br />
            /// 开曼群岛
            /// </summary>
            public static CountryCode CaymanIslandsCode => CountryCode.KY;

            /// <summary>
            /// The Turks and Caicos Islands
            /// <br />
            /// 特克斯和凯科斯群岛
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country TurksAndCaicosIslands => Country.TurksAndCaicosIslands;

            /// <summary>
            /// The Turks and Caicos Islands
            /// <br />
            /// 特克斯和凯科斯群岛
            /// </summary>
            public static CountryCode TurksAndCaicosIslandsCode => CountryCode.TC;

            /// <summary>
            /// The British Virgin Islands
            /// <br />
            /// 英属维尔金群岛
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country BritishVirginIslands => Country.VirginIslandsBritish;

            /// <summary>
            /// The British Virgin Islands
            /// <br />
            /// 英属维尔金群岛
            /// </summary>
            public static CountryCode BritishVirginIslandsCode => CountryCode.VG;

            /// <summary>
            /// Anguilla
            /// <br />
            /// 安圭拉
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Anguilla => Country.Anguilla;

            /// <summary>
            /// Anguilla
            /// <br />
            /// 安圭拉
            /// </summary>
            public static CountryCode AnguillaCode => CountryCode.AI;

            /// <summary>
            /// Montserrat
            /// <br />
            /// 蒙特塞拉特
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Montserrat => Country.Montserrat;

            /// <summary>
            /// Montserrat
            /// <br />
            /// 蒙特塞拉特
            /// </summary>
            public static CountryCode MontserratCode => CountryCode.MS;

            /// <summary>
            /// Saint Helena, Ascension and Tristan da Cunha
            /// <br />
            /// 圣赫勒拿、阿森松与特里斯坦达库尼亚
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country SaintHelena => Country.SaintHelena;

            /// <summary>
            /// Saint Helena, Ascension and Tristan da Cunha
            /// <br />
            /// 圣赫勒拿、阿森松与特里斯坦达库尼亚
            /// </summary>
            public static CountryCode SaintHelenaCode => CountryCode.SH;

            /// <summary>
            /// South Georgia and The South Sandwich Islands
            /// <br />
            /// 南乔治亚岛和南桑威奇群岛
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            // ReSharper disable once InconsistentNaming
            public static Country SGSSI => Country.SGSSI;

            /// <summary>
            /// South Georgia and The South Sandwich Islands
            /// <br />
            /// 南乔治亚岛和南桑威奇群岛
            /// </summary>
            // ReSharper disable once InconsistentNaming
            public static CountryCode SGSSICode => CountryCode.GS;

            /// <summary>
            /// British Indian Ocean Territory
            /// <br />
            /// 英属印度洋领地
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country BritishIndianOceanTerritory => Country.BritishIndianOceanTerritory;

            /// <summary>
            /// British Indian Ocean Territory
            /// <br />
            /// 英属印度洋领地
            /// </summary>
            public static CountryCode BritishIndianOceanTerritoryCode => CountryCode.IO;

            /// <summary>
            /// Pitcairn Islands
            /// <br />
            /// 皮特凯恩群岛
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Pitcairn => Country.Pitcairn;

            /// <summary>
            /// Pitcairn Islands
            /// <br />
            /// 皮特凯恩群岛
            /// </summary>
            public static CountryCode PitcairnCode => CountryCode.PN;
        }

        /// <summary>
        /// Enum values for United Kingdom regions
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// 英格兰
            /// </summary>
            [AliasInShort("ENG")]
            [RegionFlag("main")]
            England,

            /// <summary>
            /// 北爱尔兰
            /// </summary>
            [AliasInShort("NIR")]
            [RegionFlag("main")]
            NorthernIreland,

            /// <summary>
            /// 苏格兰
            /// </summary>
            [AliasInShort("SCT")]
            [RegionFlag("main")]
            Scottland,

            /// <summary>
            /// 威尔士
            /// </summary>
            [AliasInShort("WLS")]
            [RegionFlag("main")]
            Wales,

            /// <summary>
            /// 奥尔德尼岛
            /// </summary>
            [AliasInShort("ALD")]
            [RegionFlag("overseas")]
            Alderney,

            /// <summary>
            /// Bailiwick of Guernsey
            /// <br />
            /// 根西岛
            /// </summary>
            [AliasInShort("GG")]
            [RegionFlag("overseas")]
            Guernsey,

            /// <summary>
            /// Bailiwick of Jersey
            /// <br />
            /// 泽西
            /// </summary>
            [AliasInShort("JE")]
            [RegionFlag("overseas")]
            Jersey,

            /// <summary>
            /// Isle of Man
            /// <br />
            /// 英属马恩岛
            /// </summary>
            [AliasInShort("IM")]
            [RegionFlag("overseas")]
            Mann,

            /// <summary>
            /// Gibraltar
            /// <br />
            /// 直布罗陀
            /// </summary>
            [AliasInShort("GI")]
            [RegionFlag("overseas")]
            Gibraltar,

            /// <summary>
            /// The Bermuda Islands
            /// <br />
            /// 百慕大群岛
            /// </summary>
            [AliasInShort("BM")]
            [RegionFlag("overseas")]
            Bermuda,

            /// <summary>
            /// Cayman Islands
            /// <br />
            /// 开曼群岛
            /// </summary>
            [AliasInShort("KY")]
            [RegionFlag("overseas")]
            CaymanIslands,

            /// <summary>
            /// The Turks and Caicos Islands
            /// <br />
            /// 特克斯和凯科斯群岛
            /// </summary>
            [AliasInShort("TC")]
            [RegionFlag("overseas")]
            TurksAndCaicosIslands,

            /// <summary>
            /// The British Virgin Islands
            /// <br />
            /// 英属维尔金群岛
            /// </summary>
            [AliasInShort("VG")]
            [RegionFlag("overseas")]
            BritishVirginIslands,

            /// <summary>
            /// Anguilla
            /// <br />
            /// 安圭拉
            /// </summary>
            [AliasInShort("AI")]
            [RegionFlag("overseas")]
            Anguilla,

            /// <summary>
            /// Montserrat
            /// <br />
            /// 蒙特塞拉特
            /// </summary>
            [AliasInShort("MS")]
            [RegionFlag("overseas")]
            Montserrat,

            /// <summary>
            /// Saint Helena, Ascension and Tristan da Cunha
            /// <br />
            /// 圣赫勒拿、阿森松与特里斯坦达库尼亚
            /// </summary>
            [AliasInShort("SH")]
            [RegionFlag("overseas")]
            SaintHelena,

            /// <summary>
            /// South Georgia and The South Sandwich Islands
            /// <br />
            /// 南乔治亚岛和南桑威奇群岛
            /// </summary>
            [AliasInShort("GS")]
            [RegionFlag("overseas")]
            // ReSharper disable once InconsistentNaming
            SGSSI,

            /// <summary>
            /// British Indian Ocean Territory
            /// <br />
            /// 英属印度洋领地
            /// </summary>
            [AliasInShort("IO")]
            [RegionFlag("overseas")]
            BritishIndianOceanTerritory,

            /// <summary>
            /// Pitcairn Islands
            /// <br />
            /// 皮特凯恩群岛
            /// </summary>
            [AliasInShort("PN")]
            [RegionFlag("overseas")]
            Pitcairn,

            /// <summary>
            /// 未知
            /// </summary>
            [IgnoreRegionAttribute]
            [AliasInShort("??")]
            Unknown
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="UnitedKingdomRegions.EnumValues"/> to region code likes 'ENG', 'ALD', 'GI'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="UnitedKingdomRegions.EnumValues"/> to full region code likes 'GB-ENG', 'GB-ALD', 'GB-GI'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"GB-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            switch (value) {
                case EnumValues.Guernsey:
                    return Country.Guernsey;
                case EnumValues.Jersey:
                    return Country.Jersey;
                case EnumValues.Mann:
                    return Country.Mann;
                case EnumValues.Gibraltar:
                    return Country.Gibraltar;
                case EnumValues.Bermuda:
                    return Country.Bermuda;
                case EnumValues.CaymanIslands:
                    return Country.CaymanIslands;
                case EnumValues.TurksAndCaicosIslands:
                    return Country.TurksAndCaicosIslands;
                case EnumValues.BritishVirginIslands:
                    return Country.VirginIslandsBritish;
                case EnumValues.Anguilla:
                    return Country.Anguilla;
                case EnumValues.Montserrat:
                    return Country.Montserrat;
                case EnumValues.SaintHelena:
                    return Country.SaintHelena;
                case EnumValues.SGSSI:
                    return Country.SGSSI;
                case EnumValues.BritishIndianOceanTerritory:
                    return Country.BritishIndianOceanTerritory;
                case EnumValues.Pitcairn:
                    return Country.Pitcairn;
                default:
                    return Country.UnitedKingdom;
            }
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            switch (value) {
                case EnumValues.Guernsey:
                    return CountryCode.GG;
                case EnumValues.Jersey:
                    return CountryCode.JE;
                case EnumValues.Mann:
                    return CountryCode.IM;
                case EnumValues.Gibraltar:
                    return CountryCode.GI;
                case EnumValues.Bermuda:
                    return CountryCode.BM;
                case EnumValues.CaymanIslands:
                    return CountryCode.KY;
                case EnumValues.TurksAndCaicosIslands:
                    return CountryCode.TC;
                case EnumValues.BritishVirginIslands:
                    return CountryCode.VG;
                case EnumValues.Anguilla:
                    return CountryCode.AI;
                case EnumValues.Montserrat:
                    return CountryCode.MS;
                case EnumValues.SaintHelena:
                    return CountryCode.SH;
                case EnumValues.SGSSI:
                    return CountryCode.GS;
                case EnumValues.BritishIndianOceanTerritory:
                    return CountryCode.IO;
                case EnumValues.Pitcairn:
                    return CountryCode.PN;
                default:
                    return CountryCode.GB;
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
                case Country.Guernsey:
                    return EnumValues.Guernsey;
                case Country.Jersey:
                    return EnumValues.Jersey;
                case Country.Mann:
                    return EnumValues.Mann;
                case Country.Gibraltar:
                    return EnumValues.Gibraltar;
                case Country.Bermuda:
                    return EnumValues.Bermuda;
                case Country.CaymanIslands:
                    return EnumValues.CaymanIslands;
                case Country.TurksAndCaicosIslands:
                    return EnumValues.TurksAndCaicosIslands;
                case Country.VirginIslandsBritish:
                    return EnumValues.BritishVirginIslands;
                case Country.Anguilla:
                    return EnumValues.Anguilla;
                case Country.Montserrat:
                    return EnumValues.Montserrat;
                case Country.SaintHelena:
                    return EnumValues.SaintHelena;
                case Country.SGSSI:
                    return EnumValues.SGSSI;
                case Country.BritishIndianOceanTerritory:
                    return EnumValues.BritishIndianOceanTerritory;
                case Country.Pitcairn:
                    return EnumValues.Pitcairn;
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
                case CountryCode.GG:
                    return EnumValues.Guernsey;
                case CountryCode.JE:
                    return EnumValues.Jersey;
                case CountryCode.IM:
                    return EnumValues.Mann;
                case CountryCode.GI:
                    return EnumValues.Gibraltar;
                case CountryCode.BM:
                    return EnumValues.Bermuda;
                case CountryCode.KY:
                    return EnumValues.CaymanIslands;
                case CountryCode.TC:
                    return EnumValues.TurksAndCaicosIslands;
                case CountryCode.VG:
                    return EnumValues.BritishVirginIslands;
                case CountryCode.AI:
                    return EnumValues.Anguilla;
                case CountryCode.MS:
                    return EnumValues.Montserrat;
                case CountryCode.SH:
                    return EnumValues.SaintHelena;
                case CountryCode.GS:
                    return EnumValues.SGSSI;
                case CountryCode.IO:
                    return EnumValues.BritishIndianOceanTerritory;
                case CountryCode.PN:
                    return EnumValues.Pitcairn;
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