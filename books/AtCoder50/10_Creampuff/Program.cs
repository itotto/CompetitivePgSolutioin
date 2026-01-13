using System.Collections.Generic;

namespace _10_Creampuff {
    internal class Program {
        /// <summary>
        /// C - Cream puff
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc180/tasks/abc180_c</remarks>
        static void Main() {
            var n = Convert.ToInt64(Console.ReadLine());

            var stopInt = (long)Math.Floor(Math.Sqrt(n));

            var numbers = new Dictionary<long, bool> { {1, true }};
            if (n > 1) numbers.Add(n, false);

            for (long i = 2; i <= stopInt; i++) {
                if (n % i != 0) continue;

                if (!numbers.ContainsKey(i)) numbers.Add(i, true);

                var d = n / i;
                if (!numbers.ContainsKey(d)) numbers.Add(d, true);
            }

            var result = numbers.Keys.ToList();
            result.Sort();
            foreach (var r in result) Console.WriteLine(r);
        }
    }
}
