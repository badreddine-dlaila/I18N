using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Philippines Regions
    /// </summary>
    public static class PhilippinesRegions
    {

        #region Gets regions

        /// <summary>
        /// Northern Mindanao
        /// </summary>
        public static EnumValues NorthernMindanao => EnumValues.NorthernMindanao;

        /// <summary>
        /// Davao
        /// </summary>
        public static EnumValues Davao => EnumValues.Davao;

        /// <summary>
        /// Soccsksargen
        /// </summary>
        public static EnumValues Soccsksargen => EnumValues.Soccsksargen;

        /// <summary>
        /// Caraga
        /// </summary>
        public static EnumValues Caraga => EnumValues.Caraga;

        /// <summary>
        /// Muslim Mindanao
        /// </summary>
        public static EnumValues MuslimMindanao => EnumValues.MuslimMindanao;

        /// <summary>
        /// Cordillera Administrative
        /// </summary>
        public static EnumValues CordilleraAdministrative => EnumValues.CordilleraAdministrative;

        /// <summary>
        /// Calabarzon
        /// </summary>
        public static EnumValues Calabarzon => EnumValues.Calabarzon;

        /// <summary>
        /// Mimaropa
        /// </summary>
        public static EnumValues Mimaropa => EnumValues.Mimaropa;

        /// <summary>
        /// Metro Manila 
        /// </summary>
        public static EnumValues MetroManila => EnumValues.MetroManila;

        /// <summary>
        /// Ilocos
        /// </summary>
        public static EnumValues Ilocos => EnumValues.Ilocos;

        /// <summary>
        /// Cagayan Valley 
        /// </summary>
        public static EnumValues CagayanValley => EnumValues.CagayanValley;

        /// <summary>
        /// Central Luzon
        /// </summary>
        public static EnumValues CentralLuzon => EnumValues.CentralLuzon;

        /// <summary>
        /// Bicol
        /// </summary>
        public static EnumValues Bicol => EnumValues.Bicol;

        /// <summary>
        /// Western Visayas
        /// </summary>
        public static EnumValues WesternVisayas => EnumValues.WesternVisayas;

        /// <summary>
        /// Central Visayas 
        /// </summary>
        public static EnumValues CentralVisayas => EnumValues.CentralVisayas;

        /// <summary>
        /// Eastern Visayas
        /// </summary>
        public static EnumValues EasternVisayas => EnumValues.EasternVisayas;

        /// <summary>
        /// Zamboanga Peninsula 
        /// </summary>
        public static EnumValues ZamboangaPeninsula => EnumValues.ZamboangaPeninsula;

        #endregion

        /// <summary>
        /// Enum values for Philippines regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Northern Mindanao
            /// </summary>
            [AliasInShort("10")]
            NorthernMindanao,

            /// <summary>
            /// Davao
            /// </summary>
            [AliasInShort("11")]
            Davao,

            /// <summary>
            /// Soccsksargen
            /// </summary>
            [AliasInShort("12")]
            Soccsksargen,

            /// <summary>
            /// Caraga
            /// </summary>
            [AliasInShort("13")]
            Caraga,

            /// <summary>
            /// Muslim Mindanao
            /// </summary>
            [AliasInShort("14")]
            MuslimMindanao,

            /// <summary>
            /// Cordillera Administrative
            /// </summary>
            [AliasInShort("15")]
            CordilleraAdministrative,

            /// <summary>
            /// Calabarzon
            /// </summary>
            [AliasInShort("40")]
            Calabarzon,

            /// <summary>
            /// Mimaropa
            /// </summary>
            [AliasInShort("41")]
            Mimaropa,

            /// <summary>
            /// Metro Manila
            /// </summary>
            [AliasInShort("00")]
            MetroManila,

            /// <summary>
            /// Ilocos
            /// </summary>
            [AliasInShort("01")]
            Ilocos,

            /// <summary>
            /// Cagayan Valley
            /// </summary>
            [AliasInShort("02")]
            CagayanValley,

            /// <summary>
            /// Central Luzon
            /// </summary>
            [AliasInShort("03")]
            CentralLuzon,

            /// <summary>
            /// Bicol
            /// </summary>
            [AliasInShort("05")]
            Bicol,

            /// <summary>
            /// Western Visayas
            /// </summary>
            [AliasInShort("06")]
            WesternVisayas,

            /// <summary>
            /// Central Visayas
            /// </summary>
            [AliasInShort("07")]
            CentralVisayas,

            /// <summary>
            /// Eastern Visayas
            /// </summary>
            [AliasInShort("08")]
            EasternVisayas,

            /// <summary>
            /// Zamboanga Peninsula
            /// </summary>
            [AliasInShort("09")]
            ZamboangaPeninsula,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="PhilippinesRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="PhilippinesRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"PH-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Philippines;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.PH;
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