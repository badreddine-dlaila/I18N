using System;
using Cosmos.I18N.Adapters.Json.Internals;
using Cosmos.I18N.Core;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N.Adapters.Json {
    /// <summary>
    /// Json formatting adapter for AbpFx
    /// </summary>
    public static class AbpJsonFormattingAdapterExtensions {
        /// <summary>
        /// Add AbpFx Resource
        /// </summary>
        /// <param name="services"></param>
        /// <param name="virtualPath"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static II18NServiceCollection AddAbpResourceFrom(this II18NServiceCollection services, string virtualPath) {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            if (string.IsNullOrWhiteSpace(virtualPath))
                throw new ArgumentNullException(nameof(virtualPath));

            var path = PathHelper.Combine(services.ExposeOptions, virtualPath, true);

            try {
                foreach (var filePath in PathHelper.GetSeveralPathList(path)) {
                    using (var bridgeAdapter = new AbpJsonFileAdapter(filePath)) {
                        if (bridgeAdapter.Process()) {
                            var speaker = bridgeAdapter.Speak();
                            services.ExposeOptions.AddResource(speaker.PackageKey, TranslateResourceFactory.Create(speaker));
                        }
                    }
                }
            }
            catch (Exception exception) {
                InternalLogger.WriteLine($"Thrown exception when add json resource from {path}, message: {0}", exception.Message);
            }

            return services;
        }
    }
}