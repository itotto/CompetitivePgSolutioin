using System.Collections.Generic;

namespace r7_1213_assingment_A {
    internal class Program {
        /// <summary>
        /// A - o-padding
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc436/tasks/abc436_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            Console.WriteLine($"{new string('o', n - s.Length)}{s}");
        }
    }
}
