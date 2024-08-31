using System.Collections.Generic;

namespace r6_0831_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Count Arithmetic Subarrays
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc369/tasks/abc369_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;

            var sequence = new int[n + 1];
            sequence[0] = -1; // この値は使わない
            for (var i = 0; i < n; i++) {
                sequence[i + 1] = Convert.ToInt32(conditions[i]);
            }

            // 長さが1 と 2 の数列分を計算
            long result = 2 * n - 1; // n + (n - 1);

            // メモを作成+初期化
            var memo = new Dictionary<string, int>();
            for (var i = 1; i < n; i++) {
                memo.Add($"{i}-{i + 1}", sequence[i+1] - sequence[i]);
            }


            for (var len = 3; len <= n; len++) {
                for (var startPosition = 1; startPosition <= n - len + 1; startPosition++) {
                    var key = $"{startPosition}-{startPosition + len - 2}";
                    if (memo.ContainsKey(key)) {
                        var diff = sequence[startPosition + len - 1] - sequence[startPosition + len - 2];// 差分
                        if (memo[key] == diff) {
                            result++;
                            memo.Add($"{startPosition}-{startPosition + len - 1}", diff);
                        }
                    } else continue;
                }
            }
            Console.WriteLine(result);

        }
    }
}
