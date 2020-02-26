using System;
using Cosmos.I18N.Adapters.Yaml.Core.Internals;
using Cosmos.I18N.Core;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N.Adapters.Yaml {
    public static partial class YamlFormattingAdapterExtensions {
        /// <summary>
        /// Add json format resource from path...
        /// </summary>
        /// <param name="services"></param>
        /// <param name="path"></param>
        /// <param name="referenceToBasePath"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static II18NServiceCollection AddYamlResourceFrom(this II18NServiceCollection services, string path, bool referenceToBasePath = true) {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            if (!path.ToLower().EndsWith(".yml"))
                path += ".yml";

            if (PathHelper.IsSeveralPath(path)) {
                foreach (var file in PathHelper.GetSeveralPathList(services.ExposeOptions, path)) {
                    AddYamlResourceFromOnce(services, file, false);
                }

                return services;
            }

            return AddYamlResourceFromOnce(services, path, referenceToBasePath);
        }

        private static II18NServiceCollection AddYamlResourceFromOnce(II18NServiceCollection services, string path, bool referenceToBasePath) {
            try {
                using (var adapter = new YamlFileAdapter(PathHelper.Combine(services.ExposeOptions, path, referenceToBasePath))) {
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
        public static II18NServiceCollection AddYamlResource(this II18NServiceCollection services, string originContext) {
            if (services is null) throw new ArgumentNullException(nameof(services));
            if (string.IsNullOrWhiteSpace(originContext)) throw new ArgumentNullException(nameof(originContext));

            using (var adapter = new YamlContentAdapter(originContext)) {
                if (adapter.Process()) {
                    var speaker = adapter.Speak();
                    services.ExposeOptions.AddResource(speaker.PackageKey, TranslateResourceFactory.Create(speaker));
                }
            }

            return services;
        }
    }
}