using System;

namespace Cosmos.I18N.Core
{
    /// <summary>
    /// Region Flag Attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class RegionFlagAttribute : Attribute
    {
        public string Flag { get; }

        /// <summary>
        /// Create a new instance of <see cref="RegionFlagAttribute"/>
        /// </summary>
        /// <param name="flag"></param>
        public RegionFlagAttribute(string flag) => Flag = flag;
    }
}