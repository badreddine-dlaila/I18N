using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// SanMarino Regions
    /// </summary>
    public static class SanMarinoRegions
    {
            #region Gets regions

        /// <summary>
        /// Acquaviva
        /// </summary>
        public static EnumValues Acquaviva => EnumValues.Acquaviva;

        /// <summary>
        /// Chiesanuova
        /// </summary>
        public static EnumValues Chiesanuova => EnumValues.Chiesanuova;

        /// <summary>
        /// Domagnano
        /// </summary>
        public static EnumValues Domagnano => EnumValues.Domagnano;

        /// <summary>
        /// Faetano
        /// </summary>
        public static EnumValues Faetano => EnumValues.Faetano;

        /// <summary>
        /// Fiorentino
        /// </summary>
        public static EnumValues Fiorentino => EnumValues.Fiorentino;

        /// <summary>
        /// Borgo Maggiore
        /// </summary>
        public static EnumValues BorgoMaggiore => EnumValues.BorgoMaggiore;

        /// <summary>
        /// San Marino
        /// </summary>
        public static EnumValues SanMarino => EnumValues.SanMarino;

        /// <summary>
        /// Montegiardino 
        /// </summary>
        public static EnumValues Montegiardino => EnumValues.Montegiardino;

        /// <summary>
        /// Serravalle
        /// </summary>
        public static EnumValues Serravalle => EnumValues.Serravalle;

        #endregion

        /// <summary>
        /// Enum values for SanMarino regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Acquaviva
            /// </summary>
            [AliasInShort("01")]
            Acquaviva,

            /// <summary>
            /// Chiesanuova
            /// </summary>
            [AliasInShort("02")]
            Chiesanuova,

            /// <summary>
            /// Domagnano
            /// </summary>
            [AliasInShort("03")]
            Domagnano,

            /// <summary>
            /// Faetano
            /// </summary>
            [AliasInShort("04")]
            Faetano,

            /// <summary>
            /// Fiorentino
            /// </summary>
            [AliasInShort("05")]
            Fiorentino,

            /// <summary>
            /// Borgo Maggiore
            /// </summary>
            [AliasInShort("06")]
            BorgoMaggiore,

            /// <summary>
            /// San Marino
            /// </summary>
            [AliasInShort("07")]
            SanMarino,

            /// <summary>
            /// Montegiardino
            /// </summary>
            [AliasInShort("08")]
            Montegiardino,

            /// <summary>
            /// Serravalle
            /// </summary>
            [AliasInShort("09")]
            Serravalle,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SanMarinoRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SanMarinoRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"SM-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.SanMarino;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.SM;
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