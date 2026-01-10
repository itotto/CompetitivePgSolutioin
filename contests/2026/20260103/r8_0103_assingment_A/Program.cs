using System.Collections.Generic;

namespace r8_0103_assingment_A {
    internal class Program {
        /// <summary>
        /// A - 2^n - 2*n
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var term1 = 1;
            for (var i = 1; i <= n; i++) {
                term1 *= 2;
            }

            var term2 = 2 * n;

            Console.WriteLine(term1 - term2);
        }
    }
}
