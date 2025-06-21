using System.Collections.Generic;

namespace r7_0614_assingment_A {
    internal class Program {
        /// <summary>
        /// A - G1
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc410/tasks/abc410_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;

            var k = Convert.ToInt32(Console.ReadLine());

            var count = 0;
            for (var i = 0; i < n; i++) {
                var a_i = Convert.ToInt32(conditions[i]);
                if (a_i >= k) count++;
            }

            Console.WriteLine(count);
        }
    }
}
