using System.Collections.Generic;

namespace _17_Unexpressed {
    internal class Program {
        /// <summary>
        /// C - Unexpressed
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc193/tasks/abc193_c</remarks>
        static void Main() {
            var n = Convert.ToInt64(Console.ReadLine());

            var countOfNumbers = new Dictionary<long, bool>();
            for (var i = 2; i <= 100000; i++) {
                if (i > n) break;
                for (var j = 2; j <= 34; j++) {
                    long v = (long)Math.Pow(i, j);
                    if (v > n) break;
                    if (!countOfNumbers.ContainsKey(v)) countOfNumbers.Add(v, true);
                }
            }

            Console.WriteLine($"{n - countOfNumbers.Count}");
        }
    }
}
