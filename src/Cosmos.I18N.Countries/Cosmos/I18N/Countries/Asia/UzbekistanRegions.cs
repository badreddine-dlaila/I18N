using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// Uzbekistan Regions
    /// </summary>
    public static class UzbekistanRegions {

        #region Gets regions

        /// <summary>
        /// Andijan
        /// </summary>
        public static EnumValues Andijan => EnumValues.Andijan;

        /// <summary>
        /// Bukhara
        /// </summary>
        public static EnumValues Bukhara => EnumValues.Bukhara;

        /// <summary>
        /// Fergana
        /// </summary>
        public static EnumValues Fergana => EnumValues.Fergana;

        /// <summary>
        /// Jizzakh
        /// </summary>
        public static EnumValues Jizzakh => EnumValues.Jizzakh;

        /// <summary>
        /// Namangan
        /// </summary>
        public static EnumValues Namangan => EnumValues.Namangan;

        /// <summary>
        /// Navoiy
        /// </summary>
        public static EnumValues Navoiy => EnumValues.Navoiy;

        /// <summary>
        /// Qashqadaryo
        /// </summary>
        public static EnumValues Qashqadaryo => EnumValues.Qashqadaryo;

        /// <summary>
        /// Karakalpakstan
        /// </summary>
        public static EnumValues Karakalpakstan => EnumValues.Karakalpakstan;

        /// <summary>
        /// Sirdaryo
        /// </summary>
        public static EnumValues Sirdaryo => EnumValues.Sirdaryo;

        /// <summary>
        /// Surxondaryo
        /// </summary>
        public static EnumValues Surxondaryo => EnumValues.Surxondaryo;

        /// <summary>
        /// Tashkent
        /// </summary>
        public static EnumValues Tashkent => EnumValues.Tashkent;

        /// <summary>
        /// Tashkent Province
        /// </summary>
        public static EnumValues TashkentProvince => EnumValues.TashkentProvince;

        /// <summary>
        /// Xorazm
        /// </summary>
        public static EnumValues Xorazm => EnumValues.Xorazm;

        #endregion

        /// <summary>
        /// Enum values for Uzbekistan regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Andijan
            /// </summary>
            [AliasInShort("AN")]
            Andijan,

            /// <summary>
            /// Bukhara
            /// </summary>
            [AliasInShort("BU")]
            Bukhara,

            /// <summary>
            /// Fergana
            /// </summary>
            [AliasInShort("FA")]
            Fergana,

            /// <summary>
            /// Jizzakh
            /// </summary>
            [AliasInShort("JI")]
            Jizzakh,

            /// <summary>
            /// Namangan
            /// </summary>
            [AliasInShort("NG")]
            Namangan,

            /// <summary>
            /// Navoiy
            /// </summary>
            [AliasInShort("NW")]
            Navoiy,

            /// <summary>
            /// Qashqadaryo
            /// </summary>
            [AliasInShort("QA")]
            Qashqadaryo,

            /// <summary>
            /// Karakalpakstan
            /// </summary>
            [AliasInShort("QR")]
            Karakalpakstan,

            /// <summary>
            /// Sirdaryo
            /// </summary>
            [AliasInShort("SI")]
            Sirdaryo,

            /// <summary>
            /// Surxondaryo
            /// </summary>
            [AliasInShort("SU")]
            Surxondaryo,

            /// <summary>
            /// Tashkent
            /// </summary>
            [AliasInShort("TK")]
            Tashkent,

            /// <summary>
            /// Tashkent Province
            /// </summary>
            [AliasInShort("TO")]
            TashkentProvince,

            /// <summary>
            /// Xorazm
            /// </summary>
            [AliasInShort("XO")]
            Xorazm,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="UzbekistanRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="UzbekistanRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"UZ-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Uzbekistan;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.UZ;
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