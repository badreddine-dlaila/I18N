using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Libya Regions
    /// </summary>
    public static class LibyaRegions
    {

        #region Gets regions

        /// <summary>
        /// Benghazi
        /// </summary>
        public static EnumValues Benghazi => EnumValues.Benghazi;

        /// <summary>
        /// Butnan
        /// </summary>
        public static EnumValues Butnan => EnumValues.Butnan;

        /// <summary>
        /// Derna
        /// </summary>
        public static EnumValues Derna => EnumValues.Derna;

        /// <summary>
        /// Ghat
        /// </summary>
        public static EnumValues Ghat => EnumValues.Ghat;

        /// <summary>
        /// Jabal al Akhdar
        /// </summary>
        public static EnumValues JabalAlAkhdar => EnumValues.JabalAlAkhdar;

        /// <summary>
        /// Jabal al Gharbi
        /// </summary>
        public static EnumValues JabalAlGharbi => EnumValues.JabalAlGharbi;

        /// <summary>
        /// Jafara
        /// </summary>
        public static EnumValues Jafara => EnumValues.Jafara;

        /// <summary>
        /// Jufra
        /// </summary>
        public static EnumValues Jufra => EnumValues.Jufra;

        /// <summary>
        /// Kufra
        /// </summary>
        public static EnumValues Kufra => EnumValues.Kufra;

        /// <summary>
        /// Murqub
        /// </summary>
        public static EnumValues Murqub => EnumValues.Murqub;

        /// <summary>
        /// Misrata
        /// </summary>
        public static EnumValues Misrata => EnumValues.Misrata;

        /// <summary>
        /// Marj
        /// </summary>
        public static EnumValues Marj => EnumValues.Marj;

        /// <summary>
        /// Murzuq
        /// </summary>
        public static EnumValues Murzuq => EnumValues.Murzuq;

        /// <summary>
        /// Nalut
        /// </summary>
        public static EnumValues Nalut => EnumValues.Nalut;

        /// <summary>
        /// Nuqat al Khams
        /// </summary>
        public static EnumValues NuqatAlKhams => EnumValues.NuqatAlKhams;

        /// <summary>
        /// Sabha
        /// </summary>
        public static EnumValues Sabha => EnumValues.Sabha;

        /// <summary>
        /// Sirte
        /// </summary>
        public static EnumValues Sirte => EnumValues.Sirte;

        /// <summary>
        /// Tripoli
        /// </summary>
        public static EnumValues Tripoli => EnumValues.Tripoli;

        /// <summary>
        /// Al Wahat
        /// </summary>
        public static EnumValues AlWahat => EnumValues.AlWahat;

        /// <summary>
        /// Wadi al Hayaa
        /// </summary>
        public static EnumValues WadiAlHayaa => EnumValues.WadiAlHayaa;

        /// <summary>
        /// Wadi al Shatii
        /// </summary>
        public static EnumValues WadiAlShatii => EnumValues.WadiAlShatii;

        /// <summary>
        /// Zawiya
        /// </summary>
        public static EnumValues Zawiya => EnumValues.Zawiya;

        #endregion

        /// <summary>
        /// Enum values for Libya regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Benghazi
            /// </summary>
            [AliasInShort("BA")]
            Benghazi,

            /// <summary>
            /// Butnan
            /// </summary>
            [AliasInShort("BU")]
            Butnan,

            /// <summary>
            /// Derna
            /// </summary>
            [AliasInShort("DR")]
            Derna,

            /// <summary>
            /// Ghat
            /// </summary>
            [AliasInShort("GT")]
            Ghat,

            /// <summary>
            /// Jabal al Akhdar
            /// </summary>
            [AliasInShort("JA")]
            JabalAlAkhdar,

            /// <summary>
            /// Jabal al Gharbi
            /// </summary>
            [AliasInShort("JG")]
            JabalAlGharbi,

            /// <summary>
            /// Jafara
            /// </summary>
            [AliasInShort("JI")]
            Jafara,

            /// <summary>
            /// Jufra
            /// </summary>
            [AliasInShort("JU")]
            Jufra,

            /// <summary>
            /// Kufra
            /// </summary>
            [AliasInShort("KF")]
            Kufra,

            /// <summary>
            /// Murqub
            /// </summary>
            [AliasInShort("MB")]
            Murqub,

            /// <summary>
            /// Misrata
            /// </summary>
            [AliasInShort("MI")]
            Misrata,

            /// <summary>
            /// Marj
            /// </summary>
            [AliasInShort("MJ")]
            Marj,

            /// <summary>
            /// Murzuq
            /// </summary>
            [AliasInShort("MQ")]
            Murzuq,

            /// <summary>
            /// Nalut
            /// </summary>
            [AliasInShort("NL")]
            Nalut,

            /// <summary>
            /// Nuqat al Khams
            /// </summary>
            [AliasInShort("NQ")]
            NuqatAlKhams,

            /// <summary>
            /// Sabha
            /// </summary>
            [AliasInShort("SB")]
            Sabha,

            /// <summary>
            /// Sirte
            /// </summary>
            [AliasInShort("SR")]
            Sirte,

            /// <summary>
            /// Tripoli
            /// </summary>
            [AliasInShort("TB")]
            Tripoli,

            /// <summary>
            /// Al Wahat
            /// </summary>
            [AliasInShort("WA")]
            AlWahat,

            /// <summary>
            /// Wadi al Hayaa
            /// </summary>
            [AliasInShort("WD")]
            WadiAlHayaa,

            /// <summary>
            /// Wadi al Shatii
            /// </summary>
            [AliasInShort("WS")]
            WadiAlShatii,

            /// <summary>
            /// Zawiya
            /// </summary>
            [AliasInShort("ZA")]
            Zawiya,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="LibyaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="LibyaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"LY-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Libya;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.LY;
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