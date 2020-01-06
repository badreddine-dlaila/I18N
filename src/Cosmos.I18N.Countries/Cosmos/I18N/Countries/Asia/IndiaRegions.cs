using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// India Regions
    /// </summary>
    public static class IndiaRegions {

        #region Gets regions

        /// <summary>
        /// Andaman and Nicobar Islands
        /// </summary>
        public static EnumValues AndamanAndNicobarIslands => EnumValues.AndamanAndNicobarIslands;

        /// <summary>
        /// Andhra Pradesh
        /// </summary>
        public static EnumValues AndhraPradesh => EnumValues.AndhraPradesh;

        /// <summary>
        /// Arunachal Pradesh
        /// </summary>
        public static EnumValues ArunachalPradesh => EnumValues.ArunachalPradesh;

        /// <summary>
        /// Assam
        /// </summary>
        public static EnumValues Assam => EnumValues.Assam;

        /// <summary>
        /// Bihar
        /// </summary>
        public static EnumValues Bihar => EnumValues.Bihar;

        /// <summary>
        /// Chandigarh
        /// </summary>
        public static EnumValues Chandigarh => EnumValues.Chandigarh;

        /// <summary>
        /// Chhattisgarh
        /// </summary>
        public static EnumValues Chhattisgarh => EnumValues.Chhattisgarh;

        /// <summary>
        /// Daman and Diu
        /// </summary>
        public static EnumValues DamanAndDiu => EnumValues.DamanAndDiu;

        /// <summary>
        /// Delhi
        /// </summary>
        public static EnumValues Delhi => EnumValues.Delhi;

        /// <summary>
        /// Dadra and Nagar Haveli
        /// </summary>
        public static EnumValues DadraAndNagarHaveli => EnumValues.DadraAndNagarHaveli;

        /// <summary>
        /// Goa
        /// </summary>
        public static EnumValues Goa => EnumValues.Goa;

        /// <summary>
        /// Gujarat
        /// </summary>
        public static EnumValues Gujarat => EnumValues.Gujarat;

        /// <summary>
        /// Himachal Pradesh
        /// </summary>
        public static EnumValues HimachalPradesh => EnumValues.HimachalPradesh;

        /// <summary>
        /// Haryana
        /// </summary>
        public static EnumValues Haryana => EnumValues.Haryana;

        /// <summary>
        /// Jharkhand
        /// </summary>
        public static EnumValues Jharkhand => EnumValues.Jharkhand;

        /// <summary>
        /// Jammu and Kashmir
        /// </summary>
        public static EnumValues JammuAndKashmir => EnumValues.JammuAndKashmir;

        /// <summary>
        /// Karnataka
        /// </summary>
        public static EnumValues Karnataka => EnumValues.Karnataka;

        /// <summary>
        /// Kerala
        /// </summary>
        public static EnumValues Kerala => EnumValues.Kerala;

        /// <summary>
        /// Lakshadweep
        /// </summary>
        public static EnumValues Lakshadweep => EnumValues.Lakshadweep;

        /// <summary>
        /// Maharashtra
        /// </summary>
        public static EnumValues Maharashtra => EnumValues.Maharashtra;

        /// <summary>
        /// Meghalaya
        /// </summary>
        public static EnumValues Meghalaya => EnumValues.Meghalaya;

        /// <summary>
        /// Manipur
        /// </summary>
        public static EnumValues Manipur => EnumValues.Manipur;

        /// <summary>
        /// Madhya Pradesh
        /// </summary>
        public static EnumValues MadhyaPradesh => EnumValues.MadhyaPradesh;

        /// <summary>
        /// Mizoram
        /// </summary>
        public static EnumValues Mizoram => EnumValues.Mizoram;

        /// <summary>
        /// Nagaland
        /// </summary>
        public static EnumValues Nagaland => EnumValues.Nagaland;

        /// <summary>
        /// Odisha
        /// </summary>
        public static EnumValues Odisha => EnumValues.Odisha;

        /// <summary>
        /// Punjab
        /// </summary>
        public static EnumValues Punjab => EnumValues.Punjab;

        /// <summary>
        /// Puducherry
        /// </summary>
        public static EnumValues Puducherry => EnumValues.Puducherry;

        /// <summary>
        /// Rajasthan
        /// </summary>
        public static EnumValues Rajasthan => EnumValues.Rajasthan;

        /// <summary>
        /// Sikkim
        /// </summary>
        public static EnumValues Sikkim => EnumValues.Sikkim;

        /// <summary>
        /// Telangana
        /// </summary>
        public static EnumValues Telangana => EnumValues.Telangana;

        /// <summary>
        /// Tamil Nadu
        /// </summary>
        public static EnumValues TamilNadu => EnumValues.TamilNadu;

        /// <summary>
        /// Tripura
        /// </summary>
        public static EnumValues Tripura => EnumValues.Tripura;

        /// <summary>
        /// Uttar Pradesh
        /// </summary>
        public static EnumValues UttarPradesh => EnumValues.UttarPradesh;

        /// <summary>
        /// Uttarakhand
        /// </summary>
        public static EnumValues Uttarakhand => EnumValues.Uttarakhand;

        /// <summary>
        /// West Bengal
        /// </summary>
        public static EnumValues WestBengal => EnumValues.WestBengal;

        #endregion

        /// <summary>
        /// Enum values for India regions.
        /// </summary>
        public enum EnumValues {
            /// <summary>
            /// Andaman and Nicobar Islands
            /// </summary>
            [AliasInShort("AN")]
            AndamanAndNicobarIslands,

            /// <summary>
            /// Andhra Pradesh
            /// </summary>
            [AliasInShort("AP")]
            AndhraPradesh,

            /// <summary>
            /// Arunachal Pradesh
            /// </summary>
            [AliasInShort("AR")]
            ArunachalPradesh,

            /// <summary>
            /// Assam
            /// </summary>
            [AliasInShort("AS")]
            Assam,

            /// <summary>
            /// Bihar
            /// </summary>
            [AliasInShort("BR")]
            Bihar,

            /// <summary>
            /// Chandigarh
            /// </summary>
            [AliasInShort("CH")]
            Chandigarh,

            /// <summary>
            /// Chhattisgarh
            /// </summary>
            [AliasInShort("CT")]
            Chhattisgarh,

            /// <summary>
            /// Daman and Diu
            /// </summary>
            [AliasInShort("DD")]
            DamanAndDiu,

            /// <summary>
            /// Delhi
            /// </summary>
            [AliasInShort("DL")]
            Delhi,

            /// <summary>
            /// Dadra and Nagar Haveli
            /// </summary>
            [AliasInShort("DN")]
            DadraAndNagarHaveli,

            /// <summary>
            /// Goa
            /// </summary>
            [AliasInShort("GA")]
            Goa,

            /// <summary>
            /// Gujarat
            /// </summary>
            [AliasInShort("GJ")]
            Gujarat,

            /// <summary>
            /// Himachal Pradesh
            /// </summary>
            [AliasInShort("HP")]
            HimachalPradesh,

            /// <summary>
            /// Haryana
            /// </summary>
            [AliasInShort("HR")]
            Haryana,

            /// <summary>
            /// Jharkhand
            /// </summary>
            [AliasInShort("JH")]
            Jharkhand,

            /// <summary>
            /// Jammu and Kashmir
            /// </summary>
            [AliasInShort("JK")]
            JammuAndKashmir,

            /// <summary>
            /// Karnataka
            /// </summary>
            [AliasInShort("KA")]
            Karnataka,

            /// <summary>
            /// Kerala
            /// </summary>
            [AliasInShort("KL")]
            Kerala,

            /// <summary>
            /// Lakshadweep
            /// </summary>
            [AliasInShort("LD")]
            Lakshadweep,

            /// <summary>
            /// Maharashtra
            /// </summary>
            [AliasInShort("MH")]
            Maharashtra,

            /// <summary>
            /// Meghalaya
            /// </summary>
            [AliasInShort("ML")]
            Meghalaya,

            /// <summary>
            /// Manipur
            /// </summary>
            [AliasInShort("MN")]
            Manipur,

            /// <summary>
            /// Madhya Pradesh
            /// </summary>
            [AliasInShort("MP")]
            MadhyaPradesh,

            /// <summary>
            /// Mizoram
            /// </summary>
            [AliasInShort("MZ")]
            Mizoram,

            /// <summary>
            /// Nagaland
            /// </summary>
            [AliasInShort("NL")]
            Nagaland,

            /// <summary>
            /// Odisha
            /// </summary>
            [AliasInShort("OR")]
            Odisha,

            /// <summary>
            /// Punjab
            /// </summary>
            [AliasInShort("PB")]
            Punjab,

            /// <summary>
            /// Puducherry
            /// </summary>
            [AliasInShort("PY")]
            Puducherry,

            /// <summary>
            /// Rajasthan
            /// </summary>
            [AliasInShort("RJ")]
            Rajasthan,

            /// <summary>
            /// Sikkim
            /// </summary>
            [AliasInShort("SK")]
            Sikkim,

            /// <summary>
            /// Telangana
            /// </summary>
            [AliasInShort("TG")]
            Telangana,

            /// <summary>
            /// Tamil Nadu
            /// </summary>
            [AliasInShort("TN")]
            TamilNadu,

            /// <summary>
            /// Tripura
            /// </summary>
            [AliasInShort("TR")]
            Tripura,

            /// <summary>
            /// Uttar Pradesh
            /// </summary>
            [AliasInShort("UP")]
            UttarPradesh,

            /// <summary>
            /// Uttarakhand
            /// </summary>
            [AliasInShort("UT")]
            Uttarakhand,

            /// <summary>
            /// West Bengal
            /// </summary>
            [AliasInShort("WB")]
            WestBengal,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="IndiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values) {
            return values.GetAttributes().Get<AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="IndiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values) {
            return $"IN-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value) {
            return Country.India;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value) {
            return CountryCode.IN;
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