using System.Collections.Generic;

namespace r6_1221_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Equally
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc385/tasks/abc385_a</remarks>
        static void Main() {
            var condtions = Console.ReadLine()?.Split(' ');
            if (condtions == null) return;
            var a = Convert.ToInt32(condtions[0]);
            var b = Convert.ToInt32(condtions[1]);
            var c = Convert.ToInt32(condtions[2]);
            var result = false;

            if (a == b && b == c) result = true;
            if (a + b == c || a == b + c || a + c == b) result = true;

            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
