using System.Collections.Generic;

namespace r7_0607_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Conflict 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc409/tasks/abc409_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var t = Console.ReadLine();
            var a = Console.ReadLine();

            var r = false;
            for (var i = 0; i < n; i++) {
                if (t[i] == 'o' && a[i] == 'o') r = true;
            }
            Console.WriteLine(r ? "Yes" : "No");
        }
    }
}
