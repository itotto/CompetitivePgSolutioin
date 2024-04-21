using System.Collections.Generic;

namespace r6_0420_assingment_D {
    internal class Program {
        /// <summary>
        /// D - New Friends
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc350/tasks/abc350_d</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var m = Convert.ToInt32(conditions1[1]);

            // 友達関係の初期化
            var data = new Dictionary<string, bool>();
            for (var i = 1; i <= n - 1; i++) {
                for (var j = i + 1; j <= n; j++) {
                    data.Add($"{i}_{j}", false);
                }
            }

            // 友達関係を入力
            for (var i = 1; i <= m; i++) {
                var fi = Console.ReadLine()?.Split(' ');
                if (fi == null) continue;
                data[$"{Convert.ToInt32(fi[0])}_{Convert.ToInt32(fi[1])}"] = true;
            }

            var cnt = 0;
            if (data.Count > 0) {
                // 友達確認
                for (var i = 1; i <= n - 1; i++) {
                    // i番目の人との交友関係を確認
                    for (var j = i + 1; j <= n; j++) {
                        // i と j番目の人が友達の場合
                        if (data[$"{i}_{j}"]) {
                            // jの友達を探して i と友達にする
                            for (var k = j + 1; k <= n; k++) {
                                if (data[$"{j}_{k}"]) {
                                    if (!data[$"{i}_{k}"]) {
                                        data[$"{i}_{k}"] = true;
                                        cnt++;
                                    }
                                }
                            }

                            // i の友達を探して j と友達にする
                            for (var k = i + 1; k <= m; k++) {
                                if (j == k) continue;
                                if (data[$"{i}_{k}"]) {
                                    if (j > k) {
                                        if (!data[$"{k}_{j}"]) {
                                            data[$"{k}_{j}"] = true;
                                            cnt++;
                                        }
                                    } else {
                                        if (!data[$"{j}_{k}"]) {
                                            data[$"{j}_{k}"] = true;
                                            cnt++;
                                        }
                                    }
                                }
                            }

                        } else { // i と j番目の人が友達ではない場合はこれが友達になれるか確認する
                            for (var k = j + 1; k <= n; k++) {
                                if (data[$"{i}_{k}"] && data[$"{j}_{k}"]) {
                                    data[$"{i}_{j}"] = true;
                                    cnt++;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
