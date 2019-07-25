namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 法属圣马丁（Saint Martin (French part)，北美洲，MF，MAF，663），圣马丁行政区 <br />
    /// Cosmos i18n code: i18n_country_shengmading
    /// </summary>
    public static class SaintMartinFrenchPart
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SaintMartinFrenchPart()
        {
            _country = new CountryInfo
            {
                Country = Country.SaintMartinFrenchPart,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.France,
                UNCode = "663",
                Alpha2Code = "MF",
                Alpha3Code = "MAF",
                Name = "Saint Martin (French part)",
                ShorterForm = "Saint-Martin",
                ChineseName = "圣马丁行政区",
                ChineseShorterForm = "法属圣马丁",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 法属圣马丁（Saint Martin (French part)，北美洲，MF，MAF，663），圣马丁行政区 <br />
        /// Cosmos i18n code: i18n_country_shengmading
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shengmading";
    }
}