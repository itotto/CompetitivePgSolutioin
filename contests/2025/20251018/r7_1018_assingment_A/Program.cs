using System.Collections.Generic;

namespace r7_1018_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Grandma's Footsteps
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc428/tasks/abc428_a</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var s = Convert.ToInt32(conditions[0]);
            var a = Convert.ToInt32(conditions[1]);
            var b = Convert.ToInt32(conditions[2]);
            var x = Convert.ToInt32(conditions[3]);

            var distance = 0;
            while (x > 0) {
                x -= a;
                var t = a;
                if (x < 0) t += x;
                distance += t * s;
                x -= b;
            }

            Console.WriteLine(distance);
        }
    }
}
