using System.Collections.Generic;

namespace r6_1228_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Calculator
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc386/tasks/abc386_b</remarks>
        static void Main() {
            var line = Console.ReadLine();
            if (string.IsNullOrEmpty(line)) return;

            var cnt = 0;
            var pos = 0;
            while (true) {
                if (line[pos] == '0') {
                    if (pos + 1 < line.Length && line[pos + 1] == '0') {
                        pos++;
                    }
                }
                cnt++;
                if (++pos >= line.Length) break;
            }

            Console.WriteLine(cnt);
        }
    }
}
