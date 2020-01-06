using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// Afghanistan Regions
    /// </summary>
    public static class AfghanistanRegions {

        #region Gets region

        /// <summary>
        /// Balkh
        /// </summary>
        public static EnumValues Balkh => EnumValues.Balkh;

        /// <summary>
        /// Bamyan
        /// </summary>
        public static EnumValues Bamyan => EnumValues.Bamyan;

        /// <summary>
        /// Badghis
        /// </summary>
        public static EnumValues Badghis => EnumValues.Badghis;

        /// <summary>
        /// Badakhshan
        /// </summary>
        public static EnumValues Badakhshan => EnumValues.Badakhshan;

        /// <summary>
        /// Baghlan
        /// </summary>
        public static EnumValues Baghlan => EnumValues.Baghlan;

        /// <summary>
        /// Daykundi
        /// </summary>
        public static EnumValues Daykundi => EnumValues.Daykundi;

        /// <summary>
        /// Farah
        /// </summary>
        public static EnumValues Farah => EnumValues.Farah;

        /// <summary>
        /// Faryab
        /// </summary>
        public static EnumValues Faryab => EnumValues.Faryab;

        /// <summary>
        /// Ghazni
        /// </summary>
        public static EnumValues Ghazni => EnumValues.Ghazni;

        /// <summary>
        /// Ghōr
        /// </summary>
        public static EnumValues Ghōr => EnumValues.Ghōr;

        /// <summary>
        /// Helmand
        /// </summary>
        public static EnumValues Helmand => EnumValues.Helmand;

        /// <summary>
        /// Herat
        /// </summary>
        public static EnumValues Herat => EnumValues.Herat;

        /// <summary>
        /// Jowzjan
        /// </summary>
        public static EnumValues Jowzjan => EnumValues.Jowzjan;

        /// <summary>
        /// Kabul
        /// </summary>
        public static EnumValues Kabul => EnumValues.Kabul;

        /// <summary>
        /// Kandahar
        /// </summary>
        public static EnumValues Kandahar => EnumValues.Kandahar;

        /// <summary>
        /// Kapisa
        /// </summary>
        public static EnumValues Kapisa => EnumValues.Kapisa;

        /// <summary>
        /// Kunduz
        /// </summary>
        public static EnumValues Kunduz => EnumValues.Kunduz;

        /// <summary>
        /// Khost
        /// </summary>
        public static EnumValues Khost => EnumValues.Khost;

        /// <summary>
        /// Kunar
        /// </summary>
        public static EnumValues Kunar => EnumValues.Kunar;

        /// <summary>
        /// Laghman
        /// </summary>
        public static EnumValues Laghman => EnumValues.Laghman;

        /// <summary>
        /// Logar
        /// </summary>
        public static EnumValues Logar => EnumValues.Logar;

        /// <summary>
        /// Nangarhar
        /// </summary>
        public static EnumValues Nangarhar => EnumValues.Nangarhar;

        /// <summary>
        /// Nimruz
        /// </summary>
        public static EnumValues Nimruz => EnumValues.Nimruz;

        /// <summary>
        /// Nuristan
        /// </summary>
        public static EnumValues Nuristan => EnumValues.Nuristan;

        /// <summary>
        /// Panjshir
        /// </summary>
        public static EnumValues Panjshir => EnumValues.Panjshir;

        /// <summary>
        /// Parwan
        /// </summary>
        public static EnumValues Parwan => EnumValues.Parwan;

        /// <summary>
        /// Paktia
        /// </summary>
        public static EnumValues Paktia => EnumValues.Paktia;

        /// <summary>
        /// Paktika
        /// </summary>
        public static EnumValues Paktika => EnumValues.Paktika;

        /// <summary>
        /// Samangan
        /// </summary>
        public static EnumValues Samangan => EnumValues.Samangan;

        /// <summary>
        /// Sar-e Pol
        /// </summary>
        public static EnumValues SarEPol => EnumValues.SarEPol;

        /// <summary>
        /// Takhar
        /// </summary>
        public static EnumValues Takhar => EnumValues.Takhar;

        /// <summary>
        /// Urozgan
        /// </summary>
        public static EnumValues Urozgan => EnumValues.Urozgan;

        /// <summary>
        /// Maidan Wardak
        /// </summary>
        public static EnumValues MaidanWardak => EnumValues.MaidanWardak;

        /// <summary>
        /// Zabul
        /// </summary>
        public static EnumValues Zabul => EnumValues.Zabul;

        #endregion

        /// <summary>
        /// Enum values for Afghanistan regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Balkh
            /// </summary>
            [AliasInShort("BAL")]
            Balkh,

            /// <summary>
            /// Bamyan
            /// </summary>
            [AliasInShort("BAM")]
            Bamyan,

            /// <summary>
            /// Badghis
            /// </summary>
            [AliasInShort("BDG")]
            Badghis,

            /// <summary>
            /// Badakhshan
            /// </summary>
            [AliasInShort("BDS")]
            Badakhshan,

            /// <summary>
            /// Baghlan
            /// </summary>
            [AliasInShort("BGL")]
            Baghlan,

            /// <summary>
            /// Daykundi
            /// </summary>
            [AliasInShort("DAY")]
            Daykundi,

            /// <summary>
            /// Farah
            /// </summary>
            [AliasInShort("FRA")]
            Farah,

            /// <summary>
            /// Faryab
            /// </summary>
            [AliasInShort("FYB")]
            Faryab,

            /// <summary>
            /// Ghazni
            /// </summary>
            [AliasInShort("GHA")]
            Ghazni,

            /// <summary>
            /// Ghōr
            /// </summary>
            [AliasInShort("GHO")]
            Ghōr,

            /// <summary>
            /// Helmand
            /// </summary>
            [AliasInShort("HEL")]
            Helmand,

            /// <summary>
            /// Herat
            /// </summary>
            [AliasInShort("HER")]
            Herat,

            /// <summary>
            /// Jowzjan
            /// </summary>
            [AliasInShort("JOW")]
            Jowzjan,

            /// <summary>
            /// Kabul
            /// </summary>
            [AliasInShort("KAB")]
            Kabul,

            /// <summary>
            /// Kandahar
            /// </summary>
            [AliasInShort("KAN")]
            Kandahar,

            /// <summary>
            /// Kapisa
            /// </summary>
            [AliasInShort("KAP")]
            Kapisa,

            /// <summary>
            /// Kunduz
            /// </summary>
            [AliasInShort("KDZ")]
            Kunduz,

            /// <summary>
            /// Khost
            /// </summary>
            [AliasInShort("KHO")]
            Khost,

            /// <summary>
            /// Kunar
            /// </summary>
            [AliasInShort("KNR")]
            Kunar,

            /// <summary>
            /// Laghman
            /// </summary>
            [AliasInShort("LAG")]
            Laghman,

            /// <summary>
            /// Logar
            /// </summary>
            [AliasInShort("LOG")]
            Logar,

            /// <summary>
            /// Nangarhar
            /// </summary>
            [AliasInShort("NAN")]
            Nangarhar,

            /// <summary>
            /// Nimruz
            /// </summary>
            [AliasInShort("NIM")]
            Nimruz,

            /// <summary>
            /// Nuristan
            /// </summary>
            [AliasInShort("NUR")]
            Nuristan,

            /// <summary>
            /// Panjshir
            /// </summary>
            [AliasInShort("PAN")]
            Panjshir,

            /// <summary>
            /// Parwan
            /// </summary>
            [AliasInShort("PAR")]
            Parwan,

            /// <summary>
            /// Paktia
            /// </summary>
            [AliasInShort("PIA")]
            Paktia,

            /// <summary>
            /// Paktika
            /// </summary>
            [AliasInShort("PKA")]
            Paktika,

            /// <summary>
            /// Samangan
            /// </summary>
            [AliasInShort("SAM")]
            Samangan,

            /// <summary>
            /// Sar-e Pol
            /// </summary>
            [AliasInShort("SAR")]
            SarEPol,

            /// <summary>
            /// Takhar
            /// </summary>
            [AliasInShort("TAK")]
            Takhar,

            /// <summary>
            /// Urozgan
            /// </summary>
            [AliasInShort("URU")]
            Urozgan,

            /// <summary>
            /// Maidan Wardak
            /// </summary>
            [AliasInShort("WAR")]
            MaidanWardak,

            /// <summary>
            /// Zabul
            /// </summary>
            [AliasInShort("ZAB")]
            Zabul,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="AfghanistanRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="AfghanistanRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"AF-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.Afghanistan;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.AF;
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