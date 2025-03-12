using System.Collections.Generic;

namespace r7_0308_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Buy Balls
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc396/tasks/abc396_c</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var m = Convert.ToInt32(conditions1[1]);

            // 黒を取得
            var blacks = new List<int>();
            var binputs = Console.ReadLine()?.Split(' ');
            if (binputs == null) return;
            for (var i = 0; i < n; i++) {
                blacks.Add(Convert.ToInt32(binputs[i]));
            }
            blacks.Sort((x,y)=> y - x);

            // 白を取得
            var whites = new List<int>();
            var winputs = Console.ReadLine()?.Split(' ');
            if (winputs == null) return;
            for (var i = 0; i < m; i++) {
                whites.Add(Convert.ToInt32(winputs[i]));
            }
            whites.Sort((x,y) => y - x);

            long valueSum = 0;

            var valueSums = new List<long>();
            for (var i = 0; i < n; i++) {
                // 黒はずっと触っていい区間
                var b = blacks[i];

                // 白に触っていい区間
                if (i < m) {
                    var w = whites[i];
                    if (w < 0) w = 0;

                    // とりあえず足す
                    valueSum += b + w;
                    valueSums.Add(valueSum);

                // 白がない区間
                } else {
                    // 黒が0より小さくなったらおしまい
                    if (b < 0) break;

                    valueSum += b;
                    valueSums.Add(valueSum);
                }
            }
            valueSums.Sort();

            var result = valueSums[valueSums.Count - 1];

            Console.WriteLine(result < 0 ? 0 : result);
        }
    }
}
