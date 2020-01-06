using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// Belgium Regions
    /// </summary>
    public static class BelgiumRegions {

        #region Gets regions

        /// <summary>
        /// Bruxelles
        /// </summary>
        public static EnumValues Bruxelles => EnumValues.Bruxelles;

        /// <summary>
        /// Deutschsprachige Gemeinschaft
        /// </summary>
        public static EnumValues DeutschsprachigeGemeinschaft => EnumValues.DeutschsprachigeGemeinschaft;

        /// <summary>
        /// Vlaamse Gemeenschap
        /// </summary>
        public static EnumValues VlaamseGemeenschap => EnumValues.VlaamseGemeenschap;

        /// <summary>
        /// Communauté Française
        /// </summary>
        public static EnumValues CommunautéFrançaise => EnumValues.CommunautéFrançaise;

        #endregion

        /// <summary>
        /// Enum values for Belgium regions
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Bruxelles
            /// </summary>
            [AliasInShort("BRU")]
            Bruxelles,

            /// <summary>
            /// Deutschsprachige Gemeinschaft
            /// </summary>
            [AliasInShort("DE")]
            DeutschsprachigeGemeinschaft,

            /// <summary>
            /// Vlaamse Gemeenschap
            /// </summary>
            [AliasInShort("VLG")]
            VlaamseGemeenschap,

            /// <summary>
            /// Communauté Française
            /// </summary>
            [AliasInShort("WAL")]
            CommunautéFrançaise,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BelgiumRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BelgiumRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"BE-{values.ToRegionCode()}";
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