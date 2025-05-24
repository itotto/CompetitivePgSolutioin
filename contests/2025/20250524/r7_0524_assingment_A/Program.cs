using System.Collections.Generic;

namespace r7_0524_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Approximation
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc407/tasks/abc407_a</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var a = Convert.ToInt32(conditions[0]);
            var b = Convert.ToInt32(conditions[1]);

            var d = (double)a / b;

            var result = 0;
            var lastDiff = double.MaxValue;
            for (var i = 0; i <= 407; i++) {
                var diff = (d > i) ? d - i : i - d;
                if (lastDiff <= diff) break;
                result = i;
                lastDiff = diff;
            }
            Console.WriteLine(result);
        }
    }
}
