using System.Threading.Tasks;
using Cosmos.Asynchronous;
using Cosmos.I18N.Extensions.AspNetCore.Core.Internals;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Cosmos.I18N.Extensions.AspNetCore.TagHelpers {
    /// <summary>
    /// Anonymous translate tag helper<br />
    /// You should type '@addTagHelper *, Cosmos.I18N.Extensions.AspNetCore.TagHelpers' in 'ViewImports.cshtml' first.
    /// </summary>
    [HtmlTargetElement("cosmos-i18n-a")]
    public class AnonymousTagHelper : BaseTagHelper {

        /// <summary>
        /// Create a new instance of <see cref="AnonymousTagHelper"/>.
        /// </summary>
        /// <param name="accessor"></param>
        /// <param name="textProvider"></param>
        public AnonymousTagHelper(IRequestedLanguageTagAccessor accessor, ITextProvider textProvider)
            : base(accessor, textProvider) { }

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
                output.Content.SetHtmlContent(_textProvider.Anonymous(Text, GetLanguageTag(), Params).ToString());
            else
                output.Content.SetContent(_textProvider.Anonymous(Text, GetLanguageTag(), Params).ToString());
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
                output.Content.SetHtmlContent(_textProvider.Anonymous(Text, GetLanguageTag(), Params).ToString());
            else
                output.Content.SetContent(_textProvider.Anonymous(Text, GetLanguageTag(), Params).ToString());
            return Tasks.CompletedTask();
        }
    }
}