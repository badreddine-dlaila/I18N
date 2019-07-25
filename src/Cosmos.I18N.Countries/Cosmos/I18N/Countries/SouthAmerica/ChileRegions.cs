using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// Chile regions
    /// </summary>
    public static class ChileRegions
    {

        #region Gets regions

        /// <summary>
        /// Aysén
        /// </summary>
        public static EnumValues Aysén => EnumValues.Aysén;

        /// <summary>
        /// Antofagasta
        /// </summary>
        public static EnumValues Antofagasta => EnumValues.Antofagasta;

        /// <summary>
        /// Araucanía
        /// </summary>
        public static EnumValues Araucanía => EnumValues.Araucanía;

        /// <summary>
        /// Atacama
        /// </summary>
        public static EnumValues Atacama => EnumValues.Atacama;

        /// <summary>
        /// Coquimbo
        /// </summary>
        public static EnumValues Coquimbo => EnumValues.Coquimbo;

        /// <summary>
        /// Libertador General Bernardo O’Higgins
        /// </summary>
        public static EnumValues LibertadorGeneralBernardoOHiggins => EnumValues.LibertadorGeneralBernardoOHiggins;

        /// <summary>
        /// Los Lagos
        /// </summary>
        public static EnumValues LosLagos => EnumValues.LosLagos;

        /// <summary>
        /// Los Ríos
        /// </summary>
        public static EnumValues LosRíos => EnumValues.LosRíos;

        /// <summary>
        /// Magallanes Region
        /// </summary>
        public static EnumValues MagallanesRegion => EnumValues.MagallanesRegion;

        /// <summary>
        /// Maule
        /// </summary>
        public static EnumValues Maule => EnumValues.Maule;

        /// <summary>
        /// Santiago Metropolitan
        /// </summary>
        public static EnumValues SantiagoMetropolitan => EnumValues.SantiagoMetropolitan;

        /// <summary>
        /// Valparaíso
        /// </summary>
        public static EnumValues Valparaíso => EnumValues.Valparaíso;

        #endregion

        /// <summary>
        /// Enum values for Chile regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Aysén
            /// </summary>
            [AliasInShort("AI")]
            Aysén,

            /// <summary>
            /// Antofagasta
            /// </summary>
            [AliasInShort("AN")]
            Antofagasta,

            /// <summary>
            /// Araucanía
            /// </summary>
            [AliasInShort("AR")]
            Araucanía,

            /// <summary>
            /// Atacama
            /// </summary>
            [AliasInShort("AT")]
            Atacama,

            /// <summary>
            /// Coquimbo
            /// </summary>
            [AliasInShort("CO")]
            Coquimbo,

            /// <summary>
            /// Libertador General Bernardo O’Higgins
            /// </summary>
            [AliasInShort("LI")]
            LibertadorGeneralBernardoOHiggins,

            /// <summary>
            /// Los Lagos
            /// </summary>
            [AliasInShort("LL")]
            LosLagos,

            /// <summary>
            /// Los Ríos
            /// </summary>
            [AliasInShort("LR")]
            LosRíos,

            /// <summary>
            /// Magallanes Region
            /// </summary>
            [AliasInShort("MA")]
            MagallanesRegion,

            /// <summary>
            /// Maule
            /// </summary>
            [AliasInShort("ML")]
            Maule,

            /// <summary>
            /// Santiago Metropolitan
            /// </summary>
            [AliasInShort("RM")]
            SantiagoMetropolitan,

            /// <summary>
            /// Valparaíso
            /// </summary>
            [AliasInShort("VS")]
            Valparaíso,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="ChileRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="ChileRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"CL-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Chile;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.CL;
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