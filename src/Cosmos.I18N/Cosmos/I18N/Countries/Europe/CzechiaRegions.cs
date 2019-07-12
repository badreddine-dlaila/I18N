using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Czechia regions
    /// </summary>
    public static class CzechiaRegions
    {

        #region Gets regions

        /// <summary>
        /// South Bohemia
        /// </summary>
        public static EnumValues SouthBohemia => EnumValues.SouthBohemia;

        /// <summary>
        /// South Moravia
        /// </summary>
        public static EnumValues SouthMoravia => EnumValues.SouthMoravia;

        /// <summary>
        /// Karlovy Vary Region
        /// </summary>
        public static EnumValues KarlovyVaryRegion => EnumValues.KarlovyVaryRegion;

        /// <summary>
        /// Hradec Králové Region
        /// </summary>
        public static EnumValues HradecKrálovéRegion => EnumValues.HradecKrálovéRegion;

        /// <summary>
        /// Liberec Region
        /// </summary>
        public static EnumValues LiberecRegion => EnumValues.LiberecRegion;

        /// <summary>
        /// Moravian-Silesia
        /// </summary>
        public static EnumValues MoravianSilesia => EnumValues.MoravianSilesia;

        /// <summary>
        /// Olomouc Region
        /// </summary>
        public static EnumValues OlomoucRegion => EnumValues.OlomoucRegion;

        /// <summary>
        /// Pardubice Region
        /// </summary>
        public static EnumValues PardubiceRegion => EnumValues.PardubiceRegion;

        /// <summary>
        /// Plzeň Region
        /// </summary>
        public static EnumValues PlzeňRegion => EnumValues.PlzeňRegion;

        /// <summary>
        /// Prague
        /// </summary>
        public static EnumValues Prague => EnumValues.Prague;

        /// <summary>
        /// Central Bohemia
        /// </summary>
        public static EnumValues CentralBohemia => EnumValues.CentralBohemia;

        /// <summary>
        /// Ústí nad Labem Region
        /// </summary>
        public static EnumValues ÚstíNadLabemRegion => EnumValues.ÚstíNadLabemRegion;

        /// <summary>
        /// Vysočina
        /// </summary>
        public static EnumValues Vysočina => EnumValues.Vysočina;

        /// <summary>
        /// Zlín Region
        /// </summary>
        public static EnumValues ZlínRegion => EnumValues.ZlínRegion;

        #endregion

        /// <summary>
        /// Enum values for Czechia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// South Bohemia
            /// </summary>
            [AliasInShort("JC")]
            SouthBohemia,

            /// <summary>
            /// South Moravia
            /// </summary>
            [AliasInShort("JM")]
            SouthMoravia,

            /// <summary>
            /// Karlovy Vary Region
            /// </summary>
            [AliasInShort("KA")]
            KarlovyVaryRegion,

            /// <summary>
            /// Hradec Králové Region
            /// </summary>
            [AliasInShort("KR")]
            HradecKrálovéRegion,

            /// <summary>
            /// Liberec Region
            /// </summary>
            [AliasInShort("LI")]
            LiberecRegion,

            /// <summary>
            /// Moravian-Silesia
            /// </summary>
            [AliasInShort("NO")]
            MoravianSilesia,

            /// <summary>
            /// Olomouc Region
            /// </summary>
            [AliasInShort("OL")]
            OlomoucRegion,

            /// <summary>
            /// Pardubice Region
            /// </summary>
            [AliasInShort("PA")]
            PardubiceRegion,

            /// <summary>
            /// Plzeň Region
            /// </summary>
            [AliasInShort("PL")]
            PlzeňRegion,

            /// <summary>
            /// Prague
            /// </summary>
            [AliasInShort("PR")]
            Prague,

            /// <summary>
            /// Central Bohemia
            /// </summary>
            [AliasInShort("ST")]
            CentralBohemia,

            /// <summary>
            /// Ústí nad Labem Region
            /// </summary>
            [AliasInShort("US")]
            ÚstíNadLabemRegion,

            /// <summary>
            /// Vysočina
            /// </summary>
            [AliasInShort("VY")]
            Vysočina,

            /// <summary>
            /// Zlín Region
            /// </summary>
            [AliasInShort("ZL")]
            ZlínRegion,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="CzechiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="CzechiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"CZ-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Czechia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.CZ;
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