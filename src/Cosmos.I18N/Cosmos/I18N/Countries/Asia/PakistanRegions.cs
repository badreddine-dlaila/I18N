using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Pakistan Regions
    /// </summary>
    public static class PakistanRegions
    {
         #region Gets regions

        /// <summary>
        /// Balochistan
        /// </summary>
        public static EnumValues Balochistan => EnumValues.Balochistan;

        /// <summary>
        /// Gilgit-Baltistan
        /// </summary>
        public static EnumValues GilgitBaltistan => EnumValues.GilgitBaltistan;

        /// <summary>
        /// Islamabad
        /// </summary>
        public static EnumValues Islamabad => EnumValues.Islamabad;

        /// <summary>
        /// Azad Kashmir
        /// </summary>
        public static EnumValues AzadKashmir => EnumValues.AzadKashmir;

        /// <summary>
        /// Khyber Pakhtunkhwa
        /// </summary>
        public static EnumValues KhyberPakhtunkhwa => EnumValues.KhyberPakhtunkhwa;

        /// <summary>
        /// Punjab
        /// </summary>
        public static EnumValues Punjab => EnumValues.Punjab;

        /// <summary>
        /// Sindh
        /// </summary>
        public static EnumValues Sindh => EnumValues.Sindh;

        /// <summary>
        /// Federally Administered Tribal Areas
        /// </summary>
        public static EnumValues FederallyAdministeredTribalAreas => EnumValues.FederallyAdministeredTribalAreas;

        #endregion

        /// <summary>
        /// Enum values for Pakistan regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Balochistan
            /// </summary>
            [AliasInShort("BA")]
            Balochistan,

            /// <summary>
            /// Gilgit-Baltistan
            /// </summary>
            [AliasInShort("GB")]
            GilgitBaltistan,

            /// <summary>
            /// Islamabad
            /// </summary>
            [AliasInShort("IS")]
            Islamabad,

            /// <summary>
            /// Azad Kashmir
            /// </summary>
            [AliasInShort("JK")]
            AzadKashmir,

            /// <summary>
            /// Khyber Pakhtunkhwa
            /// </summary>
            [AliasInShort("KP")]
            KhyberPakhtunkhwa,

            /// <summary>
            /// Punjab
            /// </summary>
            [AliasInShort("PB")]
            Punjab,

            /// <summary>
            /// Sindh
            /// </summary>
            [AliasInShort("SD")]
            Sindh,

            /// <summary>
            /// Federally Administered Tribal Areas
            /// </summary>
            [AliasInShort("TA")]
            FederallyAdministeredTribalAreas,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="PakistanRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="PakistanRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"PK-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Pakistan;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.PK;
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