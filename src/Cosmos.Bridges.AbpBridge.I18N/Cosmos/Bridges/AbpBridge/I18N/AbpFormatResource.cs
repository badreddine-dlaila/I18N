using System.Collections.Generic;

namespace Cosmos.Bridges.AbpBridge.I18N {
    /// <summary>
    /// AbpFx format resource
    /// </summary>
    public class AbpFormatResource {
        /// <summary>
        /// Gets or sets Culture name; eg : en , en-us, zh-CN
        /// </summary>
        public string Culture { get; set; }

        /// <summary>
        /// Texts
        /// </summary>
        public Dictionary<string, string> Texts { get; } = new Dictionary<string, string>();
    }
}