using System.Collections.Generic;

namespace r7_1206_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Triangular Number 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc435/tasks/abc435_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var result = n * (n + 1) / 2;
            Console.WriteLine(result);
        }
    }
}
