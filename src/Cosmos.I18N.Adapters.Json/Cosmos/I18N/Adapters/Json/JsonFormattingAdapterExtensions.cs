using System;
using Cosmos.I18N.Adapters.Json.Core.Internals;
using Cosmos.I18N.Core;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N.Adapters.Json {
    public static partial class JsonFormattingAdapterExtensions {
        /// <summary>
        /// Add json format resource from path...
        /// </summary>
        /// <param name="services"></param>
        /// <param name="path"></param>
        /// <param name="referenceToBasePath"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static II18NServiceCollection AddJsonResourceFrom(this II18NServiceCollection services, string path, bool referenceToBasePath = true) {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            if (!path.ToLower().EndsWith(".json"))
                path += ".json";

            if (PathHelper.IsSeveralPath(path)) {
                foreach (var file in PathHelper.GetSeveralPathList(services.ExposeOptions, path)) {
                    AddJsonResourceFromOnce(services, file, false);
                }

                return services;
            }

            return AddJsonResourceFromOnce(services, path, referenceToBasePath);
        }

        private static II18NServiceCollection AddJsonResourceFromOnce(II18NServiceCollection services, string path, bool referenceToBasePath) {
            try {
                using (var adapter = new JsonFileAdapter(PathHelper.Combine(services.ExposeOptions, path, referenceToBasePath))) {
                    if (adapter.Process()) {
                        var speaker = adapter.Speak();
                        services.ExposeOptions.AddResource(speaker.PackageKey, TranslateResourceFactory.Create(speaker));
                    }
                }
            }
            catch (Exception exception) {
                InternalLogger.WriteLine($"Thrown exception when add json resource from {path}, message: {0}", exception.Message);
            }

            return services;
        }

        /// <summary>
        /// Add json format resource
        /// </summary>
        /// <param name="services"></param>
        /// <param name="originContext"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static II18NServiceCollection AddJsonResource(this II18NServiceCollection services, string originContext) {
            if (services is null) throw new ArgumentNullException(nameof(services));
            if (string.IsNullOrWhiteSpace(originContext)) throw new ArgumentNullException(nameof(originContext));

            using (var adapter = new JsonContentAdapter(originContext)) {
                if (adapter.Process()) {
                    var speaker = adapter.Speak();
                    services.ExposeOptions.AddResource(speaker.PackageKey, TranslateResourceFactory.Create(speaker));
                }
            }

            return services;
        }
    }
}