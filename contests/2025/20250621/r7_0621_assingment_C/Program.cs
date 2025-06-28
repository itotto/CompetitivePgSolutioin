using System.Collections.Generic;

namespace r7_0621_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Black Intervals
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc411/tasks/abc411_c</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var q = Convert.ToInt32(conditions1[1]);

            var conditions2 = Console.ReadLine()?.Split(' ');
            if (conditions2 == null) return;

            // key:from , value:to
            var ranges = new Dictionary<int, int>();

            for (var i = 0; i < q; i++) {
                var a_i = Convert.ToInt32(conditions2[i]);

                var found = false;

                // キーに一致するとき(先頭に一致)
                if (ranges.ContainsKey(a_i)) {
                    var to = ranges[a_i];
                    // 1マスだけ黒いときは消す
                    if (to == a_i) {
                        ranges.Remove(a_i);
                        found = true;

                    // 1マスだけではないときは先頭をずらす
                    } else {
                        ranges.Remove(a_i);
                        ranges.Add(a_i + 1, to);
                        found = true;
                    }
                } else {
                    // ここでは (1) 範囲内　(2) to に一致を見つける
                    foreach (var key in ranges.Keys) {
                        var v = ranges[key];
                        // 範囲内(端ではない)
                        if (key < a_i && a_i < v) {
                            ranges[key] = a_i - 1;
                            ranges.Add(a_i, v);
                            found = true;
                            break;

                        // to に一致する場合は 1つ手前に戻す
                        } else if (a_i == v) {
                            ranges[key] = v - 1;
                            found = true;
                            break;
                        } else continue;
                    }
                }

                // 見つからなかったときは追加する
                if (!found) {
                    ranges.Add(a_i, a_i);

                    var rCount = -1;
                    while (rCount != ranges.Count) {
                        rCount = ranges.Count;

                        // 連続している部分があればマージする(TODO)
                        foreach (var key in ranges.Keys) {
                            var to_next = ranges[key] + 1;

                            // 黒が続くことになったら結合する
                            if (ranges.ContainsKey(to_next)) {
                                var to = ranges[to_next];
                                ranges.Remove(to_next);
                                ranges[key] = to;
                                break;
                            }
                        }
                    }
                }
                Console.WriteLine(ranges.Count);
            }
        }
    }
}
