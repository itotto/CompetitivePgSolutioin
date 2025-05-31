using System.Collections.Generic;

namespace r7_0531_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Not All Covered 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc408/tasks/abc408_c</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var m = Convert.ToInt32(conditions1[1]);

            // 最初は全部0(最初と最後のオフセットを足して+2)
            var rangeDistincts = new int[n + 2];
            for (var i = 0; i <= n + 1; i++) rangeDistincts[i] = 0;
            for (var i = 0; i < m; i++) {
                var ranges = Console.ReadLine()?.Split(' ');
                if (ranges == null) return;
                var s = Convert.ToInt32(ranges[0]);
                var e = Convert.ToInt32(ranges[1]);

                rangeDistincts[s]++;
                rangeDistincts[e + 1]--;
            }

            var min = int.MaxValue;
            var walls = new int[n + 1];
            walls[0] = 0;
            for (var i = 1; i<= n; i++) {
                walls[i] = rangeDistincts[i] + walls[i - 1];
                if (min > walls[i]) min = walls[i];
            }

            Console.WriteLine(min);
        }
    }
}
