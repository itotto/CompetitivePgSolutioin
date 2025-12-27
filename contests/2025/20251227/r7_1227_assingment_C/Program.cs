using System.Collections.Generic;

namespace r7_1227_assingment_C {
    internal class Program {
        /// <summary>
        /// C - 1D puyopuyo
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc438/tasks/abc438_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;

            var puyopuyos = new List<int[]>();

            // 初期入力
            var currentValue = new int[2] { Convert.ToInt32(conditions[0]), 1 };
            for (var i = 1; i < n; i++) {
                var v = Convert.ToInt32(conditions[i]);
                if (v == currentValue[0]) {
                    currentValue[1]++;
                } else {
                    currentValue[1] = currentValue[1] % 4;
                    if (currentValue[1] != 0) {
                        puyopuyos.Add(currentValue);
                    }
                    currentValue = new int[2] { v, 1 };
                }
            }

            // 最後の分を追加
            if (currentValue[1] > 0) {
                currentValue[1] = currentValue[1] % 4;
                if (currentValue[1] != 0) {
                    puyopuyos.Add(currentValue);
                }
            }

            var execConcat = true;
            while (puyopuyos.Count > 1 && execConcat) {

                execConcat = false;
                var nextPuyopuyos = new List<int[]>();

                // puyopuyosをマージしながら新しいListに入れる
                var lastPuyo = new int[2] { puyopuyos[0][0], puyopuyos[0][1] };
                for (var i = 1; i < puyopuyos.Count; i++) {
                    var p = puyopuyos[i];
                    // 同じなら足す
                    if (lastPuyo[0] == p[0]) {
                        lastPuyo[1] += p[1];
                        execConcat = true;
                    } else {
                        lastPuyo[1] = lastPuyo[1] % 4;
                        if (lastPuyo[1] != 0) {
                            nextPuyopuyos.Add(lastPuyo);
                        }
                        lastPuyo = new int[] { p[0], p[1] };
                    }
                }
                if (lastPuyo[1] > 0) {
                    nextPuyopuyos.Add(lastPuyo);
                }
                puyopuyos = new List<int[]>(nextPuyopuyos);
            }

            var totalCount = 0;
            foreach (var p in puyopuyos) {
                totalCount += p[1];
            }
            Console.WriteLine(totalCount);
        }
    }
}
