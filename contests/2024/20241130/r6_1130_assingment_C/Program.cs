using System.Collections.Generic;

namespace r6_1130_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Kaiten Sushi
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc382/tasks/abc382_c</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var countOfPersons = Convert.ToInt32(conditions1[0]);
            var countOfSushi = Convert.ToInt32(conditions1[1]);

            // 閾値を入力
            var thresholds = new List<int>();
            var positions = new List<int>();

            var minValue = int.MaxValue;

            var conditions2 = Console.ReadLine()?.Split(' ');
            if (conditions2 == null) return;
            for (var i = 0; i < conditions2.Length; i++) {
                var v = Convert.ToInt32(conditions2[i]);
                if (minValue > v) {
                    thresholds.Add(v);
                    positions.Add(i + 1);
                    minValue = v;
                }
            }

            var memo = new Dictionary<int, int>();

            var conditions3 = Console.ReadLine()?.Split(' ');
            if (conditions3 == null) return;
            foreach (var c in conditions3) {
                var v = Convert.ToInt32(c);

                if (v < minValue) {
                    Console.WriteLine(-1);
                } else {
                    // メモを使う
                    if (memo.ContainsKey(v)) {
                        Console.WriteLine(memo[v]);
                    } else {
                        for (var i = 0; i < thresholds.Count; i++) {
                            if (thresholds[i] > v) continue;
                            memo.Add(v, positions[i]);
                            Console.WriteLine(positions[i]);
                            break;
                        }
                    }
                }
            }

        }
    }
}
