namespace Cosmos.I18N {
    internal static partial class AntManager {
        private static Ant AntHead { get; set; }
        private static Ant AntTail { get; set; }

        private static object _antLockObj = new object();

        public static void AppendAnt(AntFrom from, params string[] bodyNames) {
            lock (_antLockObj) {
                var ant = new Ant(from, bodyNames);
                if (AntHead is null) {
                    AntHead = ant;
                    AntTail = ant;
                } else {
                    AntTail.Next = ant;
                    AntTail = ant;
                }
            }
        }

        public static Ant GetAntChain() => AntHead;
    }
}