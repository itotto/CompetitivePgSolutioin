using System.Collections.Generic;

namespace r7_1206_assingment_B {
    internal class Program {
        /// <summary>
        /// B - No-Divisible Range 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc435/tasks/abc435_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var data = new List<int>() { 0 };
            var sums = new List<int>() { 0 };
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;

            var a_0 = Convert.ToInt32(conditions[0]);
            data.Add(a_0);
            sums.Add(a_0);

            for (var i = 1; i < conditions.Length; i++) {
                var a_i = Convert.ToInt32(conditions[i]);
                data.Add(a_i);
                sums.Add(sums[i] + a_i);
            }

            var count = 0;
            for (var l = 1; l < n; l++) {
                for (var r = l + 1; r <= n; r++) {
                    var sum_l_to_r = sums[r] - sums[l - 1];
                    var nonDivisible = true;
                    for (var i = l; i <= r; i++) {
                        if (sum_l_to_r % data[i] == 0) {
                            nonDivisible = false;
                            break;
                        }
                    }
                    if (nonDivisible) count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
