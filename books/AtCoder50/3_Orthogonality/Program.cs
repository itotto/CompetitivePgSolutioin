using System.Collections.Generic;

namespace _3_Orthogonality {
    internal class Program {
        /// <summary>
        /// B - Orthogonality
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc188/tasks/abc188_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var a = Console.ReadLine()?.Split(' ');
            if (a == null) return;

            var b = Console.ReadLine()?.Split(' ');
            if (b == null) return;

            var result = 0;
            for (var i = 0; i < n; i++) {
                result += Convert.ToInt32(a[i]) * Convert.ToInt32(b[i]);
            }
            Console.WriteLine(result == 0 ? "Yes" : "No");
        }
    }
}
