namespace Cosmos.I18N.Countries {
    public static partial class CountryManager {
        /// <summary>
        /// Expose information
        /// </summary>
        public static class Expose {
            /// <summary>
            /// To count the Country-CountryCode mapping
            /// </summary>
            public static int CountOfCountryAndCodeMap => _nameAndCodeMap.Count;

            /// <summary>
            /// To count the CountryCode-Country mapping
            /// </summary>
            public static int CountOfCodeAndCountryMap => _codeAndNameMap.Count;

            /// <summary>
            /// To count the Country-CountryInfo mapping
            /// </summary>
            public static int CountOfCountryAndInfoMap => _countryInfoCache.Count;

        }
    }
}