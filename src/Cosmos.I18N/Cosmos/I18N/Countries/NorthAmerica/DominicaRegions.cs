using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// Dominica regions
    /// </summary>
    public static class DominicaRegions
    {
             #region Gets regions

        /// <summary>
        /// Saint Andrew
        /// </summary>
        public static EnumValues SaintAndrew => EnumValues.SaintAndrew;

        /// <summary>
        /// Saint David
        /// </summary>
        public static EnumValues SaintDavid => EnumValues.SaintDavid;

        /// <summary>
        /// Saint George
        /// </summary>
        public static EnumValues SaintGeorge => EnumValues.SaintGeorge;

        /// <summary>
        /// Saint John
        /// </summary>
        public static EnumValues SaintJohn => EnumValues.SaintJohn;

        /// <summary>
        /// Saint Joseph
        /// </summary>
        public static EnumValues SaintJoseph => EnumValues.SaintJoseph;

        /// <summary>
        /// Saint Luke
        /// </summary>
        public static EnumValues SaintLuke => EnumValues.SaintLuke;

        /// <summary>
        /// Saint Mark
        /// </summary>
        public static EnumValues SaintMark => EnumValues.SaintMark;

        /// <summary>
        /// Saint Patrick
        /// </summary>
        public static EnumValues SaintPatrick => EnumValues.SaintPatrick;

        /// <summary>
        /// Saint Paul
        /// </summary>
        public static EnumValues SaintPaul => EnumValues.SaintPaul;

        /// <summary>
        /// Saint Peter
        /// </summary>
        public static EnumValues SaintPeter => EnumValues.SaintPeter;

        #endregion

        /// <summary>
        /// Enum values for Dominica regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Saint Andrew
            /// </summary>
            [AliasInShort("02")]
            SaintAndrew,

            /// <summary>
            /// Saint David
            /// </summary>
            [AliasInShort("03")]
            SaintDavid,

            /// <summary>
            /// Saint George
            /// </summary>
            [AliasInShort("04")]
            SaintGeorge,

            /// <summary>
            /// Saint John
            /// </summary>
            [AliasInShort("05")]
            SaintJohn,

            /// <summary>
            /// Saint Joseph
            /// </summary>
            [AliasInShort("06")]
            SaintJoseph,

            /// <summary>
            /// Saint Luke
            /// </summary>
            [AliasInShort("07")]
            SaintLuke,

            /// <summary>
            /// Saint Mark
            /// </summary>
            [AliasInShort("08")]
            SaintMark,

            /// <summary>
            /// Saint Patrick
            /// </summary>
            [AliasInShort("09")]
            SaintPatrick,

            /// <summary>
            /// Saint Paul
            /// </summary>
            [AliasInShort("10")]
            SaintPaul,

            /// <summary>
            /// Saint Peter
            /// </summary>
            [AliasInShort("11")]
            SaintPeter,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="DominicaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="DominicaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"DM-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Dominica;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.DM;
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