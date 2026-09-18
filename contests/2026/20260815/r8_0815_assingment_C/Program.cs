using System;
using System.Collections.Generic;

namespace r8_0815_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Cookies and Greedy Takahashi 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc471/tasks/abc471_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;

            var a_i = new int[n];
            for (var i = 0; i < conditions.Length; i++) {
                var v = Convert.ToInt32(conditions[i]);
                a_i[i] = v;
            }

            Array.Sort(a_i);

            var minValue = int.MaxValue;
            var currentPos = -1;
            if (a_i[0] > 0) {
                minValue = a_i[0];
                currentPos = 0;
            } else if (a_i[n -1] < 0) {
                minValue = a_i[n- 1];
                currentPos = n - 1;
            } else {
                var lastV = a_i[0];
                for (var i = 1; i < n; i++) {
                    if (a_i[i] > 0) {
                        currentPos = Math.Abs(a_i[i]) < Math.Abs(lastV) ? i : i - 1;
                        minValue = a_i[currentPos];
                        break;
                    }
                }
            }

            long distance = 0;


            Console.WriteLine(distance);
        }
    }
}
