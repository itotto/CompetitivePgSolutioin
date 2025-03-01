using System.Collections.Generic;

namespace r7_0215_assingment_D {
    internal class Program {
        /// <summary>
        /// D - Swap to Gather
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc393/tasks/abc393_d</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            var clusters = new Dictionary<int, int>();
            var clusterStartPos = new List<int>();

            var clusterCount = 0;
            var startpos = -1;
            for (var i = 0; i < n; i++) {
                if (s[i] == '0') {
                    // もともとカウントしてなかったらおしまい
                    if (startpos == -1) continue;

                    // カウント中だった場合はここでいったんおしまいにする
                    clusters.Add(startpos, clusterCount);
                    startpos = -1;
                    clusterCount = 0;

                } else {
                    // もともとカウントしてなかったら開始位置として指定する
                    if (startpos == -1) {
                        startpos = i;
                        clusterStartPos.Add(i);
                    }
                    clusterCount++;
                }
            }

            // カウント途中だった場合はそれも加える
            if (clusterCount > 0) {
                clusters.Add(startpos, clusterCount);
            }

            Console.ReadLine();
        }
    }
}
