using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Eritrea regions
    /// </summary>
    public static class EritreaRegions
    {
                #region Gets regions

        /// <summary>
        /// Anseba
        /// </summary>
        public static EnumValues Anseba => EnumValues.Anseba;

        /// <summary>
        /// Southern Red Sea
        /// </summary>
        public static EnumValues SouthernRedSea => EnumValues.SouthernRedSea;

        /// <summary>
        /// Debub
        /// </summary>
        public static EnumValues Debub => EnumValues.Debub;

        /// <summary>
        /// Gash-Barka
        /// </summary>
        public static EnumValues GashBarka => EnumValues.GashBarka;

        /// <summary>
        /// Maekel
        /// </summary>
        public static EnumValues Maekel => EnumValues.Maekel;

        /// <summary>
        /// Northern Red Sea
        /// </summary>
        public static EnumValues NorthernRedSea => EnumValues.NorthernRedSea;

        #endregion

        /// <summary>
        /// Enum values for Eritrea regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Anseba
            /// </summary>
            [AliasInShort("AN")]
            Anseba,

            /// <summary>
            /// Southern Red Sea
            /// </summary>
            [AliasInShort("DX")]
            SouthernRedSea,

            /// <summary>
            /// Debub
            /// </summary>
            [AliasInShort("DU")]
            Debub,

            /// <summary>
            /// Gash-Barka
            /// </summary>
            [AliasInShort("GB")]
            GashBarka,

            /// <summary>
            /// Maekel
            /// </summary>
            [AliasInShort("MA")]
            Maekel,

            /// <summary>
            /// Northern Red Sea
            /// </summary>
            [AliasInShort("SK")]
            NorthernRedSea,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="EritreaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="EritreaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"ER-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Eritrea;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.ER;
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