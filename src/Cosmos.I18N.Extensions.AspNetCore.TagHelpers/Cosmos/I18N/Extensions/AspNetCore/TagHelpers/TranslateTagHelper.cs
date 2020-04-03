using System.Threading.Tasks;
using Cosmos.Asynchronous;
using Cosmos.I18N.Extensions.AspNetCore.Core.Internals;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Cosmos.I18N.Extensions.AspNetCore.TagHelpers {
    /// <summary>
    /// Translate tag helper
    /// You should type '@addTagHelper *, Cosmos.I18N.Extensions.AspNetCore.TagHelpers' in 'ViewImports.cshtml' first.
    /// </summary>
    [HtmlTargetElement("cosmos-i18n")]
    public class TranslateTagHelper : BaseTagHelper {
        /// <summary>
        /// Create a new instance of <see cref="TranslateTagHelper"/>.
        /// </summary>
        /// <param name="accessor"></param>
        /// <param name="textProvider"></param>
        public TranslateTagHelper(IRequestedLanguageTagAccessor accessor, ITextProvider textProvider)
            : base(accessor, textProvider) { }

        /// <summary>
        /// Package Namespace, also means PackageKey
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Process
        /// </summary>
        /// <param name="context"></param>
        /// <param name="output"></param>
        public override void Process(TagHelperContext context, TagHelperOutput output) {
            Check();

            output.TagMode = TagMode.StartTagAndEndTag;
            output.TagName = "span";
            if (OutputHtml)
                output.Content.SetHtmlContent(_textProvider.Create(Text, Namespace, GetLanguageTag(), Params).ToString());
            else
                output.Content.SetContent(_textProvider.Create(Text, Namespace, GetLanguageTag(), Params).ToString());
        }

        /// <summary>
        /// Process async
        /// </summary>
        /// <param name="context"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output) {
            Check();

            output.TagMode = TagMode.StartTagAndEndTag;
            output.TagName = "span";
            if (OutputHtml)
                output.Content.SetHtmlContent(_textProvider.Create(Text, Namespace, GetLanguageTag(), Params).ToString());
            else
                output.Content.SetContent(_textProvider.Create(Text, Namespace, GetLanguageTag(), Params).ToString());
            return Tasks.CompletedTask();
        }
    }
}