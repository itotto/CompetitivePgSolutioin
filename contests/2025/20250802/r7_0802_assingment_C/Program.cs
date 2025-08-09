using System.Collections.Generic;

namespace r7_0802_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Distance Indicators 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc417/tasks/abc417_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var cnt = 0;

            if (n <= 2) {
                Console.ReadLine();
            } else {
                var array_a = new List<int>(n + 1) { 0 };
                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) return;
                array_a.Add(Convert.ToInt32(conditions[0]));
                array_a.Add(Convert.ToInt32(conditions[1]));

                for (var idx = 2; idx < conditions.Length; idx++) {
                    var a_j = Convert.ToInt32(conditions[idx]);
                    array_a.Add(a_j);
                    var j = idx + 1;
                    if (a_j >= j) continue;
                    for (var i = 1; i <= j - 2; i++) {
                        var a_i = array_a[i];
                        if (a_i >= j) continue;
                        if (a_i + a_j == j - i) cnt++;
                    }
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
