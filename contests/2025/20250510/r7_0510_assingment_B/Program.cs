using System;
using System.Collections.Generic;

namespace r7_0510_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Not All
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc405/tasks/abc405_b</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var m = Convert.ToInt32(conditions1[1]);

            // データ入力
            var array_a = new int[n];
            var data = new Dictionary<int, int>();
            var conditions2 = Console.ReadLine()?.Split(' ');
            if (conditions2 == null) return;
            for ( var i = 0; i < n; i++) {
                var d = Convert.ToInt32(conditions2[i]);
                array_a[i] = d;
                if (data.ContainsKey(d)) data[d]++;
                else data.Add(d, 1);
            }

            var procCount = 0;

            var canExec = true;
            // チェック
            for (var i = 1; i <= m; i++) {
                if (!data.ContainsKey(i)) {
                    canExec = false;
                    break;
                }
            }

            if (canExec) {
                // 処理
                for (var i = n - 1; i >= 0; i--) {
                    procCount++;
                    var d = array_a[i];
                    data[d]--;
                    if (data[d] <= m && data[d] <= 0) {
                        break;
                    }
                }
            }
            Console.WriteLine(procCount);
        }
    }
}
