using System.Collections.Generic;

namespace r6_0615_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Ticket Counter
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc358/tasks/abc358_b</remarks>
        static void Main() {
            var cs1 = Console.ReadLine()?.Split(' ');
            if (cs1 == null) return;
            var n = Convert.ToInt32(cs1[0]);
            var a = Convert.ToInt32(cs1[1]);

            var visitTimes = Console.ReadLine()?.Split(' ');
            if (visitTimes == null) return;

            var t = 0;
            for (int i = 0; i < visitTimes.Length; i++) {
                var t1 = t + a;
                var t2 = Convert.ToInt32(visitTimes[i]) + a;
                t = Math.Max(t1, t2);
                Console.WriteLine(t);
            }
        }
    }
}
