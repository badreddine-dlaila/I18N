namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 哥斯达黎加（The Republic of Costa Rica，北美洲，CR，CRI，188），哥斯达黎加共和国 <br />
    /// Cosmos i18n code: i18n_country_gesidalijia
    /// </summary>
    public static class CostaRica
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static CostaRica()
        {
            _country = new CountryInfo
            {
                Country = Country.CostaRica,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.CostaRica,
                UNCode = "188",
                Alpha2Code = "CR",
                Alpha3Code = "CRI",
                Name = "The Republic of Costa Rica",
                ShorterForm = "Costa Rica",
                ChineseName = "哥斯达黎加共和国",
                ChineseShorterForm = "哥斯达黎加",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 哥斯达黎加（The Republic of Costa Rica，北美洲，CR，CRI，188），哥斯达黎加共和国 <br />
        /// Cosmos i18n code: i18n_country_gesidalijia
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_gesidalijia";
    }
}