using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// SolomonIslands Regions
    /// </summary>
    public static class SolomonIslandsRegions {

        #region Gets regions

        /// <summary>
        /// Central
        /// </summary>
        public static EnumValues Central => EnumValues.Central;

        /// <summary>
        /// Choiseul
        /// </summary>
        public static EnumValues Choiseul => EnumValues.Choiseul;

        /// <summary>
        /// Honiara
        /// </summary>
        public static EnumValues Honiara => EnumValues.Honiara;

        /// <summary>
        /// Guadalcanal
        /// </summary>
        public static EnumValues Guadalcanal => EnumValues.Guadalcanal;

        /// <summary>
        /// Isabel
        /// </summary>
        public static EnumValues Isabel => EnumValues.Isabel;

        /// <summary>
        /// Makira-Ulawa
        /// </summary>
        public static EnumValues MakiraUlawa => EnumValues.MakiraUlawa;

        /// <summary>
        /// Malaita
        /// </summary>
        public static EnumValues Malaita => EnumValues.Malaita;

        /// <summary>
        /// Rennell and Bellona
        /// </summary>
        public static EnumValues RennellAndBellona => EnumValues.RennellAndBellona;

        /// <summary>
        /// Temotu
        /// </summary>
        public static EnumValues Temotu => EnumValues.Temotu;

        /// <summary>
        /// Western
        /// </summary>
        public static EnumValues Western => EnumValues.Western;

        #endregion

        /// <summary>
        /// Enum values for SolomonIslands regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Central
            /// </summary>
            [AliasInShort("CE")]
            Central,

            /// <summary>
            /// Choiseul
            /// </summary>
            [AliasInShort("CH")]
            Choiseul,

            /// <summary>
            /// Honiara
            /// </summary>
            [AliasInShort("CT")]
            Honiara,

            /// <summary>
            /// Guadalcanal
            /// </summary>
            [AliasInShort("GU")]
            Guadalcanal,

            /// <summary>
            /// Isabel
            /// </summary>
            [AliasInShort("IS")]
            Isabel,

            /// <summary>
            /// Makira-Ulawa
            /// </summary>
            [AliasInShort("MK")]
            MakiraUlawa,

            /// <summary>
            /// Malaita
            /// </summary>
            [AliasInShort("ML")]
            Malaita,

            /// <summary>
            /// Rennell and Bellona
            /// </summary>
            [AliasInShort("RB")]
            RennellAndBellona,

            /// <summary>
            /// Temotu
            /// </summary>
            [AliasInShort("TE")]
            Temotu,

            /// <summary>
            /// Western
            /// </summary>
            [AliasInShort("WE")]
            Western,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SolomonIslandsRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SolomonIslandsRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"SB-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.SolomonIslands;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.SB;
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