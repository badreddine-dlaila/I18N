namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 列支敦士登（Principality of Liechtenstein，欧洲，LI，LIE，438），列支敦士登公国 <br />
    /// Cosmos i18n code: i18n_country_liezhidunshideng
    /// </summary>
    public static class Liechtenstein
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Liechtenstein()
        {
            _country = new CountryInfo
            {
                Country = Country.Liechtenstein,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Liechtenstein,
                UNCode = "438",
                Alpha2Code = "LI",
                Alpha3Code = "LIE",
                Name = "Principality of Liechtenstein",
                ShorterForm = "Liechtenstein",
                ChineseName = "列支敦士登公国",
                ChineseShorterForm = "列支敦士登",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 列支敦士登（Principality of Liechtenstein，欧洲，LI，LIE，438），列支敦士登公国 <br />
        /// Cosmos i18n code: i18n_country_liezhidunshideng
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_liezhidunshideng";
    }
}