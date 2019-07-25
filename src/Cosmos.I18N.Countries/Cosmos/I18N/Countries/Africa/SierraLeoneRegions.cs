using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Sierra Leone Regions
    /// </summary>
    public static class SierraLeoneRegions
    {

        #region Gets region

        /// <summary>
        /// Eastern
        /// </summary>
        public static EnumValues Eastern => EnumValues.Eastern;

        /// <summary>
        /// Northern
        /// </summary>
        public static EnumValues Northern => EnumValues.Northern;

        /// <summary>
        /// Southern
        /// </summary>
        public static EnumValues Southern => EnumValues.Southern;

        /// <summary>
        /// Western Area
        /// </summary>
        public static EnumValues WesternArea => EnumValues.WesternArea;

        #endregion

        /// <summary>
        /// Enum values for Sierra Leone regions
        /// </summary>
        public enum EnumValues
        {
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
            /// Southern
            /// </summary>
            [AliasInShort("S")]
            Southern,

            /// <summary>
            /// Western Area
            /// </summary>
            [AliasInShort("W")]
            WesternArea,

            /// <summary>
            /// Unknown<br />未知
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SierraLeoneRegions.EnumValues"/> to region code likes 'MAP'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SierraLeoneRegions.EnumValues"/> to full region code likes 'VU-MAP'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"SL-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.SierraLeone;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.SL;
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