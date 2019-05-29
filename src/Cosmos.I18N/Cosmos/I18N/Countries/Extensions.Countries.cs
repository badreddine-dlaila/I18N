namespace Cosmos.I18N.Countries
{
    public static class CountriesExtensions
    {
        public static CountryInfo ToInfo(this Country country)
        {
            return CountryManager.GetCountryInfo(country);
        }

        public static CountryInfo ToInfo(this CountryCode code)
        {
            return CountryManager.GetCountryInfo(code);
        }

        public static Country ToCountry(this CountryCode code)
        {
            return CountryManager.GetCountryEnum(code);
        }

        public static CountryCode ToCode(this Country country)
        {
            return CountryManager.GetCountryCode(country);
        }
    }
}