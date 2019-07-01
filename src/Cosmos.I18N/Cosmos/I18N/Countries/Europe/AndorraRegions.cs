using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Andorra Regions
    /// </summary>
    public static class AndorraRegions
    {

        #region Gets regions

        /// <summary>
        /// Andorra la Vella
        /// </summary>
        public static EnumValues AndorraLaVella => EnumValues.AndorraLaVella;

        /// <summary>
        /// Canillo
        /// </summary>
        public static EnumValues Canillo => EnumValues.Canillo;

        /// <summary>
        /// Massana
        /// </summary>
        public static EnumValues Massana => EnumValues.Massana;

        /// <summary>
        /// Sant Julia de Loria
        /// </summary>
        public static EnumValues SantJuliaDeLoria => EnumValues.SantJuliaDeLoria;

        /// <summary>
        /// Encamp
        /// </summary>
        public static EnumValues Encamp => EnumValues.Encamp;

        /// <summary>
        /// Les Escaldes-Engordany
        /// </summary>
        public static EnumValues LesEscaldesEngordany => EnumValues.LesEscaldesEngordany;

        /// <summary>
        /// Ordino
        /// </summary>
        public static EnumValues Ordino => EnumValues.Ordino;

        #endregion

        /// <summary>
        /// Enum values for Andorra regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Andorra la Vella
            /// </summary>
            [AliasInShort("07")]
            AndorraLaVella,
            
            /// <summary>
            /// Canillo
            /// </summary>
            [AliasInShort("02")]
            Canillo,
            
            /// <summary>
            /// Massana
            /// </summary>
            [AliasInShort("04")]
            Massana,
            
            /// <summary>
            /// Sant Julia de Loria
            /// </summary>
            [AliasInShort("06")]
            SantJuliaDeLoria,
            
            /// <summary>
            /// Encamp
            /// </summary>
            [AliasInShort("03")]
            Encamp,
            
            /// <summary>
            /// Les Escaldes-Engordany
            /// </summary>
            [AliasInShort("01")]
            LesEscaldesEngordany,
            
            /// <summary>
            /// Ordino
            /// </summary>
            [AliasInShort("05")]
            Ordino,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="AndorraRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="AndorraRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"AD-{values.ToRegionCode()}";
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