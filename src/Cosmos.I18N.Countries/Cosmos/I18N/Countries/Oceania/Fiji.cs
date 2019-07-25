namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 斐济（The Republic of Fiji，大洋洲，FJ，FJI，242），斐济共和国 <br />
    /// Cosmos i18n code: i18n_country_feiji
    /// </summary>
    public static class Fiji
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Fiji()
        {
            _country = new CountryInfo
            {
                Country = Country.Fiji,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.Fiji,
                UNCode = "242",
                Alpha2Code = "FJ",
                Alpha3Code = "FJI",
                Name = "The Republic of Fiji",
                ShorterForm = "Fiji",
                ChineseName = "斐济共和国",
                ChineseShorterForm = "斐济",
                Continent = Continent.Oceania,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 斐济（The Republic of Fiji，大洋洲，FJ，FJI，242），斐济共和国 <br />
        /// Cosmos i18n code: i18n_country_feiji
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_feiji";
    }
}