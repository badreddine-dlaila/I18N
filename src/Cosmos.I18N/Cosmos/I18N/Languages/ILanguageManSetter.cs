using System.Collections.Generic;

namespace Cosmos.I18N.Languages
{
    public interface ILanguageManSetter
    {
        void RegisterLanguagePackage(ILanguagePackage languagePackage);
        void RegisterLanguagePackages(IEnumerable<ILanguagePackage> languagePackages);
    }
}