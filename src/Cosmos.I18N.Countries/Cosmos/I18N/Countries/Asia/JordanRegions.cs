using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Jordan Regions
    /// </summary>
    public static class JordanRegions
    {

        #region Gets regions

        /// <summary>
        /// Ajloun
        /// </summary>
        public static EnumValues Ajloun => EnumValues.Ajloun;

        /// <summary>
        /// Amman
        /// </summary>
        public static EnumValues Amman => EnumValues.Amman;

        /// <summary>
        /// Aqaba
        /// </summary>
        public static EnumValues Aqaba => EnumValues.Aqaba;

        /// <summary>
        /// Tafilah
        /// </summary>
        public static EnumValues Tafilah => EnumValues.Tafilah;

        /// <summary>
        /// Zarqa
        /// </summary>
        public static EnumValues Zarqa => EnumValues.Zarqa;

        /// <summary>
        /// Balqa
        /// </summary>
        public static EnumValues Balqa => EnumValues.Balqa;

        /// <summary>
        /// Irbid
        /// </summary>
        public static EnumValues Irbid => EnumValues.Irbid;

        /// <summary>
        /// Jerash
        /// </summary>
        public static EnumValues Jerash => EnumValues.Jerash;

        /// <summary>
        /// Karak
        /// </summary>
        public static EnumValues Karak => EnumValues.Karak;

        /// <summary>
        /// Mafraq
        /// </summary>
        public static EnumValues Mafraq => EnumValues.Mafraq;

        /// <summary>
        /// Madaba
        /// </summary>
        public static EnumValues Madaba => EnumValues.Madaba;

        /// <summary>
        /// Ma’an
        /// </summary>
        public static EnumValues Maan => EnumValues.Maan;

        #endregion

        /// <summary>
        /// Enum values for Jordan regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Ajloun
            /// </summary>
            [AliasInShort("AJ")]
            Ajloun,

            /// <summary>
            /// Amman
            /// </summary>
            [AliasInShort("AM")]
            Amman,

            /// <summary>
            /// Aqaba
            /// </summary>
            [AliasInShort("AQ")]
            Aqaba,

            /// <summary>
            /// Tafilah
            /// </summary>
            [AliasInShort("AT")]
            Tafilah,

            /// <summary>
            /// Zarqa
            /// </summary>
            [AliasInShort("AZ")]
            Zarqa,

            /// <summary>
            /// Balqa
            /// </summary>
            [AliasInShort("BA")]
            Balqa,

            /// <summary>
            /// Irbid
            /// </summary>
            [AliasInShort("IR")]
            Irbid,

            /// <summary>
            /// Jerash
            /// </summary>
            [AliasInShort("JA")]
            Jerash,

            /// <summary>
            /// Karak
            /// </summary>
            [AliasInShort("KA")]
            Karak,

            /// <summary>
            /// Mafraq
            /// </summary>
            [AliasInShort("MA")]
            Mafraq,

            /// <summary>
            /// Madaba
            /// </summary>
            [AliasInShort("MD")]
            Madaba,

            /// <summary>
            /// Ma’an
            /// </summary>
            [AliasInShort("MN")]
            Maan,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="JordanRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="JordanRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"JO-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Jordan;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.JO;
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