using System.Collections.Generic;

namespace r8_0131_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Chokutter Addiction
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc443/tasks/abc443_c</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var t = Convert.ToInt32(conditions1[1]);

            var a_i = new int[n + 1];
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            for (var i = 0; i < n; i++) {
                a_i[i] = Convert.ToInt32(conditions[i]);
            }
            a_i[n] = t;

            var totalSec = n == 0 ? t : 0;

            if (n >= 1) {
                var nextStartTime = 0;

                for (var i = 0; i <= n; i++) {
                    // まだ見ていい時間になってなければ次へ
                    if (a_i[i] < nextStartTime) continue;
                    totalSec += a_i[i] - nextStartTime;
                    nextStartTime = a_i[i] + 100;
                }
            }
            Console.WriteLine(totalSec);
        }
    }
}
