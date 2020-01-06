using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// Belize regions
    /// </summary>
    public static class BelizeRegions {

        #region Gets regions

        /// <summary>
        /// Belize
        /// </summary>
        public static EnumValues Belize => EnumValues.Belize;

        /// <summary>
        /// Cayo
        /// </summary>
        public static EnumValues Cayo => EnumValues.Cayo;

        /// <summary>
        /// Corozal
        /// </summary>
        public static EnumValues Corozal => EnumValues.Corozal;

        /// <summary>
        /// Orange Walk    
        /// </summary>
        public static EnumValues OrangeWalk => EnumValues.OrangeWalk;

        /// <summary>
        /// Stann Creek
        /// </summary>
        public static EnumValues StannCreek => EnumValues.StannCreek;

        /// <summary>
        /// Toledo
        /// </summary>
        public static EnumValues Toledo => EnumValues.Toledo;

        #endregion

        /// <summary>
        /// Enum values for Belize regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Belize
            /// </summary>
            [AliasInShort("BZ")]
            Belize,

            /// <summary>
            /// Cayo
            /// </summary>
            [AliasInShort("CY")]
            Cayo,

            /// <summary>
            /// Corozal
            /// </summary>
            [AliasInShort("CZL")]
            Corozal,

            /// <summary>
            /// Orange Walk    
            /// </summary>
            [AliasInShort("OW")]
            OrangeWalk,

            /// <summary>
            /// Stann Creek
            /// </summary>
            [AliasInShort("SC")]
            StannCreek,

            /// <summary>
            /// Toledo
            /// </summary>
            [AliasInShort("TOL")]
            Toledo,


            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BelizeRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BelizeRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"BZ-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Belize;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.BZ;
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