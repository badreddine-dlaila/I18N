namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 澳大利亚（The Commonwealth of Australia，大洋洲，AU，AUS，036），澳大利亚联邦 <br />
    /// Cosmos i18n code: i18n_country_aodaliya
    /// </summary>
    public static class Australia
    {
        private static readonly CountryInfo _country;

        static Australia()
        {
            _country = new CountryInfo
            {
                Country = Country.Australia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Australia,
                UNCode = "036",
                Alpha2Code = "AU",
                Alpha3Code = "AUS",
                Name = "The Commonwealth of Australia",
                ShorterForm = "Argentina",
                ChineseName = "澳大利亚联邦",
                ChineseShorterForm = "澳大利亚",
                Continent = Continent.Oceania,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 澳大利亚（The Commonwealth of Australia，大洋洲，AU，AUS，036），澳大利亚联邦 <br />
        /// Cosmos i18n code: i18n_country_aodaliya
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_aodaliya";
    }
}