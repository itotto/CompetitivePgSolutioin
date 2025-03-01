using System.Collections.Generic;

namespace r7_0215_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Make it Simple
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc393/tasks/abc393_c</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var m = Convert.ToInt32(conditions1[1]);

            var nodes = new Dictionary<string, bool>();

            var count = 0;
            for (var i = 0; i < m; i++) {
                var inputs = Console.ReadLine()?.Split(' ');
                if (inputs == null) return;
                var node1 = Convert.ToInt32(inputs[0]);
                var node2 = Convert.ToInt32(inputs[1]);

                // 自己ループははじく
                if (node1 == node2) {
                    count++;
                    continue;
                }

                var key = node1 > node2 ? $"{node2}-{node1}" : $"{node1}-{node2}";
                if (nodes.ContainsKey(key)) {
                    count++;
                    continue;
                } else {
                    nodes.Add(key, true);
                }
            }

            Console.WriteLine(count);
        }
    }
}
