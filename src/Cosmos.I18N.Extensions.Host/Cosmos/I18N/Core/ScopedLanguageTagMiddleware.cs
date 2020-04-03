#if !NETSTANDARD2_1

using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Cosmos.I18N.Core {
    /// <summary>
    /// Scoped language tag middleware
    /// </summary>
    public class ScopedLanguageTagMiddleware {
        private readonly RequestDelegate _next;

        /// <summary>
        /// Create a new instance of <see cref="ScopedLanguageTagMiddleware"/>.
        /// </summary>
        /// <param name="next"></param>
        public ScopedLanguageTagMiddleware(RequestDelegate next) {
            _next = next;
        }

        /// <summary>
        /// Invoke async
        /// </summary>
        /// <param name="context"></param>
        /// <param name="accessor"></param>
        /// <returns></returns>
        public async Task InvokeAsync(HttpContext context, IRequestedLanguageTagAccessor accessor) {

            //Set current LanguageTag in LanguageTagCoreManager.
            //If the value is null, empty or whitespace, will be used 'DefaultLocaleStr' - 'en_US'.
            var languageTag = AntManager.Get(context, accessor);

            LanguageTagCoreManager.UpdateTag(languageTag);

            await _next(context);
        }
    }
}

#endif