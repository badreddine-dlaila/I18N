namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 荷兰属圣马丁（Sint Maarten (Dutch part)，北美洲，SX，SXM，534） <br />
    /// Cosmos i18n code: i18n_country_shengmadingdp
    /// </summary>
    public static class SintMaartenDutchPart {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SintMaartenDutchPart() {
            _country = new CountryInfo {
                Country = Country.SintMaartenDutchPart,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.Netherlands,
                UNCode = "534",
                Alpha2Code = "SX",
                Alpha3Code = "SXM",
                Name = "Sint Maarten (Dutch part)",
                ShorterForm = "Sint Maarten",
                ChineseName = "荷兰属圣马丁",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 荷兰属圣马丁（Sint Maarten (Dutch part)，北美洲，SX，SXM，534） <br />
        /// Cosmos i18n code: i18n_country_shengmadingdp
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shengmadingdp";
    }
}