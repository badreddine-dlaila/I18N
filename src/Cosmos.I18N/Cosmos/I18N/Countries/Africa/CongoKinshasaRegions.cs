using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Congo Kinshasa regions
    /// </summary>
    public static class CongoKinshasaRegions
    {

        #region Gets regions

        /// <summary>
        /// Bas-Congo
        /// </summary>
        public static EnumValues BasCongo => EnumValues.BasCongo;

        /// <summary>
        /// Bandundu
        /// </summary>
        public static EnumValues Bandundu => EnumValues.Bandundu;

        /// <summary>
        /// Équateur
        /// </summary>
        public static EnumValues Équateur => EnumValues.Équateur;

        /// <summary>
        /// Katanga
        /// </summary>
        public static EnumValues Katanga => EnumValues.Katanga;

        /// <summary>
        /// Kasaï-Oriental
        /// </summary>
        public static EnumValues KasaïOriental => EnumValues.KasaïOriental;

        /// <summary>
        /// Kinshasa
        /// </summary>
        public static EnumValues Kinshasa => EnumValues.Kinshasa;

        /// <summary>
        /// Kasaï-Occidental
        /// </summary>
        public static EnumValues KasaïOccidental => EnumValues.KasaïOccidental;

        /// <summary>
        /// Maniema
        /// </summary>
        public static EnumValues Maniema => EnumValues.Maniema;

        /// <summary>
        /// North Kivu
        /// </summary>
        public static EnumValues NorthKivu => EnumValues.NorthKivu;

        /// <summary>
        /// Orientale
        /// </summary>
        public static EnumValues Orientale => EnumValues.Orientale;

        /// <summary>
        /// South Kivu
        /// </summary>
        public static EnumValues SouthKivu => EnumValues.SouthKivu;

        #endregion

        /// <summary>
        /// Enum values for Congo Kinshasa regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Bas-Congo
            /// </summary>
            [AliasInShort("BC")]
            BasCongo,

            /// <summary>
            /// Bandundu
            /// </summary>
            [AliasInShort("BN")]
            Bandundu,

            /// <summary>
            /// Équateur
            /// </summary>
          [AliasInShort("EQ")]
            Équateur,

            /// <summary>
            /// Katanga
            /// </summary>
            [AliasInShort("KA")]
            Katanga,

            /// <summary>
            /// Kasaï-Oriental
            /// </summary>
            [AliasInShort("KE")]
            KasaïOriental,

            /// <summary>
            /// Kinshasa
            /// </summary>
            [AliasInShort("KN")]
            Kinshasa,

            /// <summary>
            /// Kasaï-Occidental
            /// </summary>
            [AliasInShort("KW")]
            KasaïOccidental,

            /// <summary>
            /// Maniema
            /// </summary>
            [AliasInShort("MA")]
            Maniema,

            /// <summary>
            /// North Kivu
            /// </summary>
            [AliasInShort("NK")]
            NorthKivu,

            /// <summary>
            /// Orientale
            /// </summary>
            [AliasInShort("OR")]
            Orientale,

            /// <summary>
            /// South Kivu
            /// </summary>
            [AliasInShort("SK")]
            SouthKivu,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="CongoKinshasaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="CongoKinshasaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"CD-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.CongoKinshasa;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.CD;
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