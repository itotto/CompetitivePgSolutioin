using System.Collections.Generic;

namespace r7_0914_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Scary Fee
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc423/tasks/abc423_a</remarks>
        static void Main() {
            const int BASE = 1000;
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            var x = Convert.ToInt32(inputs[0]);
            var c = Convert.ToInt32(inputs[1]);

            var result = 0;
            var baseCost = BASE + c;
            if(x >= baseCost) {
                result = (x / baseCost) * BASE;
            }

            Console.WriteLine(result);
        }
    }
}
