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
            //long result = 2 * n - 1; // n + (n - 1);
            long result = n;

            if (n >= 3) {
                var memo = new Dictionary<int, int>();
                var diffData = new List<int> { -1 }; // 最初のデータは使わない
                for (var i = 1; i < n; i++) {
                    diffData.Add(sequence[i + 1] - sequence[i]);
                }

                for (var i = 1; i < n; i++) {
                    var d_base = diffData[i];
                    var last = n;
                    for (var j = i + 1; j < n; j++) {
                        if (d_base != diffData[j]) {
                            last = j - 1;
                            break;
                        }
                    }
                    memo.Add(i, last);
                }

                foreach (var m in memo) {
                    result += m.Value - m.Key;
                }
            }
            Console.WriteLine(result);

        }
    }
}
