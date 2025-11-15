using System.Collections.Generic;
using System.Text;

namespace r7_1101_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Count Subgrid
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc430/tasks/abc430_b</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var m = Convert.ToInt32(conditions1[1]);

            var grid = new char[n, n];
            for (var i = 0; i < n; i++) {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) continue;
                for (var j = 0; j < n; j++) {
                    grid[i, j] = line[j];
                }
            }

            var patterns = new Dictionary<string, bool>();
            var result = 0;

            // i は縦方向の開始地点
            for (var i = 0; i <= n - m; i++) {
                // j は横方向の開始地点
                for (var j = 0; j <= n - m; j++) {

                    var workStr = new StringBuilder();

                    // k は縦にスライドさせる
                    for (var k = i; k < i + m; k++) {
                        // l は横にスライドさせる
                        for (var l = j; l < j + m; l++) {
                            workStr.Append(grid[k, l]);
                        }
                    }

                    if (!patterns.ContainsKey(workStr.ToString())) {
                        patterns.Add(workStr.ToString(), true);
                        result++;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
