using System.Collections.Generic;

namespace r6_0803_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Transportation Expenses
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc365/tasks/abc365_c</remarks>
        static void Main() {
            // 
            var cs1 = Console.ReadLine()?.Split(' ');
            if (cs1 == null) return;
            var countOfMembers = Convert.ToInt32(cs1[0]);
            var budget = Convert.ToInt64(cs1[1]);

            var min = int.MaxValue;
            var max = int.MinValue;

            // 交通費
            var te = new int[countOfMembers];
            var cs2 = Console.ReadLine()?.Split(' ');
            if (cs2 == null) return;
            var idx = 0;
            foreach (var c in cs2) {
                var p = Convert.ToInt32(c);
                if (p < min) min = p;
                else if (p > max) max = p;
                te[idx++] = p;
            }

            var result = min;
            // 予算でまかなえる場合はinifinite
            if (max * countOfMembers <= budget) {
                result = -1;
            } else {

            }



            Console.WriteLine(result == -1 ? "inifinite" : result.ToString());
        }
    }
}
