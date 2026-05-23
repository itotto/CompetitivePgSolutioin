using System.Collections.Generic;

namespace r8_0509_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Array 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc457/tasks/abc457_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var data = new Dictionary<int, int>();
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            for (var i = 0; i < conditions.Length; i++) {
                data.Add(i + 1, Convert.ToInt32(conditions[i]));
            }

            var x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(data[x]);
        }
    }
}
