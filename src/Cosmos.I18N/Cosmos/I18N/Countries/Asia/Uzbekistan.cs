namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 乌兹别克斯坦（The Republic Of Uzbekistan，亚洲，UZ，UZB，860），乌兹别克斯坦共和国 <br />
    /// Cosmos i18n code: i18n_country_wuzibiekesitan
    /// </summary>
    public static class Uzbekistan
    {
        private static readonly CountryInfo _country;

        static Uzbekistan()
        {
            _country = new CountryInfo
            {
                Country = Country.Uzbekistan,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Uzbekistan,
                UNCode = "860",
                Alpha2Code = "UZ",
                Alpha3Code = "UZB",
                Name = "The Republic Of Uzbekistan",
                ShorterForm = "Uzbekistan",
                ChineseName = "乌兹别克斯坦共和国",
                ChineseShorterForm = "乌兹别克斯坦",
                ChineseAlias = "乌兹别克",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 乌兹别克斯坦（The Republic Of Uzbekistan，亚洲，UZ，UZB，860），乌兹别克斯坦共和国 <br />
        /// Cosmos i18n code: i18n_country_wuzibiekesitan
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_wuzibiekesitan";
    }
}