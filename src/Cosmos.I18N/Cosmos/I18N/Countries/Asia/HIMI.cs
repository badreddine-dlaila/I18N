namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 赫德岛和麦克唐纳群岛（Heard Island and McDonald Islands，亚洲，HM，HMD，334） <br />
    /// Cosmos i18n code: i18n_country_hedemaiketang
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static class HIMI
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        // ReSharper disable once IdentifierTypo
        static HIMI()
        {
            _country = new CountryInfo
            {
                Country = Country.HIMI,
                CountryType = CountryType.Region,
                BeongsToCountry = Country.Australia,
                UNCode = "334",
                Alpha2Code = "HM",
                Alpha3Code = "HMD",
                Name = "Heard Island and McDonald Islands",
                ShorterForm = "HIMI",
                ChineseName = "赫德岛和麦克唐纳群岛",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 赫德岛和麦克唐纳群岛（Heard Island and McDonald Islands，亚洲，HM，HMD，334） <br />
        /// Cosmos i18n code: i18n_country_hedemaiketang
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_hedemaiketang";
    }
}