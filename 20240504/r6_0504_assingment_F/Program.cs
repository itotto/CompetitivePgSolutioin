using System.Collections.Generic;
using System.Text;

namespace r6_0504_assingment_F {
    internal class Program {
        /// <summary>
        /// F - Estimate Order
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc352/tasks/abc352_f</remarks>
        static void Main() {
            var cs1 = Console.ReadLine()?.Split(' ');
            if (cs1 == null) return;
            var n = Convert.ToInt32(cs1[0]);
            var m = Convert.ToInt32(cs1[1]);

            // 順位初期化
            var ranks = new int[n + 1];
            for (var i = 0; i <= n; i++) ranks[i] = -1;

            var qs = 
            // 情報を入力
            for (var i = 0; i < m; i++) {
                var cs2 = Console.ReadLine()?.Split(' ');
                if (cs2 == null) return;
                var x = Convert.ToInt32(cs2[0]);
                var y = Convert.ToInt32(cs2[1]);
                var z = Convert.ToInt32(cs2[2]);
            }


            // 表示用に整形
            var r = new StringBuilder();
            for (var i = 1; i <= n; i++) { r.Append($"{ranks[i]} "); }

            r.Remove(r.Length - 1, 1);
            Console.WriteLine(r.ToString());
        }
    }
}
