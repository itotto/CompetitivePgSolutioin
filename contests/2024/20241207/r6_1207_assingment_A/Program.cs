using System.Collections.Generic;

namespace r6_1207_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Humidifier 1
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc383/tasks/abc383_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var firstInputs = Console.ReadLine()?.Split(' ');
            if (firstInputs == null) return;

            var lastTime = Convert.ToInt32(firstInputs[0]);
            var totalVolume = Convert.ToInt32(firstInputs[1]);
            for (var i = 1; i < n; i++) {
                var cs = Console.ReadLine()?.Split(' ');
                if (cs == null) return;

                var t = Convert.ToInt32(cs[0]);
                var v = Convert.ToInt32(cs[1]);

                if (t - lastTime <= totalVolume) {
                    totalVolume -= t - lastTime;
                } else {
                    totalVolume = 0;
                }
                lastTime = t;
                totalVolume += v;
            }

            Console.WriteLine(totalVolume);

        }
    }
}
