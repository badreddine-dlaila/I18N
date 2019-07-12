using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Brunei Regions
    /// </summary>
    public static class BruneiRegions
    {

        #region Gets regions

        /// <summary>
        /// Belait
        /// </summary>
        public static EnumValues Belait => EnumValues.Belait;

        /// <summary>
        /// Brunei-Muara
        /// </summary>
        public static EnumValues BruneiMuara => EnumValues.BruneiMuara;

        /// <summary>
        /// Temburong
        /// </summary>
        public static EnumValues Temburong => EnumValues.Temburong;

        /// <summary>
        /// Tutong
        /// </summary>
        public static EnumValues Tutong => EnumValues.Tutong;

        #endregion

        /// <summary>
        /// Enum values for Brunei regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Belait
            /// </summary>
            [AliasInShort("BE")]
            Belait,

            /// <summary>
            /// Brunei-Muara
            /// </summary>
            [AliasInShort("BM")]
            BruneiMuara,

            /// <summary>
            /// Temburong
            /// </summary>
            [AliasInShort("TE")]
            Temburong,

            /// <summary>
            /// Tutong
            /// </summary>
            [AliasInShort("TU")]
            Tutong,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BruneiRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BruneiRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"BN-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Brunei;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.BN;
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