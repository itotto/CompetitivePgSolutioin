using System.Collections.Generic;

namespace r6_0928_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Max Ai+Bj
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc373/tasks/abc373_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var a_max = int.MinValue;
            var b_max = int.MinValue;

            var a_i_strs = Console.ReadLine()?.Split(' ');
            if (a_i_strs == null) return;
            foreach (var a_str in a_i_strs) {
                var a = Convert.ToInt32(a_str);
                if (a > a_max) a_max = a;
            }

            var b_i_strs = Console.ReadLine()?.Split(' ');
            if (b_i_strs == null) return;
            foreach (var b_str in b_i_strs) {
                var b = Convert.ToInt32(b_str);
                if (b > b_max) b_max = b;
            }
            Console.WriteLine(a_max + b_max);
        }
    }
}
