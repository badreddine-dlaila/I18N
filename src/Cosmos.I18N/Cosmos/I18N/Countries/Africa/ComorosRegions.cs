using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Comoros Regions
    /// </summary>
    public static class ComorosRegions
    {
           #region Gets regions

        /// <summary>
        /// Anjouan
        /// </summary>
        public static EnumValues Anjouan => EnumValues.Anjouan;

        /// <summary>
        /// Grande Comore
        /// </summary>
        public static EnumValues GrandeComore => EnumValues.GrandeComore;

        /// <summary>
        /// Mohéli
        /// </summary>
        public static EnumValues Mohéli => EnumValues.Mohéli;

        #endregion

        /// <summary>
        /// Enum values for Comoros regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Gilbert Islands
            /// </summary>
            [AliasInShort("A")]
            Anjouan,

            /// <summary>
            /// Grande Comore
            /// </summary>
            [AliasInShort("G")]
            GrandeComore,

            /// <summary>
            /// Mohéli
            /// </summary>
            [AliasInShort("M")]
            Mohéli,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="ComorosRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="ComorosRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"KM-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Comoros;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.KM;
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