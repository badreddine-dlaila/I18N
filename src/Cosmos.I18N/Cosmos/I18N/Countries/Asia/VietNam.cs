namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 越南（Socialist Republic of Vietnam，亚洲，VN，VNM，704），越南社会主义共和国 <br />
    /// Cosmos i18n code: i18n_country_yuenan
    /// </summary>
    public static class Vietnam
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Vietnam()
        {
            _country = new CountryInfo
            {
                Country = Country.Vietnam,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Vietnam,
                UNCode = "704",
                Alpha2Code = "VN",
                Alpha3Code = "VNM",
                Name = "Socialist Republic of Vietnam",
                ShorterForm = "Vietnam",
                ChineseName = "越南社会主义共和国",
                ChineseShorterForm = "越南",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 越南（Socialist Republic of Vietnam，亚洲，VN，VNM，704），越南社会主义共和国 <br />
        /// Cosmos i18n code: i18n_country_yuenan
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yuenan";
    }
}