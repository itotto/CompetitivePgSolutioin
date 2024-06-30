using System.Collections.Generic;

namespace r6_0630_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Move It 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc360/tasks/abc360_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var data1 = Console.ReadLine()?.Split(' ');
            if (data1 == null) return;

            // 荷物を取得
            var cargos = new Dictionary<int, List<int>>();
            for (var i = 0; i < n; i++) {
                var a_i = Convert.ToInt32(data1[i]);
                if (cargos.ContainsKey(a_i)) cargos[a_i].Add(i + 1);
                else cargos.Add(a_i, new List<int>() { i + 1 });
            }

            var duplicateList = new List<int>();
            foreach (var c in cargos) {
                if (c.Value.Count >= 2) duplicateList.Add(c.Key);
            }

            // 重さを取得
            var weigths = new Dictionary<int, int>();
            var data2 = Console.ReadLine()?.Split(' ');
            if (data2 == null) return;
            for (var i = 0; i < n; i++) {
                weigths.Add(i + 1, Convert.ToInt32(data2[i]));
            }

            // 移動する重さの総重量を計算
            var cost = 0;

            foreach (var d in duplicateList) {
                var pSum = 0;
                var pMax = -1;
                var cargo = cargos[d];
                foreach (var c in cargo) {
                    var w = weigths[c];
                    pSum += w;
                    if (pMax < w) pMax = w;
                }
                cost += (pSum - pMax);
            }

            Console.WriteLine(cost);
        }
    }
}
