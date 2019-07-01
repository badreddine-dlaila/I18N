using Cosmos.I18N.Countries;
using Shouldly;
using Xunit;

namespace Cosmos.I18N.Tests.Country
{
    public class CountryManagerTests
    {
        [Fact]
        public void CountTest()
        {
            var count = CountryManager.Expose.CountOfCountryAndCodeMap;

            CountryManager.Expose.CountOfCountryAndCodeMap.ShouldBe(count);
            CountryManager.Expose.CountOfCodeAndCountryMap.ShouldBe(count);
            CountryManager.Expose.CountOfCountryAndInfoMap.ShouldBe(count);
        }
    }
}