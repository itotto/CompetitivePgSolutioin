using System.Collections.Generic;

namespace r6_0413_assignment_B {
    internal class Program {
        /// <summary>
        /// B - Commencement
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc349/tasks/abc349_b</remarks>
        static void Main() {
            var r = true;
            var s = Console.ReadLine();
            if (!string.IsNullOrEmpty(s)) {
                // 文字ごとの集計
                var charCount = new Dictionary<char, int>();
                foreach (var c in s ) {
                    if (charCount.ContainsKey(c)) { charCount[c]++; }
                    else charCount.Add(c, 1);
                }

                var countCount = new Dictionary<int, int>();
                // 集計
                foreach (var c in charCount.Values ) {
                    if (countCount.ContainsKey(c)) { countCount[c]++; }
                    else countCount.Add(c, 1);
                }
                // 確認
                foreach (var v in countCount.Values ) {
                    if (v != 0 && v != 2) {
                        r = false;
                        break;
                    }
                }
            }

            Console.WriteLine(r ? "Yes" : "No");
        }
    }
}
