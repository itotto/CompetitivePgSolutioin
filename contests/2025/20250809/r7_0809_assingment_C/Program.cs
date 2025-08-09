using System.Collections.Generic;
using System.Text;

namespace r7_0809_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Flush
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc418/tasks/abc418_c</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var q = Convert.ToInt32(conditions1[1]);

            var sum_of_a = 0;
            var countOfTeabag = new List<int>();
            var conditions2 = Console.ReadLine()?.Split(' ');
            if (conditions2 == null) return;
            for (var i = 0; i < conditions2.Length; i++) {
                var count = Convert.ToInt32(conditions2[i]);
                countOfTeabag.Add(count);
                sum_of_a += count;
            }

            // 昇順にソート
            countOfTeabag.Sort((x, y) => x - y);

            // 中央値
            var centerValue = countOfTeabag[countOfTeabag.Count / 2];

            // 最大値を格納
            var maxCount = countOfTeabag[countOfTeabag.Count - 1];
            long sum_of = 0;
            var minCounts = new Dictionary<int, long>();

            for (var i = 0; i < countOfTeabag.Count; i++) {
                var t = countOfTeabag[i];
                if (!minCounts.ContainsKey(t)) minCounts.Add(t, sum_of);
                sum_of += t;
            }

            var result = new StringBuilder();
            for (var i = 0; i < q; i++) {
                var b_i = Convert.ToInt32(Console.ReadLine());
                if (b_i > maxCount) {
                    result.AppendLine("-1");
                } else {
                    var start = b_i > centerValue ? centerValue : 0;
                    for (var j = start; j < countOfTeabag.Count; j++) {
                        var t = countOfTeabag[j];
                        if (b_i <= t) {
                            var c = minCounts[t] + (b_i - 1) * (countOfTeabag.Count - j - 1) + b_i;
                            result.AppendLine(c <= sum_of_a ? c.ToString() : "-1");
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
