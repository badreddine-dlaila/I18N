using System;
using Cosmos.I18N.Adapters.Xml.Core.Internals;
using Cosmos.I18N.Core;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N.Adapters.Xml
{
    public static partial class XmlFormattingAdapterExtensions
    {
        public static II18NServiceCollection AddXmlResourceFrom(this II18NServiceCollection services, string path, bool referenceToBasePath = true)
        {
            if (services == null) 
                throw new ArgumentNullException(nameof(services));
            
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));
            
            if (!path.ToLower().EndsWith(".xml"))
                path += ".xml";

            if (PathHelper.IsSeveralPath(path))
            {
                foreach (var file in PathHelper.GetSeveralPathList(services.ExposeOptions, path))
                {
                    AddXmlResourceFromOnce(services, file, false);
                }

                return services;
            }

            return AddXmlResourceFromOnce(services, path, referenceToBasePath);
        }

        private static II18NServiceCollection AddXmlResourceFromOnce(II18NServiceCollection services, string path, bool referenceToBasePath)
        {
            try
            {
                using (var adapter = new XmlFileAdapter(PathHelper.Combine(services.ExposeOptions, path, referenceToBasePath)))
                {
                    if (adapter.Process())
                    {
                        var speaker = adapter.Speak();
                        services.ExposeOptions.AddResource(speaker.PackageKey, TranslateResourceFactory.Create(speaker));
                    }
                }
            }
            catch (Exception exception)
            {
                InternalLogger.WriteLine($"Thrown exception when add xml resource from {path}, message: {0}", exception.Message);
            }

            return services;
        }
        
        public static II18NServiceCollection AddXmlResource(this II18NServiceCollection services, string originContext)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (string.IsNullOrWhiteSpace(originContext)) throw new ArgumentNullException(nameof(originContext));
            using (var adapter = new XmlContentAdapter(originContext))
            {
                if (adapter.Process())
                {
                    var speaker = adapter.Speak();
                    services.ExposeOptions.AddResource(speaker.PackageKey, TranslateResourceFactory.Create(speaker));
                }
            }

            return services;
        }
    }
}