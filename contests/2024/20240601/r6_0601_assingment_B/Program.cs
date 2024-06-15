using System.Collections.Generic;

namespace r6_0601_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Nutrients
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc356/tasks/abc356_b</remarks>
        static void Main() {
            var cs1 = Console.ReadLine()?.Split(' ');
            if (cs1 == null) return;
            var n = Convert.ToInt32(cs1[0]);
            var m = Convert.ToInt32(cs1[1]);

            // 目標を取得
            var goals = new int[m];
            var goalStrs = Console.ReadLine()?.Split(' ');
            if (goalStrs == null) return;
            for (var i = 0; i < m; i++) {
                goals[i] = Convert.ToInt32(goalStrs[i]);
            }

            for (var i = 0; i < n; i++) {
                var foods = Console.ReadLine()?.Split(' ');
                if (foods == null) return;
                for (var j = 0; j < m; j++) {
                    goals[j] -= Convert.ToInt32(foods[j]);
                }
            }

            // チェック
            var r = true;
            for (var i = 0; i < m; i++) {
                if (goals[i] > 0) {
                    r = false;
                    break;
                }
            }

            // 結果を表示
            Console.WriteLine(r ? "Yes" : "No");
        }
    }
}
