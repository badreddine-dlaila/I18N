namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 埃塞俄比亚（The Federal Democratic Republic of Ethiopia，非洲，ET，ETH，231），埃塞俄比亚联邦民主共和国 <br />
    /// Cosmos i18n code: i18n_country_aisaiebiya
    /// </summary>
    public static class Ethiopia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Ethiopia()
        {
            _country = new CountryInfo
            {
                Country = Country.Ethiopia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Ethiopia,
                UNCode = "231",
                Alpha2Code = "ET",
                Alpha3Code = "ETH",
                Name = "The Federal Democratic Republic of Ethiopia",
                ShorterForm = "Ethiopia",
                ChineseName = "埃塞俄比亚联邦民主共和国",
                ChineseShorterForm = "埃塞俄比亚",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 埃塞俄比亚（The Federal Democratic Republic of Ethiopia，非洲，ET，ETH，231），埃塞俄比亚联邦民主共和国 <br />
        /// Cosmos i18n code: i18n_country_aisaiebiya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aisaiebiya";
    }
}