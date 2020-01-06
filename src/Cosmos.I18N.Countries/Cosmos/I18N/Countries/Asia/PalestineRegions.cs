using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// Palestine Regions
    /// </summary>
    public static class PalestineRegions {

        #region Gets regions

        /// <summary>
        /// Bethlehem
        /// </summary>
        public static EnumValues Bethlehem => EnumValues.Bethlehem;

        /// <summary>
        /// Deir al-Balah
        /// </summary>
        public static EnumValues DeirAlBalah => EnumValues.DeirAlBalah;

        /// <summary>
        /// Gaza
        /// </summary>
        public static EnumValues Gaza => EnumValues.Gaza;

        /// <summary>
        /// Hebron
        /// </summary>
        public static EnumValues Hebron => EnumValues.Hebron;

        /// <summary>
        /// Jerusalem
        /// </summary>
        public static EnumValues Jerusalem => EnumValues.Jerusalem;

        /// <summary>
        /// Jenin
        /// </summary>
        public static EnumValues Jenin => EnumValues.Jenin;

        /// <summary>
        /// Jericho
        /// </summary>
        public static EnumValues Jericho => EnumValues.Jericho;

        /// <summary>
        /// Khan Yunis    
        /// </summary>
        public static EnumValues KhanYunis => EnumValues.KhanYunis;

        /// <summary>
        /// Nablus
        /// </summary>
        public static EnumValues Nablus => EnumValues.Nablus;

        /// <summary>
        /// North Gaza
        /// </summary>
        public static EnumValues NorthGaza => EnumValues.NorthGaza;

        /// <summary>
        /// Qalqilya
        /// </summary>
        public static EnumValues Qalqilya => EnumValues.Qalqilya;

        /// <summary>
        /// Ramallah and al-Bireh
        /// </summary>
        public static EnumValues RamallahAndAlBireh => EnumValues.RamallahAndAlBireh;

        /// <summary>
        /// Rafah
        /// </summary>
        public static EnumValues Rafah => EnumValues.Rafah;

        /// <summary>
        /// Salfit
        /// </summary>
        public static EnumValues Salfit => EnumValues.Salfit;

        /// <summary>
        /// Tubas
        /// </summary>
        public static EnumValues Tubas => EnumValues.Tubas;

        /// <summary>
        /// Tulkarm
        /// </summary>
        public static EnumValues Tulkarm => EnumValues.Tulkarm;

        #endregion

        /// <summary>
        /// Enum values for Palestine regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Bethlehem
            /// </summary>
            [AliasInShort("BTH")]
            Bethlehem,

            /// <summary>
            /// Deir al-Balah
            /// </summary>
            [AliasInShort("DEB")]
            DeirAlBalah,

            /// <summary>
            /// Gaza
            /// </summary>
            [AliasInShort("GZA")]
            Gaza,

            /// <summary>
            /// Hebron
            /// </summary>
            [AliasInShort("HBN")]
            Hebron,

            /// <summary>
            /// Jerusalem
            /// </summary>
            [AliasInShort("JEM")]
            Jerusalem,

            /// <summary>
            /// Jenin
            /// </summary>
            [AliasInShort("JEN")]
            Jenin,

            /// <summary>
            /// Jericho
            /// </summary>
            [AliasInShort("JRH")]
            Jericho,

            /// <summary>
            /// Khan Yunis
            /// </summary>
            [AliasInShort("KYS")]
            KhanYunis,

            /// <summary>
            /// Nablus
            /// </summary>
            [AliasInShort("NBS")]
            Nablus,

            /// <summary>
            /// North Gaza
            /// </summary>
            [AliasInShort("MGZ")]
            NorthGaza,

            /// <summary>
            /// Qalqilya
            /// </summary>
            [AliasInShort("QQA")]
            Qalqilya,

            /// <summary>
            /// Ramallah and al-Bireh
            /// </summary>
            [AliasInShort("RBH")]
            RamallahAndAlBireh,

            /// <summary>
            /// Rafah
            /// </summary>
            [AliasInShort("RFH")]
            Rafah,

            /// <summary>
            /// Salfit
            /// </summary>
            [AliasInShort("SLT")]
            Salfit,

            /// <summary>
            /// Tubas
            /// </summary>
            [AliasInShort("TBS")]
            Tubas,

            /// <summary>
            /// Tulkarm
            /// </summary>
            [AliasInShort("TKM")]
            Tulkarm,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="PalestineRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="PalestineRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"PS-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Palestine;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.PS;
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