using System;
using Cosmos.I18N.Extensions.AspNetCore.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Cosmos.I18N.Extensions.AspNetCore.Core.Internals {
    /// <summary>
    /// Base tag helper
    /// </summary>
    public abstract class BaseTagHelper : TagHelper {
        /// <summary>
        /// Accessor
        /// </summary>
        // ReSharper disable once InconsistentNaming
        protected readonly IRequestedLanguageTagAccessor _accessor;

        /// <summary>
        /// Text provider
        /// </summary>
        // ReSharper disable once InconsistentNaming
        protected readonly ITextProvider _textProvider;

        /// <summary>
        /// Create a new instance of <see cref="BaseTagHelper"/>.
        /// </summary>
        /// <param name="accessor"></param>
        /// <param name="textProvider"></param>
        protected BaseTagHelper(IRequestedLanguageTagAccessor accessor, ITextProvider textProvider) {
            _accessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
            _textProvider = textProvider ?? throw new ArgumentNullException(nameof(textProvider));
        }

        /// <summary>
        /// Language tag
        /// </summary>
        public string LanguageTag { get; set; }

        /// <summary>
        /// Original text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Parameters
        /// </summary>
        public object[] Params { get; set; }

        /// <summary>
        /// Output html or not
        /// </summary>
        public bool OutputHtml { get; set; }

        /// <summary>
        /// Check
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        protected void Check() {
            if (string.IsNullOrWhiteSpace(Text))
                throw new ArgumentNullException(nameof(Text), "Errors occurred in cosmos i18n services: empty original text.");
        }

        /// <summary>
        /// Get language tag
        /// </summary>
        /// <returns></returns>
        protected string GetLanguageTag(string languageTagBodyName = null) => _accessor.MayLanguageTag(LanguageTag, languageTagBodyName);
    }
}