using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// Albania regions
    /// </summary>
    public static class AlbaniaRegions {

        #region Gets regions

        /// <summary>
        /// Berat 
        /// </summary>
        public static EnumValues Berat => EnumValues.Berat;

        /// <summary>
        /// Durrës 
        /// </summary>
        public static EnumValues Durrës => EnumValues.Dibër;

        /// <summary>
        /// Elbasan 
        /// </summary>
        public static EnumValues Elbasan => EnumValues.Elbasan;

        /// <summary>
        /// Fier 
        /// </summary>
        public static EnumValues Fier => EnumValues.Fier;

        /// <summary>
        /// Gjirokastër 
        /// </summary>
        public static EnumValues Gjirokastër => EnumValues.Gjirokastër;

        /// <summary>
        /// Korçë 
        /// </summary>
        public static EnumValues Korçë => EnumValues.Korçë;

        /// <summary>
        /// Kukës 
        /// </summary>
        public static EnumValues Kukës => EnumValues.Kukës;

        /// <summary>
        /// Lezhë 
        /// </summary>
        public static EnumValues Lezhë => EnumValues.Lezhë;

        /// <summary>
        /// Dibër 
        /// </summary>
        public static EnumValues Dibër => EnumValues.Dibër;

        /// <summary>
        /// Shkodër 
        /// </summary>
        public static EnumValues Shkodër => EnumValues.Shkodër;

        /// <summary>
        /// Tirana 
        /// </summary>
        public static EnumValues Tirana => EnumValues.Tirana;

        /// <summary>
        /// Vlorë 
        /// </summary>
        public static EnumValues Vlorë => EnumValues.Vlorë;

        #endregion

        /// <summary>
        /// Enum values for Albania regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Berat 
            /// </summary>
            [AliasInShort("1")]
            Berat,

            /// <summary>
            /// Durrës 
            /// </summary>
            [AliasInShort("2")]
            Durrës,

            /// <summary>
            /// Elbasan 
            /// </summary>
            [AliasInShort("3")]
            Elbasan,

            /// <summary>
            /// Fier 
            /// </summary>
            [AliasInShort("4")]
            Fier,

            /// <summary>
            /// Gjirokastër 
            /// </summary>
            [AliasInShort("5")]
            Gjirokastër,

            /// <summary>
            /// Korçë 
            /// </summary>
            [AliasInShort("6")]
            Korçë,

            /// <summary>
            /// Kukës 
            /// </summary>
            [AliasInShort("7")]
            Kukës,

            /// <summary>
            /// Lezhë 
            /// </summary>
            [AliasInShort("8")]
            Lezhë,

            /// <summary>
            /// Dibër 
            /// </summary>
            [AliasInShort("9")]
            Dibër,

            /// <summary>
            /// Shkodër 
            /// </summary>
            [AliasInShort("10")]
            Shkodër,

            /// <summary>
            /// Tirana 
            /// </summary>
            [AliasInShort("11")]
            Tirana,

            /// <summary>
            /// Vlorë 
            /// </summary>
            [AliasInShort("12")]
            Vlorë,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="AlbaniaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="AlbaniaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"AL-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Albania;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.AL;
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