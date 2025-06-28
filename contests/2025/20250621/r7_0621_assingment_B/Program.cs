using System.Collections.Generic;
using System.Text;

namespace r7_0621_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Distance Table 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc411/tasks/abc411_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var stations = new int[n + 1];
            stations[0] = 0;
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            for (var i = 1; i < n; i++) {
                stations[i] = Convert.ToInt32(conditions[i - 1]) + stations[i - 1];
            }

            for (var start = 0; start < n - 1; start++) {
                var startPos = stations[start];
                var r = new StringBuilder();
                for (var j = start + 1; j < n; j++) {
                    r.Append($"{stations[j] - startPos} ");
                }
                r.Remove(r.Length - 1, 1);
                Console.WriteLine(r.ToString());
            }
        }
    }
}
