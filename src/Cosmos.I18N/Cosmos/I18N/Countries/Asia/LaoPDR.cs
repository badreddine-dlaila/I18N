namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 老挝（Lao People's Democratic Republic，亚洲，LA，LAO，418），老挝人民民主共和国 <br />
    /// Cosmos i18n code: i18n_country_laowo
    /// </summary>
    public static class LaoPDR
    {
        private static readonly CountryInfo _country;

        static LaoPDR()
        {
            _country = new CountryInfo
            {
                Country = Country.LaoPDR,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.LaoPDR,
                UNCode = "418",
                Alpha2Code = "LA",
                Alpha3Code = "LAO",
                Name = "Lao People's Democratic Republic",
                ShorterForm = "LaoPDR",
                ChineseName = "老挝人民民主共和国",
                ChineseShorterForm = "老挝",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 老挝（Lao People's Democratic Republic，亚洲，LA，LAO，418），老挝人民民主共和国 <br />
        /// Cosmos i18n code: i18n_country_laowo
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_laowo";
    }
}