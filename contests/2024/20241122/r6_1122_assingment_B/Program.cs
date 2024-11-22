using System.Collections.Generic;

namespace r6_1122_assingment_B {
    internal class Program {
        /// <summary>
        /// B - 1122 String
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc381/tasks/abc381_b</remarks>
        static void Main() {
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;
            var s_len = s.Length;

            var result = false;
            if (s_len % 2 == 0) {
                var r = true;
                for (var i = 0; i < s_len / 2 - 1; i++) {
                    if (s[2 * i] != s[2 * i + 1]) { r = false; break; }
                }

                if (r) {
                    var charsCount = new Dictionary<char, int>();
                    foreach (var c in s) {
                        if (!charsCount.ContainsKey(c)) charsCount.Add(c, 1);
                        else charsCount[c]++;
                    }

                    // 出現回数が2回か確認
                    foreach (var v in charsCount.Values) {
                        if (v != 2) {
                            r = false;
                            break;
                        }
                    }
                    if (r) result = true;
                }
            }

            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
