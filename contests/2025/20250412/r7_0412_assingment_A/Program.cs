using System.Collections.Generic;

namespace r7_0412_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Status Code
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc401/tasks/abc401_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(200 <= n && n <= 299 ? "Success" : "Failure");
        }
    }
}
