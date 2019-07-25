using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// SaudiArabia Regions
    /// </summary>
    public static class SaudiArabiaRegions
    {

        #region Gets regions

        /// <summary>
        /// Najran
        /// </summary>
        public static EnumValues Najran => EnumValues.Najran;

        /// <summary>
        /// Al Bahah
        /// </summary>
        public static EnumValues AlBahah => EnumValues.AlBahah;

        /// <summary>
        /// Al Jawf
        /// </summary>
        public static EnumValues AlJawf => EnumValues.AlJawf;

        /// <summary>
        /// Asir
        /// </summary>
        public static EnumValues Asir => EnumValues.Asir;

        /// <summary>
        /// Riyadh
        /// </summary>
        public static EnumValues Riyadh => EnumValues.Riyadh;

        /// <summary>
        /// Makkah
        /// </summary>
        public static EnumValues Makkah => EnumValues.Makkah;

        /// <summary>
        /// Al Madinah
        /// </summary>
        public static EnumValues AlMadinah => EnumValues.AlMadinah;

        /// <summary>
        /// Eastern
        /// </summary>
        public static EnumValues Eastern => EnumValues.Eastern;

        /// <summary>
        /// Al-Qassim
        /// </summary>
        public static EnumValues AlQassim => EnumValues.AlQassim;

        /// <summary>
        /// Ha’il
        /// </summary>
        public static EnumValues Hail => EnumValues.Hail;

        /// <summary>
        /// Tabuk
        /// </summary>
        public static EnumValues Tabuk => EnumValues.Tabuk;

        /// <summary>
        /// Northern Borders
        /// </summary>
        public static EnumValues NorthernBorders => EnumValues.NorthernBorders;

        /// <summary>
        /// Jizan
        /// </summary>
        public static EnumValues Jizan => EnumValues.Jizan;

        #endregion

        /// <summary>
        /// Enum values for SaudiArabia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Najran
            /// </summary>
            [AliasInShort("10")]
            Najran,

            /// <summary>
            /// Al Bahah
            /// </summary>
            [AliasInShort("11")]
            AlBahah,

            /// <summary>
            /// Al Jawf
            /// </summary>
            [AliasInShort("12")]
            AlJawf,

            /// <summary>
            /// Asir
            /// </summary>
            [AliasInShort("14")]
            Asir,

            /// <summary>
            /// Riyadh
            /// </summary>
            [AliasInShort("1")]
            Riyadh,

            /// <summary>
            /// Makkah
            /// </summary>
            [AliasInShort("2")]
            Makkah,

            /// <summary>
            /// Al Madinah
            /// </summary>
            [AliasInShort("3")]
            AlMadinah,

            /// <summary>
            /// Eastern
            /// </summary>
            [AliasInShort("4")]
            Eastern,

            /// <summary>
            /// Al-Qassim
            /// </summary>
            [AliasInShort("5")]
            AlQassim,

            /// <summary>
            /// Ha’il
            /// </summary>
            [AliasInShort("6")]
            Hail,

            /// <summary>
            /// Tabuk
            /// </summary>
            [AliasInShort("7")]
            Tabuk,

            /// <summary>
            /// Northern Borders
            /// </summary>
            [AliasInShort("8")]
            NorthernBorders,

            /// <summary>
            /// Jizan
            /// </summary>
            [AliasInShort("9")]
            Jizan,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SaudiArabiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SaudiArabiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"SA-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.SaudiArabia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.SA;
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