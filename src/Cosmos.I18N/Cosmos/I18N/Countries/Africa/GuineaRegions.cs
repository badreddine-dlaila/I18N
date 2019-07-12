using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Guinea Regions
    /// </summary>
    public static class GuineaRegions
    {

        #region Gets regions

        /// <summary>
        /// Boké Region
        /// </summary>
        public static EnumValues BokéRegion => EnumValues.BokéRegion;

        /// <summary>
        /// Conakry
        /// </summary>
        public static EnumValues Conakry => EnumValues.Conakry;

        /// <summary>
        /// Kindia Region
        /// </summary>
        public static EnumValues KindiaRegion => EnumValues.KindiaRegion;

        /// <summary>
        /// Faranah Region
        /// </summary>
        public static EnumValues FaranahRegion => EnumValues.FaranahRegion;

        /// <summary>
        /// Kankan Region
        /// </summary>
        public static EnumValues KankanRegion => EnumValues.KankanRegion;

        /// <summary>
        /// Labé Region
        /// </summary>
        public static EnumValues LabéRegion => EnumValues.LabéRegion;

        /// <summary>
        /// Ogooué-Lolo
        /// </summary>
        public static EnumValues MamouRegion => EnumValues.MamouRegion;

        /// <summary>
        /// Nzérékoré Region
        /// </summary>
        public static EnumValues NzérékoréRegion => EnumValues.NzérékoréRegion;

        #endregion

        /// <summary>
        /// Enum values for Guinea regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Boké Region
            /// </summary>
            [AliasInShort("B")]
            BokéRegion,

            /// <summary>
            /// Conakry
            /// </summary>
            [AliasInShort("C")]
            Conakry,

            /// <summary>
            /// Kindia Region
            /// </summary>
            [AliasInShort("D")]
            KindiaRegion,

            /// <summary>
            /// Faranah Region
            /// </summary>
            [AliasInShort("F")]
            FaranahRegion,

            /// <summary>
            /// Kankan Region
            /// </summary>
            [AliasInShort("K")]
            KankanRegion,

            /// <summary>
            /// Labé Region
            /// </summary>
            [AliasInShort("L")]
            LabéRegion,

            /// <summary>
            /// Mamou Region
            /// </summary>
            [AliasInShort("M")]
            MamouRegion,

            /// <summary>
            /// Nzérékoré Region
            /// </summary>
            [AliasInShort("N")]
            NzérékoréRegion,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="GuineaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="GuineaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"GN-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Guinea;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.GN;
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