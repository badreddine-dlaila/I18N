using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Wallis And Futuna regions
    /// </summary>
    public static class WallisAndFutunaRegions
    {

        #region Gets regions

        /// <summary>
        /// Alo
        /// </summary>
        public static EnumValues Alo => EnumValues.Alo;

        /// <summary>
        /// Sigave
        /// </summary>
        public static EnumValues Sigave => EnumValues.Sigave;

        /// <summary>
        /// Uvea
        /// </summary>
        public static EnumValues Uvea => EnumValues.Uvea;

        #endregion

        /// <summary>
        /// Enum values for Wallis And Futuna regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Alo
            /// </summary>
            [AliasInShort("AL")]
            Alo,

            /// <summary>
            /// Sigave
            /// </summary>
            [AliasInShort("SG")]
            Sigave,

            /// <summary>
            /// Uvea
            /// </summary>
            [AliasInShort("UV")]
            Uvea,

            /// <summary>
            /// Unknown<br />未知
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="WallisAndFutunaRegions.EnumValues"/> to region code likes 'AL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="WallisAndFutunaRegions.EnumValues"/> to full region code likes 'WF-AL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"WF-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.WallisAndFutuna;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.WF;
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