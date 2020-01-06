using Cosmos.I18N.Templates;

namespace Cosmos.I18N.Adapters.Formats {
    /// <summary>
    /// Speak as xml interface
    /// </summary>
    /// <typeparam name="TTemplate"></typeparam>
    public interface ISpeakAsXml<out TTemplate> where TTemplate : class, ILocalizationTemplate, new() {
        /// <summary>
        /// Speak
        /// </summary>
        /// <returns></returns>
        TTemplate Speak();
    }
}