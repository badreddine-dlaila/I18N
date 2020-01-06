using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// Nepal Regions
    /// </summary>
    public static class NepalRegions {

        #region Gets regions

        /// <summary>
        /// Central
        /// </summary>
        public static EnumValues Central => EnumValues.Central;

        /// <summary>
        /// Madhya Pashchimanchal
        /// </summary>
        public static EnumValues MadhyaPashchimanchal => EnumValues.MadhyaPashchimanchal;

        /// <summary>
        /// Western
        /// </summary>
        public static EnumValues Western => EnumValues.Western;

        /// <summary>
        /// Purwanchal
        /// </summary>
        public static EnumValues Purwanchal => EnumValues.Purwanchal;

        /// <summary>
        /// Sudur Pashchimanchal
        /// </summary>
        public static EnumValues SudurPashchimanchal => EnumValues.SudurPashchimanchal;

        #endregion

        /// <summary>
        /// Enum values for Nepal regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Central
            /// </summary>
            [AliasInShort("1")]
            Central,

            /// <summary>
            /// Madhya Pashchimanchal
            /// </summary>
            [AliasInShort("2")]
            MadhyaPashchimanchal,

            /// <summary>
            /// Western
            /// </summary>
            [AliasInShort("3")]
            Western,

            /// <summary>
            /// Purwanchal
            /// </summary>
            [AliasInShort("4")]
            Purwanchal,

            /// <summary>
            /// Sudur Pashchimanchal
            /// </summary>
            [AliasInShort("5")]
            SudurPashchimanchal,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="NepalRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="NepalRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"NP-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Nepal;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.NP;
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