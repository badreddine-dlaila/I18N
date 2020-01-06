using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// Oman Regions
    /// </summary>
    public static class OmanRegions {

        #region Gets regions

        /// <summary>
        /// Janub al Batinah
        /// </summary>
        public static EnumValues JanubAlBatinah => EnumValues.JanubAlBatinah;

        /// <summary>
        /// Shamal al Batinah
        /// </summary>
        public static EnumValues ShamalAlBatinah => EnumValues.ShamalAlBatinah;

        /// <summary>
        /// Al Buraimi
        /// </summary>
        public static EnumValues AlBuraimi => EnumValues.AlBuraimi;

        /// <summary>
        /// Ad Dakhiliyah
        /// </summary>
        public static EnumValues AdDakhiliyah => EnumValues.AdDakhiliyah;

        /// <summary>
        /// Muscat
        /// </summary>
        public static EnumValues Muscat => EnumValues.Muscat;

        /// <summary>
        /// Musandam
        /// </summary>
        public static EnumValues Musandam => EnumValues.Musandam;

        /// <summary>
        /// Janub ash Sharqiyah
        /// </summary>
        public static EnumValues JanubAshSharqiyah => EnumValues.JanubAshSharqiyah;

        /// <summary>
        /// Shamal ash Sharqiyah
        /// </summary>
        public static EnumValues ShamalAshSharqiyah => EnumValues.ShamalAshSharqiyah;

        /// <summary>
        /// Al Wusta
        /// </summary>
        public static EnumValues AlWusta => EnumValues.AlWusta;

        /// <summary>
        /// Ad Dhahirah
        /// </summary>
        public static EnumValues AdDhahirah => EnumValues.AdDhahirah;

        /// <summary>
        /// Dhofar
        /// </summary>
        public static EnumValues Dhofar => EnumValues.Dhofar;

        #endregion

        /// <summary>
        /// Enum values for Oman regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Janub al Batinah
            /// </summary>
            [AliasInShort("BJ")]
            JanubAlBatinah,

            /// <summary>
            /// Shamal al Batinah
            /// </summary>
            [AliasInShort("BS")]
            ShamalAlBatinah,

            /// <summary>
            /// Al Buraimi
            /// </summary>
            [AliasInShort("BU")]
            AlBuraimi,

            /// <summary>
            /// Ad Dakhiliyah
            /// </summary>
            [AliasInShort("DA")]
            AdDakhiliyah,

            /// <summary>
            /// Muscat
            /// </summary>
            [AliasInShort("MA")]
            Muscat,

            /// <summary>
            /// Musandam
            /// </summary>
            [AliasInShort("MU")]
            Musandam,

            /// <summary>
            /// Janub ash Sharqiyah
            /// </summary>
            [AliasInShort("SJ")]
            JanubAshSharqiyah,

            /// <summary>
            /// Shamal ash Sharqiyah
            /// </summary>
            [AliasInShort("SS")]
            ShamalAshSharqiyah,

            /// <summary>
            /// Al Wusta
            /// </summary>
            [AliasInShort("WU")]
            AlWusta,

            /// <summary>
            /// Ad Dhahirah
            /// </summary>
            [AliasInShort("ZA")]
            AdDhahirah,

            /// <summary>
            /// Dhofar
            /// </summary>
            [AliasInShort("ZU")]
            Dhofar,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="OmanRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="OmanRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"OM-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Oman;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.OM;
        }

        #endregion

        #region Getters

        private static List<EnumMember<EnumValues>> InternalEnumMembersCache { get; }
            = Enums.GetMembers<EnumValues>().Where(x => !x.Attributes.Has<IgnoreRegionAttribute>()).ToList();

        /// <summary>
        /// Get all region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAllRegonCodes() {
            foreach (var member in InternalEnumMembersCache)
                yield return member.Value.ToFullRegionCode();
        }

        #endregion

    }
}