namespace Cosmos.I18N.Languages
{
    public interface ILanguageManager
    {
        bool Contains(string langName);
        bool Contains(Locale locale);
        Locale GetLanguage(string langName);
        Locale GetCurrentCultureLanguage();
        ILanguagePackage GetLanguagePackage(string langName);
        ILanguagePackage GetLanguagePackage(Locale language);
        void RegisterUsedLanguage(string lang);
        void RegisterUsedLanguage(Locale locale);
        
    }
}