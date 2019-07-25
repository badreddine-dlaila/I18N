using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Gabon Regions
    /// </summary>
    public static class GabonRegions
    {
         #region Gets regions

        /// <summary>
        /// Estuaire
        /// </summary>
        public static EnumValues Estuaire => EnumValues.Estuaire;

        /// <summary>
        /// Haut-Ogooué
        /// </summary>
        public static EnumValues HautOgooué => EnumValues.HautOgooué;

        /// <summary>
        /// Moyen-Ogooué
        /// </summary>
        public static EnumValues MoyenOgooué => EnumValues.MoyenOgooué;

        /// <summary>
        /// Ngounié
        /// </summary>
        public static EnumValues Ngounié => EnumValues.Ngounié;

        /// <summary>
        /// Nyanga
        /// </summary>
        public static EnumValues Nyanga => EnumValues.Nyanga;

        /// <summary>
        /// Ogooué-Ivindo
        /// </summary>
        public static EnumValues OgoouéIvindo => EnumValues.OgoouéIvindo;

        /// <summary>
        /// Ogooué-Lolo
        /// </summary>
        public static EnumValues OgoouéLolo => EnumValues.OgoouéLolo;

        /// <summary>
        /// Ogooué-Maritime
        /// </summary>
        public static EnumValues OgoouéMaritime => EnumValues.OgoouéMaritime;

        /// <summary>
        /// Woleu-Ntem
        /// </summary>
        public static EnumValues WoleuNtem => EnumValues.WoleuNtem;

        #endregion

        /// <summary>
        /// Enum values for Gabon regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Estuaire
            /// </summary>
            [AliasInShort("1")]
            Estuaire,

            /// <summary>
            /// Haut-Ogooué
            /// </summary>
            [AliasInShort("2")]
            HautOgooué,

            /// <summary>
            /// Moyen-Ogooué
            /// </summary>
            [AliasInShort("3")]
            MoyenOgooué,

            /// <summary>
            /// Ngounié
            /// </summary>
            [AliasInShort("4")]
            Ngounié,

            /// <summary>
            /// Nyanga
            /// </summary>
            [AliasInShort("5")]
            Nyanga,

            /// <summary>
            /// Ogooué-Ivindo
            /// </summary>
            [AliasInShort("6")]
            OgoouéIvindo,

            /// <summary>
            /// Ogooué-Lolo
            /// </summary>
            [AliasInShort("7")]
            OgoouéLolo,

            /// <summary>
            /// Ogooué-Maritime
            /// </summary>
            [AliasInShort("8")]
            OgoouéMaritime,

            /// <summary>
            /// Woleu-Ntem
            /// </summary>
            [AliasInShort("9")]
            WoleuNtem,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="GabonRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="GabonRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"GA-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Gabon;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.GA;
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