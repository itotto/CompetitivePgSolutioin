using System.Collections.Generic;

namespace r7_1227_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Substring 2
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc438/tasks/abc438_b</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var m = Convert.ToInt32(conditions[1]);

            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            var t = Console.ReadLine();
            if (string.IsNullOrEmpty(t)) return;

            var minCount = int.MaxValue;
            for (var i = 0; i <= n - m; i++) {
                var currentCount = 0;
                // Tの先頭から比較する
                for (var j = 0; j < m; j++) {
                    var s_current = s[i + j];
                    var t_current = t[j];
                    if (s_current == t_current) continue;
                    //var diff = t_current - s_current;
                    var diff = s_current - t_current;
                    if (diff <= 0) diff += 10;
                    currentCount += diff;
                }
                if (currentCount < minCount) minCount = currentCount;
            }
            Console.WriteLine(minCount);
        }
    }
}
