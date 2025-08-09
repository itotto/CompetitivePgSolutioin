using System.Collections.Generic;

namespace r7_0802_assingment_A {
    internal class Program {
        /// <summary>
        /// A - A Substring
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc417/tasks/abc417_a</remarks>
        static void Main() {
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            var n = Convert.ToInt32(inputs[0]);
            var a = Convert.ToInt32(inputs[1]);
            var b = Convert.ToInt32(inputs[2]);

            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            Console.WriteLine(s.Substring(a).Substring(0, n - a - b));
        }
    }
}
