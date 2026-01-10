using System.Collections.Generic;

namespace _1_SquareInequality {
    internal class Program {
        /// <summary>
        /// A - Square Inequality
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc199/tasks/abc199_a</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var a = Convert.ToInt32(conditions[0]);
            var b = Convert.ToInt32(conditions[1]);
            var c = Convert.ToInt32(conditions[2]);

            Console.WriteLine(a * a + b * b < c * c ? "Yes" : "No");
        }
    }
}
