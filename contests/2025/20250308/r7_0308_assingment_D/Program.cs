using System.Collections.Generic;

namespace r7_0308_assingment_D {
    internal class Program {
        /// <summary>
        /// D - Minimum XOR Path
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc396/tasks/abc396_d</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var m = Convert.ToInt32(conditions[1]);

            var nodes = new Dictionary<int, List<int>>();
            var paths = new Dictionary<string, ulong>();

            for (var i = 0; i < m; i++) {
                var cs = Console.ReadLine()?.Split(' ');
                if (cs == null) return;
                var u = Convert.ToInt32(cs[0]);
                var v = Convert.ToInt32(cs[1]);
                var w = Convert.ToUInt64(cs[2]);

                if (nodes.ContainsKey(u)) nodes[u].Add(v);
                else nodes.Add(u, new List<int> { v });

                // 経路を追加
                paths.Add($"{u}-{v}", w);
            }

            ulong result = 0;

            foreach (var next_1 in nodes[1]) {
                var alreadyOver = new Dictionary<int, bool>();
                alreadyOver.Add(next_1, true);


            }


            Console.WriteLine(result);
        }
    }
}
