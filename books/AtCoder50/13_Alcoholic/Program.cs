using System.Collections.Generic;

namespace _13_Alcoholic {
    internal class Program {
        /// <summary>
        /// B - Alcoholic
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc189/tasks/abc189_b</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            long x = Convert.ToInt32(conditions[1]) * 100;

            long totalVolume = 0;
            var count = -1;
            for (var i = 1; i <= n; i++) {
                var conditions1 = Console.ReadLine()?.Split(' ');
                if (conditions1 == null) return;
                if (totalVolume > x) continue;
                totalVolume += Convert.ToInt32(conditions1[0]) * Convert.ToInt32(conditions1[1]); ;
                if (totalVolume > x) count = i;
            }

            Console.WriteLine(count);
        }
    }
}
