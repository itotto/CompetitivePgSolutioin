using System.Collections.Generic;
using System.Text;

namespace r7_0920_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Perfect
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc424/tasks/abc424_b</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var m = Convert.ToInt32(conditions1[1]);
            var k = Convert.ToInt32(conditions1[2]);

            var maxPoint = m * (m + 1) / 2;

            var contestResult = new Dictionary<int, int>();
            for (var i = 1; i <= n; i++) contestResult.Add(i, maxPoint);

            var result = new StringBuilder();

            for (var i = 0; i < k; i++) {
                var conditions2 = Console.ReadLine()?.Split(' ');
                if (conditions2 == null) return;
                var a = Convert.ToInt32(conditions2[0]);
                var b = Convert.ToInt32(conditions2[1]);
                contestResult[a] -= b;
                if (contestResult[a] == 0) result.Append($"{a} ");
            }

            if (result.Length > 0) result.Remove(result.Length - 1, 1);
            Console.WriteLine(result);
        }
    }
}
