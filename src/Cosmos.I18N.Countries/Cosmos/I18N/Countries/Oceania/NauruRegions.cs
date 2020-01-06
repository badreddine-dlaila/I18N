using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// Nauru Regions
    /// </summary>
    public static class NauruRegions {

        #region Gets regions

        /// <summary>
        /// Ijuw
        /// </summary>
        public static EnumValues Ijuw => EnumValues.Ijuw;

        /// <summary>
        /// Meneng
        /// </summary>
        public static EnumValues Meneng => EnumValues.Meneng;

        /// <summary>
        /// Nibok
        /// </summary>
        public static EnumValues Nibok => EnumValues.Nibok;

        /// <summary>
        /// Uaboe
        /// </summary>
        public static EnumValues Uaboe => EnumValues.Uaboe;

        /// <summary>
        /// Yaren
        /// </summary>
        public static EnumValues Yaren => EnumValues.Yaren;

        /// <summary>
        /// Aiwo
        /// </summary>
        public static EnumValues Aiwo => EnumValues.Aiwo;

        /// <summary>
        /// Anabar
        /// </summary>
        public static EnumValues Anabar => EnumValues.Anabar;

        /// <summary>
        /// Anetan
        /// </summary>
        public static EnumValues Anetan => EnumValues.Anetan;

        /// <summary>
        /// Anibare
        /// </summary>
        public static EnumValues Anibare => EnumValues.Anibare;

        /// <summary>
        /// Baiti
        /// </summary>
        public static EnumValues Baiti => EnumValues.Baiti;

        /// <summary>
        /// Boe
        /// </summary>
        public static EnumValues Boe => EnumValues.Boe;

        /// <summary>
        /// Buada
        /// </summary>
        public static EnumValues Buada => EnumValues.Buada;

        /// <summary>
        /// Denigomodu
        /// </summary>
        public static EnumValues Denigomodu => EnumValues.Denigomodu;

        /// <summary>
        /// Ewa
        /// </summary>
        public static EnumValues Ewa => EnumValues.Ewa;

        #endregion

        /// <summary>
        /// Enum values for Nauru regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Ijuw
            /// </summary>
            [AliasInShort("10")]
            Ijuw,

            /// <summary>
            /// Meneng
            /// </summary>
            [AliasInShort("11")]
            Meneng,

            /// <summary>
            /// Nibok
            /// </summary>
            [AliasInShort("12")]
            Nibok,

            /// <summary>
            /// Uaboe
            /// </summary>
            [AliasInShort("13")]
            Uaboe,

            /// <summary>
            /// Yaren
            /// </summary>
            [AliasInShort("14")]
            Yaren,

            /// <summary>
            /// Aiwo
            /// </summary>
            [AliasInShort("01")]
            Aiwo,

            /// <summary>
            /// Anabar
            /// </summary>
            [AliasInShort("02")]
            Anabar,

            /// <summary>
            /// Anetan
            /// </summary>
            [AliasInShort("03")]
            Anetan,

            /// <summary>
            /// Anibare
            /// </summary>
            [AliasInShort("04")]
            Anibare,

            /// <summary>
            /// Baiti
            /// </summary>
            [AliasInShort("05")]
            Baiti,

            /// <summary>
            /// Boe
            /// </summary>
            [AliasInShort("06")]
            Boe,

            /// <summary>
            /// Buada
            /// </summary>
            [AliasInShort("07")]
            Buada,

            /// <summary>
            /// Denigomodu
            /// </summary>
            [AliasInShort("08")]
            Denigomodu,

            /// <summary>
            /// Ewa
            /// </summary>
            [AliasInShort("09")]
            Ewa,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="NauruRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="NauruRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"NR-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Nauru;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.NR;
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