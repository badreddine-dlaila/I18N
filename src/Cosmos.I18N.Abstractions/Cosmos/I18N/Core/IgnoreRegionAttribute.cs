using System;

namespace Cosmos.I18N.Core {
    /// <summary>
    /// Ignore Region Attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class IgnoreRegionAttribute : Attribute { }
}