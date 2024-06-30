using System.Collections.Generic;

namespace r6_0622_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Couples
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc359/tasks/abc359_b</remarks>
        static void Main() {
            const int CORRECT_DISTANCE = 2;
            var n = Convert.ToInt32(Console.ReadLine());

            var cnt = 0;
            var colorPos = new Dictionary<int, int>(n);
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            for (var i = 0; i < n * 2; i++) {
                var a_i = Convert.ToInt32(conditions[i]);
                if (colorPos.ContainsKey(a_i)) {
                    var distance = i - colorPos[a_i];
                    if (distance == CORRECT_DISTANCE) cnt++;
                } else {
                    colorPos.Add(a_i, i);
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
