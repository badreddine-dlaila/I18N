namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 尼日利亚（The Republic of Madagascar，非洲，NG，NGA，566，尼日利亚联邦共和国 <br />
    /// Cosmos i18n code: i18n_country_niriliya
    /// </summary>
    public static class Nigeria
    {
        private static readonly CountryInfo _country;

        static Nigeria()
        {
            _country = new CountryInfo
            {
                Country = Country.Nigeria,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Nigeria,
                UNCode = "566",
                Alpha2Code = "NG",
                Alpha3Code = "NGA",
                Name = "Federal Republic of Nigeria",
                ShorterForm = "Nigeria",
                ChineseName = "尼日利亚联邦共和国",
                ChineseShorterForm = "尼日利亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 尼日利亚（The Republic of Madagascar，非洲，NG，NGA，566，尼日利亚联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_niriliya
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_niriliya";
    }
}