using System;

namespace Cosmos.I18N.Core
{
    /// <summary>
    /// AliasInShort Attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class AliasInShortAttribute : Attribute
    {
        /// <summary>
        /// Alias
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// Create a new instance of <see cref="AliasInShortAttribute"/>
        /// </summary>
        /// <param name="alias"></param>
        public AliasInShortAttribute(string alias) => Alias = alias;
    }
}
