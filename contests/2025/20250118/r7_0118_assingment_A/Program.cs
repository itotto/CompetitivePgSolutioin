using System.Collections.Generic;

namespace r7_0118_assingment_A {
    internal class Program {
        /// <summary>
        /// A - 9x9
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc389/tasks/abc389_a</remarks>
        static void Main() {
            var cs = Console.ReadLine();
            if (string.IsNullOrEmpty(cs)) return;
            Console.WriteLine((Convert.ToInt32(cs[0]) - 48) * (Convert.ToInt32(cs[2]) - 48));
        }
    }
}
