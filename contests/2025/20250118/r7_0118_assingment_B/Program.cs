using System.Collections.Generic;

namespace r7_0118_assingment_B {
    internal class Program {
        /// <summary>
        /// B - tcaF
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc389/tasks/abc389_b</remarks>
        static void Main() {
            var x = Convert.ToInt64(Console.ReadLine());
            var result = 2;
            while (true) {
                x = x / result;
                if (x == 1) break;
                result++;
            }
            Console.WriteLine(result);
        }
    }
}
