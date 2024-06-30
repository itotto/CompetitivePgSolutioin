using System.Collections.Generic;

namespace r6_0622_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Count Takahashi
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc359/tasks/abc359_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var cnt = 0;
            for (var i = 0; i < n; i++) {
                if (Console.ReadLine() == "Takahashi") cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
