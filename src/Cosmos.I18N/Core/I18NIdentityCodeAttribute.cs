using System;

namespace Cosmos.I18N.Core
{
    public class I18NIdentityCodeAttribute : Attribute
    {
        public string IdentityCode { get; }

        public I18NIdentityCodeAttribute(string identityCode)
        {
            IdentityCode = identityCode;
        }
    }
}