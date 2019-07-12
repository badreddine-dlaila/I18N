namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 法属圭亚那（Guyane Francaise，南美洲，GF，GUF，254） <br />
    /// Cosmos i18n code: i18n_country_guiyana
    /// </summary>
    public static class Guiana
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Guiana()
        {
            _country = new CountryInfo
            {
                Country = Country.Guiana,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.France,
                UNCode = "254",
                Alpha2Code = "GF",
                Alpha3Code = "GUF",
                Name = "Guyane Francaise",
                ShorterForm = "Guiana",
                ChineseName = "法属圭亚那",
                ChineseAlias = "森林之国",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 法属圭亚那（Guyane Francaise，南美洲，GF，GUF，254） <br />
        /// Cosmos i18n code: i18n_country_guiyana
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_guiyana";
    }
}