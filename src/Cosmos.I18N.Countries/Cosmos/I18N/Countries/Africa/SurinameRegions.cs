using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// Suriname Regions
    /// </summary>
    public static class SurinameRegions {

        #region Gets regions

        /// <summary>
        /// Brokopondo
        /// </summary>
        public static EnumValues Brokopondo => EnumValues.Brokopondo;

        /// <summary>
        /// Commewijne
        /// </summary>
        public static EnumValues Commewijne => EnumValues.Commewijne;

        /// <summary>
        /// Coronie
        /// </summary>
        public static EnumValues Coronie => EnumValues.Coronie;

        /// <summary>
        /// Marowijne
        /// </summary>
        public static EnumValues Marowijne => EnumValues.Marowijne;

        /// <summary>
        /// Nickerie
        /// </summary>
        public static EnumValues Nickerie => EnumValues.Nickerie;

        /// <summary>
        /// Paramaribo
        /// </summary>
        public static EnumValues Paramaribo => EnumValues.Paramaribo;

        /// <summary>
        /// Para
        /// </summary>
        public static EnumValues Para => EnumValues.Para;

        /// <summary>
        /// Saramacca 
        /// </summary>
        public static EnumValues Saramacca => EnumValues.Saramacca;

        /// <summary>
        /// Sipaliwini
        /// </summary>
        public static EnumValues Sipaliwini => EnumValues.Sipaliwini;

        /// <summary>
        /// Wanica
        /// </summary>
        public static EnumValues Wanica => EnumValues.Wanica;

        #endregion

        /// <summary>
        /// Enum values for Suriname regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Brokopondo
            /// </summary>
            [AliasInShort("BR")]
            Brokopondo,

            /// <summary>
            /// Commewijne
            /// </summary>
            [AliasInShort("CM")]
            Commewijne,

            /// <summary>
            /// Coronie
            /// </summary>
            [AliasInShort("CR")]
            Coronie,

            /// <summary>
            /// Marowijne
            /// </summary>
            [AliasInShort("MA")]
            Marowijne,

            /// <summary>
            /// Nickerie
            /// </summary>
            [AliasInShort("NI")]
            Nickerie,

            /// <summary>
            /// Paramaribo
            /// </summary>
            [AliasInShort("PA")]
            Paramaribo,

            /// <summary>
            /// Para
            /// </summary>
            [AliasInShort("PR")]
            Para,

            /// <summary>
            /// Saramacca
            /// </summary>
            [AliasInShort("SA")]
            Saramacca,

            /// <summary>
            /// Sipaliwini
            /// </summary>
            [AliasInShort("SI")]
            Sipaliwini,

            /// <summary>
            /// Wanica
            /// </summary>
            [AliasInShort("WA")]
            Wanica,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SurinameRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SurinameRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"SR-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Suriname;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.SR;
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