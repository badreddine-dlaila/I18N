using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Tonga regions
    /// </summary>
    public static class TongaRegions
    {

        #region Gets region

        /// <summary>
        /// ʻEua
        /// </summary>
        /// <returns></returns>
        public static EnumValues Eua => EnumValues.Eua;

        /// <summary>
        /// Haʻapai
        /// </summary>
        public static EnumValues HaApai => EnumValues.HaApai;

        /// <summary>
        /// Niuas
        /// </summary>
        public static EnumValues Niuas => EnumValues.Niuas;

        /// <summary>
        /// Tongatapu
        /// </summary>
        public static EnumValues Tongatapu => EnumValues.Tongatapu;

        /// <summary>
        /// Vavaʻu
        /// </summary>
        public static EnumValues VavaU => EnumValues.VavaU;

        #endregion

        /// <summary>
        /// Enum values for Tonga regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// ʻEua
            /// </summary>
            [AliasInShort("01")]
            Eua,

            /// <summary>
            /// Haʻapai
            /// </summary>
            [AliasInShort("02")]
            HaApai,

            /// <summary>
            /// Niuas
            /// </summary>
            [AliasInShort("03")]
            Niuas,

            /// <summary>
            /// Tongatapu
            /// </summary>
            [AliasInShort("04")]
            Tongatapu,

            /// <summary>
            /// Vavaʻu
            /// </summary>
            [AliasInShort("05")]
            VavaU,

            /// <summary>
            /// Unknown<br />未知
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="TongaRegions.EnumValues"/> to region code likes 'MAP'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="TongaRegions.EnumValues"/> to full region code likes 'VU-MAP'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"TO-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Tonga;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.TO;
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