using System.Collections.Generic;

namespace r7_0607_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Equilateral Triangle
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc409/tasks/abc409_c</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var l = Convert.ToInt32(conditions1[1]);

            var conditions2 = Console.ReadLine()?.Split(' ');
            if (conditions2 == null) return;

            var lastPos = 0;

            // key:位置、value:個数
            var posGroups = new Dictionary<int, int> {
                { lastPos, 1 }
            };

            for (var i = 0; i < n - 1; i++) {
                // いまの位置と次の位置までの距離を足して次の位置を計算する
                var nextPos = lastPos + Convert.ToInt32(conditions2[i]);

                // 最大値を超えたら元に戻る
                if (nextPos >= l) nextPos -= l;
                if (nextPos >= l) nextPos -= l;

                if (posGroups.ContainsKey(nextPos)) posGroups[nextPos]++;
                else posGroups.Add(nextPos, 1);
                lastPos = nextPos;
            }

            var triangleCounts = 0;
            if (l % 3 == 0) {
                var equilateralDistance = l / 3;
                for (var i = 0; i < equilateralDistance; i++) {
                    var p1 = i;
                    var p2 = p1 + equilateralDistance;
                    var p3 = p2 + equilateralDistance;
                    if (!posGroups.ContainsKey(p1)) continue;
                    if (!posGroups.ContainsKey(p2)) continue;
                    if (!posGroups.ContainsKey(p3)) continue;

                    triangleCounts += posGroups[p1] * posGroups[p2] * posGroups[p3];
                }
            }
            Console.WriteLine(triangleCounts);
        }
    }
}
