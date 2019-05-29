namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 阿根廷（The Republic of Argentina，南美洲，AR，ARG，032），阿根廷共和国 <br />
    /// Cosmos i18n code: i18n_country_agenting
    /// </summary>
    public static class Argentina
    {
        private static readonly CountryInfo _country;

        static Argentina()
        {
            _country = new CountryInfo
            {
                Country = Country.Argentina,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Argentina,
                UNCode = "032",
                Alpha2Code = "AR",
                Alpha3Code = "ARG",
                Name = "The Republic of Argentina",
                ShorterForm = "Argentina",
                ChineseName = "阿根廷共和国",
                ChineseShorterForm = "阿根廷",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 阿根廷（The Republic of Argentina，南美洲，AR，ARG，032），阿根廷共和国 <br />
        /// Cosmos i18n code: i18n_country_agenting
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_agenting";
    }
}