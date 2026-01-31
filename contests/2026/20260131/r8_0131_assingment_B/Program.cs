using System.Collections.Generic;

namespace r8_0131_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Setsubun 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc443/tasks/abc443_b</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var k = Convert.ToInt32(conditions[1]);

            var sum = n;
            var cnt = 0;
            if (n < k) {
                while (sum < k) {
                    cnt++;
                    sum += n + cnt;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
