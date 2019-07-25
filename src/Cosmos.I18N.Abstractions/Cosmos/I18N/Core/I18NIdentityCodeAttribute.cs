using System;

namespace Cosmos.I18N.Core
{
    /// <summary>
    /// Attribute of cosmos i18n identity core
    /// </summary>
    public class I18NIdentityCodeAttribute : Attribute
    {
        /// <summary>
        /// Identity code
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string IdentityCode { get; }

        /// <summary>
        /// Create a new instance of <see cref="I18NIdentityCodeAttribute"/>
        /// </summary>
        /// <param name="identityCode"></param>
        public I18NIdentityCodeAttribute(string identityCode)
        {
            IdentityCode = identityCode;
        }
    }
}