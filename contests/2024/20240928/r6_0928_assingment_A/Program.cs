using System.Collections.Generic;

namespace r6_0928_assingment_A {
    internal class Program {
        /// <summary>
        /// A - September
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc373/tasks/abc373_a</remarks>
        static void Main() {
            const int EXEC_COUNT = 12;
            var cnt = 0;
            for (var i = 1; i <= EXEC_COUNT; i++) {
                var s_i = Console.ReadLine();
                if (string.IsNullOrEmpty(s_i)) continue;
                if (s_i.Length == i) cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
