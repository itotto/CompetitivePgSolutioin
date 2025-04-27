using System.Collections.Generic;

namespace r7_0427_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Odd Position Sum
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc403/tasks/abc403_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var oddsum = 0;
            for (var i = 0; i < conditions.Length; i++) {
                // 奇数 == 添え字は偶数(1ずれる)
                if (i % 2 == 0) oddsum += Convert.ToInt32(conditions[i]);
            }
            Console.WriteLine(oddsum);
        }
    }
}
