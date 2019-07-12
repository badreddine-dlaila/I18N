using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Tajikistan Regions
    /// </summary>
    public static class TajikistanRegions
    {

        #region Gets regions

        /// <summary>
        /// Dushanbe
        /// </summary>
        public static EnumValues Dushanbe => EnumValues.Dushanbe;

        /// <summary>
        /// Gorno-Badakhshan
        /// </summary>
        public static EnumValues GornoBadakhshan => EnumValues.GornoBadakhshan;

        /// <summary>
        /// Khatlon
        /// </summary>
        public static EnumValues Khatlon => EnumValues.Khatlon;

        /// <summary>
        /// Sughd
        /// </summary>
        public static EnumValues Sughd => EnumValues.Sughd;

        #endregion

        /// <summary>
        /// Enum values for Tajikistan regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Dushanbe
            /// </summary>
            [AliasInShort("DU")]
            Dushanbe,

            /// <summary>
            /// Gorno-Badakhshan
            /// </summary>
            [AliasInShort("GB")]
            GornoBadakhshan,

            /// <summary>
            /// Khatlon
            /// </summary>
            [AliasInShort("KT")]
            Khatlon,

            /// <summary>
            /// Sughd
            /// </summary>
            [AliasInShort("SU")]
            Sughd,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="TajikistanRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="TajikistanRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"TJ-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Tajikistan;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.TJ;
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