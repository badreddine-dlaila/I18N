using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// Bolivia regions
    /// </summary>
    public static class BoliviaRegions
    {

        #region Gets region

        /// <summary>
        /// Beni
        /// </summary>
        public static EnumValues Beni => EnumValues.Beni;

        /// <summary>
        /// Cochabamba
        /// </summary>
        public static EnumValues Cochabamba => EnumValues.Cochabamba;

        /// <summary>
        /// Chuquisaca
        /// </summary>
        public static EnumValues Chuquisaca => EnumValues.Chuquisaca;

        /// <summary>
        /// La Paz
        /// </summary>
        public static EnumValues LaPaz => EnumValues.LaPaz;

        /// <summary>
        /// Pando
        /// </summary>
        public static EnumValues Pando => EnumValues.Pando;

        /// <summary>
        /// Oruro
        /// </summary>
        public static EnumValues Oruro => EnumValues.Oruro;

        /// <summary>
        /// Potosí
        /// </summary>
        public static EnumValues Potosí => EnumValues.Potosí;

        /// <summary>
        /// Santa Cruz
        /// </summary>
        public static EnumValues SantaCruz => EnumValues.SantaCruz;

        /// <summary>
        /// Tarija
        /// </summary>
        public static EnumValues Tarija => EnumValues.Tarija;

        #endregion

        /// <summary>
        /// Enum values for Bolivia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Beni
            /// </summary>
            [AliasInShort("B")]
            Beni,

            /// <summary>
            /// Cochabamba
            /// </summary>
            [AliasInShort("C")]
            Cochabamba,

            /// <summary>
            /// Chuquisaca
            /// </summary>
            [AliasInShort("H")]
            Chuquisaca,

            /// <summary>
            /// La Paz
            /// </summary>
            [AliasInShort("L")]
            LaPaz,

            /// <summary>
            /// Pando
            /// </summary>
            [AliasInShort("N")]
            Pando,

            /// <summary>
            /// Oruro
            /// </summary>
            [AliasInShort("O")]
            Oruro,

            /// <summary>
            /// Potosí
            /// </summary>
            [AliasInShort("P")]
            Potosí,

            /// <summary>
            /// Santa Cruz
            /// </summary>
            [AliasInShort("S")]
            SantaCruz,

            /// <summary>
            /// Tarija
            /// </summary>
            [AliasInShort("T")]
            Tarija,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BoliviaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BoliviaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"BO-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Bolivia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.BO;
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