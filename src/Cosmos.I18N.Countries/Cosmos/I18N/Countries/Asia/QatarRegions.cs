using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// Qatar Regons
    /// </summary>
    public static class QatarRegions {

        #region Gets regions

        /// <summary>
        /// Doha
        /// </summary>
        public static EnumValues Doha => EnumValues.Doha;

        /// <summary>
        /// Al Khor
        /// </summary>
        public static EnumValues AlKhor => EnumValues.AlKhor;

        /// <summary>
        /// Madinat ash Shamal
        /// </summary>
        public static EnumValues MadinatAshShamal => EnumValues.MadinatAshShamal;

        /// <summary>
        /// Al Rayyan
        /// </summary>
        public static EnumValues AlRayyan => EnumValues.AlRayyan;

        /// <summary>
        /// Umm Salal
        /// </summary>
        public static EnumValues UmmSalal => EnumValues.UmmSalal;

        /// <summary>
        /// Al Wakrah
        /// </summary>
        public static EnumValues AlWakrah => EnumValues.AlWakrah;

        /// <summary>
        /// Al Daayen    
        /// </summary>
        public static EnumValues AlDaayen => EnumValues.AlDaayen;

        #endregion

        /// <summary>
        /// Enum values for Qatar regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Doha
            /// </summary>
            [AliasInShort("DA")]
            Doha,

            /// <summary>
            /// Al Khor
            /// </summary>
            [AliasInShort("KN")]
            AlKhor,

            /// <summary>
            /// Madinat ash Shamal
            /// </summary>
            [AliasInShort("MS")]
            MadinatAshShamal,

            /// <summary>
            /// Al Rayyan
            /// </summary>
            [AliasInShort("RA")]
            AlRayyan,

            /// <summary>
            /// Umm Salal
            /// </summary>
            [AliasInShort("US")]
            UmmSalal,

            /// <summary>
            /// Al Wakrah
            /// </summary>
            [AliasInShort("WA")]
            AlWakrah,

            /// <summary>
            /// Al Daayen
            /// </summary>
            [AliasInShort("ZA")]
            AlDaayen,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="QatarRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="QatarRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"QA-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Qatar;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.QA;
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