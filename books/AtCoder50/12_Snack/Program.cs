using System.Collections.Generic;

namespace _12_Snack {
    internal class Program {
        /// <summary>
        /// C - Snack
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc148/tasks/abc148_c</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var a = Convert.ToInt64(conditions[0]);
            var b = Convert.ToInt64(conditions[1]);
            Console.WriteLine(a / Gcd(a,b) * b);
        }

        static long Gcd(long a, long b) {
            if (a == 0 || b == 0) return 0;
            if (a != b) {
                if (a < b) {
                    var t = a;
                    a = b;
                    b = t;
                }
                while (b != 0) {
                    var c = a % b;
                    a = b;
                    b = c;
                }
            }
            return a;
        }
    }
}
