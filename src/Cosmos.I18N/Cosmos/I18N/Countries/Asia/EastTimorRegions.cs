using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// EastTimor Regions
    /// </summary>
    public static class EastTimorRegions
    {

        #region Gets regions

        /// <summary>
        /// Aileu
        /// </summary>
        public static EnumValues Aileu => EnumValues.Aileu;

        /// <summary>
        /// Ainaro
        /// </summary>
        public static EnumValues Ainaro => EnumValues.Ainaro;

        /// <summary>
        /// Baucau
        /// </summary>
        public static EnumValues Baucau => EnumValues.Baucau;

        /// <summary>
        /// Bobonaro
        /// </summary>
        public static EnumValues Bobonaro => EnumValues.Bobonaro;

        /// <summary>
        /// Cova Lima
        /// </summary>
        public static EnumValues CovaLima => EnumValues.CovaLima;

        /// <summary>
        /// Dili
        /// </summary>
        public static EnumValues Dili => EnumValues.Dili;

        /// <summary>
        /// Ermera
        /// </summary>
        public static EnumValues Ermera => EnumValues.Ermera;

        /// <summary>
        /// Lautém
        /// </summary>
        public static EnumValues Lautém => EnumValues.Lautém;

        /// <summary>
        /// Liquiçá
        /// </summary>
        public static EnumValues Liquiçá => EnumValues.Liquiçá;

        /// <summary>
        /// Manufahi
        /// </summary>
        public static EnumValues Manufahi => EnumValues.Manufahi;

        /// <summary>
        /// Manatuto
        /// </summary>
        public static EnumValues Manatuto => EnumValues.Manatuto;

        /// <summary>
        /// Oecusse
        /// </summary>
        public static EnumValues Oecusse => EnumValues.Oecusse;

        /// <summary>
        /// Viqueque
        /// </summary>
        public static EnumValues Viqueque => EnumValues.Viqueque;

        #endregion

        /// <summary>
        /// Enum values for EastTimor regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Aileu
            /// </summary>
            [AliasInShort("AL")]
            Aileu,

            /// <summary>
            /// Ainaro
            /// </summary>
            [AliasInShort("AN")]
            Ainaro,

            /// <summary>
            /// Baucau
            /// </summary>
            [AliasInShort("BA")]
            Baucau,

            /// <summary>
            /// Bobonaro
            /// </summary>
            [AliasInShort("BO")]
            Bobonaro,

            /// <summary>
            /// Cova Lima
            /// </summary>
            [AliasInShort("CO")]
            CovaLima,

            /// <summary>
            /// Dili
            /// </summary>
            [AliasInShort("DI")]
            Dili,

            /// <summary>
            /// Ermera
            /// </summary>
            [AliasInShort("ER")]
            Ermera,

            /// <summary>
            /// Lautém
            /// </summary>
            [AliasInShort("LA")]
            Lautém,

            /// <summary>
            /// Liquiçá
            /// </summary>
            [AliasInShort("LI")]
            Liquiçá,

            /// <summary>
            /// Manufahi
            /// </summary>
            [AliasInShort("MF")]
            Manufahi,

            /// <summary>
            /// Manatuto
            /// </summary>
            [AliasInShort("MT")]
            Manatuto,

            /// <summary>
            /// Oecusse
            /// </summary>
            [AliasInShort("OE")]
            Oecusse,

            /// <summary>
            /// Viqueque
            /// </summary>
            [AliasInShort("VI")]
            Viqueque,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="EastTimorRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="EastTimorRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"TL-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.EastTimor;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.TL;
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