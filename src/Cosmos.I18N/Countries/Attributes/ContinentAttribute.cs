using System;

namespace Cosmos.I18N.Countries
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ContinentAttribute : Attribute
    {
        public Continent Continent { get; }

        public ContinentAttribute(Continent name)
        {
            Continent = name;
        }
    }
}