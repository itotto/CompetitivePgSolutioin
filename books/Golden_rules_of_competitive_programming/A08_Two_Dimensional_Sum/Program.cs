using System.Collections.Generic;
using System.Text;

namespace A08_Two_Dimensional_Sum {
    internal class Program {
        /// <summary>
        /// A08 - Two Dimensional Sum
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/tessoku-book/tasks/tessoku_book_h</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var height = Convert.ToInt32(conditions[0]);
            var width = Convert.ToInt32(conditions[1]);

            // マス目の値をそのまま入力
            var squares = new int[width, height];
            for (var y = 0; y < height; y++) {
                var columns = Console.ReadLine()?.Split(' ');
                if (columns == null) return;
                for (var x = 0; x < columns.Length; x++) {
                    squares[y, x] = Convert.ToInt32(columns[x]);
                }
            }

            // 横方向に足す
            for (var y = 0; y < height; y++) {
                for (var x = 1; x < width; x++) {
                    squares[y, x] += squares[y, x - 1];
                }
            }

            // 縦方向に足す
            for (var x = 0; x < width; x++) {
                for (var y = 1; y < height; y++) {
                    squares[y, x] += squares[y - 1, x];
                }
            }

            var result = new StringBuilder();

            // 質問
            var questionsCount = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < questionsCount; i++) {
                var q = Console.ReadLine()?.Split(' ');
                if (q == null) return;
                var h1 = Convert.ToInt32(q[0]) - 1;
                var w1 = Convert.ToInt32(q[1]) - 1;
                var h2 = Convert.ToInt32(q[2]) - 1;
                var w2 = Convert.ToInt32(q[3]) - 1;

                var v1 = (w1 > 0 && h1 > 0) ? squares[h1 - 1, w1 - 1] : 0;
                var v2 = w1 > 0 ? squares[h2, w1 - 1] : 0;
                var v3 = h1 > 0 ? squares[h1 - 1, w2] : 0;
                var v4 = squares[h2, w2];

                result.AppendLine($"{v4 - v2 - v3 + v1}");
            }

            Console.Write(result.ToString());
        }
    }
}
