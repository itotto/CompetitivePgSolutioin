using System.Collections.Generic;

namespace r7_0315_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Thermometer
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc397/tasks/abc397_a</remarks>
        static void Main() {
            var x = Convert.ToDouble(Console.ReadLine());
            if (x >= 38.0) Console.WriteLine(1);
            else if (x >= 37.5) Console.WriteLine(2);
            else Console.WriteLine(3);
        }
    }
}
