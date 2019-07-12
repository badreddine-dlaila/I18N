using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Iraq Regions
    /// </summary>
    public static class IraqRegions
    {

        #region Gets regions

        /// <summary>
        /// Al Anbar
        /// </summary>
        public static EnumValues AlAnbar => EnumValues.AlAnbar;

        /// <summary>
        /// Erbil
        /// </summary>
        public static EnumValues Erbil => EnumValues.Erbil;

        /// <summary>
        /// Basra
        /// </summary>
        public static EnumValues Basra => EnumValues.Basra;

        /// <summary>
        /// Babylon
        /// </summary>
        public static EnumValues Babylon => EnumValues.Babylon;

        /// <summary>
        /// Baghdad
        /// </summary>
        public static EnumValues Baghdad => EnumValues.Baghdad;

        /// <summary>
        /// Dohuk
        /// </summary>
        public static EnumValues Dohuk => EnumValues.Dohuk;

        /// <summary>
        /// Diyala
        /// </summary>
        public static EnumValues Diyala => EnumValues.Diyala;

        /// <summary>
        /// Dhi Qar    
        /// </summary>
        public static EnumValues DhiQar => EnumValues.DhiQar;

        /// <summary>
        /// Karbala
        /// </summary>
        public static EnumValues Karbala => EnumValues.Karbala;

        /// <summary>
        /// Kirkuk
        /// </summary>
        public static EnumValues Kirkuk => EnumValues.Kirkuk;

        /// <summary>
        /// Maysan
        /// </summary>
        public static EnumValues Maysan => EnumValues.Maysan;

        /// <summary>
        /// Al Muthanna
        /// </summary>
        public static EnumValues AlMuthanna => EnumValues.AlMuthanna;

        /// <summary>
        /// Najaf
        /// </summary>
        public static EnumValues Najaf => EnumValues.Najaf;

        /// <summary>
        /// Nineveh
        /// </summary>
        public static EnumValues Nineveh => EnumValues.Nineveh;

        /// <summary>
        /// Al-Qādisiyyah
        /// </summary>
        public static EnumValues AlQādisiyyah => EnumValues.AlQādisiyyah;

        /// <summary>
        /// Saladin
        /// </summary>
        public static EnumValues Saladin => EnumValues.Saladin;

        /// <summary>
        /// Sulaymaniyah
        /// </summary>
        public static EnumValues Sulaymaniyah => EnumValues.Sulaymaniyah;

        /// <summary>
        /// Wasit
        /// </summary>
        public static EnumValues Wasit => EnumValues.Wasit;

        #endregion

        /// <summary>
        /// Enum values for Iraq regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Al Anbar
            /// </summary>
            [AliasInShort("AN")]
            AlAnbar,

            /// <summary>
            /// Erbil
            /// </summary>
            [AliasInShort("AR")]
            Erbil,

            /// <summary>
            /// Basra
            /// </summary>
            [AliasInShort("BA")]
            Basra,

            /// <summary>
            /// Babylon
            /// </summary>
            [AliasInShort("BB")]
            Babylon,

            /// <summary>
            /// Baghdad
            /// </summary>
            [AliasInShort("BG")]
            Baghdad,

            /// <summary>
            /// Dohuk
            /// </summary>
            [AliasInShort("DA")]
            Dohuk,

            /// <summary>
            /// Diyala
            /// </summary>
            [AliasInShort("DI")]
            Diyala,

            /// <summary>
            /// Dhi Qar
            /// </summary>
            [AliasInShort("DQ")]
            DhiQar,

            /// <summary>
            /// Karbala
            /// </summary>
            [AliasInShort("KA")]
            Karbala,

            /// <summary>
            /// Kirkuk
            /// </summary>
            [AliasInShort("KI")]
            Kirkuk,

            /// <summary>
            /// Maysan
            /// </summary>
            [AliasInShort("MA")]
            Maysan,

            /// <summary>
            /// Al Muthanna
            /// </summary>
            [AliasInShort("MU")]
            AlMuthanna,

            /// <summary>
            /// Najaf
            /// </summary>
            [AliasInShort("NA")]
            Najaf,

            /// <summary>
            /// Nineveh
            /// </summary>
            [AliasInShort("NI")]
            Nineveh,

            /// <summary>
            /// Al-Qādisiyyah
            /// </summary>
            [AliasInShort("QA")]
            AlQādisiyyah,

            /// <summary>
            /// Saladin
            /// </summary>
            [AliasInShort("SD")]
            Saladin,

            /// <summary>
            /// Sulaymaniyah
            /// </summary>
            [AliasInShort("SU")]
            Sulaymaniyah,

            /// <summary>
            /// Wasit
            /// </summary>
            [AliasInShort("WA")]
            Wasit,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="IraqRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="IraqRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"IQ-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Iraq;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.IQ;
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