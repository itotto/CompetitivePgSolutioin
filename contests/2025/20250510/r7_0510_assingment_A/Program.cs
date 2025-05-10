using System.Collections.Generic;

namespace r7_0510_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Is it rated?
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc405/tasks/abc405_a</remarks>
        static void Main() {
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            var r = Convert.ToInt32(inputs[0]);
            var x = Convert.ToInt32(inputs[1]);

            var result = false;

            if (x == 1) {
                result = 1600 <= r && r <= 2999;
            } else if (x == 2) {
                result = 1200 <= r && r <= 2399;
            }
            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
