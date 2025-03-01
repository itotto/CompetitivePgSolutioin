using System.Collections.Generic;

namespace r7_0215_assingment_B {
    internal class Program {
        /// <summary>
        /// B - A..B..C
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc393/tasks/abc393_b</remarks>
        static void Main() {
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            var count = 0;
            for (var i = 0; i < s.Length; i++) {
                if (s[i] != 'A') continue;

                // B → C と探していく
                for (var j = 1; j <= s.Length - i - 2; j++) {
                    if (s[i + j] != 'B') continue;
                    var c_index = i + j + j;
                    if (c_index >= s.Length) break;
                    if (s[c_index] == 'C') count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
