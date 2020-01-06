using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// Denmark regions
    /// </summary>
    public static class DenmarkRegions {

        #region Gets regions

        /// <summary>
        /// Northern Denmark
        /// </summary>
        public static EnumValues NorthernDenmark => EnumValues.NorthernDenmark;

        /// <summary>
        /// Central Denmark
        /// </summary>
        public static EnumValues CentralDenmark => EnumValues.CentralDenmark;

        /// <summary>
        /// Southern Denmark
        /// </summary>
        public static EnumValues SouthernDenmark => EnumValues.SouthernDenmark;

        /// <summary>
        /// Capital Region
        /// </summary>
        public static EnumValues CapitalRegion => EnumValues.CapitalRegion;

        /// <summary>
        /// Zealand
        /// </summary>
        public static EnumValues Zealand => EnumValues.Zealand;

        /// <summary>
        /// 法罗群岛（Faroe Islands，欧洲，FO，FRO，234） <br />
        /// Cosmos i18n code: i18n_country_faluo
        /// </summary>
        public static EnumValues Faroe => EnumValues.Faroe;

        #endregion

        /// <summary>
        /// Special regions
        /// </summary>
        public static class Special {
            /// <summary>
            /// 法罗群岛（Faroe Islands，欧洲，FO，FRO，234） <br />
            /// Cosmos i18n code: i18n_country_faluo
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Faroe => Country.Faroe;

            /// <summary>
            /// 法罗群岛（Faroe Islands，欧洲，FO，FRO，234） <br />
            /// Cosmos i18n code: i18n_country_faluo
            /// </summary>
            public static CountryCode FaroeCode => CountryCode.FO;
        }

        /// <summary>
        /// Enum values for Denmark regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Northern Denmark
            /// </summary>
            [AliasInShort("81")]
            [RegionFlag("main")]
            NorthernDenmark,

            /// <summary>
            /// Central Denmark
            /// </summary>
            [AliasInShort("82")]
            [RegionFlag("main")]
            CentralDenmark,

            /// <summary>
            /// Southern Denmark
            /// </summary>
            [AliasInShort("83")]
            [RegionFlag("main")]
            SouthernDenmark,

            /// <summary>
            /// Capital Region
            /// </summary>
            [AliasInShort("84")]
            [RegionFlag("main")]
            CapitalRegion,

            /// <summary>
            /// Zealand
            /// </summary>
            [AliasInShort("85")]
            [RegionFlag("main")]
            Zealand,

            /// <summary>
            /// 法罗群岛（Faroe Islands，欧洲，FO，FRO，234） <br />
            /// Cosmos i18n code: i18n_country_faluo
            /// </summary>
            [AliasInShort("FO")]
            [RegionFlag("overseas")]
            Faroe,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="DenmarkRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="DenmarkRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"DK-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            switch (value) {
                case EnumValues.Faroe:
                    return Country.Faroe;
                default:
                    return Country.Denmark;
            }
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            switch (value) {
                case EnumValues.Faroe:
                    return CountryCode.FO;
                default:
                    return CountryCode.DK;
            }
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Convert from special regions of Denmark
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(Country country) {
            switch (country) {
                case Country.Faroe:
                    return EnumValues.Faroe;
                default:
                    return EnumValues.Unknown;
            }
        }

        /// <summary>
        /// Convert from special regions of Denmark
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(CountryCode code) {
            switch (code) {
                case CountryCode.FO:
                    return EnumValues.Faroe;
                default:
                    return EnumValues.Unknown;
            }
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