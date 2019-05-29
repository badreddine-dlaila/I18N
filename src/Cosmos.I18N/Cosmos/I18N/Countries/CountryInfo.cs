namespace Cosmos.I18N.Countries
{
    public class CountryInfo
    {
        public Country Country { get; internal set; }

        public CountryType CountryType { get; internal set; }

        public Country BeongsToCountry { get; internal set; }

        // ReSharper disable once InconsistentNaming
        public string UNCode { get; internal set; }

        public string Alpha2Code { get; internal set; }

        public string Alpha3Code { get; internal set; }

        public string Name { get; internal set; }

        public string ShorterForm { get; internal set; }

        public string Alias { get; internal set; }

        public string ChineseName { get; internal set; }

        public string ChineseShorterForm { get; internal set; }

        public string ChineseAlias { get; internal set; }

        public string ChineseAlias2 { get; internal set; }

        public Continent Continent { get; internal set; }

        public string I18NIdentityCode { get; internal set; }

        public bool CommonwealthOfNations { get; internal set; }
    }
}