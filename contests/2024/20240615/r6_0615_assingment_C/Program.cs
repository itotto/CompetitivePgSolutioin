using System.Collections.Generic;

namespace r6_0615_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Popcorn
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc358/tasks/abc358_c</remarks>
        static void Main() {
            var pow = new Dictionary<int, uint> {
                {0, 1}, {1, 2}, {2, 4}, {3, 8}, {4, 16}, {5, 32}, {6, 64}, {7, 128}, {8, 256}, {9, 512}, {10, 1024}, {11, 2048},
            };

            var cs1 = Console.ReadLine()?.Split(' ');
            if (cs1 == null) return;
            var n = Convert.ToInt32(cs1[0]);
            var m = Convert.ToInt32(cs1[1]);

            // 正解を決める
            var correct = pow[n] - 1;

            var bFound = false;
            var data = new List<uint>();

            // key:文字位置, value:〇の文字番号(S_iのi)
            var dataCnt = new Dictionary<int, List<int>>();
            for (var i = 0; i < m; i++) { dataCnt.Add(i, new List<int>()); }

            for (var i = 0; i < n; i++) {
                uint d = 0;
                var s_i = Console.ReadLine();
                if (string.IsNullOrEmpty(s_i)) continue;
                if (!bFound) {
                    for (var j = 0; j < m; j++) {
                        var idx = m - j - 1;
                        if (s_i[idx] == 'o') {
                            d += pow[j];
                            dataCnt[idx].Add(i);
                        }
                    }
                    // データの読み取りが終わってないのでbreakしない
                    if (d == correct) { bFound = true; }
                }
                data.Add(d);
            }

            var cnt = 1;
            if (!bFound) {
                var x = new List<int>();

                uint answer = 0;
                // その文字列だけが〇のものを抽出する
                foreach (var d in dataCnt) {
                    if (d.Value.Count == 1) {
                        answer = answer | data[d.Key];
                        cnt++;
                    } else {
                        // ２個以上はメモしておく
                        x.Add(d.Key);
                    }
                }

                // これだけでは足りない場合
                if (answer != correct) {
                }

            }
            Console.WriteLine(cnt);
        }
    }
}
