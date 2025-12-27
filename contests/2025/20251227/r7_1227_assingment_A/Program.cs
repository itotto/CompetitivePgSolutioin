using System.Collections.Generic;

namespace r7_1227_assingment_A {
    internal class Program {
        /// <summary>
        /// A - First Contest of the Year
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc438/tasks/abc438_a</remarks>
        static void Main() {
            const int BASEDAY = 7;
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            var d = Convert.ToInt32(inputs[0]);
            var f = Convert.ToInt32(inputs[1]);
            var firstDay =  f - (d % BASEDAY);

            Console.WriteLine(firstDay <= 0 ? firstDay + BASEDAY : firstDay);
        }
    }
}
