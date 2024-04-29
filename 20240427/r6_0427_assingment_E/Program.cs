using System.Collections.Generic;

namespace r6_0427_assingment_E {
    internal class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            ulong r = 0;
            var maxV = int.MinValue;
            var minV = int.MaxValue;

            // データ取得
            var d = new int[n];
            var cs = Console.ReadLine()?.Split(' ');
            if (cs == null) return;
            for (var i = 0; i < cs.Length; i++) {
                d[i] = Convert.ToInt32(cs[i]);

                var isMax = false;
                if (d[i] >= maxV) {
                    maxV = d[i];
                    isMax = true;
                }
                if (d[i] < minV) minV = d[i];
                else { // 最小ではない場合のみ計算
                    if (isMax) { // 最大のときは比較しない
                        for (var j = i - 1; j >= 0; j--) {
                            r += (ulong)(d[i] - d[j]);
                        }
                    } else {
                        for (var j = i - 1; j >= 0; j--) {
                            if (d[i] > d[j]) {
                                r += (ulong)(d[i] - d[j]);
                            }
                        }
                    }
                }
            }
            Console.WriteLine(r);
        }
    }
}
