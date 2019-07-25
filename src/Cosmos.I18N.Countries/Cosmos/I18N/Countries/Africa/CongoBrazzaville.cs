namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 刚果（布）（The Republic of Congo，非洲，CG，COG，178），刚果共和国 <br />
    /// Cosmos i18n code: i18n_country_gangguobu
    /// </summary>
    public static class CongoBrazzaville
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static CongoBrazzaville()
        {
            _country = new CountryInfo
            {
                Country = Country.CongoBrazzaville,
                CountryType = CountryType.Country,
                BeongsToCountry = Country.CongoBrazzaville,
                UNCode = "178",
                Alpha2Code = "CG",
                Alpha3Code = "COG",
                Name = "The Republic of Congo",
                ShorterForm = "Congo (Brazzaville)",
                ChineseName = "刚果共和国",
                ChineseShorterForm = "刚果（布）",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 刚果（布）（The Republic of Congo，非洲，CG，COG，178），刚果共和国 <br />
        /// Cosmos i18n code: i18n_country_gangguobu
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_gangguobu";
    }
}