namespace Cosmos.I18N.Countries.NorthAmerica
{
    public static class SaintBarts
    {
        
        private static readonly CountryInfo _country;

        static SaintBarts()
        {
            _country = new CountryInfo
            {
                Country = Country.SaintBarts,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.France,
                UNCode = "652",
                Alpha2Code = "BL",
                Alpha3Code = "BLM",
                Name = "Collectivitéde Saint-Barthélemy",
                ShorterForm = "Saint Barts",
                ChineseName = "法兰西共和国圣巴托洛缪行政区",
                ChineseShorterForm = "圣巴托洛缪岛",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 圣巴托洛缪岛（Collectivitéde Saint-Barthélemy，北美洲，BL，BLM，652），法兰西共和国圣巴托洛缪行政区 <br />
        /// Cosmos i18n code: i18n_country_shengbatuo
        /// </summary>
        public static CountryInfo Instance => _country;

        public const string I18N_IDENTITY_CODE = "i18n_country_shengbatuo";
    }
}