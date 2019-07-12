using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Malaysia Regions
    /// </summary>
    public static class MalaysiaRegions
    {
            #region Gets regions

        /// <summary>
        /// Selangor
        /// </summary>
        public static EnumValues Selangor => EnumValues.Selangor;

        /// <summary>
        /// Terengganu
        /// </summary>
        public static EnumValues Terengganu => EnumValues.Terengganu;

        /// <summary>
        /// Sabah
        /// </summary>
        public static EnumValues Sabah => EnumValues.Sabah;

        /// <summary>
        /// Sarawak
        /// </summary>
        public static EnumValues Sarawak => EnumValues.Sarawak;

        /// <summary>
        /// Kuala Lumpur
        /// </summary>
        public static EnumValues KualaLumpur => EnumValues.KualaLumpur;

        /// <summary>
        /// Labuan
        /// </summary>
        public static EnumValues Labuan => EnumValues.Labuan;

        /// <summary>
        /// Putrajaya
        /// </summary>
        public static EnumValues Putrajaya => EnumValues.Putrajaya;

        /// <summary>
        /// Johor   
        /// </summary>
        public static EnumValues Johor => EnumValues.Johor;

        /// <summary>
        /// Kedah
        /// </summary>
        public static EnumValues Kedah => EnumValues.Kedah;

        /// <summary>
        /// Kelantan
        /// </summary>
        public static EnumValues Kelantan => EnumValues.Kelantan;

        /// <summary>
        /// Malacca
        /// </summary>
        public static EnumValues Malacca => EnumValues.Malacca;

        /// <summary>
        /// Negeri Sembilan
        /// </summary>
        public static EnumValues NegeriSembilan => EnumValues.NegeriSembilan;

        /// <summary>
        /// Pahang
        /// </summary>
        public static EnumValues Pahang => EnumValues.Pahang;

        /// <summary>
        /// Penang
        /// </summary>
        public static EnumValues Penang => EnumValues.Penang;

        /// <summary>
        /// Perak
        /// </summary>
        public static EnumValues Perak => EnumValues.Perak;

        /// <summary>
        /// Perlis
        /// </summary>
        public static EnumValues Perlis => EnumValues.Perlis;

        #endregion

        /// <summary>
        /// Enum values for Malaysia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Selangor
            /// </summary>
            [AliasInShort("10")]
            Selangor,

            /// <summary>
            /// Terengganu
            /// </summary>
            [AliasInShort("11")]
            Terengganu,

            /// <summary>
            /// Sabah
            /// </summary>
            [AliasInShort("12")]
            Sabah,

            /// <summary>
            /// Sarawak
            /// </summary>
            [AliasInShort("13")]
            Sarawak,

            /// <summary>
            /// Kuala Lumpur
            /// </summary>
            [AliasInShort("14")]
            KualaLumpur,

            /// <summary>
            /// Labuan
            /// </summary>
            [AliasInShort("15")]
            Labuan,

            /// <summary>
            /// Putrajaya
            /// </summary>
            [AliasInShort("16")]
            Putrajaya,

            /// <summary>
            /// Johor
            /// </summary>
            [AliasInShort("01")]
            Johor,

            /// <summary>
            /// Kedah
            /// </summary>
            [AliasInShort("02")]
            Kedah,

            /// <summary>
            /// Kelantan
            /// </summary>
            [AliasInShort("03")]
            Kelantan,

            /// <summary>
            /// Malacca
            /// </summary>
            [AliasInShort("04")]
            Malacca,

            /// <summary>
            /// Negeri Sembilan
            /// </summary>
            [AliasInShort("05")]
            NegeriSembilan,

            /// <summary>
            /// Pahang
            /// </summary>
            [AliasInShort("06")]
            Pahang,

            /// <summary>
            /// Penang
            /// </summary>
            [AliasInShort("07")]
            Penang,

            /// <summary>
            /// Perak
            /// </summary>
            [AliasInShort("08")]
            Perak,

            /// <summary>
            /// Perlis
            /// </summary>
            [AliasInShort("09")]
            Perlis,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="MalaysiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="MalaysiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"MY-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Malaysia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.MY;
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