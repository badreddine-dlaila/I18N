using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EnumsNET;

namespace Cosmos.I18N.Languages
{
    public class LanguageManager : ILanguageManager, ILanguageManSetter
    {
        private readonly IList<Locale> _usedLanguages;
        private readonly Dictionary<Locale, ILanguagePackage> _languagePackages;
        private readonly object _langObject = new object();

        public LanguageManager()
        {
            _usedLanguages = new List<Locale>();
            _languagePackages = new Dictionary<Locale, ILanguagePackage>();
        }

        #region Contains

        public bool Contains(string langName)
        {
            return !string.IsNullOrWhiteSpace(langName) && Contains(langName.ToLocale());
        }

        public bool Contains(Locale locale)
        {
            return _usedLanguages.Contains(locale);
        }

        #endregion

        #region Get language

        public Locale GetLanguage(string langName)
        {
            if (string.IsNullOrWhiteSpace(langName)) return GetCurrentCultureLanguage();
            if (!Contains(langName)) return GetCurrentCultureLanguage();
            return langName.ToLocale();
        }

        public Locale GetCurrentCultureLanguage()
        {
            return CultureInfo.CurrentCulture.Name.ToLocale();
        }

        #endregion

        #region Get language package

        public ILanguagePackage GetLanguagePackage(string langName)
        {
            return GetLanguagePackage(GetLanguage(langName));
        }

        public ILanguagePackage GetLanguagePackage(Locale language)
        {
            return _languagePackages.TryGetValue(language, out var ret) ? ret : null;
        }

        #endregion

        #region Register used language

        public void RegisterUsedLanguage(string lang)
        {
            if (string.IsNullOrWhiteSpace(lang)) throw new ArgumentNullException(nameof(lang));
            RegisterUsedLanguage(lang.ToLocale());
        }

        public void RegisterUsedLanguage(Locale locale)
        {
            lock (_langObject)
            {
                if (!Contains(locale))
                {
                    _usedLanguages.Add(locale);
                }
            }
        }

        #endregion

        #region Register language packages

        void ILanguageManSetter.RegisterLanguagePackage(ILanguagePackage languagePackage)
        {
            if (languagePackage == null)
                return;

            if (_languagePackages.ContainsKey(languagePackage.Language))
                return;

            _languagePackages.Add(languagePackage.Language, languagePackage);
        }

        void ILanguageManSetter.RegisterLanguagePackages(IEnumerable<ILanguagePackage> languagePackages)
        {
            if (languagePackages == null)
                return;

            var setter = (ILanguageManSetter) this;

            foreach (var package in languagePackages)
                setter.RegisterLanguagePackage(package);
        }

        #endregion

        public override string ToString()
        {
            return string.Join(",", _usedLanguages.Select(x => x.GetName()));
        }
    }
}