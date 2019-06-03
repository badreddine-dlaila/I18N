namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 巴林（The Kingdom of Bahrain ，非洲，BH，BHR，048），巴林王国 <br />
    /// Cosmos i18n code: i18n_country_balin
    /// </summary>
    public static class Bahrain
    {
        private static readonly CountryInfo _country;

        static Bahrain()
        {
            _country = new CountryInfo
            {
                Country = Country.Bahrain,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Bahrain,
                UNCode = "048",
                Alpha2Code = "BH",
                Alpha3Code = "BHR",
                Name = "The Kingdom of Bahrain",
                ShorterForm = "Bahrain",
                ChineseName = "巴林王国",
                ChineseShorterForm = "巴林",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 巴林（The Kingdom of Bahrain ，非洲，BH，BHR，048），巴林王国 <br />
        /// Cosmos i18n code: i18n_country_balin
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_balin";
    }
}