using System.Collections.Generic;

namespace r8_0815_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Survey Tabulation
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc471/tasks/abc471_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var answers = new Dictionary<string, int>();

            for (var i = 0; i < n; i++) {
                var s = Console.ReadLine()?.ToUpper();
                if (string.IsNullOrEmpty(s)) continue;

                if (answers.ContainsKey(s)) answers[s]++;
                else answers.Add(s, 1);
            }

            var max = -1;

            foreach (var v in answers.Values) {
                if (v > max) max = v;
            }

            Console.WriteLine(max);
        }
    }
}
