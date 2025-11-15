using System.Collections.Generic;

namespace r7_1101_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Truck Driver
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc430/tasks/abc430_c</remarks>
        static void Main() {
            var condition = Console.ReadLine()?.Split(' ');
            if (condition == null) return;
            var n = Convert.ToInt32(condition[0]);
            var a = Convert.ToInt32(condition[1]);
            var b = Convert.ToInt32(condition[2]);

            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            //var values = new List<KeyValuePair<int, int>>();
            var values = new Dictionary<int, int[]>();
            var countA = 0;
            var countB = 0;

            for (var i = 0; i < n; i++) {
                if (s[i] == 'a') countA++;
                else countB++;
                values.Add(i, new int[2] { countA, countB });
            }

            var result = 0;

            // aがA個以上ある場合だけ実施
            if (countA >= a) {
                for (var i = 0; i < n - 1; i++) {
                    var countOfA_l = values[i][0];
                    var countOfB_l = values[i][1];
                    for (var j = i + 1; j < n; j++) {
                        var countOfA_r = values[j][0];
                        var countOfB_r = values[j][1];

                        var diff_a = countOfA_r - countOfA_l;
                        var diff_b = countOfB_r - countOfB_l;

                        if (diff_b >= b) break;
                        if (diff_a >= a) result++;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
