using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// Belarus regions
    /// </summary>
    public static class BelarusRegions {

        #region Gets region

        /// <summary>
        /// Brest
        /// </summary>
        public static EnumValues Brest => EnumValues.Brest;

        /// <summary>
        /// Minsk
        /// </summary>
        public static EnumValues Minsk => EnumValues.Minsk;

        /// <summary>
        /// Homel
        /// </summary>
        public static EnumValues Homel => EnumValues.Homel;

        /// <summary>
        /// Hrodna
        /// </summary>
        public static EnumValues Hrodna => EnumValues.Hrodna;

        /// <summary>
        /// Magileu
        /// </summary>
        public static EnumValues Magileu => EnumValues.Magileu;

        /// <summary>
        /// Minsk Region
        /// </summary>
        public static EnumValues MinskRegion => EnumValues.MinskRegion;

        /// <summary>
        /// Vitebsk
        /// </summary>
        public static EnumValues Vitebsk => EnumValues.Vitebsk;

        #endregion

        /// <summary>
        /// Enum values for Belarus regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Brest
            /// </summary>
            [AliasInShort("BR")]
            Brest,

            /// <summary>
            /// Minsk
            /// </summary>
            [AliasInShort("HM")]
            Minsk,

            /// <summary>
            /// Homel
            /// </summary>
            [AliasInShort("HO")]
            Homel,

            /// <summary>
            /// Hrodna
            /// </summary>
            [AliasInShort("HR")]
            Hrodna,

            /// <summary>
            /// Magileu
            /// </summary>
            [AliasInShort("MA")]
            Magileu,

            /// <summary>
            /// Minsk Region
            /// </summary>
            [AliasInShort("MI")]
            MinskRegion,

            /// <summary>
            /// Vitebsk
            /// </summary>
            [AliasInShort("VI")]
            Vitebsk,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BelarusRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BelarusRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"BY-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Belarus;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.BY;
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