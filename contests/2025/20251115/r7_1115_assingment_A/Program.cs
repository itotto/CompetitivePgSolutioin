using System.Collections.Generic;

namespace r7_1115_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Permute to Maximize 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc432/tasks/abc432_a</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var a = Convert.ToInt32(conditions[0]);
            var b = Convert.ToInt32(conditions[1]);
            var c = Convert.ToInt32(conditions[2]);

            var result = new List<int> {
                a * 100 + b * 10 + c,
                a * 100 + c * 10 + b,
                b * 100 + a * 10 + c,
                b * 100 + c * 10 + a,
                c * 100 + a * 10 + b,
                c * 100 + b * 10 + a
            };

            result.Sort();

            Console.WriteLine(result[result.Count - 1 ]);
        }
    }
}
