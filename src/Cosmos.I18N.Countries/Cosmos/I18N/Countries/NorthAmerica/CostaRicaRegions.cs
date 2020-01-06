using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// CostaRica regions
    /// </summary>
    public static class CostaRicaRegions {

        #region Gets regions

        /// <summary>
        /// Alajuela
        /// </summary>
        public static EnumValues Alajuela => EnumValues.Alajuela;

        /// <summary>
        /// Cartago
        /// </summary>
        public static EnumValues Cartago => EnumValues.Cartago;

        /// <summary>
        /// Guanacaste
        /// </summary>
        public static EnumValues Guanacaste => EnumValues.Guanacaste;

        /// <summary>
        /// Heredia
        /// </summary>
        public static EnumValues Heredia => EnumValues.Heredia;

        /// <summary>
        /// Limón
        /// </summary>
        public static EnumValues Limón => EnumValues.Limón;

        /// <summary>
        /// Puntarenas
        /// </summary>
        public static EnumValues Puntarenas => EnumValues.Puntarenas;

        /// <summary>
        /// San José
        /// </summary>
        public static EnumValues SanJosé => EnumValues.SanJosé;

        #endregion

        /// <summary>
        /// Enum values for CostaRica regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Alajuela
            /// </summary>
            [AliasInShort("A")]
            Alajuela,

            /// <summary>
            /// Cartago
            /// </summary>
            [AliasInShort("C")]
            Cartago,

            /// <summary>
            /// Guanacaste
            /// </summary>
            [AliasInShort("G")]
            Guanacaste,

            /// <summary>
            /// Heredia
            /// </summary>
            [AliasInShort("H")]
            Heredia,

            /// <summary>
            /// Limón
            /// </summary>
            [AliasInShort("L")]
            Limón,

            /// <summary>
            /// Puntarenas
            /// </summary>
            [AliasInShort("P")]
            Puntarenas,

            /// <summary>
            /// San José
            /// </summary>
            [AliasInShort("SJ")]
            SanJosé,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="CostaRicaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="CostaRicaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"CR-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.CostaRica;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.CR;
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