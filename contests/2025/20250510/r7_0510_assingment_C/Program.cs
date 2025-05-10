using System.Collections.Generic;

namespace r7_0510_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Sum of Product
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc405/tasks/abc405_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var data = new int[n];

            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;

            var sumData = new long[n + 1];
            data[0] = Convert.ToInt32(conditions[0]);
            sumData[n] = 0; // 

            for (var i = n - 1; i >= 0; i--) {
                data[i] = Convert.ToInt32(conditions[i]);
                sumData[i] = sumData[i + 1] + data[i];
            }

            long sum = 0;
            for (var i = 0; i < n - 1; i++) {
                sum += (data[i] * sumData[i + 1]);
            }

            Console.WriteLine(sum);
        }
    }
}
