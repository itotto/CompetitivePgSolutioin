using System.Collections.Generic;
using System.Linq;

namespace r6_1221_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Illuminate Buildings 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc385/tasks/abc385_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            // key : height, value : position about building
            var buildingsHeights = new Dictionary<int, List<int>>();
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;

            for (var i = 0; i < conditions.Length; i++) {
                var h = Convert.ToInt32(conditions[i]);
                if (!buildingsHeights.ContainsKey(h)) {
                    buildingsHeights.Add(h, new List<int>());
                }
                buildingsHeights[h].Add(i);
            }

            var maxlen = 1;

            foreach (var b in buildingsHeights) {
                // 最小の幅を求める
                var minInterval = int.MaxValue;

                var lastV = b.Value[b.Value.Count - 1];

                for (var i = 1; i < b.Value.Count; i++) {
                    var v = b.Value[i] - b.Value[i - 1];
                    if (v < minInterval) minInterval = v;
                }

                // 最大の幅を求める
                var maxInterval = (b.Value[b.Value.Count - 1] - b.Value[0]) / 2;
                var dic = b.Value.ToDictionary(x => x, x => false);

                // 間隔を広げていって満たす値を数える
                for (var i = minInterval; i <= maxInterval; i++) {

                    // 左側から最後の手前まで全部回す
                    for (var j = 0; j < b.Value.Count - maxlen; j++) {
                        // 基準の値をセット
                        var baseV = b.Value[j];
                        var workCount = 0;

                        while (baseV <= lastV) {
                            if (dic.ContainsKey(baseV)) {
                                workCount++;
                            } else {
                                break;
                            }
                            baseV += i; // 間隔を広げる
                        }

                        // 最大値を超えてたら更新
                        if (workCount > maxlen) maxlen = workCount;
                    }
                }
            }

            Console.WriteLine(maxlen > 2 ? maxlen : 1);
        }
    }
}
