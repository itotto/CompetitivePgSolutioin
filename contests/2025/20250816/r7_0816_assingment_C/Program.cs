using System.Collections.Generic;

namespace r7_0816_assingment_C {
    internal class Program {
        /// <summary>
        /// C - King's Summit
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc419/tasks/abc419_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var positions = new List<int[]>();

            var min_y = int.MaxValue;
            var max_y = int.MinValue;

            var min_x = int.MaxValue;
            var max_x = int.MinValue;

            for (var i = 0; i < n; i++) {
                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) return;
                var y = Convert.ToInt32(conditions[0]);
                var x = Convert.ToInt32(conditions[1]);

                if (y < min_y) min_y = y;
                if (y > max_y) max_y = y;
                if (x < min_x) min_x = x;
                if (x > max_x) max_x = x;

                positions.Add(new int[2] { y, x });
            }

            var minDiff_y = int.MaxValue;
            var minDiff_x = int.MaxValue;
            var current_y = min_y;
            var current_x = min_x;
            // 最小値を確認する

            while (true) {
                var pMaxDiff_y = int.MinValue;
                var pMaxDiff_x = int.MinValue;
                // 一番遠い点を探す
                foreach (var p in positions) {
                    var diff_y = Math.Abs(current_y - p[0]);
                    var diff_x = Math.Abs(current_x - p[1]);
                    if (diff_y > pMaxDiff_y) pMaxDiff_y = diff_y;
                    if (diff_x > pMaxDiff_x) pMaxDiff_x = diff_x;
                }

                // 一番遠い点の距離が一番短いものを保持する
                if (minDiff_y > pMaxDiff_y) minDiff_y = pMaxDiff_y;
                if (minDiff_x > pMaxDiff_x) minDiff_x = pMaxDiff_x;

                current_y++;current_x++;
                if (current_y > max_y) break;
                if (current_x > max_x) break;
            }
            Console.WriteLine(minDiff_y > minDiff_x ? minDiff_y : minDiff_x);
        }
    }
}
