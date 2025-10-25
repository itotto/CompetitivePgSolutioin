using System.Collections.Generic;

namespace r7_1025_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Too Many Requests 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc429/tasks/abc429_a</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var m = Convert.ToInt32(conditions[1]);
            for (var i = 1; i <= n; i++) {
                if (i <= m) Console.WriteLine("OK");
                else Console.WriteLine("Too Many Requests");
            }
        }
    }
}
