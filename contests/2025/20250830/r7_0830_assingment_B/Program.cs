using System.Collections.Generic;
using System.Text;

namespace r7_0830_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Fibonacci Reversed 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc421/tasks/abc421_b</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var a_m_2 = Convert.ToInt64(conditions[0]);
            var a_m_1 = Convert.ToInt64(conditions[1]);

            long a_i = 0;
            for (var i = 3; i <= 10; i++) {
                a_i = ReverseNum(a_m_1 + a_m_2);
                a_m_2 = a_m_1;
                a_m_1 = a_i;
            }
            Console.WriteLine(a_i);
        }

        static long ReverseNum(long num) {
            var result = new StringBuilder();
            foreach (var c in num.ToString().Reverse()) {
                result.Append(c);
            }
            return Convert.ToInt64(result.ToString());
        }

    }
}
