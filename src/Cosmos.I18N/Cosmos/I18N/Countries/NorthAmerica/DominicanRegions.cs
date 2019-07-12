using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// Dominican region
    /// </summary>
    public static class DominicanRegions
    {
             #region Gets regions

        /// <summary>
        /// Cibao Nordeste
        /// </summary>
        public static EnumValues CibaoNordeste => EnumValues.CibaoNordeste;

        /// <summary>
        /// Cibao Noroeste
        /// </summary>
        public static EnumValues CibaoNoroeste => EnumValues.CibaoNoroeste;

        /// <summary>
        /// Cibao Norte
        /// </summary>
        public static EnumValues CibaoNorte => EnumValues.CibaoNorte;

        /// <summary>
        /// Cibao Sur
        /// </summary>
        public static EnumValues CibaoSur => EnumValues.CibaoSur;

        /// <summary>
        /// El Valle
        /// </summary>
        public static EnumValues ElValle => EnumValues.ElValle;

        /// <summary>
        /// Enriquillo
        /// </summary>
        public static EnumValues Enriquillo => EnumValues.Enriquillo;

        /// <summary>
        /// Higüamo
        /// </summary>
        public static EnumValues Higüamo => EnumValues.Higüamo;

        /// <summary>
        /// Ozama
        /// </summary>
        public static EnumValues Ozama => EnumValues.Ozama;

        /// <summary>
        /// Valdesia
        /// </summary>
        public static EnumValues Valdesia => EnumValues.Valdesia;

        /// <summary>
        /// Yuma
        /// </summary>
        public static EnumValues Yuma => EnumValues.Yuma;

        #endregion

        /// <summary>
        /// Enum values for Dominican regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Cibao Nordeste
            /// </summary>
            [AliasInShort("33")]
            CibaoNordeste,

            /// <summary>
            /// Cibao Noroeste
            /// </summary>
            [AliasInShort("34")]
            CibaoNoroeste,

            /// <summary>
            /// Cibao Norte
            /// </summary>
            [AliasInShort("35")]
            CibaoNorte,

            /// <summary>
            /// Cibao Sur
            /// </summary>
            [AliasInShort("36")]
            CibaoSur,

            /// <summary>
            /// El Valle
            /// </summary>
            [AliasInShort("37")]
            ElValle,

            /// <summary>
            /// Enriquillo
            /// </summary>
            [AliasInShort("38")]
            Enriquillo,

            /// <summary>
            /// Higüamo
            /// </summary>
            [AliasInShort("39")]
            Higüamo,

            /// <summary>
            /// Ozama
            /// </summary>
            [AliasInShort("40")]
            Ozama,

            /// <summary>
            /// Valdesia
            /// </summary>
            [AliasInShort("41")]
            Valdesia,

            /// <summary>
            /// Yuma
            /// </summary>
            [AliasInShort("42")]
            Yuma,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="DominicanRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="DominicanRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"DO-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Dominican;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.DO;
        }

        #endregion

        #region Getters

        private static List<EnumMember<EnumValues>> InternalEnumMembersCache { get; }
            = Enums.GetMembers<EnumValues>().Where(x => !x.Attributes.Has<IgnoreRegionAttribute>()).ToList();

        /// <summary>
        /// Get all region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAllRegonCodes()
        {
            foreach (var member in InternalEnumMembersCache)
                yield return member.Value.ToFullRegionCode();
        }

        #endregion
    }
}