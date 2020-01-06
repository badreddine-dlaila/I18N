namespace Cosmos.I18N.Countries {
    /// <summary>
    /// Countries Extensions
    /// </summary>
    public static class CountriesExtensions {
        /// <summary>
        /// Convert <see cref="Country"/> to <see cref="CountryInfo"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static CountryInfo ToInfo(this Country country) {
            return CountryManager.GetCountryInfo(country);
        }

        /// <summary>
        /// Convert <see cref="CountryCode"/> to <see cref="CountryInfo"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static CountryInfo ToInfo(this CountryCode code) {
            return CountryManager.GetCountryInfo(code);
        }

        /// <summary>
        /// Convert <see cref="CountryCode"/> to <see cref="Country"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static Country ToCountry(this CountryCode code) {
            return CountryManager.GetCountryEnum(code);
        }

        /// <summary>
        /// Convert <see cref="Country"/> to <see cref="CountryCode"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static CountryCode ToCode(this Country country) {
            return CountryManager.GetCountryCode(country);
        }

        /// <summary>
        /// Convert <see cref="CountryCode"/> to string.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string ToCodeString(this CountryCode code) {
            return EnumsNET.Enums.GetName(code);
        }

        /// <summary>
        /// Convert <see cref="Country"/> to string.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static string ToCodeString(this Country country) {
            return country.ToCode().ToCodeString();
        }

    }
}