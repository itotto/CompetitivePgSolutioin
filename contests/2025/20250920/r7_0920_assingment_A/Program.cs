using System.Collections.Generic;

namespace r7_0920_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Isosceles
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc424/tasks/abc424_a</remarks>
        static void Main() {
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            var a = Convert.ToInt32(inputs[0]);
            var b = Convert.ToInt32(inputs[1]);
            var c = Convert.ToInt32(inputs[2]);

            var result = false;
            if (a == b) {
                result = true;
            } else {
                result = a == c || b == c;
            }
            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
