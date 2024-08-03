using System.Collections.Generic;

namespace r6_0713_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Sum = 0
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc362/tasks/abc362_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var diff = 0;
            var answers = new List<int>(n);
            var data = new List<KeyValuePair<int,int>>(n);

            for (var i = 1; i <= n;i++) {
                var cs = Console.ReadLine()?.Split(' ');
                if (cs == null) return;
                var min = Convert.ToInt32(cs[0]);
                var max = Convert.ToInt32(cs[1]);

                var v = 0;
                if (max < 0) v = max; // 最大値が0より小さいときはこれを採用
                else if (min > 0) v = min;

                diff += v;
                answers.Add(v);

                // データを保持
                data.Add(new KeyValuePair<int, int>(min, max));
            }

            // この時点で合計値を0にできていないとき
            if (diff != 0) {
                for (var i = 0; i < n; i++) {
                    if (diff > 0) {
                        var min = data[i].Key;
                        // 差分が0より大きいから引かないといけない(最小値が0より大きい場合は処理不可)
                        if (min > 0) continue;

                        if (diff + min < 0) {
                            answers[i] -= diff;
                            diff = 0;
                        } else {
                            answers[i] += min;
                            diff += min;
                        }

                    } else {
                        var max = data[i].Value;
                        // 差分が0より小さいから足さないといけない(最大値が0より小さい場合は処理不可)
                        if (max < 0) continue;

                        if (diff + max > 0) {
                            answers[i] += diff;
                            diff = 0;
                        } else {
                            answers[i] -= max;
                            diff -= max;
                        }
                    }

                    if (diff == 0) break;
                }
            }


            Console.WriteLine(diff == 0 ? "Yes" : "No");
            if (diff == 0) {
                Console.Write(answers[0]);
                for (int i = 1; i < n; i++) {
                    Console.Write($" {answers[i]}");
                }
                Console.WriteLine();
            }
        }
    }
}
