using System.Collections.Generic;
using System.Text;

namespace r7_0628_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Giant Domino 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc412/tasks/abc412_c</remarks>
        static void Main() {
            var testCount = Convert.ToInt32(Console.ReadLine());

            var result = new StringBuilder();
            for (var i = 0; i < testCount; i++) {
                var n = Convert.ToInt32(Console.ReadLine());

                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) return;
                var start = Convert.ToInt32(conditions[0]);
                var end = Convert.ToInt32(conditions[n - 1]);

                // これを超えたら最後のドミノを倒せる
                var finishCondition = end % 2 == 1 ? end / 2 + 1 : end / 2;

                var dominoCount = 2;
                if (finishCondition > start) {
                    if (n == 2) {
                        dominoCount = -1;
                    } else {
                        var data = new List<int>(n - 2);
                        for (var j = 1; j < n - 1; j++) {
                            data.Add(Convert.ToInt32(conditions[j]));
                        }
                        data.Sort();

                        // 倒せる重さの上限値
                        var fromLimit = start * 2;

                        // 一番小さい値でも倒せる上限値より重かったら×
                        if (data[0] > fromLimit) {
                            dominoCount = -1;

                        // 一番大きい値でも最後のドミノを倒せなかったら終わり
                        } else if (data[n - 3] < finishCondition) {
                            dominoCount = -1;

                        } else {
                            // 見つかった場所
                            var foundPoint = -1;

                            var currentValue = start;

                            while (true) {
                                var found = false;
                                // 前に見つかったやつ以降を確認する
                                for (var k = foundPoint + 1; k < data.Count; k++) {
                                    var d = data[k];
                                    // 上限いっぱいのが見つかれば採用
                                    if (d == fromLimit) {
                                        found = true;
                                        foundPoint = k;
                                        dominoCount++;
                                        currentValue = d;
                                        fromLimit = currentValue * 2;
                                        break;

                                    // 上限を超えたらひとつ前を採用
                                    } else if (d > fromLimit) {
                                        found = true;
                                        foundPoint = k - 1;
                                        dominoCount++;
                                        currentValue = data[k - 1];
                                        fromLimit = currentValue * 2;
                                        break;
                                    }
                                }
                                // 見つからなかったら最後の値を採用
                                if (!found) {
                                    foundPoint = n - 3;
                                    currentValue = data[n - 3];
                                    fromLimit = currentValue * 2;
                                    dominoCount++;
                                }

                                // ここからジャッジする
                                if (currentValue >= finishCondition) break;
                            }
                        }
                    }
                }
                result.AppendLine(dominoCount.ToString());
            }
            Console.WriteLine(result.ToString());
        }
    }
}
