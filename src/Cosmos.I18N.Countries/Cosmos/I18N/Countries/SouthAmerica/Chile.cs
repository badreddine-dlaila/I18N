namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 智利（Republic of Chile，南美洲，CL，CHL，152），智利共和国 <br />
    /// Cosmos i18n code: i18n_country_zhili
    /// </summary>
    public static class Chile
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Chile()
        {
            _country = new CountryInfo
            {
                Country = Country.Chile,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Chile,
                UNCode = "152",
                Alpha2Code = "CL",
                Alpha3Code = "CHL",
                Name = "Republic of Chile",
                ShorterForm = "Chile",
                ChineseName = "智利共和国",
                ChineseShorterForm = "智利",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 智利（Republic of Chile，南美洲，CL，CHL，152），智利共和国 <br />
        /// Cosmos i18n code: i18n_country_zhili
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_zhili";
    }
}