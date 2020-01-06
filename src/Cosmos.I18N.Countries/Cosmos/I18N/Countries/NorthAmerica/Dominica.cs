namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 多米尼克（The Commonwealth of Dominica，北美洲，DM，DMA，212），多米尼克国 <br />
    /// Cosmos i18n code: i18n_country_duominike
    /// </summary>
    public static class Dominica {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Dominica() {
            _country = new CountryInfo {
                Country = Country.Dominica,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Dominica,
                UNCode = "212",
                Alpha2Code = "DM",
                Alpha3Code = "DMA",
                Name = "The Commonwealth of Dominica",
                ShorterForm = "Dominica",
                ChineseName = "多米尼克国",
                ChineseShorterForm = "多米尼克",
                Continent = Continent.NorthAmerica,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 多米尼克（The Commonwealth of Dominica，北美洲，DM，DMA，212），多米尼克国 <br />
        /// Cosmos i18n code: i18n_country_duominike
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_duominike";
    }
}