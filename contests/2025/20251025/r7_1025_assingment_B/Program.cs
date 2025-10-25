using System.Collections.Generic;

namespace r7_1025_assingment_B {
    internal class Program {
        /// <summary>
        /// B - N - 1
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc429/tasks/abc429_b</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var m = Convert.ToInt32(conditions1[1]);

            var a_i = new List<int>(n);
            var conditions2 = Console.ReadLine()?.Split(' ');
            if (conditions2 == null) return;
            var sum = 0;
            for (var i = 0; i < conditions2.Length; i++) {
                var a = Convert.ToInt32(conditions2[i]);
                sum += a;
                a_i.Add(a);
            }

            var diff = m > sum ? m - sum : sum - m;
            Console.WriteLine(a_i.Contains(diff) ? "Yes" : "No");
        }
    }
}
