namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 越南（Socialist Republic of Vietnam，亚洲，VN，VNM，704），越南社会主义共和国 <br />
    /// Cosmos i18n code: i18n_country_yuenan
    /// </summary>
    public static class VietNam
    {
        private static readonly CountryInfo _country;

        static VietNam()
        {
            _country = new CountryInfo
            {
                Country = Country.VietNam,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.VietNam,
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

        public const string I18N_IDENTITY_CODE = "i18n_country_yuenan";
    }
}