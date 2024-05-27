using System.Collections.Generic;

namespace r6_0525_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Bingo 2
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc355/tasks/abc355_c</remarks>
        static void Main() {
            var condtions = Console.ReadLine()?.Split(' ');
            if (condtions == null) return;
            var n = Convert.ToInt32(condtions[0]);
            var t = Convert.ToInt32(condtions[1]);

            // 呼ばれる番号
            var callStr = Console.ReadLine()?.Split(' ');
            if (callStr == null) return;
            var calls = new List<int>();
            foreach (var call in callStr) {
                calls.Add(Convert.ToInt32(call));
            }

            // マスの情報
            var squares = new int[n + 1, n + 1];

            // 結果
            var result = new bool[n + 1, n + 1];

            // 数値と位置の関係
            var numberPos = new Dictionary<int, KeyValuePair<int, int>>();

            // 初期化
            for (int j = 0; j <= n; j++) squares[0, j] = 0;
            for (int i = 0; i <= n; i++) squares[i, 0] = 0;
            for (var i = 1; i <= n; i++) {
                var baseNum = n * (i - 1);
                for (var j = 1; j <= n; j++) {
                    var v = baseNum + j;
                    squares[i, j] = v;
                    numberPos.Add(v, new KeyValuePair<int, int>(i, j));
                }
            }

            var cnt = 0;
            var isFin = false;

            foreach (var c in calls) {
                cnt++; // 回数設定

                if (!numberPos.ContainsKey(c)) continue;
                var p = numberPos[c];

                result[p.Key, p.Value] = true;

                var r = true;
                // 横方向の確認
                for (var j = 1; j <= n; j++) {
                    if (!result[p.Key, j]) {
                        r = false;
                        break;
                    }
                }
                if (r) {
                    isFin = true;
                    break;
                } else {
                    r = true;
                    // 縦方向の確認
                    for (var i = 1; i <= n; i++) {
                        if (!result[i, p.Value]) {
                            r = false;
                            break;
                        }
                    }

                    if (r) {
                        isFin = true;
                        break;
                    } else {
                        r = true;
                        if (p.Key == p.Value) {
                            for (var v1 = 1; v1 <= n; v1++) {
                                if (!result[v1, v1]) {
                                    r = false;
                                    break;
                                }
                            }
                            if (r) {
                                isFin = true;
                                break;
                            }

                        } else if (p.Key + p.Value == n + 1) {
                            for (var v2 = 1; v2 <= n; v2++) {
                                if (!result[n + 1 - v2, v2]) {
                                    r = false;
                                    break;
                                }
                            }
                            if (r) {
                                isFin = true;
                                break;
                            }
                        }

                    }
                }

            }

            // 結果を表示
            Console.WriteLine(isFin ? cnt : -1);

            //// debug
            //for (var i = 1; i <= n; i++) {
            //    for (var j = 1; j <= n; j++) {
            //        Console.Write($"{squares[i,j]} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
        }
    }
}
