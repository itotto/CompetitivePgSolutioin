using System.Collections.Generic;

namespace r7_0712_assingment_A {
    internal class Program {
        /// <summary>
        ///  A - Streamer Takahashi
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc414/tasks/abc414_a</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var l = Convert.ToInt32(conditions1[1]);
            var r = Convert.ToInt32(conditions1[2]);

            var cnt = 0;

            for (var i = 0; i < n; i++) {
                var conditions2 = Console.ReadLine()?.Split(' ');
                if (conditions2 == null) return;
                var x_1 = Convert.ToInt32(conditions2[0]);
                var x_2 = Convert.ToInt32(conditions2[1]);
                if (x_1 <= l && r <= x_2) cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}
