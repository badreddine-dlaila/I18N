using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// SaoTomeAndPrincipe Regions
    /// </summary>
    public static class SaoTomeAndPrincipeRegions
    {
         #region Gets regions

        /// <summary>
        /// Príncipe
        /// </summary>
        public static EnumValues Príncipe => EnumValues.Príncipe;

        /// <summary>
        /// São Tomé
        /// </summary>
        public static EnumValues SãoTomé => EnumValues.SãoTomé;

        #endregion

        /// <summary>
        /// Enum values for SaoTomeAndPrincipe regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Príncipe
            /// </summary>
            [AliasInShort("P")]
            Príncipe,

            /// <summary>
            /// São Tomé
            /// </summary>
            [AliasInShort("S")]
            SãoTomé,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SaoTomeAndPrincipeRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SaoTomeAndPrincipeRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"ST-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.SaoTomeAndPrincipe;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.ST;
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