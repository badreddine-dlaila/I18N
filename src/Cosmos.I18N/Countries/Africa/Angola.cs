namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 安哥拉（Angola，非洲，AO，AGO，024），安哥拉共和国 <br />
    /// Cosmos i18n code: i18n_country_angela
    /// </summary>
    public static class Angola
    {
        private static readonly CountryInfo _country;

        static Angola()
        {
            _country = new CountryInfo
            {
                Country = Country.Angola,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Angola,
                UNCode = "024",
                Alpha2Code = "AO",
                Alpha3Code = "AGO",
                Name = "The Republic of Angola",
                ShorterForm = "Angola",
                ChineseName = "安哥拉共和国",
                ChineseShorterForm = "安哥拉",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 安哥拉（Angola，非洲，AO，AGO，024），安哥拉共和国 <br />
        /// Cosmos i18n code: i18n_country_angela
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_angela";
    }
}