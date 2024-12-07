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

            // 閾値を入力
            var thresholds = new int[countOfPersons];
            var positions = new int[countOfPersons];

            var minValue = int.MaxValue;

            var idx = 0;
            var conditions2 = Console.ReadLine()?.Split(' ');
            for (var i = 0; i < conditions2.Length; i++) {
                var v = Convert.ToInt32(conditions2[i]);
                if (minValue <= v) continue;

                thresholds[idx] = v;
                positions[idx++] = i + 1;
                minValue = v;
            }

            var memo = new Dictionary<string, int>();

            var conditions3 = Console.ReadLine()?.Split(' ');
            foreach (var str in conditions3) {
                if (memo.ContainsKey(str)) {
                    Console.WriteLine(memo[str]);
                } else {
                    var v = Convert.ToInt32(str);

                    if (v < minValue) {
                        Console.WriteLine(-1);
                        memo.Add(str, -1);
                    } else {
                        // メモを使う
                        for (var i = 0; i < idx; i++) {
                            if (thresholds[i] > v) continue;
                            var p = positions[i];
                            memo.Add(str, p);
                            Console.WriteLine(p);
                            break;
                        }
                    }
                }
            }

        }
    }
}
