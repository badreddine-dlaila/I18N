using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Languages;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N.Core
{
    internal static class TranslationChecker
    {
        public static bool FallbackMode(LanguageTag languageTagInstance, string resourceKey,
            IReadOnlyDictionary<LanguageTag, ITranslateResource> resources, FallbackExperimenter experimenter)
        {
            if (resources.TryGetValue(languageTagInstance, out var resource) && resource.CanTranslate(resourceKey))
                return true;

            var suitableTags = experimenter.GetSuitableTags(languageTagInstance).ToList();

            if (!suitableTags.Any())
                return false;

            foreach (var tag in suitableTags)
                if (resources.TryGetValue(tag, out resource) && resource.CanTranslate(resourceKey))
                    return true;

            return false;
        }

        public static bool SequenceMode(LanguageTag languageTagInstance, string resourceKey,
            IReadOnlyDictionary<LanguageTag, ITranslateResource> resources)
        {
            if (resources.TryGetValue(languageTagInstance, out var resource) && resource.CanTranslate(resourceKey))
                return true;

            foreach (var resource2 in resources)
                if (resource2.Value.CanTranslate(resourceKey))
                    return true;

            return false;
        }

        public static bool StrictMode(LanguageTag languageTagInstance, string resourceKey,
            IReadOnlyDictionary<LanguageTag, ITranslateResource> resources)
        {
            if (resources.TryGetValue(languageTagInstance, out var resource) && resource.CanTranslate(resourceKey))
                return true;
            return false;
        }
    }
}