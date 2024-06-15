using System.Collections.Generic;

namespace r6_0615_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Popcorn
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc358/tasks/abc358_c</remarks>
        static void Main() {
            var pow = new Dictionary<int, ushort> {
                {0, 1}, {1, 2}, {2, 4}, {3, 8}, {4, 16}, {5, 32}, {6, 64}, {7, 128}, {8, 256}, {9, 512}, {10, 1024}, {11, 2048},
            };

            var cs1 = Console.ReadLine()?.Split(' ');
            if (cs1 == null) return;
            var n = Convert.ToInt32(cs1[0]);
            var m = Convert.ToInt32(cs1[1]);

            // 正解を決める
            var correct = pow[n] - 1;

            var bFound = false;
            var data = new List<ushort>();
            for (var i = 0; i < n; i++) {
                ushort d = 0;
                var s_i = Console.ReadLine();
                if (!bFound) {
                    if (string.IsNullOrEmpty(s_i)) continue;
                    for (var j = 0; j < m; j++) {
                        if (s_i[m - j - 1] == 'o') d += pow[j];
                    }
                    // データの読み取りが終わってないのでbreakしない
                    if (d == correct) { bFound = true; }
                }
                data.Add(d);
            }

            var cnt = n;
            if (bFound) {
                cnt = 1;
            } else {
                for (var i = 2; i < n; i++) { // n-1までしか確認しない
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
