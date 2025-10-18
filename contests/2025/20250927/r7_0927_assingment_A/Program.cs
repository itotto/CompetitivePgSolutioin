using System.Collections.Generic;

namespace r7_0927_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Sigma Cubes
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc425/tasks/abc425_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var result = 0;

            for (var i = 1; i <= n; i++) {
                var x = i * i * i;
                if (i % 2 == 0) result += x;
                else result -= x;
            }
            Console.WriteLine(result);
        }
    }
}
