namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 俄罗斯（Russian Federation，欧洲，BI，BDI，108），俄罗斯联邦 <br />
    /// Cosmos i18n code: i18n_country_eluosi
    /// </summary>
    public static class Russia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Russia()
        {
            _country = new CountryInfo
            {
                Country = Country.Russia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Russia,
                UNCode = "643",
                Alpha2Code = "RU",
                Alpha3Code = "RUS",
                Name = "Russian Federation",
                ShorterForm = "Russia",
                ChineseName = "俄罗斯联邦",
                ChineseShorterForm = "俄罗斯",
                ChineseAlias = "俄联邦",
                ChineseAlias2 = "俄国",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 俄罗斯（Russian Federation，欧洲，BI，BDI，108），俄罗斯联邦 <br />
        /// Cosmos i18n code: i18n_country_eluosi
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_eluosi";
    }
}