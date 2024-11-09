using System.Collections.Generic;

namespace r6_1109_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Sowing Stones
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc379/tasks/abc379_c</remarks>
        static void Main() {
            // 初期化
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var m = Convert.ToInt32(conditions1[1]);

            var stones = new List<KeyValuePair<int, int>>();
            long countOfStones = 0;

            var conditions2 = Console.ReadLine()?.Split(' ');
            if (conditions2 == null) return;

            var conditions3 = Console.ReadLine()?.Split(' ');
            if (conditions3 == null) return;

            for (var i = 0; i < m; i++) {
                var x_i = Convert.ToInt32(conditions2[i]);
                var a_i = Convert.ToInt32(conditions3[i]);
                stones.Add(new KeyValuePair<int, int>(x_i, a_i));
                countOfStones += a_i;
            }

            // 最後が n でなければ nを追加する
            if (stones[stones.Count - 1].Key != n) {
                stones.Add(new KeyValuePair<int, int>(n, 0));
            }

            // 計算
            var steps = -1;
            if (countOfStones == n && stones[0].Key == 1) {
                steps = 0;
                var currentPos = stones[0].Key; // これは基本的に1
                var currentStone = stones[0].Value;
                for (var i = 1; i < stones.Count; i++) {
                    var pos = stones[i].Key;
                    var stone = stones[i].Value;

                    var rest = currentStone - 1 - (pos - currentPos);

                    // 次のステップまで届かなかったら終了
                    if (rest <= 0) {
                        steps = -1;
                        break;
                    }

                    for (var j = currentPos + 1; j <= pos; j++) {
                        currentStone--; // 1個残すからデクリメント
                        steps += currentStone; // 残すもの以外は移すからのその回数を計上
                    }

                    // 追加分と足す
                    currentStone += stone;
                }
            }

            // 回答
            Console.WriteLine(steps);
        }
    }
}
