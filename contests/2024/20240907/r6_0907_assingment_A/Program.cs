using System.Collections.Generic;

namespace r6_0907_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Raise Both Hands
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc370/tasks/abc370_a</remarks>
        static void Main() {
            var cs = Console.ReadLine()?.Split(' ');
            if (cs == null) return;
            var left = Convert.ToInt32(cs[0]);
            var right = Convert.ToInt32(cs[1]);
            var answer = "Invalid";
            if (left != right) {
                answer = left == 1 ? "Yes" : "No";
            }
            Console.WriteLine(answer);
        }
    }
}
