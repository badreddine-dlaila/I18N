using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Swaziland Regions
    /// </summary>
    public static class SwazilandRegions
    {
            #region Gets regions

        /// <summary>
        /// Hhohho
        /// </summary>
        public static EnumValues Hhohho => EnumValues.Hhohho;

        /// <summary>
        /// Lubombo
        /// </summary>
        public static EnumValues Lubombo => EnumValues.Lubombo;

        /// <summary>
        /// Manzini
        /// </summary>
        public static EnumValues Manzini => EnumValues.Manzini;

        /// <summary>
        /// Shiselweni
        /// </summary>
        public static EnumValues Shiselweni => EnumValues.Shiselweni;

        #endregion

        /// <summary>
        /// Enum values for Swaziland regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Hhohho
            /// </summary>
            [AliasInShort("HH")]
            Hhohho,

            /// <summary>
            /// Lubombo
            /// </summary>
            [AliasInShort("LU")]
            Lubombo,

            /// <summary>
            /// Manzini
            /// </summary>
            [AliasInShort("MA")]
            Manzini,

            /// <summary>
            /// Shiselweni
            /// </summary>
            [AliasInShort("SH")]
            Shiselweni,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SwazilandRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SwazilandRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"SZ-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Swaziland;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.SZ;
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