namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 挪威（The Kingdom of Norway，欧洲，NO，NOR，578），挪威王国 <br />
    /// Cosmos i18n code: i18n_country_nuowei
    /// </summary>
    public static class Norway
    {
        private static readonly CountryInfo _country;

        static Norway()
        {
            _country = new CountryInfo
            {
                Country = Country.Norway,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Norway,
                UNCode = "578",
                Alpha2Code = "NO",
                Alpha3Code = "NOR",
                Name = "The Kingdom of Norway",
                ShorterForm = "Norway",
                ChineseName = "挪威王国",
                ChineseShorterForm = "挪威",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 挪威（The Kingdom of Norway，欧洲，NO，NOR，578），挪威王国 <br />
        /// Cosmos i18n code: i18n_country_nuowei
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_nuowei";
    }
}