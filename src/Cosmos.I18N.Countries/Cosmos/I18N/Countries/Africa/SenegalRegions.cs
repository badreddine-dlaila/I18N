using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// Senegal regons
    /// </summary>
    public static class SenegalRegions {

        #region Gets regions

        /// <summary>
        /// Diourbel
        /// </summary>
        public static EnumValues Diourbel => EnumValues.Diourbel;

        /// <summary>
        /// Dakar
        /// </summary>
        public static EnumValues Dakar => EnumValues.Dakar;

        /// <summary>
        /// Fatick
        /// </summary>
        public static EnumValues Fatick => EnumValues.Fatick;

        /// <summary>
        /// Kaffrine
        /// </summary>
        public static EnumValues Kaffrine => EnumValues.Kaffrine;

        /// <summary>
        /// Kolda
        /// </summary>
        public static EnumValues Kolda => EnumValues.Kolda;

        /// <summary>
        /// Kédougou
        /// </summary>
        public static EnumValues Kédougou => EnumValues.Kédougou;

        /// <summary>
        /// Kaolack
        /// </summary>
        public static EnumValues Kaolack => EnumValues.Kaolack;

        /// <summary>
        /// Louga
        /// </summary>
        public static EnumValues Louga => EnumValues.Louga;

        /// <summary>
        /// Matam
        /// </summary>
        public static EnumValues Matam => EnumValues.Matam;

        /// <summary>
        /// Sédhiou
        /// </summary>
        public static EnumValues Sédhiou => EnumValues.Sédhiou;

        /// <summary>
        /// Saint-Louis
        /// </summary>
        public static EnumValues SaintLouis => EnumValues.SaintLouis;

        /// <summary>
        /// Tambacounda
        /// </summary>
        public static EnumValues Tambacounda => EnumValues.Tambacounda;

        /// <summary>
        /// Thiès
        /// </summary>
        public static EnumValues Thiès => EnumValues.Thiès;

        /// <summary>
        /// Ziguinchor
        /// </summary>
        public static EnumValues Ziguinchor => EnumValues.Ziguinchor;

        #endregion

        /// <summary>
        /// Enum values for Senegal regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Diourbel
            /// </summary>
            [AliasInShort("DB")]
            Diourbel,

            /// <summary>
            /// Dakar
            /// </summary>
            [AliasInShort("DK")]
            Dakar,

            /// <summary>
            /// Fatick
            /// </summary>
            [AliasInShort("FK")]
            Fatick,

            /// <summary>
            /// Kaffrine
            /// </summary>
            [AliasInShort("KA")]
            Kaffrine,

            /// <summary>
            /// Kolda
            /// </summary>
            [AliasInShort("KD")]
            Kolda,

            /// <summary>
            /// Kédougou
            /// </summary>
            [AliasInShort("KE")]
            Kédougou,

            /// <summary>
            /// Kaolack
            /// </summary>
            [AliasInShort("KL")]
            Kaolack,

            /// <summary>
            /// Louga
            /// </summary>
            [AliasInShort("LG")]
            Louga,

            /// <summary>
            /// Matam
            /// </summary>
            [AliasInShort("ML")]
            Matam,

            /// <summary>
            /// Sédhiou
            /// </summary>
            [AliasInShort("SE")]
            Sédhiou,

            /// <summary>
            /// Saint-Louis
            /// </summary>
            [AliasInShort("SL")]
            SaintLouis,

            /// <summary>
            /// Tambacounda
            /// </summary>
            [AliasInShort("TC")]
            Tambacounda,

            /// <summary>
            /// Thiès
            /// </summary>
            [AliasInShort("TH")]
            Thiès,

            /// <summary>
            /// Ziguinchor
            /// </summary>
            [AliasInShort("ZG")]
            Ziguinchor,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SenegalRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SenegalRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"SN-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Senegal;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.SN;
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