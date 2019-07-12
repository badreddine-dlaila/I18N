namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 匈牙利（Hungary，欧洲，HU，HUN，348） <br />
    /// Cosmos i18n code: i18n_country_xiongyali
    /// </summary>
    public static class Hungary
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Hungary()
        {
            _country = new CountryInfo
            {
                Country = Country.Hungary,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Hungary,
                UNCode = "348",
                Alpha2Code = "HU",
                Alpha3Code = "HUN",
                Name = "Hungary",
                ChineseName = "匈牙利",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 匈牙利（Hungary，欧洲，HU，HUN，348） <br />
        /// Cosmos i18n code: i18n_country_xiongyali
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_xiongyali";
    }
}