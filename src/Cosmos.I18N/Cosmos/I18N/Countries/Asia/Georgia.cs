namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 格鲁吉亚（Georgia，亚洲，GE，GEO，268） <br />
    /// Cosmos i18n code: i18n_country_gelujiya
    /// </summary>
    public static class Georgia
    {
        private static readonly CountryInfo _country;

        static Georgia()
        {
            _country = new CountryInfo
            {
                Country = Country.Georgia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Georgia,
                UNCode = "268",
                Alpha2Code = "GE",
                Alpha3Code = "GEO",
                Name = "Georgia",
                ChineseName = "格鲁吉亚",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 格鲁吉亚（Georgia，亚洲，GE，GEO，268） <br />
        /// Cosmos i18n code: i18n_country_gelujiya
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_gelujiya";
    }
}