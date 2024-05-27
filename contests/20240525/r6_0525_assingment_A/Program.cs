using System.Collections.Generic;

namespace r6_0525_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Who Ate the Cake?
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc355/tasks/abc355_a</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var a = Convert.ToInt32(conditions[0]);
            var b = Convert.ToInt32(conditions[1]);

            var result = -1;
            if (a != b) {
                result = 6 - (a + b);
            }
            Console.WriteLine(result);
        }
    }
}
