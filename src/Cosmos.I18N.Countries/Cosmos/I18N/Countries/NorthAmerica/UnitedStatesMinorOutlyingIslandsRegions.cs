using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// United States Minor Outlying Islands Regions
    /// </summary>
    public static class UnitedStatesMinorOutlyingIslandsRegions {

        #region Gets regions

        /// <summary>
        /// Johnston Atoll
        /// </summary>
        public static EnumValues JohnstonAtoll => EnumValues.JohnstonAtoll;

        /// <summary>
        /// Midway Atoll
        /// </summary>
        public static EnumValues MidwayAtoll => EnumValues.MidwayAtoll;

        /// <summary>
        /// Navassa Island
        /// </summary>
        public static EnumValues NavassaIsland => EnumValues.NavassaIsland;

        /// <summary>
        /// Wake Island
        /// </summary>
        public static EnumValues WakeIsland => EnumValues.WakeIsland;

        /// <summary>
        /// Baker Island
        /// </summary>
        public static EnumValues BakerIsland => EnumValues.BakerIsland;

        /// <summary>
        /// Howland Island
        /// </summary>
        public static EnumValues HowlandIsland => EnumValues.HowlandIsland;

        /// <summary>
        /// Jarvis Island
        /// </summary>
        public static EnumValues JarvisIsland => EnumValues.JarvisIsland;

        /// <summary>
        /// Kingman Reef
        /// </summary>
        public static EnumValues KingmanReef => EnumValues.KingmanReef;

        /// <summary>
        /// Palmyra Atoll
        /// </summary>
        public static EnumValues PalmyraAtoll => EnumValues.PalmyraAtoll;

        #endregion

        /// <summary>
        /// Enum values for UnitedStatesMinorOutlyingIslands regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Johnston Atoll
            /// </summary>
            [AliasInShort("67")]
            JohnstonAtoll,

            /// <summary>
            /// Midway Atoll
            /// </summary>
            [AliasInShort("71")]
            MidwayAtoll,

            /// <summary>
            /// Navassa Island
            /// </summary>
            [AliasInShort("76")]
            NavassaIsland,

            /// <summary>
            /// Wake Island
            /// </summary>
            [AliasInShort("79")]
            WakeIsland,

            /// <summary>
            /// Baker Island
            /// </summary>
            [AliasInShort("81")]
            BakerIsland,

            /// <summary>
            /// Howland Island
            /// </summary>
            [AliasInShort("84")]
            HowlandIsland,

            /// <summary>
            /// Jarvis Island
            /// </summary>
            [AliasInShort("86")]
            JarvisIsland,

            /// <summary>
            /// Kingman Reef
            /// </summary>
            [AliasInShort("89")]
            KingmanReef,

            /// <summary>
            /// Palmyra Atoll
            /// </summary>
            [AliasInShort("95")]
            PalmyraAtoll,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="UnitedStatesMinorOutlyingIslandsRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="UnitedStatesMinorOutlyingIslandsRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"US-UM-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.UnitedStates;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.US;
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