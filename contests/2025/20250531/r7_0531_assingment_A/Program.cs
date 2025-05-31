using System.Collections.Generic;

namespace r7_0531_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Timeout
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc408/tasks/abc408_a</remarks>
        static void Main() {
            var condtions = Console.ReadLine()?.Split(' ');
            if (condtions == null) return;
            var n = Convert.ToInt32(condtions[0]);
            var s = Convert.ToInt32(condtions[1]);


            var sleepCount = 0;
            var lastV = 0;
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            for (var i = 0; i < inputs.Length; i++) {
                var t_i = Convert.ToInt32(inputs[i]);
                if (t_i -  lastV > s) {
                    sleepCount++;
                }
                lastV = t_i;
            }
            Console.WriteLine(sleepCount == 0 ? "Yes" : "No");
        }
    }
}
