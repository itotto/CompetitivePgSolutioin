using System.Collections.Generic;

namespace r7_0809_assingment_A {
    internal class Program {
        /// <summary>
        /// A - I'm a teapot 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc418/tasks/abc418_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            var isTea = false;
            if (n >= 3) {
                isTea = s.Substring(n - 3, 3) == "tea";
            }

            Console.WriteLine(isTea ? "Yes" : "No");
        }
    }
}
