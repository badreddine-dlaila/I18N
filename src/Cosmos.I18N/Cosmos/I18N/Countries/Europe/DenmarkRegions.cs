using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Denmark regions
    /// </summary>
    public static class DenmarkRegions
    {
           #region Gets regions

        /// <summary>
        /// Northern Denmark
        /// </summary>
        public static EnumValues NorthernDenmark => EnumValues.NorthernDenmark;

        /// <summary>
        /// Central Denmark
        /// </summary>
        public static EnumValues CentralDenmark => EnumValues.CentralDenmark;

        /// <summary>
        /// Southern Denmark
        /// </summary>
        public static EnumValues SouthernDenmark => EnumValues.SouthernDenmark;

        /// <summary>
        /// Capital Region
        /// </summary>
        public static EnumValues CapitalRegion => EnumValues.CapitalRegion;

        /// <summary>
        /// Zealand
        /// </summary>
        public static EnumValues Zealand => EnumValues.Zealand;
        
        #endregion

        /// <summary>
        /// Enum values for Denmark regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Northern Denmark
            /// </summary>
            [AliasInShort("81")]
            NorthernDenmark,

            /// <summary>
            /// Central Denmark
            /// </summary>
            [AliasInShort("82")]
            CentralDenmark,

            /// <summary>
            /// Southern Denmark
            /// </summary>
            [AliasInShort("83")]
            SouthernDenmark,

            /// <summary>
            /// Capital Region
            /// </summary>
            [AliasInShort("84")]
            CapitalRegion,

            /// <summary>
            /// Zealand
            /// </summary>
            [AliasInShort("85")]
            Zealand,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="DenmarkRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="DenmarkRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"DK-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Denmark;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.DK;
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