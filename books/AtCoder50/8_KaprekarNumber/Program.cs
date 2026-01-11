using System.Collections.Generic;

namespace _8_KaprekarNumber {
    internal class Program {
        /// <summary>
        /// C - Kaprekar Number
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc192/tasks/abc192_c</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var k = Convert.ToInt32(conditions[1]);

            for (var i = 1; i <= k; i++) {
                n = g1(n) - g2(n);
            }

            Console.WriteLine(n);
        }

        static Dictionary<int, int> _g1Answer = new Dictionary<int, int>();
        static Dictionary<int, int> _g2Answer = new Dictionary<int, int>();

        static int g1(int x) {
            if (_g1Answer.TryGetValue(x, out var answer)) return answer;
            else {
                var w = x.ToString().ToList();
                w.Sort((c1, c2) => c2 - c1);
                var result = Convert.ToInt32(new string(w.ToArray()));
                _g1Answer.Add(x, result);
                return result;
            }
        }

        static int g2(int x) {
            if (_g2Answer.TryGetValue(x, out var answer)) return answer;
            else {
                var w = x.ToString().ToList();
                w.Sort();
                var result = Convert.ToInt32(new string(w.ToArray()));
                _g2Answer.Add(x, result);
                return result;
            }
        }
    }
}
