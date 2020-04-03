namespace Cosmos.I18N.Core.Extensions {
    /// <summary>
    /// Object extensions
    /// </summary>
    internal static class ObjectExtensions {
        /// <summary>
        /// Equals support null
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool EqualsSupportsNull(this object obj, object target) {
            if (obj == null && target == null) return true;
            if (obj == null || target == null) return false;
            return ReferenceEquals(obj, target) || obj.Equals(target);
        }
    }
}