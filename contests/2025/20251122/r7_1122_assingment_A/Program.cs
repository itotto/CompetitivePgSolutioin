using System.Collections.Generic;

namespace r7_1122_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Happy Birthday! 4
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc433/tasks/abc433_a</remarks>
        static void Main() {
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            var x = Convert.ToInt32(inputs[0]);
            var y = Convert.ToInt32(inputs[1]);
            var z = Convert.ToInt32(inputs[2]);


            var result = false;

            for (var i = 0; i < 100; i++) {
                var newX = x + i;
                var newY = y + i;
                var targetNum = newY * z;
                if (targetNum == newX) {
                    result = true;
                    break;
                }
                if (targetNum > newX) break;
            }
            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
