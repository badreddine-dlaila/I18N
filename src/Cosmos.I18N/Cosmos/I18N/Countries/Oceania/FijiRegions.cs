using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Fiji Regions
    /// </summary>
    public static class FijiRegions
    {

        #region Gets regions

        /// <summary>
        /// Namosi
        /// </summary>
        public static EnumValues Namosi => EnumValues.Namosi;

        /// <summary>
        /// Ra
        /// </summary>
        public static EnumValues Ra => EnumValues.Ra;

        /// <summary>
        /// Rewa
        /// </summary>
        public static EnumValues Rewa => EnumValues.Rewa;

        /// <summary>
        /// Serua
        /// </summary>
        public static EnumValues Serua => EnumValues.Serua;

        /// <summary>
        /// Tailevu
        /// </summary>
        public static EnumValues Tailevu => EnumValues.Tailevu;

        /// <summary>
        /// Ba
        /// </summary>
        public static EnumValues Ba => EnumValues.Ba;

        /// <summary>
        /// Bua
        /// </summary>
        public static EnumValues Bua => EnumValues.Bua;

        /// <summary>
        /// Cakaudrove
        /// </summary>
        public static EnumValues Cakaudrove => EnumValues.Cakaudrove;

        /// <summary>
        /// Kadavu
        /// </summary>
        public static EnumValues Kadavu => EnumValues.Kadavu;

        /// <summary>
        /// Lau
        /// </summary>
        public static EnumValues Lau => EnumValues.Lau;

        /// <summary>
        /// Lomaiviti
        /// </summary>
        public static EnumValues Lomaiviti => EnumValues.Lomaiviti;

        /// <summary>
        /// Valparaíso
        /// </summary>
        public static EnumValues Macuata => EnumValues.Macuata;

        /// <summary>
        /// Nadroga-Navosa
        /// </summary>
        public static EnumValues NadrogaNavosa => EnumValues.NadrogaNavosa;

        /// <summary>
        /// Naitasiri
        /// </summary>
        public static EnumValues Naitasiri => EnumValues.Naitasiri;

        /// <summary>
        /// Central
        /// </summary>
        public static EnumValues Central => EnumValues.Central;

        /// <summary>
        /// Eastern
        /// </summary>
        public static EnumValues Eastern => EnumValues.Eastern;

        /// <summary>
        /// Northern
        /// </summary>
        public static EnumValues Northern => EnumValues.Northern;

        /// <summary>
        /// Rotuma
        /// </summary>
        public static EnumValues Rotuma => EnumValues.Rotuma;

        /// <summary>
        /// Western
        /// </summary>
        public static EnumValues Western => EnumValues.Western;

        #endregion

        /// <summary>
        /// Enum values for Fiji regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Namosi
            /// </summary>
            [AliasInShort("10")]
            Namosi,

            /// <summary>
            /// Ra
            /// </summary>
            [AliasInShort("11")]
            Ra,

            /// <summary>
            /// Rewa
            /// </summary>
            [AliasInShort("12")]
            Rewa,

            /// <summary>
            /// Serua
            /// </summary>
            [AliasInShort("13")]
            Serua,

            /// <summary>
            /// Tailevu
            /// </summary>
            [AliasInShort("14")]
            Tailevu,

            /// <summary>
            /// Ba
            /// </summary>
            [AliasInShort("01")]
            Ba,

            /// <summary>
            /// Bua
            /// </summary>
            [AliasInShort("02")]
            Bua,

            /// <summary>
            /// Cakaudrove
            /// </summary>
            [AliasInShort("03")]
            Cakaudrove,

            /// <summary>
            /// Kadavu
            /// </summary>
            [AliasInShort("04")]
            Kadavu,

            /// <summary>
            /// Lau
            /// </summary>
            [AliasInShort("05")]
            Lau,

            /// <summary>
            /// Lomaiviti
            /// </summary>
            [AliasInShort("06")]
            Lomaiviti,

            /// <summary>
            /// Macuata
            /// </summary>
            [AliasInShort("07")]
            Macuata,

            /// <summary>
            /// Nadroga-Navosa
            /// </summary>
            [AliasInShort("08")]
            NadrogaNavosa,

            /// <summary>
            /// Naitasiri
            /// </summary>
            [AliasInShort("09")]
            Naitasiri,

            /// <summary>
            /// Central
            /// </summary>
            [AliasInShort("C")]
            Central,

            /// <summary>
            /// Eastern
            /// </summary>
            [AliasInShort("E")]
            Eastern,

            /// <summary>
            /// Northern
            /// </summary>
            [AliasInShort("N")]
            Northern,

            /// <summary>
            /// Rotuma
            /// </summary>
            [AliasInShort("R")]
            Rotuma,

            /// <summary>
            /// Western
            /// </summary>
            [AliasInShort("W")]
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
        /// Convert <see cref="FijiRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="FijiRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"FJ-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Fiji;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.FJ;
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