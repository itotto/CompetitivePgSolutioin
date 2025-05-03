using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace r7_0503_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Cycle Graph?
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc404/tasks/abc404_c</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var m = Convert.ToInt32(conditions[1]);

            var edges = new Dictionary<int, List<int>>();
            for (var i = 0; i < m; i++) {
                var cs = Console.ReadLine()?.Split(' ');
                if (cs == null) return;
                var node_from = Convert.ToInt32(cs[0]);
                var node_to = Convert.ToInt32(cs[1]);

                if (edges.ContainsKey(node_from)) edges[node_from].Add(node_to);
                else edges.Add(node_from, new List<int> { node_to });

                if (edges.ContainsKey(node_to)) edges[node_to].Add(node_from);
                else edges.Add(node_to, new List<int> { node_from });
            }

            var result = edges.Keys.Count > 0;
            if (result) {
                var startNode = edges.Keys.ToList()[0];
                var lastNode = -1;
                var nextNode = startNode;


                var procCount = 0;
                while (true) {
                    if (!edges.ContainsKey(nextNode)) {
                        result = false;
                        break;
                    }
                    var nodes = edges[nextNode];

                    // ノードが2個以外の場合は×
                    if (nodes.Count != 2) {
                        result = false;
                        break;
                    }

                    // 次のノードを決定
                    if (lastNode == -1) {
                        lastNode = nextNode;
                        nextNode = nodes[0];

                    } else {
                        if (lastNode == nodes[0]) {
                            lastNode = nextNode;
                            nextNode = nodes[1];
                        } else if (lastNode == nodes[1]) {
                            lastNode = nextNode;
                            nextNode = nodes[0];
                        } else {
                            result = false;
                            break;
                        }
                    }

                    if (++procCount >= n) {
                        result = nextNode == startNode;
                        break;
                    }
                }
            }
            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
