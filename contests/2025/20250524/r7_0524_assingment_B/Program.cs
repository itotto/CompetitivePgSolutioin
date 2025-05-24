using System.Collections.Generic;

namespace r7_0524_assingment_B {
    internal class Program {
        /// <summary>
        /// B - P(X or Y)
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc407/tasks/abc407_b</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var x = Convert.ToInt32(conditions[0]);
            var y = Convert.ToInt32(conditions[1]);

            var totalCount = 0;
            var count = 0;
            for (var i = 1; i <= 6; i++) {
                for (var j = 1; j <= 6; j++) {
                    if (i + j >= x) count++;
                    else {
                        var diff = i > j ? i - j : j - i;
                        if (diff >= y) count++;
                    }
                    totalCount++;
                }
            }
            Console.WriteLine((double)count / totalCount);
        }
    }
}
