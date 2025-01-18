using System.Collections.Generic;

namespace r7_0111_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Heavy Snake
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc388/tasks/abc388_b</remarks>
        static void Main() {
            var cnd1 = Console.ReadLine()?.Split(' ');
            if (cnd1 == null) return;
            var n = Convert.ToInt32(cnd1[0]);
            var d = Convert.ToInt32(cnd1[1]);

            var snakeSize = new List<KeyValuePair<int, int>>();
            for (var i = 0; i < n; i++) {
                var cnds = Console.ReadLine()?.Split(' ');
                if (cnds == null) return;
                snakeSize.Add(new KeyValuePair<int, int>(Convert.ToInt32(cnds[0]), Convert.ToInt32(cnds[1])));
            }

            for (var k = 1; k <= d; k++) {
                var maxWeight = 0;
                foreach (var ss in snakeSize) {
                    var w = ss.Key * (ss.Value + k);
                    if (w > maxWeight) maxWeight = w;
                }
                Console.WriteLine(maxWeight);
            }
        }
    }
}
