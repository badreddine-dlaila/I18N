using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Niger Regions
    /// </summary>
    public static class NigerRegions
    {

        #region Gets regions

        /// <summary>
        /// Agadez
        /// </summary>
        public static EnumValues Agadez => EnumValues.Agadez;

        /// <summary>
        /// Diffa
        /// </summary>
        public static EnumValues Diffa => EnumValues.Diffa;

        /// <summary>
        /// Dosso
        /// </summary>
        public static EnumValues Dosso => EnumValues.Dosso;

        /// <summary>
        /// Maradi
        /// </summary>
        public static EnumValues Maradi => EnumValues.Maradi;

        /// <summary>
        /// Tahoua
        /// </summary>
        public static EnumValues Tahoua => EnumValues.Tahoua;

        /// <summary>
        /// Tillabéri
        /// </summary>
        public static EnumValues Tillabéri => EnumValues.Tillabéri;

        /// <summary>
        /// Zinder
        /// </summary>
        public static EnumValues Zinder => EnumValues.Zinder;

        /// <summary>
        /// Niamey   
        /// </summary>
        public static EnumValues Niamey => EnumValues.Niamey;

        #endregion

        /// <summary>
        /// Enum values for Niger regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Agadez
            /// </summary>
            [AliasInShort("1")]
            Agadez,

            /// <summary>
            /// Diffa
            /// </summary>
            [AliasInShort("2")]
            Diffa,

            /// <summary>
            /// Dosso
            /// </summary>
            [AliasInShort("3")]
            Dosso,

            /// <summary>
            /// Maradi
            /// </summary>
            [AliasInShort("4")]
            Maradi,

            /// <summary>
            /// Tahoua
            /// </summary>
            [AliasInShort("5")]
            Tahoua,

            /// <summary>
            /// Tillabéri
            /// </summary>
            [AliasInShort("6")]
            Tillabéri,

            /// <summary>
            /// Zinder
            /// </summary>
            [AliasInShort("7")]
            Zinder,

            /// <summary>
            /// Niamey
            /// </summary>
            [AliasInShort("8")]
            Niamey,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="NigerRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="NigerRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"NE-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Niger;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.NE;
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