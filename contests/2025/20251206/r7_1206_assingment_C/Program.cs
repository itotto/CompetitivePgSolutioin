using System.Collections.Generic;

namespace r7_1206_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Domino
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc435/tasks/abc435_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var dominos = new List<int> { -1 };
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            for (var i = 0; i < n; i++) {
                dominos.Add(Convert.ToInt32(conditions[i]));
            }

            var count = 1;
            while (true) {
                if (count >= n) {
                    count = n;
                    break;
                }

                var d = dominos[count];
                if (d == 1) break;

                count += d - 1;
            }

            Console.WriteLine(count);
        }
    }
}
