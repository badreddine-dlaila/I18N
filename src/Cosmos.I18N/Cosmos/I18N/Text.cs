using System;
using Cosmos.I18N.Core;
using Cosmos.I18N.Core.Extensions;
using Cosmos.I18N.Languages;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N
{
    /// <summary>
    /// Text
    /// </summary>
    public struct Text : IText, IEquatable<Text>
    {
        private LanguageTag LanguageTag { get; set; }

        private string PackageKey { get; set; }
        private string OriginText { get; set; }
        private object[] FormatingParameters { get; set; }

        private readonly TranslationProcessor _translationProcessor;

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        public Text(string text, string packageKey)
            : this(text, packageKey, LanguageTag.Current, null) { }

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="parameters"></param>
        public Text(string text, string packageKey, params object[] parameters)
            : this(text, packageKey, LanguageTag.Current, parameters) { }

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        public Text(string text, string packageKey, string languageTag)
            : this(text, packageKey, languageTag, null) { }

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        public Text(string text, string packageKey, ILanguageTag languageTag)
            : this(text, packageKey, languageTag, null) { }

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="locale"></param>
        public Text(string text, string packageKey, Locale locale)
            : this(text, packageKey, locale.GetLanguageTagText(), null) { }

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        /// <param name="parameters"></param>
        public Text(string text, string packageKey, string languageTag, params object[] parameters)
            : this(text, packageKey, LanguageTagManager.Get(languageTag), parameters) { }

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        /// <param name="parameters"></param>
        public Text(string text, string packageKey, ILanguageTag languageTag, params object[] parameters)
        {
            LanguageTag = languageTag as LanguageTag ?? LanguageTag.Current;
            PackageKey = packageKey;
            OriginText = text;
            FormatingParameters = parameters;

            _translationProcessor = StaticInstanceForILanguageServiceProvider.Instance.GetTranslationProcessor();
            CustomFormatProvider = (packageKeyArg, languageTagArg, textArg, parametersArg) => string.Format(textArg, parametersArg);
        }

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="locale"></param>
        /// <param name="parameters"></param>
        public Text(string text, string packageKey, Locale locale, params object[] parameters)
            : this(text, packageKey, locale.GetLanguageTagText(), parameters) { }

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="processor"></param>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        public Text(TranslationProcessor processor, string text, string packageKey)
            : this(processor, text, packageKey, LanguageTag.Current, null) { }

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="processor"></param>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="parameters"></param>
        public Text(TranslationProcessor processor, string text, string packageKey, params object[] parameters)
            : this(processor, text, packageKey, LanguageTag.Current, parameters) { }

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="processor"></param>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        public Text(TranslationProcessor processor, string text, string packageKey, string languageTag)
            : this(processor, text, packageKey, languageTag, null) { }

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="processor"></param>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        public Text(TranslationProcessor processor, string text, string packageKey, ILanguageTag languageTag)
            : this(processor, text, packageKey, languageTag, null) { }

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="processor"></param>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="locale"></param>
        public Text(TranslationProcessor processor, string text, string packageKey, Locale locale)
            : this(processor, text, packageKey, locale.GetLanguageTagText(), null) { }

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="processor"></param>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        /// <param name="parameters"></param>
        public Text(TranslationProcessor processor, string text, string packageKey, string languageTag, params object[] parameters)
            : this(processor, text, packageKey, LanguageTagManager.Get(languageTag), parameters) { }

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="processor"></param>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="languageTag"></param>
        /// <param name="parameters"></param>
        public Text(TranslationProcessor processor, string text, string packageKey, ILanguageTag languageTag, params object[] parameters)
        {
            LanguageTag = languageTag as LanguageTag ?? LanguageTag.Current;
            PackageKey = packageKey;
            OriginText = text;
            FormatingParameters = parameters;

            _translationProcessor = processor ?? throw new ArgumentNullException(nameof(processor));
            CustomFormatProvider = (packageKeyArg, languageTagArg, textArg, parametersArg) => string.Format(textArg, parametersArg);
        }

        /// <summary>
        /// Create a new instance of <see cref="Text"/>.
        /// </summary>
        /// <param name="processor"></param>
        /// <param name="text"></param>
        /// <param name="packageKey"></param>
        /// <param name="locale"></param>
        /// <param name="parameters"></param>
        public Text(TranslationProcessor processor, string text, string packageKey, Locale locale, params object[] parameters)
            : this(processor, text, packageKey, locale.GetLanguageTagText(), parameters) { }

        /// <summary>
        /// Gets or sets custom format provider
        /// </summary>
        public Func<string, ILanguageTag, string, object[], string> CustomFormatProvider { get; set; }

        /// <summary>
        /// Convert to String
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static implicit operator string(Text t) => t.ToString();

        /// <summary>
        /// To String.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var text = PackageKey == TranslationManager.ANONYMOUS_PACKAGE_KEY
                ? _translationProcessor.AnonymousTranslate(LanguageTag, OriginText)
                : _translationProcessor.Translate(LanguageTag, PackageKey, OriginText);
            if (FormatingParameters != null)
                text = CustomFormatProvider == null
                    ? string.Format(text, FormatingParameters)
                    : CustomFormatProvider(PackageKey, LanguageTag, OriginText, FormatingParameters);
            return text;
        }

        /// <summary>
        /// Text hashcode
        /// </summary>
        /// <returns></returns>
        public int TextHashCode() => OriginText.GetHashCode();

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Text other)
        {
            return LanguageTag != null && other.LanguageTag != null &&
                   LanguageTag.Equals(other.LanguageTag) &&
                   PackageKey == other.PackageKey &&
                   OriginText == other.OriginText &&
                   FormatingParameters.EqualsSupportsNull(other.FormatingParameters);
        }
    }
}