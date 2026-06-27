using System.Collections.Generic;

namespace r8_0627_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Plumage Palette
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc464/tasks/abc464_c</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var m = Convert.ToInt32(conditions[1]);

            var colors = new Dictionary<int, int>();

            var changes = new Dictionary<int, List<KeyValuePair<int, int>>>();

            for (var i = 1; i <= n; i++) {
                var conditions1 = Console.ReadLine()?.Split(' ');
                if (conditions1 == null) return;
                var a = Convert.ToInt32(conditions1[0]);
                var d = Convert.ToInt32(conditions1[1]);
                var b = Convert.ToInt32(conditions1[2]);

                // 1日目以降は色が変わらないものは変更日を取得しない
                if (d == 1 || (a == b)) {
                    if (colors.ContainsKey(b)) {
                        colors[b]++;
                    } else {
                        colors.Add(b, 1);
                    }
                } else {
                    if (colors.ContainsKey(a)) {
                        colors[a]++;
                    } else {
                        colors.Add(a, 1);
                    }

                    // 色が変わる日を記録する
                    if (!changes.ContainsKey(d)) {
                        changes.Add(d, new List<KeyValuePair<int, int>>());
                    }
                    changes[d].Add(new KeyValuePair<int, int>(a, b));
                }
            }

            // 結果を表示
            for (var i = 1; i <= m; i++) {
                if (changes.ContainsKey(i)) {
                    var birdColors = changes[i];
                    foreach (var c in birdColors) {
                        // 変更前の色から1つ減らす
                        if (colors[c.Key] == 1) colors.Remove(c.Key);
                        else colors[c.Key]--;

                        if (colors.ContainsKey(c.Value)) colors[c.Value]++;
                        else colors.Add(c.Value, 1);
                    }
                }

                // そのとき登録されている数を表示
                Console.WriteLine(colors.Count);
            }
        }
    }
}
