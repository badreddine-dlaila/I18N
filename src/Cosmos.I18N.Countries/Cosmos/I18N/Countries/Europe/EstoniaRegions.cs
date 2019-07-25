using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Estonia Regions
    /// </summary>
    public static class EstoniaRegions
    {
         #region Gets regions

        /// <summary>
        /// Harju
        /// </summary>
        public static EnumValues Harju => EnumValues.Harju;

        /// <summary>
        /// Hiiu
        /// </summary>
        public static EnumValues Hiiu => EnumValues.Hiiu;

        /// <summary>
        /// Ida-Viru
        /// </summary>
        public static EnumValues IdaViru => EnumValues.IdaViru;

        /// <summary>
        /// Jõgeva
        /// </summary>
        public static EnumValues Jõgeva => EnumValues.Jõgeva;

        /// <summary>
        /// Järva
        /// </summary>
        public static EnumValues Järva => EnumValues.Järva;

        /// <summary>
        /// Lääne
        /// </summary>
        public static EnumValues Lääne => EnumValues.Lääne;

        /// <summary>
        /// Lääne-Viru
        /// </summary>
        public static EnumValues LääneViru => EnumValues.LääneViru;

        /// <summary>
        /// Põlva
        /// </summary>
        public static EnumValues Põlva => EnumValues.Põlva;

        /// <summary>
        /// Pärnu
        /// </summary>
        public static EnumValues Pärnu => EnumValues.Pärnu;

        /// <summary>
        /// Rapla
        /// </summary>
        public static EnumValues Rapla => EnumValues.Rapla;

        /// <summary>
        /// Saare
        /// </summary>
        public static EnumValues Saare => EnumValues.Saare;

        /// <summary>
        /// Tartu
        /// </summary>
        public static EnumValues Tartu => EnumValues.Tartu;

        /// <summary>
        /// Valga
        /// </summary>
        public static EnumValues Valga => EnumValues.Valga;

        /// <summary>
        /// Viljandi
        /// </summary>
        public static EnumValues Viljandi => EnumValues.Viljandi;

        /// <summary>
        /// Võru
        /// </summary>
        public static EnumValues Võru => EnumValues.Võru;

        #endregion

        /// <summary>
        /// Enum values for Estonia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Harju
            /// </summary>
            [AliasInShort("37")]
            Harju,

            /// <summary>
            /// Hiiu
            /// </summary>
            [AliasInShort("39")]
            Hiiu,

            /// <summary>
            /// Ida-Viru
            /// </summary>
            [AliasInShort("44")]
            IdaViru,

            /// <summary>
            /// Jõgeva
            /// </summary>
            [AliasInShort("49")]
            Jõgeva,

            /// <summary>
            /// Järva
            /// </summary>
            [AliasInShort("51")]
            Järva,

            /// <summary>
            /// Lääne
            /// </summary>
            [AliasInShort("57")]
            Lääne,

            /// <summary>
            /// Lääne-Viru
            /// </summary>
            [AliasInShort("59")]
            LääneViru,

            /// <summary>
            /// Põlva
            /// </summary>
            [AliasInShort("65")]
            Põlva,

            /// <summary>
            /// Pärnu
            /// </summary>
            [AliasInShort("67")]
            Pärnu,

            /// <summary>
            /// Rapla
            /// </summary>
            [AliasInShort("70")]
            Rapla,

            /// <summary>
            /// Saare
            /// </summary>
            [AliasInShort("74")]
            Saare,

            /// <summary>
            /// Tartu
            /// </summary>
            [AliasInShort("78")]
            Tartu,

            /// <summary>
            /// Valga
            /// </summary>
            [AliasInShort("82")]
            Valga,

            /// <summary>
            /// Viljandi
            /// </summary>
            [AliasInShort("84")]
            Viljandi,

            /// <summary>
            /// Võru
            /// </summary>
            [AliasInShort("86")]
            Võru,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="EstoniaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="EstoniaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"EE-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Estonia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.EE;
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