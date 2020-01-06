using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// Cambodia Regions
    /// </summary>
    public static class CambodiaRegions {

        #region Gets regions

        /// <summary>
        /// Banteay Meanchey
        /// </summary>
        public static EnumValues BanteayMeanchey => EnumValues.BanteayMeanchey;

        /// <summary>
        /// Battambang
        /// </summary>
        public static EnumValues Battambang => EnumValues.Battambang;

        /// <summary>
        /// Kampong Cham
        /// </summary>
        public static EnumValues KampongCham => EnumValues.KampongCham;

        /// <summary>
        /// Kampong Chhnang
        /// </summary>
        public static EnumValues KampongChhnang => EnumValues.KampongChhnang;

        /// <summary>
        /// Kampong Speu
        /// </summary>
        public static EnumValues KampongSpeu => EnumValues.KampongSpeu;

        /// <summary>
        /// Kampong Thom
        /// </summary>
        public static EnumValues KampongThom => EnumValues.KampongThom;

        /// <summary>
        /// Kampot
        /// </summary>
        public static EnumValues Kampot => EnumValues.Kampot;

        /// <summary>
        /// Kandal
        /// </summary>
        public static EnumValues Kandal => EnumValues.Kandal;

        /// <summary>
        /// Koh Kong
        /// </summary>
        public static EnumValues KohKong => EnumValues.KohKong;

        /// <summary>
        /// Kratié
        /// </summary>
        public static EnumValues Kratié => EnumValues.Kratié;

        /// <summary>
        /// Mondulkiri
        /// </summary>
        public static EnumValues Mondulkiri => EnumValues.Mondulkiri;

        /// <summary>
        /// Phnom Penh
        /// </summary>
        public static EnumValues PhnomPenh => EnumValues.PhnomPenh;

        /// <summary>
        /// Preah Vihear
        /// </summary>
        public static EnumValues PreahVihear => EnumValues.PreahVihear;

        /// <summary>
        /// Prey Veng
        /// </summary>
        public static EnumValues PreyVeng => EnumValues.PreyVeng;

        /// <summary>
        /// Pursat
        /// </summary>
        public static EnumValues Pursat => EnumValues.Pursat;

        /// <summary>
        /// Ratanakiri
        /// </summary>
        public static EnumValues Ratanakiri => EnumValues.Ratanakiri;

        /// <summary>
        /// Siem Reap
        /// </summary>
        public static EnumValues SiemReap => EnumValues.SiemReap;

        /// <summary>
        /// Sihanoukville
        /// </summary>
        public static EnumValues Sihanoukville => EnumValues.Sihanoukville;

        /// <summary>
        /// Stung Treng
        /// </summary>
        public static EnumValues StungTreng => EnumValues.StungTreng;

        /// <summary>
        /// Svay Rieng
        /// </summary>
        public static EnumValues SvayRieng => EnumValues.SvayRieng;

        /// <summary>
        /// Takéo
        /// </summary>
        public static EnumValues Takéo => EnumValues.Takéo;

        /// <summary>
        /// Oddar Meanchey
        /// </summary>
        public static EnumValues OddarMeanchey => EnumValues.OddarMeanchey;

        /// <summary>
        /// Kep
        /// </summary>
        public static EnumValues Kep => EnumValues.Kep;

        /// <summary>
        /// Pailin
        /// </summary>
        public static EnumValues Pailin => EnumValues.Pailin;

        /// <summary>
        /// Tbong Khmum
        /// </summary>
        public static EnumValues TbongKhmum => EnumValues.TbongKhmum;

        #endregion

        /// <summary>
        /// Enum values for Cambodia regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Banteay Meanchey
            /// </summary>
            [AliasInShort("1")]
            BanteayMeanchey,

            /// <summary>
            /// Battambang
            /// </summary>
            [AliasInShort("2")]
            Battambang,

            /// <summary>
            /// Kampong Cham
            /// </summary>
            [AliasInShort("3")]
            KampongCham,

            /// <summary>
            /// Kampong Chhnang
            /// </summary>
            [AliasInShort("4")]
            KampongChhnang,

            /// <summary>
            /// Kampong Speu
            /// </summary>
            [AliasInShort("5")]
            KampongSpeu,

            /// <summary>
            /// Kampong Thom
            /// </summary>
            [AliasInShort("6")]
            KampongThom,

            /// <summary>
            /// Kampot
            /// </summary>
            [AliasInShort("7")]
            Kampot,

            /// <summary>
            /// Kandal
            /// </summary>
            [AliasInShort("8")]
            Kandal,

            /// <summary>
            /// Koh Kong
            /// </summary>
            [AliasInShort("9")]
            KohKong,

            /// <summary>
            /// Kratié
            /// </summary>
            [AliasInShort("10")]
            Kratié,

            /// <summary>
            /// Mondulkiri
            /// </summary>
            [AliasInShort("11")]
            Mondulkiri,

            /// <summary>
            /// Phnom Penh
            /// </summary>
            [AliasInShort("12")]
            PhnomPenh,

            /// <summary>
            /// Preah Vihear
            /// </summary>
            [AliasInShort("13")]
            PreahVihear,

            /// <summary>
            /// Prey Veng
            /// </summary>
            [AliasInShort("14")]
            PreyVeng,

            /// <summary>
            /// Pursat
            /// </summary>
            [AliasInShort("15")]
            Pursat,

            /// <summary>
            /// Ratanakiri
            /// </summary>
            [AliasInShort("16")]
            Ratanakiri,

            /// <summary>
            /// Siem Reap
            /// </summary>
            [AliasInShort("17")]
            SiemReap,

            /// <summary>
            /// Sihanoukville
            /// </summary>
            [AliasInShort("18")]
            Sihanoukville,

            /// <summary>
            /// Stung Treng
            /// </summary>
            [AliasInShort("19")]
            StungTreng,

            /// <summary>
            /// Svay Rieng
            /// </summary>
            [AliasInShort("20")]
            SvayRieng,

            /// <summary>
            /// Takéo
            /// </summary>
            [AliasInShort("21")]
            Takéo,

            /// <summary>
            /// Oddar Meanchey
            /// </summary>
            [AliasInShort("22")]
            OddarMeanchey,

            /// <summary>
            /// Kep
            /// </summary>
            [AliasInShort("23")]
            Kep,

            /// <summary>
            /// Pailin
            /// </summary>
            [AliasInShort("24")]
            Pailin,

            /// <summary>
            /// Tbong Khmum
            /// </summary>
            [AliasInShort("25")]
            TbongKhmum,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="CambodiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="CambodiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"KH-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Cambodia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.KH;
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