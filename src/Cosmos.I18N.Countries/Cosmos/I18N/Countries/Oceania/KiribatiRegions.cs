using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Kiribati Regions
    /// </summary>
    public static class KiribatiRegions
    {

        #region Gets regions

        /// <summary>
        /// Gilbert Islands
        /// </summary>
        public static EnumValues GilbertIslands => EnumValues.GilbertIslands;

        /// <summary>
        /// Line Islands
        /// </summary>
        public static EnumValues LineIslands => EnumValues.LineIslands;

        /// <summary>
        /// Phoenix Islands
        /// </summary>
        public static EnumValues PhoenixIslands => EnumValues.PhoenixIslands;

        #endregion

        /// <summary>
        /// Enum values for Kiribati regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Gilbert Islands
            /// </summary>
            [AliasInShort("G")]
            GilbertIslands,

            /// <summary>
            /// Line Islands
            /// </summary>
            [AliasInShort("L")]
            LineIslands,

            /// <summary>
            /// Phoenix Islands
            /// </summary>
            [AliasInShort("P")]
            PhoenixIslands,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="KiribatiRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="KiribatiRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"KI-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Kiribati;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.KI;
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