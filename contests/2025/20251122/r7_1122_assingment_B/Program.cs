using System.Collections.Generic;
using System.Text;

namespace r7_1122_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Nearest Taller
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc433/tasks/abc433_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;

            var lengths = new int[n];

            for (var i = 0; i < n; i++) {
                lengths[i] = Convert.ToInt32(conditions[i]);
            }

            var result = new StringBuilder();
            for (var i = 0; i < n; i++) {
                var pos = -1;

                for (var j = 0; j < i; j++) {
                    if (lengths[i] < lengths[j]) {
                        pos = j + 1;
                    }
                }

                result.AppendLine(pos.ToString());
            }

            Console.WriteLine(result);
        }
    }
}
