using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// Palau Regions
    /// </summary>
    public static class PalauRegions {

        #region Gets regions

        /// <summary>
        /// Kayangel
        /// </summary>
        public static EnumValues Kayangel => EnumValues.Kayangel;

        /// <summary>
        /// Koror
        /// </summary>
        public static EnumValues Koror => EnumValues.Koror;

        /// <summary>
        /// Melekeok
        /// </summary>
        public static EnumValues Melekeok => EnumValues.Melekeok;

        /// <summary>
        /// Ngaraard
        /// </summary>
        public static EnumValues Ngaraard => EnumValues.Ngaraard;

        /// <summary>
        /// Ngarchelong
        /// </summary>
        public static EnumValues Ngarchelong => EnumValues.Ngarchelong;

        /// <summary>
        /// Dohuk
        /// </summary>
        public static EnumValues Ngardmau => EnumValues.Ngardmau;

        /// <summary>
        /// Ngatpang
        /// </summary>
        public static EnumValues Ngatpang => EnumValues.Ngatpang;

        /// <summary>
        /// Ngchesar  
        /// </summary>
        public static EnumValues Ngchesar => EnumValues.Ngchesar;

        /// <summary>
        /// Ngeremlengui
        /// </summary>
        public static EnumValues Ngeremlengui => EnumValues.Ngeremlengui;

        /// <summary>
        /// Ngiwal
        /// </summary>
        public static EnumValues Ngiwal => EnumValues.Ngiwal;

        /// <summary>
        /// Peleliu
        /// </summary>
        public static EnumValues Peleliu => EnumValues.Peleliu;

        /// <summary>
        /// Sonsorol
        /// </summary>
        public static EnumValues Sonsorol => EnumValues.Sonsorol;

        /// <summary>
        /// Aimeliik
        /// </summary>
        public static EnumValues Aimeliik => EnumValues.Aimeliik;

        /// <summary>
        /// Airai
        /// </summary>
        public static EnumValues Airai => EnumValues.Airai;

        /// <summary>
        /// Angaur
        /// </summary>
        public static EnumValues Angaur => EnumValues.Angaur;

        /// <summary>
        /// Hatohobei
        /// </summary>
        public static EnumValues Hatohobei => EnumValues.Hatohobei;

        #endregion

        /// <summary>
        /// Enum values for Palau regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Kayangel
            /// </summary>
            [AliasInShort("100")]
            Kayangel,

            /// <summary>
            /// Koror
            /// </summary>
            [AliasInShort("150")]
            Koror,

            /// <summary>
            /// Melekeok
            /// </summary>
            [AliasInShort("212")]
            Melekeok,

            /// <summary>
            /// Ngaraard
            /// </summary>
            [AliasInShort("214")]
            Ngaraard,

            /// <summary>
            /// Ngarchelong
            /// </summary>
            [AliasInShort("218")]
            Ngarchelong,

            /// <summary>
            /// Ngardmau
            /// </summary>
            [AliasInShort("222")]
            Ngardmau,

            /// <summary>
            /// Ngatpang
            /// </summary>
            [AliasInShort("224")]
            Ngatpang,

            /// <summary>
            /// Ngchesar
            /// </summary>
            [AliasInShort("226")]
            Ngchesar,

            /// <summary>
            /// Ngeremlengui
            /// </summary>
            [AliasInShort("227")]
            Ngeremlengui,

            /// <summary>
            /// Ngiwal
            /// </summary>
            [AliasInShort("228")]
            Ngiwal,

            /// <summary>
            /// Peleliu
            /// </summary>
            [AliasInShort("350")]
            Peleliu,

            /// <summary>
            /// Sonsorol
            /// </summary>
            [AliasInShort("370")]
            Sonsorol,

            /// <summary>
            /// Aimeliik
            /// </summary>
            [AliasInShort("002")]
            Aimeliik,

            /// <summary>
            /// Airai
            /// </summary>
            [AliasInShort("004")]
            Airai,

            /// <summary>
            /// Angaur
            /// </summary>
            [AliasInShort("010")]
            Angaur,

            /// <summary>
            /// Hatohobei
            /// </summary>
            [AliasInShort("050")]
            Hatohobei,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="PalauRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="PalauRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"PW-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Palau;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.PW;
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