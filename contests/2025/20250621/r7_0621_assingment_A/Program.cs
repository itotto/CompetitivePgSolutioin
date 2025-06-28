using System.Collections.Generic;

namespace r7_0621_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Required Length
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc411/tasks/abc411_a</remarks>
        static void Main() {
            var p = Console.ReadLine();
            if (string.IsNullOrEmpty(p)) return;

            var l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.Length >= l ? "Yes" : "No");
        }
    }
}
