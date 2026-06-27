using System.Collections.Generic;

namespace r8_0613_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Not Covered Points
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc462/tasks/abc462_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            // xごとの最小値を求める
            var minXs = new Dictionary<int, int>();

            var coordinates = new List<KeyValuePair<int,int>>();

            // 入力
            for (var i = 1; i <= n; i++) {
                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) return;
                var x = Convert.ToInt32(conditions[0]);
                var y = Convert.ToInt32(conditions[1]);

                if (minXs.TryGetValue(x, out var v)) {
                    if (v > y) minXs[x] = y;
                } else {
                    minXs.Add(x, y);
                }
                coordinates.Add(new KeyValuePair<int, int>(x, y));
            }

            // 昇順に並び替える
            //coordinates.Sort((x, y) => x.Key - y.Key > 0 ? 1 : x.Value - y.Value);
            //coordinates.Sort((x, y) => x.Key - y.Key);
            //coordinates.OrderBy((x,y) => x.Key - y.Key)
            //            .ThenBy

            var count = 0 ;

            var minY = 0;
            for(var i = 0; i < coordinates.Count; i++) {
                var c = coordinates[i];

                // その時点での最小のYを保持する
                if (c.Value < minY) {
                    minY = c.Value;
                    count++;
                } else {
                }

            }





            Console.WriteLine(count);
        }
    }
}
