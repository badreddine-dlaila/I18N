#if !NETSTANDARD2_1

using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Cosmos.I18N {
    internal static partial class AntManager {

        public static string Get(HttpContext context, IRequestedLanguageTagAccessor accessor) {
            var antChain = GetAntChain();
            var languageTag = string.Empty;

            if (antChain is null) {

                languageTag = GetFromCookie(context, accessor);

            } else {

                do {
                    var antPosNames = antChain.AntPosNames is null || antChain.AntPosNames.Count == 0
                        ? new[] {AntPosNameConstants.LANGUAGE_TAG}
                        : antChain.AntPosNames.ToArray();

                    languageTag = antChain.From switch {
                        AntFrom.Cookie      => GetFromCookie(context, accessor, antPosNames),
                        AntFrom.Route       => GetFromRoute(context, antPosNames),
                        AntFrom.QueryString => GetFromQuery(context, antPosNames),
                        AntFrom.Forms       => GetFromForms(context, antPosNames),
                        AntFrom.Headers     => GetFromHeader(context, antPosNames),
                        _                   => languageTag
                    };

                    if (!string.IsNullOrWhiteSpace(languageTag))
                        break;

                    antChain = antChain.Next;

                } while (antChain != null);

            }

            return languageTag;
        }


        private static string GetFromCookie(HttpContext context, IRequestedLanguageTagAccessor accessor, params string[] antPosNames) {
            var languageTag = string.Empty;
            foreach (var antPosName in antPosNames) {
                languageTag = accessor is null || !accessor.HasContext
                    ? context.Request.Cookies[antPosName]
                    : accessor.Get(antPosName);
                if (!string.IsNullOrWhiteSpace(languageTag))
                    return languageTag;
            }

            return languageTag;
        }

        private static string GetFromRoute(HttpContext context, params string[] antPosNames) {
            var routeData = context.GetRouteData();
            if (routeData is null)
                return string.Empty;
            foreach (var antPosName in routeData.Values.Keys) {
                if (antPosNames.Contains(antPosName))
                    return routeData.Values[antPosName].ToString();
            }

            return string.Empty;
        }

        private static string GetFromQuery(HttpContext context, params string[] antPosNames) {
            var query = context.Request.Query;
            if (query is null)
                return string.Empty;
            foreach (var antPosName in antPosNames) {
                if (query.ContainsKey(antPosName))
                    return query[antPosName];
            }

            return string.Empty;
        }

        private static string GetFromForms(HttpContext context, params string[] antPosNames) {
            var forms = context.Request.Form;
            if (forms is null)
                return string.Empty;
            foreach (var antPosName in antPosNames) {
                if (forms.ContainsKey(antPosName))
                    return forms[antPosName];
            }

            return string.Empty;
        }

        private static string GetFromHeader(HttpContext context, params string[] antPosNames) {
            var headers = context.Request.Headers;
            if (headers is null)
                return string.Empty;
            foreach (var antPosName in antPosNames) {
                if (headers.ContainsKey(antPosName))
                    return headers[antPosName];
            }

            return string.Empty;
        }
    }
}

#endif