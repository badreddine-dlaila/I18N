using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Languages;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N.Core
{
    internal static class TranslationGetter
    {
        public static bool FallbackMode(LanguageTag languageTagInstance, string resourceKey, out string result,
            IReadOnlyDictionary<LanguageTag, ITranslateResource> resources, FallbackExperimenter experimenter)
        {
            result = string.Empty;

            if (resources.TryGetValue(languageTagInstance, out var resource) && resource.CanTranslate(resourceKey))
            {
                result = resource.Translate(resourceKey);
                return true;
            }

            var suitableTags = experimenter.GetSuitableTags(languageTagInstance).ToList();

            if (!suitableTags.Any())
                return false;

            foreach (var tag in suitableTags)
            {
                if (resources.TryGetValue(tag, out resource) && resource.CanTranslate(resourceKey))
                {
                    result = resource.Translate(resourceKey);
                    return true;
                }
            }

            return false;
        }

        public static bool SequenceMode(LanguageTag languageTagInstance, string resourceKey, out string result,
            IReadOnlyDictionary<LanguageTag, ITranslateResource> resources)
        {
            result = string.Empty;

            if (resources.TryGetValue(languageTagInstance, out var resource) && resource.CanTranslate(resourceKey))
            {
                result = resource.Translate(resourceKey);
                return true;
            }

            foreach (var resource2 in resources)
            {
                if (resource2.Value.CanTranslate(resourceKey))
                {
                    result = resource2.Value.Translate(resourceKey);
                    return true;
                }
            }

            return false;
        }

        public static bool StrictMode(LanguageTag languageTagInstance, string resourceKey, out string result,
            IReadOnlyDictionary<LanguageTag, ITranslateResource> resources)
        {
            result = string.Empty;

            if (resources.TryGetValue(languageTagInstance, out var resource) && resource.CanTranslate(resourceKey))
            {
                result = resource.Translate(resourceKey);
                return true;
            }

            return false;
        }
    }
}