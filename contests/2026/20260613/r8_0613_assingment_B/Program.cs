using System.Text;
using System.Collections.Generic;

namespace r8_0613_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Gift
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc462/tasks/abc462_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var sended = new Dictionary<int, List<int>>();

            // 初期化
            for (var i = 1; i <= n; i++) {
                sended.Add(i, new List<int>());
            }

            for (var i = 1; i <= n; i++) {
                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) return;

                var k = Convert.ToInt32(conditions[0]);
                for (var j = 1; j <= k; j++) {
                    var a = Convert.ToInt32(conditions[j]);
                    sended[a].Add(i);
                }
            }

            var result = new StringBuilder();
            for (var i = 1; i <= n; i++) {
                var count = sended[i].Count;
                result.Append(count);
                if (count > 0) {
                    foreach (var v in sended[i]) {
                        result.Append($" {v}");
                    }
                }
                result.AppendLine();
            }
            Console.WriteLine(result);
        }
    }
}
