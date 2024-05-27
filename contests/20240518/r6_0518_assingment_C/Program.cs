using System.Collections.Generic;

namespace r6_0518_assingment_C {
    internal class Program {
        /// <summary>
        /// C - AtCoder Magics 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc354/tasks/abc354_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var cards = new Dictionary<int, KeyValuePair<int, int>>();

            for (var i = 1; i <= n; i++) {
                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) return;
                cards.Add(
                    i,
                    new KeyValuePair<int, int>(
                        Convert.ToInt32(conditions[0]), Convert.ToInt32(conditions[1]))
                );
            }

            for (var i = 1; i < n; i++) {
                if (!cards.ContainsKey(i)) continue;
                var a_i = cards[i].Key;
                var c_i = cards[i].Value;
                for (var j = i + 1; j <= n; j++) {
                    if (!cards.ContainsKey(j)) continue;
                    var t_a = cards[j].Key;
                    var t_c = cards[j].Value;

                    // 比較対象のデータが弱い場合
                    if (a_i > t_a && c_i < t_c) {
                        cards.Remove(j);

                    // 比較元のデータが弱い場合
                    } else if (t_a > a_i && t_c < c_i) {
                        cards.Remove(i);
                        break;
                    }
                }
            }

            var result = new List<int>();
            foreach (var c in cards) {
                result.Add(c.Key);
            }
            result.Sort();

            Console.WriteLine(result.Count);
            Console.Write(result[0]);
            for (var i = 1; i < result.Count; i++) {
                Console.Write($" {result[i]}");
            }
            Console.WriteLine();
        }
    }
}
