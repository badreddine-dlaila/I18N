namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 波黑（Bosnia and Herzegovina，欧洲，BA，BIH，070），波斯尼亚和黑塞哥维那 <br />
    /// Cosmos i18n code: i18n_country_bohei
    /// </summary>
    public static class BosniaAndHerzegovina
    {
        private static readonly CountryInfo _country;

        static BosniaAndHerzegovina()
        {
            _country = new CountryInfo
            {
                Country = Country.BosniaAndHerzegovina,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.BosniaAndHerzegovina,
                UNCode = "070",
                Alpha2Code = "BA",
                Alpha3Code = "BIH",
                Name = "Bosnia and Herzegovina",
                ShorterForm="Azerbaijan",
                ChineseName = "波斯尼亚和黑塞哥维那",
                ChineseShorterForm = "波黑",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 波黑（Bosnia and Herzegovina，欧洲，BA，BIH，070），波斯尼亚和黑塞哥维那 <br />
        /// Cosmos i18n code: i18n_country_bohei
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_bohei";
    }
}