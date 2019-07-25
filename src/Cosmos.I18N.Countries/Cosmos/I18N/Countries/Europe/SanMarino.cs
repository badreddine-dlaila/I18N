namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 圣马力诺（The Republic of San Marino，欧洲，SM，SMR，674），圣马力诺共和国 <br />
    /// Cosmos i18n code: i18n_country_shengmalinuo
    /// </summary>
    public static class SanMarino
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SanMarino()
        {
            _country = new CountryInfo
            {
                Country = Country.SanMarino,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.SanMarino,
                UNCode = "674",
                Alpha2Code = "SM",
                Alpha3Code = "SMR",
                Name = "The Republic of San Marino",
                ShorterForm = "San Marino",
                ChineseName = "圣马力诺共和国",
                ChineseShorterForm = "圣马力诺",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 圣马力诺（The Republic of San Marino，欧洲，SM，SMR，674），圣马力诺共和国 <br />
        /// Cosmos i18n code: i18n_country_shengmalinuo
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shengmalinuo";
    }
}