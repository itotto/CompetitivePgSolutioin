using System.Collections.Generic;

namespace A03_Two_Cards {
    internal class Program {
        /// <summary>
        /// A03 - Two Cards
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/tessoku-book/tasks/tessoku_book_c</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var k = Convert.ToInt32(conditions[1]);

            var redCards = new Dictionary<int, bool>(n);

            // 赤いカードの情報を取得
            var r_inputs = Console.ReadLine()?.Split(' ');
            if (r_inputs == null) return;
            foreach (var red in r_inputs) {
                // kにするために必要な値に変換する
                var kred = k - Convert.ToInt32(red);
                if (!redCards.ContainsKey(kred)) {
                    redCards.Add(kred, true);
                }
            }

            var r = false;

            // 青いカードの情報を取得
            var b_inputs = Console.ReadLine()?.Split(' ');
            if (b_inputs == null) return;
            foreach (var blue in b_inputs) {
                var b_value = Convert.ToInt32(blue);
                if (redCards.ContainsKey(b_value)) {
                    r = true;
                    break;
                }
            }
            Console.WriteLine(r ? "Yes" : "No");
        }
    }
}
