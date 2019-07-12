using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Kazakhstan Regions
    /// </summary>
    public static class KazakhstanRegions
    {

        #region Gets regions

        /// <summary>
        /// Akmola
        /// </summary>
        public static EnumValues Akmola => EnumValues.Akmola;

        /// <summary>
        /// Aktobe
        /// </summary>
        public static EnumValues Aktobe => EnumValues.Aktobe;

        /// <summary>
        /// Almaty
        /// </summary>
        public static EnumValues Almaty => EnumValues.Almaty;

        /// <summary>
        /// Almaty Region
        /// </summary>
        public static EnumValues AlmatyRegion => EnumValues.AlmatyRegion;

        /// <summary>
        /// Astana
        /// </summary>
        public static EnumValues Astana => EnumValues.Astana;

        /// <summary>
        /// Atyrau
        /// </summary>
        public static EnumValues Atyrau => EnumValues.Atyrau;

        /// <summary>
        /// Karagandy
        /// </summary>
        public static EnumValues Karagandy => EnumValues.Karagandy;

        /// <summary>
        /// Kostanay
        /// </summary>
        public static EnumValues Kostanay => EnumValues.Kostanay;

        /// <summary>
        /// Kyzylorda
        /// </summary>
        public static EnumValues Kyzylorda => EnumValues.Kyzylorda;

        /// <summary>
        /// Mangystau
        /// </summary>
        public static EnumValues Mangystau => EnumValues.Mangystau;

        /// <summary>
        /// Pavlodar
        /// </summary>
        public static EnumValues Pavlodar => EnumValues.Pavlodar;

        /// <summary>
        /// North Kazakhstan
        /// </summary>
        public static EnumValues NorthKazakhstan => EnumValues.NorthKazakhstan;

        /// <summary>
        /// East Kazakhstan
        /// </summary>
        public static EnumValues EastKazakhstan => EnumValues.EastKazakhstan;

        /// <summary>
        /// South Kazakhstan
        /// </summary>
        public static EnumValues SouthKazakhstan => EnumValues.SouthKazakhstan;

        /// <summary>
        /// West Kazakhstan
        /// </summary>
        public static EnumValues WestKazakhstan => EnumValues.WestKazakhstan;

        /// <summary>
        /// Jambyl
        /// </summary>
        public static EnumValues Jambyl => EnumValues.Jambyl;

        #endregion

        /// <summary>
        /// Enum values for Kazakhstan regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Akmola
            /// </summary>
            [AliasInShort("AKM")]
            Akmola,

            /// <summary>
            /// Aktobe
            /// </summary>
            [AliasInShort("AKT")]
            Aktobe,

            /// <summary>
            /// Almaty
            /// </summary>
            [AliasInShort("ALA")]
            Almaty,

            /// <summary>
            /// Almaty Region
            /// </summary>
            [AliasInShort("ALM")]
            AlmatyRegion,

            /// <summary>
            /// Astana
            /// </summary>
            [AliasInShort("AST")]
            Astana,

            /// <summary>
            /// Atyrau
            /// </summary>
            [AliasInShort("ATY")]
            Atyrau,

            /// <summary>
            /// Karagandy
            /// </summary>
            [AliasInShort("KAR")]
            Karagandy,

            /// <summary>
            /// Kostanay
            /// </summary>
            [AliasInShort("KUS")]
            Kostanay,

            /// <summary>
            /// Kyzylorda
            /// </summary>
            [AliasInShort("KZY")]
            Kyzylorda,

            /// <summary>
            /// Mangystau
            /// </summary>
            [AliasInShort("MAN")]
            Mangystau,

            /// <summary>
            /// Pavlodar
            /// </summary>
            [AliasInShort("PAV")]
            Pavlodar,

            /// <summary>
            /// North Kazakhstan
            /// </summary>
            [AliasInShort("SEV")]
            NorthKazakhstan,

            /// <summary>
            /// East Kazakhstan
            /// </summary>
            [AliasInShort("VOS")]
            EastKazakhstan,

            /// <summary>
            /// South Kazakhstan
            /// </summary>
            [AliasInShort("YUS")]
            SouthKazakhstan,

            /// <summary>
            /// West Kazakhstan
            /// </summary>
            [AliasInShort("ZAP")]
            WestKazakhstan,

            /// <summary>
            /// Jambyl
            /// </summary>
            [AliasInShort("ZHA")]
            Jambyl,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="KazakhstanRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="KazakhstanRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"KZ-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Kazakhstan;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.KZ;
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