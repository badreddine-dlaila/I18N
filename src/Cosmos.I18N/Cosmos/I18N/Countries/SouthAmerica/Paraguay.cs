namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 巴拉圭（Republic Of Paraguay，南美洲，PY，PRY，600），巴拉圭共和国 <br />
    /// Cosmos i18n code: i18n_country_balagui
    /// </summary>
    public static class Paraguay
    {
        private static readonly CountryInfo _country;

        static Paraguay()
        {
            _country = new CountryInfo
            {
                Country = Country.Paraguay,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Paraguay,
                UNCode = "600",
                Alpha2Code = "PY",
                Alpha3Code = "PRY",
                Name = "Republic of Paraguay",
                ShorterForm = "Paraguay",
                ChineseName = "巴拉圭共和国",
                ChineseShorterForm = "巴拉圭",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 巴拉圭（Republic Of Paraguay，南美洲，PY，PRY，600），巴拉圭共和国 <br />
        /// Cosmos i18n code: i18n_country_balagui
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_balagui";
    }
}