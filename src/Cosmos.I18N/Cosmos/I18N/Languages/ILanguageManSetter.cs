using System.Collections.Generic;

namespace Cosmos.I18N.Languages
{
    public interface ILanguageManSetter
    {
        void RegisterLanguagePackages(IEnumerable<ILanguagePackage> languagePackages);
    }
}