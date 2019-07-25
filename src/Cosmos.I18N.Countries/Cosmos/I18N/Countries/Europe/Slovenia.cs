namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 斯洛文尼亚（The Republic of Slovenia，欧洲，SI，SVN，705），斯洛文尼亚共和国 <br />
    /// Cosmos i18n code: i18n_country_sinuowenniya
    /// </summary>
    public class Slovenia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Slovenia()
        {
            _country = new CountryInfo
            {
                Country = Country.Slovenia,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Slovenia,
                UNCode = "705",
                Alpha2Code = "SI",
                Alpha3Code = "SVN",
                Name = "The Republic of Slovenia",
                ShorterForm = "Slovenia",
                ChineseName = "斯洛文尼亚共和国",
                ChineseShorterForm = "斯洛文尼亚",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 斯洛文尼亚（The Republic of Slovenia，欧洲，SI，SVN，705），斯洛文尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_sinuowenniya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_sinuowenniya";
    }
}