using System.Collections.Generic;
using System.Text;

namespace _7_Visibility {
    internal class Program {
        /// <summary>
        /// B - Visibility
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc197/tasks/abc197_b</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var h = Convert.ToInt32(conditions[0]);
            var w = Convert.ToInt32(conditions[1]);
            var y = Convert.ToInt32(conditions[2]) - 1;
            var x = Convert.ToInt32(conditions[3]) - 1;

            var masses = new List<char[]>();

            for (var i = 0; i < h; i++) {
                var s = Console.ReadLine();
                if (string.IsNullOrEmpty(s)) continue;
                masses.Add(s.ToArray());
            }

            var vertLineWork = new StringBuilder();
            for (var i = 0; i < h; i++) {
                vertLineWork.Append(masses[i][x]);
            }

            var count = 1; // 自分自身も含むので初期値が1
            var horzLine = masses[y];
            var vertLine = vertLineWork.ToString().ToArray();

            // 左方向
            if (x > 0) {
                for (var i = x - 1; i >= 0; i--) {
                    if (horzLine[i] == '.') count++;
                    else break;
                }
            }

            // 上方向
            if (y > 0) {
                for (var i = y - 1; i >= 0; i--) {
                    if (vertLine[i] == '.') count++;
                    else break;
                }
            }

            // 右方向
            if (x < w - 1) {
                for (var i = x + 1; i < w; i++) {
                    if (horzLine[i] == '.') count++;
                    else break;
                }
            }

            // 下方向
            if (y < h - 1) {
                for (var i = y + 1; i < h; i++) {
                    if (vertLine[i] == '.') count++;
                    else break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
