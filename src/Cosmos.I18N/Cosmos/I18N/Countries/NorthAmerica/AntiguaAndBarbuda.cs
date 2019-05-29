namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 安提瓜和巴布达（Antigua and Barbuda，北美洲，AG，ATG，028） <br />
    /// Cosmos i18n code: i18n_country_andaguababuda
    /// </summary>
    public static class AntiguaAndBarbuda
    {
        private static readonly CountryInfo _country;

        static AntiguaAndBarbuda()
        {
            _country = new CountryInfo
            {
                Country = Country.AntiguaAndBarbuda,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.AntiguaAndBarbuda,
                UNCode = "028",
                Alpha2Code = "AG",
                Alpha3Code = "ATG",
                Name = "Antigua and Barbuda",
                ChineseName = "安提瓜和巴布达",
                Continent = Continent.NorthAmerica,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 安提瓜和巴布达（Antigua and Barbuda，北美洲，AG，ATG，028） <br />
        /// Cosmos i18n code: i18n_country_andaguababuda
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_andaguababuda";
    }
}