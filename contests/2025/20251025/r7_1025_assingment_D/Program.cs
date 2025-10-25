using System.Collections.Generic;

namespace r7_1025_assingment_D {
    internal class Program {
        /// <summary>
        /// D - On AtCoder Conference
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc429/tasks/abc429_d</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var m = Convert.ToInt32(conditions1[1]);
            var c = Convert.ToInt32(conditions1[2]);

            // key:position , value: count
            var posCounts = new Dictionary<int, int>();

            var conditions2 = Console.ReadLine()?.Split(' ');
            if (conditions2 == null) return;
            for (var i = 0; i < conditions2.Length; i++) {
                var p = Convert.ToInt32(conditions2[i]);
                if (posCounts.ContainsKey(p)) posCounts[p]++;
                else posCounts.Add(p, 1);
            }

            long sum = 0;
            var current = 0;
            for (var i = 0; i < m; i++) {
                long currentTurn = 0;
                while (true) {
                    if (++current == m) current = 0;
                    if (!posCounts.ContainsKey(current)) continue;
                    currentTurn += posCounts[current];
                    if (currentTurn >= c) break;
                }
                sum += currentTurn;
            }
            Console.WriteLine(sum);
        }
    }
}
