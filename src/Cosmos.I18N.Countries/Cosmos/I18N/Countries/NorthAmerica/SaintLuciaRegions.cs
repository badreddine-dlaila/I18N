using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// SaintLucia Regions
    /// </summary>
    public static class SaintLuciaRegions {

        #region Gets regions

        /// <summary>
        /// Soufrière
        /// </summary>
        public static EnumValues Soufrière => EnumValues.Soufrière;

        /// <summary>
        /// Vieux Fort
        /// </summary>
        public static EnumValues VieuxFort => EnumValues.VieuxFort;

        /// <summary>
        /// Canaries
        /// </summary>
        public static EnumValues Canaries => EnumValues.Canaries;

        /// <summary>
        /// Anse la Raye
        /// </summary>
        public static EnumValues AnseLaRaye => EnumValues.AnseLaRaye;

        /// <summary>
        /// Castries
        /// </summary>
        public static EnumValues Castries => EnumValues.Castries;

        /// <summary>
        /// Choiseul
        /// </summary>
        public static EnumValues Choiseul => EnumValues.Choiseul;

        /// <summary>
        /// Dennery
        /// </summary>
        public static EnumValues Dennery => EnumValues.Dennery;

        /// <summary>
        /// Gros Islet
        /// </summary>
        public static EnumValues GrosIslet => EnumValues.GrosIslet;

        /// <summary>
        /// Laborie
        /// </summary>
        public static EnumValues Laborie => EnumValues.Laborie;

        /// <summary>
        /// Micoud
        /// </summary>
        public static EnumValues Micoud => EnumValues.Micoud;

        #endregion

        /// <summary>
        /// Enum values for SaintLucia regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Soufrière
            /// </summary>
            [AliasInShort("10")]
            Soufrière,

            /// <summary>
            /// Vieux Fort
            /// </summary>
            [AliasInShort("11")]
            VieuxFort,

            /// <summary>
            /// Canaries
            /// </summary>
            [AliasInShort("12")]
            Canaries,

            /// <summary>
            /// Anse la Raye
            /// </summary>
            [AliasInShort("01")]
            AnseLaRaye,

            /// <summary>
            /// Castries
            /// </summary>
            [AliasInShort("02")]
            Castries,

            /// <summary>
            /// Choiseul
            /// </summary>
            [AliasInShort("03")]
            Choiseul,

            /// <summary>
            /// Dennery
            /// </summary>
            [AliasInShort("05")]
            Dennery,

            /// <summary>
            /// Gros Islet
            /// </summary>
            [AliasInShort("06")]
            GrosIslet,

            /// <summary>
            /// Laborie
            /// </summary>
            [AliasInShort("07")]
            Laborie,

            /// <summary>
            /// Micoud
            /// </summary>
            [AliasInShort("08")]
            Micoud,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SaintLuciaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SaintLuciaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"CL-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.SaintLucia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.LC;
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