using System.Collections.Generic;

namespace r6_0824_assingment_D {
    internal class Program {
        /// <summary>
        /// D - Minimum Steiner Tree
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc368/tasks/abc368_d</remarks>
        static void Main() {
            // 条件入力
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var k = Convert.ToInt32(conditions1[1]);

            // ノードを入力
            var nodes = new Dictionary<int, List<int>>();
            for (var i = 0; i < n; i++) {
                var conditions2 = Console.ReadLine()?.Split(' ');
                if (conditions2 == null) return;

                var node_from = Convert.ToInt32(conditions2[0]);
                var node_to = Convert.ToInt32(conditions2[1]);
                if (nodes.ContainsKey(node_from)) nodes[node_from].Add(node_to);
                else nodes[node_from] = new List<int> { node_to };
            }

            // 残したいノードを取得
            var conditions3 = Console.ReadLine()?.Split(' ');
            if (conditions3 == null) return;
            var needNodes = new List<int>();
            foreach (var c in conditions3) {
                needNodes.Add(Convert.ToInt32(c));
            }

            var cnt = 1;
            if (needNodes.Count >= 2) {

            }
            Console.WriteLine(cnt);
        }
    }
}
