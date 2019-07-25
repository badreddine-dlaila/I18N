namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 巴勒斯坦（The State of Palestine，亚洲，PS，PSE，275），巴勒斯坦国 <br />
    /// Cosmos i18n code: i18n_country_balesitan
    /// </summary>
    public static class Palestine
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Palestine()
        {
            _country = new CountryInfo
            {
                Country = Country.Palestine,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Palestine,
                UNCode = "275",
                Alpha2Code = "PS",
                Alpha3Code = "PSE",
                Name = "The State of Palestine",
                ShorterForm = "Palestine",
                ChineseName = "巴勒斯坦国",
                ChineseShorterForm = "巴勒斯坦",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 巴勒斯坦（The State of Palestine，亚洲，PS，PSE，275），巴勒斯坦国 <br />
        /// Cosmos i18n code: i18n_country_balesitan
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_balesitan";
    }
}