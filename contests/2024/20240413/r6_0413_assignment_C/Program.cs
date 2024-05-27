using System.Collections.Generic;

namespace r6_0413_assignment_C {
    internal class Program {
        /// <summary>
        /// C - Airport Code 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc349/tasks/abc349_c</remarks>
        static void Main() {
            var s = Console.ReadLine();
            var t = Console.ReadLine()?.ToLower();

            if (string.IsNullOrEmpty(s)) return;
            if (string.IsNullOrEmpty(t)) return;

            var r = false;
            var pos = 0;
            for (var i = 0; i < s.Length; i++) {
                if (s[i] != t[pos]) continue;
                pos++;
                if ((pos >= 3) || // 3文字一致
                    (pos == 2 && t[pos] == 'x')) { // 2文字一致+最後はx
                    r = true;
                    break;
                }
            }

            Console.WriteLine(r ? "Yes" : "No");
        }
    }
}
