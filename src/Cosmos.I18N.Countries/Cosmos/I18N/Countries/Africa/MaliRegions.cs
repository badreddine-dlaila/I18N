using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// Mali Regions
    /// </summary>
    public static class MaliRegions {

        #region Gets regions

        /// <summary>
        /// Kayes
        /// </summary>
        public static EnumValues Kayes => EnumValues.Kayes;

        /// <summary>
        /// Koulikoro
        /// </summary>
        public static EnumValues Koulikoro => EnumValues.Koulikoro;

        /// <summary>
        /// Sikasso
        /// </summary>
        public static EnumValues Sikasso => EnumValues.Sikasso;

        /// <summary>
        /// Ségou
        /// </summary>
        public static EnumValues Ségou => EnumValues.Ségou;

        /// <summary>
        /// Tombouctou
        /// </summary>
        public static EnumValues Tombouctou => EnumValues.Tombouctou;

        /// <summary>
        /// Gao
        /// </summary>
        public static EnumValues Gao => EnumValues.Gao;

        /// <summary>
        /// Kidal
        /// </summary>
        public static EnumValues Kidal => EnumValues.Kidal;

        /// <summary>
        /// Bamako
        /// </summary>
        public static EnumValues Bamako => EnumValues.Bamako;

        #endregion

        /// <summary>
        /// Enum values for Mali regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Kayes
            /// </summary>
            [AliasInShort("1")]
            Kayes,

            /// <summary>
            /// Koulikoro
            /// </summary>
            [AliasInShort("2")]
            Koulikoro,

            /// <summary>
            /// Sikasso
            /// </summary>
            [AliasInShort("3")]
            Sikasso,

            /// <summary>
            /// Ségou
            /// </summary>
            [AliasInShort("4")]
            Ségou,

            /// <summary>
            /// Tombouctou
            /// </summary>
            [AliasInShort("6")]
            Tombouctou,

            /// <summary>
            /// Gao
            /// </summary>
            [AliasInShort("7")]
            Gao,

            /// <summary>
            /// Kidal
            /// </summary>
            [AliasInShort("8")]
            Kidal,

            /// <summary>
            /// Bamako
            /// </summary>
            [AliasInShort("BKO")]
            Bamako,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="MaliRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="MaliRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"ML-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Mali;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.ML;
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