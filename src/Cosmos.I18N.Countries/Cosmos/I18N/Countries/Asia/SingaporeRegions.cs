using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// Singapore Regions
    /// </summary>
    public static class SingaporeRegions {

        #region Gets regions

        /// <summary>
        /// Central Singapore
        /// </summary>
        public static EnumValues CentralSingapore => EnumValues.CentralSingapore;

        /// <summary>
        /// North East
        /// </summary>
        public static EnumValues NorthEast => EnumValues.NorthEast;

        /// <summary>
        /// North West
        /// </summary>
        public static EnumValues NorthWest => EnumValues.NorthWest;

        /// <summary>
        /// South East
        /// </summary>
        public static EnumValues SouthEast => EnumValues.SouthEast;

        /// <summary>
        /// South West
        /// </summary>
        public static EnumValues SouthWest => EnumValues.SouthWest;

        #endregion

        /// <summary>
        /// Enum values for Singapore regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Central Singapore
            /// </summary>
            [AliasInShort("01")]
            CentralSingapore,

            /// <summary>
            /// North East
            /// </summary>
            [AliasInShort("02")]
            NorthEast,

            /// <summary>
            /// North West
            /// </summary>
            [AliasInShort("03")]
            NorthWest,

            /// <summary>
            /// South East
            /// </summary>
            [AliasInShort("04")]
            SouthEast,

            /// <summary>
            /// South West
            /// </summary>
            [AliasInShort("05")]
            SouthWest,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SingaporeRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SingaporeRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"SG-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Singapore;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.SG;
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