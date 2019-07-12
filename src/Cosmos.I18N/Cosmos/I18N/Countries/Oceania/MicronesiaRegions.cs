using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Micronesia Regions
    /// </summary>
    public static class MicronesiaRegions
    {
         #region Gets regions

        /// <summary>
        /// Kosrae
        /// </summary>
        public static EnumValues Kosrae => EnumValues.Kosrae;

        /// <summary>
        /// Pohnpei
        /// </summary>
        public static EnumValues Pohnpei => EnumValues.Pohnpei;

        /// <summary>
        /// Chuuk
        /// </summary>
        public static EnumValues Chuuk => EnumValues.Chuuk;

        /// <summary>
        /// Yap
        /// </summary>
        public static EnumValues Yap => EnumValues.Yap;

        #endregion

        /// <summary>
        /// Enum values for Micronesia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Kosrae
            /// </summary>
            [AliasInShort("KSA")]
            Kosrae,

            /// <summary>
            /// Pohnpei
            /// </summary>
            [AliasInShort("PNI")]
            Pohnpei,

            /// <summary>
            /// Chuuk
            /// </summary>
            [AliasInShort("TRK")]
            Chuuk,

            /// <summary>
            /// Yap
            /// </summary>
            [AliasInShort("YAP")]
            Yap,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="MicronesiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="MicronesiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"FM-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Micronesia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.FM;
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