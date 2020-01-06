using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// Thailand Regions
    /// </summary>
    public static class ThailandRegions {

        #region Gets regions

        /// <summary>
        /// Bangkok
        /// </summary>
        public static EnumValues Bangkok => EnumValues.Bangkok;

        /// <summary>
        /// Samut Prakan
        /// </summary>
        public static EnumValues SamutPrakan => EnumValues.SamutPrakan;

        /// <summary>
        /// Nonthaburi
        /// </summary>
        public static EnumValues Nonthaburi => EnumValues.Nonthaburi;

        /// <summary>
        /// Pathum Thani
        /// </summary>
        public static EnumValues PathumThani => EnumValues.PathumThani;

        /// <summary>
        /// Phra Nakhon Si Ayutthaya
        /// </summary>
        public static EnumValues PhraNakhonSiAyutthaya => EnumValues.PhraNakhonSiAyutthaya;

        /// <summary>
        /// Ang Thong
        /// </summary>
        public static EnumValues AngThong => EnumValues.AngThong;

        /// <summary>
        /// Lopburi
        /// </summary>
        public static EnumValues Lopburi => EnumValues.Lopburi;

        /// <summary>
        /// Sing Buri   
        /// </summary>
        public static EnumValues SingBuri => EnumValues.SingBuri;

        /// <summary>
        /// Chai Nat
        /// </summary>
        public static EnumValues ChaiNat => EnumValues.ChaiNat;

        /// <summary>
        /// Saraburi
        /// </summary>
        public static EnumValues Saraburi => EnumValues.Saraburi;

        /// <summary>
        /// Chon Buri
        /// </summary>
        public static EnumValues ChonBuri => EnumValues.ChonBuri;

        /// <summary>
        /// Rayong
        /// </summary>
        public static EnumValues Rayong => EnumValues.Rayong;

        /// <summary>
        /// Chanthaburi
        /// </summary>
        public static EnumValues Chanthaburi => EnumValues.Chanthaburi;

        /// <summary>
        /// Trat
        /// </summary>
        public static EnumValues Trat => EnumValues.Trat;

        /// <summary>
        /// Chachoengsao
        /// </summary>
        public static EnumValues Chachoengsao => EnumValues.Chachoengsao;

        /// <summary>
        /// Prachin Buri
        /// </summary>
        public static EnumValues PrachinBuri => EnumValues.PrachinBuri;

        /// <summary>
        /// Nakhon Nayok
        /// </summary>
        public static EnumValues NakhonNayok => EnumValues.NakhonNayok;

        /// <summary>
        /// Sa Kaeo
        /// </summary>
        public static EnumValues SaKaeo => EnumValues.SaKaeo;

        /// <summary>
        /// Nakhon Ratchasima
        /// </summary>
        public static EnumValues NakhonRatchasima => EnumValues.NakhonRatchasima;

        /// <summary>
        /// Buri Ram
        /// </summary>
        public static EnumValues BuriRam => EnumValues.BuriRam;

        /// <summary>
        /// Surin
        /// </summary>
        public static EnumValues Surin => EnumValues.Surin;

        /// <summary>
        /// Si Sa Ket
        /// </summary>
        public static EnumValues SiSaKet => EnumValues.SiSaKet;

        /// <summary>
        /// Ubon Ratchathani
        /// </summary>
        public static EnumValues UbonRatchathani => EnumValues.UbonRatchathani;

        /// <summary>
        /// Yasothon
        /// </summary>
        public static EnumValues Yasothon => EnumValues.Yasothon;

        /// <summary>
        /// Chaiyaphum
        /// </summary>
        public static EnumValues Chaiyaphum => EnumValues.Chaiyaphum;

        /// <summary>
        /// Amnat Charoen
        /// </summary>
        public static EnumValues AmnatCharoen => EnumValues.AmnatCharoen;

        /// <summary>
        /// Bueng Kan
        /// </summary>
        public static EnumValues BuengKan => EnumValues.BuengKan;

        /// <summary>
        /// Nong Bua Lam Phu
        /// </summary>
        public static EnumValues NongBuaLamPhu => EnumValues.NongBuaLamPhu;

        /// <summary>
        /// Khon Kaen
        /// </summary>
        public static EnumValues KhonKaen => EnumValues.KhonKaen;

        /// <summary>
        /// Udon Thani
        /// </summary>
        public static EnumValues UdonThani => EnumValues.UdonThani;

        /// <summary>
        /// Loei
        /// </summary>
        public static EnumValues Loei => EnumValues.Loei;

        /// <summary>
        /// Nong Khai
        /// </summary>
        public static EnumValues NongKhai => EnumValues.NongKhai;

        /// <summary>
        /// Maha Sarakham
        /// </summary>
        public static EnumValues MahaSarakham => EnumValues.MahaSarakham;

        /// <summary>
        /// Roi Et
        /// </summary>
        public static EnumValues RoiEt => EnumValues.RoiEt;

        /// <summary>
        /// Kalasin
        /// </summary>
        public static EnumValues Kalasin => EnumValues.Kalasin;

        /// <summary>
        /// Sakon Nakhon
        /// </summary>
        public static EnumValues SakonNakhon => EnumValues.SakonNakhon;

        /// <summary>
        /// Nakhon Phanom
        /// </summary>
        public static EnumValues NakhonPhanom => EnumValues.NakhonPhanom;

        /// <summary>
        /// Mukdahan
        /// </summary>
        public static EnumValues Mukdahan => EnumValues.Mukdahan;

        /// <summary>
        /// Chiang Mai
        /// </summary>
        public static EnumValues ChiangMai => EnumValues.ChiangMai;

        /// <summary>
        /// Lamphun
        /// </summary>
        public static EnumValues Lamphun => EnumValues.Lamphun;

        /// <summary>
        /// Lampang
        /// </summary>
        public static EnumValues Lampang => EnumValues.Lampang;

        /// <summary>
        /// Uttaradit
        /// </summary>
        public static EnumValues Uttaradit => EnumValues.Uttaradit;

        /// <summary>
        /// Phrae
        /// </summary>
        public static EnumValues Phrae => EnumValues.Phrae;

        /// <summary>
        /// Nan
        /// </summary>
        public static EnumValues Nan => EnumValues.Nan;

        /// <summary>
        /// Phayao
        /// </summary>
        public static EnumValues Phayao => EnumValues.Phayao;

        /// <summary>
        /// Chiang Rai
        /// </summary>
        public static EnumValues ChiangRai => EnumValues.ChiangRai;

        /// <summary>
        /// Mae Hong Son
        /// </summary>
        public static EnumValues MaeHongSon => EnumValues.MaeHongSon;

        /// <summary>
        /// Nakhon Sawan
        /// </summary>
        public static EnumValues NakhonSawan => EnumValues.NakhonSawan;

        /// <summary>
        /// Uthai Thani
        /// </summary>
        public static EnumValues UthaiThani => EnumValues.UthaiThani;

        /// <summary>
        /// Kamphaeng Phet
        /// </summary>
        public static EnumValues KamphaengPhet => EnumValues.KamphaengPhet;

        /// <summary>
        /// Tak
        /// </summary>
        public static EnumValues Tak => EnumValues.Tak;

        /// <summary>
        /// Sukhothai
        /// </summary>
        public static EnumValues Sukhothai => EnumValues.Sukhothai;

        /// <summary>
        /// Phitsanulok
        /// </summary>
        public static EnumValues Phitsanulok => EnumValues.Phitsanulok;

        /// <summary>
        /// Phichit
        /// </summary>
        public static EnumValues Phichit => EnumValues.Phichit;

        /// <summary>
        /// Phetchabun
        /// </summary>
        public static EnumValues Phetchabun => EnumValues.Phetchabun;

        /// <summary>
        /// Ratchaburi
        /// </summary>
        public static EnumValues Ratchaburi => EnumValues.Ratchaburi;

        /// <summary>
        /// Kanchanaburi
        /// </summary>
        public static EnumValues Kanchanaburi => EnumValues.Kanchanaburi;

        /// <summary>
        /// Suphanburi
        /// </summary>
        public static EnumValues Suphanburi => EnumValues.Suphanburi;

        /// <summary>
        /// Nakhon Pathom
        /// </summary>
        public static EnumValues NakhonPathom => EnumValues.NakhonPathom;

        /// <summary>
        /// Samut Sakhon
        /// </summary>
        public static EnumValues SamutSakhon => EnumValues.SamutSakhon;

        /// <summary>
        /// Samut Songkhram
        /// </summary>
        public static EnumValues SamutSongkhram => EnumValues.SamutSongkhram;

        /// <summary>
        /// Phetchaburi
        /// </summary>
        public static EnumValues Phetchaburi => EnumValues.Phetchaburi;

        /// <summary>
        /// Prachuap Khiri Khan
        /// </summary>
        public static EnumValues PrachuapKhiriKhan => EnumValues.PrachuapKhiriKhan;

        /// <summary>
        /// Nakhon Si Thammarat
        /// </summary>
        public static EnumValues NakhonSiThammarat => EnumValues.NakhonSiThammarat;

        /// <summary>
        /// Krabi
        /// </summary>
        public static EnumValues Krabi => EnumValues.Krabi;

        /// <summary>
        /// Phang Nga
        /// </summary>
        public static EnumValues PhangNga => EnumValues.PhangNga;

        /// <summary>
        /// Phuket
        /// </summary>
        public static EnumValues Phuket => EnumValues.Phuket;

        /// <summary>
        /// Surat Thani
        /// </summary>
        public static EnumValues SuratThani => EnumValues.SuratThani;

        /// <summary>
        /// Ranong
        /// </summary>
        public static EnumValues Ranong => EnumValues.Ranong;

        /// <summary>
        /// Chumphon
        /// </summary>
        public static EnumValues Chumphon => EnumValues.Chumphon;

        /// <summary>
        /// Songkhla
        /// </summary>
        public static EnumValues Songkhla => EnumValues.Songkhla;

        /// <summary>
        /// Satun
        /// </summary>
        public static EnumValues Satun => EnumValues.Satun;

        /// <summary>
        /// Trang
        /// </summary>
        public static EnumValues Trang => EnumValues.Trang;

        /// <summary>
        /// Phatthalung
        /// </summary>
        public static EnumValues Phatthalung => EnumValues.Phatthalung;

        /// <summary>
        /// Pattani
        /// </summary>
        public static EnumValues Pattani => EnumValues.Pattani;

        /// <summary>
        /// Yala
        /// </summary>
        public static EnumValues Yala => EnumValues.Yala;

        /// <summary>
        /// Narathiwat
        /// </summary>
        public static EnumValues Narathiwat => EnumValues.Narathiwat;

        /// <summary>
        /// Pattaya
        /// </summary>
        public static EnumValues Pattaya => EnumValues.Pattaya;

        #endregion

        /// <summary>
        /// Enum values for Thailand regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Bangkok
            /// </summary>
            [AliasInShort("10")]
            Bangkok,

            /// <summary>
            /// Samut Prakan
            /// </summary>
            [AliasInShort("11")]
            SamutPrakan,

            /// <summary>
            /// Nonthaburi
            /// </summary>
            [AliasInShort("12")]
            Nonthaburi,

            /// <summary>
            /// Pathum Thani
            /// </summary>
            [AliasInShort("13")]
            PathumThani,

            /// <summary>
            /// Phra Nakhon Si Ayutthaya
            /// </summary>
            [AliasInShort("14")]
            PhraNakhonSiAyutthaya,

            /// <summary>
            /// Ang Thong
            /// </summary>
            [AliasInShort("15")]
            AngThong,

            /// <summary>
            /// Lopburi
            /// </summary>
            [AliasInShort("16")]
            Lopburi,

            /// <summary>
            /// Sing Buri
            /// </summary>
            [AliasInShort("17")]
            SingBuri,

            /// <summary>
            /// Chai Nat
            /// </summary>
            [AliasInShort("18")]
            ChaiNat,

            /// <summary>
            /// Saraburi
            /// </summary>
            [AliasInShort("19")]
            Saraburi,

            /// <summary>
            /// Chon Buri
            /// </summary>
            [AliasInShort("20")]
            ChonBuri,

            /// <summary>
            /// Rayong
            /// </summary>
            [AliasInShort("21")]
            Rayong,

            /// <summary>
            /// Chanthaburi
            /// </summary>
            [AliasInShort("22")]
            Chanthaburi,

            /// <summary>
            /// Trat
            /// </summary>
            [AliasInShort("23")]
            Trat,

            /// <summary>
            /// Chachoengsao
            /// </summary>
            [AliasInShort("24")]
            Chachoengsao,

            /// <summary>
            /// Prachin Buri
            /// </summary>
            [AliasInShort("25")]
            PrachinBuri,

            /// <summary>
            /// Nakhon Nayok
            /// </summary>
            [AliasInShort("26")]
            NakhonNayok,

            /// <summary>
            /// Sa Kaeo
            /// </summary>
            [AliasInShort("27")]
            SaKaeo,

            /// <summary>
            /// Nakhon Ratchasima
            /// </summary>
            [AliasInShort("30")]
            NakhonRatchasima,

            /// <summary>
            /// Buri Ram
            /// </summary>
            [AliasInShort("31")]
            BuriRam,

            /// <summary>
            /// Surin
            /// </summary>
            [AliasInShort("32")]
            Surin,

            /// <summary>
            /// Si Sa Ket
            /// </summary>
            [AliasInShort("33")]
            SiSaKet,

            /// <summary>
            /// Ubon Ratchathani
            /// </summary>
            [AliasInShort("34")]
            UbonRatchathani,

            /// <summary>
            /// Yasothon
            /// </summary>
            [AliasInShort("35")]
            Yasothon,

            /// <summary>
            /// Chaiyaphum
            /// </summary>
            [AliasInShort("36")]
            Chaiyaphum,

            /// <summary>
            /// Amnat Charoen
            /// </summary>
            [AliasInShort("37")]
            AmnatCharoen,

            /// <summary>
            /// Bueng Kan
            /// </summary>
            [AliasInShort("38")]
            BuengKan,

            /// <summary>
            /// Nong Bua Lam Phu
            /// </summary>
            [AliasInShort("39")]
            NongBuaLamPhu,

            /// <summary>
            /// Khon Kaen
            /// </summary>
            [AliasInShort("40")]
            KhonKaen,

            /// <summary>
            /// Udon Thani
            /// </summary>
            [AliasInShort("41")]
            UdonThani,

            /// <summary>
            /// Loei
            /// </summary>
            [AliasInShort("42")]
            Loei,

            /// <summary>
            /// Nong Khai
            /// </summary>
            [AliasInShort("43")]
            NongKhai,

            /// <summary>
            /// Maha Sarakham
            /// </summary>
            [AliasInShort("44")]
            MahaSarakham,

            /// <summary>
            /// Roi Et
            /// </summary>
            [AliasInShort("45")]
            RoiEt,

            /// <summary>
            /// Kalasin
            /// </summary>
            [AliasInShort("46")]
            Kalasin,

            /// <summary>
            /// Sakon Nakhon
            /// </summary>
            [AliasInShort("47")]
            SakonNakhon,

            /// <summary>
            /// Nakhon Phanom
            /// </summary>
            [AliasInShort("48")]
            NakhonPhanom,

            /// <summary>
            /// Mukdahan
            /// </summary>
            [AliasInShort("49")]
            Mukdahan,

            /// <summary>
            /// Chiang Mai
            /// </summary>
            [AliasInShort("50")]
            ChiangMai,

            /// <summary>
            /// Lamphun
            /// </summary>
            [AliasInShort("51")]
            Lamphun,

            /// <summary>
            /// Lampang
            /// </summary>
            [AliasInShort("52")]
            Lampang,

            /// <summary>
            /// Uttaradit
            /// </summary>
            [AliasInShort("53")]
            Uttaradit,

            /// <summary>
            /// Phrae
            /// </summary>
            [AliasInShort("54")]
            Phrae,

            /// <summary>
            /// Nan
            /// </summary>
            [AliasInShort("55")]
            Nan,

            /// <summary>
            /// Phayao
            /// </summary>
            [AliasInShort("56")]
            Phayao,

            /// <summary>
            /// Chiang Rai
            /// </summary>
            [AliasInShort("57")]
            ChiangRai,

            /// <summary>
            /// Mae Hong Son
            /// </summary>
            [AliasInShort("58")]
            MaeHongSon,

            /// <summary>
            /// Nakhon Sawan
            /// </summary>
            [AliasInShort("60")]
            NakhonSawan,

            /// <summary>
            /// Uthai Thani
            /// </summary>
            [AliasInShort("61")]
            UthaiThani,

            /// <summary>
            /// Kamphaeng Phet
            /// </summary>
            [AliasInShort("62")]
            KamphaengPhet,

            /// <summary>
            /// Tak
            /// </summary>
            [AliasInShort("63")]
            Tak,

            /// <summary>
            /// Sukhothai
            /// </summary>
            [AliasInShort("64")]
            Sukhothai,

            /// <summary>
            /// Phitsanulok
            /// </summary>
            [AliasInShort("65")]
            Phitsanulok,

            /// <summary>
            /// Phichit
            /// </summary>
            [AliasInShort("66")]
            Phichit,

            /// <summary>
            /// Phetchabun
            /// </summary>
            [AliasInShort("67")]
            Phetchabun,

            /// <summary>
            /// Ratchaburi
            /// </summary>
            [AliasInShort("70")]
            Ratchaburi,

            /// <summary>
            /// Kanchanaburi
            /// </summary>
            [AliasInShort("71")]
            Kanchanaburi,

            /// <summary>
            /// Suphanburi
            /// </summary>
            [AliasInShort("72")]
            Suphanburi,

            /// <summary>
            /// Nakhon Pathom
            /// </summary>
            [AliasInShort("73")]
            NakhonPathom,

            /// <summary>
            /// Samut Sakhon
            /// </summary>
            [AliasInShort("74")]
            SamutSakhon,

            /// <summary>
            /// Samut Songkhram
            /// </summary>
            [AliasInShort("75")]
            SamutSongkhram,

            /// <summary>
            /// Phetchaburi
            /// </summary>
            [AliasInShort("76")]
            Phetchaburi,

            /// <summary>
            /// Prachuap Khiri Khan
            /// </summary>
            [AliasInShort("77")]
            PrachuapKhiriKhan,

            /// <summary>
            /// Nakhon Si Thammarat
            /// </summary>
            [AliasInShort("80")]
            NakhonSiThammarat,

            /// <summary>
            /// Krabi
            /// </summary>
            [AliasInShort("81")]
            Krabi,

            /// <summary>
            /// Phang Nga
            /// </summary>
            [AliasInShort("82")]
            PhangNga,

            /// <summary>
            /// Phuket
            /// </summary>
            [AliasInShort("83")]
            Phuket,

            /// <summary>
            /// Surat Thani
            /// </summary>
            [AliasInShort("84")]
            SuratThani,

            /// <summary>
            /// Ranong
            /// </summary>
            [AliasInShort("85")]
            Ranong,

            /// <summary>
            /// Chumphon
            /// </summary>
            [AliasInShort("86")]
            Chumphon,

            /// <summary>
            /// Songkhla
            /// </summary>
            [AliasInShort("90")]
            Songkhla,

            /// <summary>
            /// Satun
            /// </summary>
            [AliasInShort("91")]
            Satun,

            /// <summary>
            /// Trang
            /// </summary>
            [AliasInShort("92")]
            Trang,

            /// <summary>
            /// Phatthalung
            /// </summary>
            [AliasInShort("93")]
            Phatthalung,

            /// <summary>
            /// Pattani
            /// </summary>
            [AliasInShort("94")]
            Pattani,

            /// <summary>
            /// Yala
            /// </summary>
            [AliasInShort("95")]
            Yala,

            /// <summary>
            /// Narathiwat
            /// </summary>
            [AliasInShort("96")]
            Narathiwat,

            /// <summary>
            /// Pattaya
            /// </summary>
            [AliasInShort("S")]
            Pattaya,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="ThailandRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="ThailandRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"TH-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Thailand;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.TH;
        }

        #endregion

        #region Getters

        private static List<EnumMember<EnumValues>> InternalEnumMembersCache { get; }
            = Enums.GetMembers<EnumValues>().Where(x => !x.Attributes.Has<IgnoreRegionAttribute>()).ToList();

        /// <summary>
        /// Get all region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAllRegonCodes() {
            foreach (var member in InternalEnumMembersCache)
                yield return member.Value.ToFullRegionCode();
        }

        #endregion

    }
}