namespace Cosmos.I18N.Countries.Europe
{
    public static class Faroe
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Faroe()
        {
            _country = new CountryInfo
            {
                Country = Country.Faroe,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.Denmark,
                UNCode = "234",
                Alpha2Code = "FO",
                Alpha3Code = "FRO",
                Name = "Faroe Islands",
                ShorterForm = "Faroe",
                ChineseName = "法罗群岛",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 法罗群岛（Faroe Islands，欧洲，FO，FRO，234） <br />
        /// Cosmos i18n code: i18n_country_faluo
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_faluo";
    }
}