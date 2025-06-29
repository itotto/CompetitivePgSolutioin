using System.Collections.Generic;

namespace r7_0628_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Task Failed Successfully 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc412/tasks/abc412_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var cnt = 0;

            for (var i = 0; i < n; i++) {
                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) return;
                var a_i = Convert.ToInt32(conditions[0]);
                var b_i = Convert.ToInt32(conditions[1]);
                if (a_i < b_i) cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
