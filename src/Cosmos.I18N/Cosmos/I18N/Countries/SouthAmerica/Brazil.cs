namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 巴西（The Federative Republic of Brazil，南美洲，BR，BRA，076），巴西联邦共和国 <br />
    /// Cosmos i18n code: i18n_country_baxi
    /// </summary>
    public static class Brazil
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Brazil()
        {
            _country = new CountryInfo
            {
                Country = Country.Brazil,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Brazil,
                UNCode = "076",
                Alpha2Code = "BR",
                Alpha3Code = "BRA",
                Name = "The Federative Republic of Brazil",
                ShorterForm = "Brazil",
                ChineseName = "巴西联邦共和国",
                ChineseShorterForm = "巴西",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 巴西（The Federative Republic of Brazil，南美洲，BR，BRA，076），巴西联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_baxi
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18n
        /// </summary>
        public const string I18N_IDENTITY_CODE = "i18n_country_baxi";
    }
}