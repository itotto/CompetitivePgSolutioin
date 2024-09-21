using System.Collections.Generic;
using System.Text;

namespace r6_0921_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Count ABC Again
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            const string TC = "ABC";
            var condition1 = Console.ReadLine()?.Split(' ');
            if (condition1 == null) return;
            var n = Convert.ToInt32(condition1[0]);
            var q = Convert.ToInt32(condition1[1]);

            var strc = Console.ReadLine()?.ToArray();

            var result = new StringBuilder();
            for (var i = 0; i < q; i++) {
                var conditions2 = Console.ReadLine()?.Split(' ');
                if (conditions2 == null) return;
                var x = Convert.ToInt32(conditions2[0]) - 1;
                var c = conditions2[1][0];

                strc[x] = c;

                result.AppendLine(CountString(strc, TC).ToString());
            }
            Console.WriteLine(result.ToString());
        }

        static int CountString(char[] strc, string ts) {
            var cnt = 0;
            var c1 = ts[0];
            var c2 = ts[1];
            var c3 = ts[2];

            var i = 0;
            while (i < strc.Length - 2) {
                if (strc[i] != c1) {
                    i++;
                    continue;
                }
                if (strc[i + 1] != c2) {
                    i += strc[i + 1] == c1 ? 1 : 2;
                    continue;
                }
                if (strc[i + 2] != c3) {
                    i += strc[i + 2] == c1 ? 2 : 3;
                    continue;
                }
                cnt++;
                i += 3;
            }
            return cnt;
        }
    }
}
