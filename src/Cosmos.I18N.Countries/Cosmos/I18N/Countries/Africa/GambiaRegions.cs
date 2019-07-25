using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Gambia Regions
    /// </summary>
    public static class GambiaRegions
    {

        #region Gets regions

        /// <summary>
        /// Banjul
        /// </summary>
        public static EnumValues Banjul => EnumValues.Banjul;

        /// <summary>
        /// Lower River Division
        /// </summary>
        public static EnumValues LowerRiverDivision => EnumValues.LowerRiverDivision;

        /// <summary>
        /// Central River Division
        /// </summary>
        public static EnumValues CentralRiverDivision => EnumValues.CentralRiverDivision;

        /// <summary>
        /// North Bank Division
        /// </summary>
        public static EnumValues NorthBankDivision => EnumValues.NorthBankDivision;

        /// <summary>
        /// Upper River Division
        /// </summary>
        public static EnumValues UpperRiverDivision => EnumValues.UpperRiverDivision;

        /// <summary>
        /// West Coast Division
        /// </summary>
        public static EnumValues WestCoastDivision => EnumValues.WestCoastDivision;

        #endregion

        /// <summary>
        /// Enum values for Gambia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Banjul
            /// </summary>
            [AliasInShort("B")]
            Banjul,

            /// <summary>
            /// Lower River Division
            /// </summary>
            [AliasInShort("L")]
            LowerRiverDivision,

            /// <summary>
            /// Central River Division
            /// </summary>
            [AliasInShort("M")]
            CentralRiverDivision,

            /// <summary>
            /// North Bank Division
            /// </summary>
            [AliasInShort("N")]
            NorthBankDivision,

            /// <summary>
            /// Upper River Division
            /// </summary>
            [AliasInShort("U")]
            UpperRiverDivision,

            /// <summary>
            /// West Coast Division
            /// </summary>
            [AliasInShort("W")]
            WestCoastDivision,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="GambiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="GambiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"GM-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Gambia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.GM;
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