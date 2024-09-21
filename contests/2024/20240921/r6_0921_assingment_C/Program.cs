using System.Collections.Generic;
using System.Text;

namespace r6_0921_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Count ABC Again
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var condition1 = Console.ReadLine()?.Split(' ');
            if (condition1 == null) return;
            var n = Convert.ToInt32(condition1[0]);
            var q = Convert.ToInt32(condition1[1]);

            var strc = Console.ReadLine()?.ToArray();

            var baseCnt = CountString(strc);

            var result = new StringBuilder();
            for (var i = 0; i < q; i++) {
                var conditions2 = Console.ReadLine()?.Split(' ');
                if (conditions2 == null) return;
                var x = Convert.ToInt32(conditions2[0]) - 1;
                var c = conditions2[1][0];

                var diff = CheckString(ref strc, x, c);
                baseCnt += diff;
                result.AppendLine(baseCnt.ToString());
            }
            Console.WriteLine(result.ToString());
        }

        static int CountString(char[] strc) {
            var cnt = 0;

            var i = 0;
            while (i < strc.Length - 2) {
                if (strc[i] != 'A') {
                    i++;
                    continue;
                }
                if (strc[i + 1] != 'B') {
                    i += strc[i + 1] == 'A' ? 1 : 2;
                    continue;
                }
                if (strc[i + 2] != 'C') {
                    i += strc[i + 2] == 'A' ? 2 : 3;
                    continue;
                }
                cnt++;
                i += 3;
            }
            return cnt;
        }

        static int CheckString(ref char[] strc, int pos, char newc) {
            var start = pos - 2;
            if (start < 0) start = 0;

            var end = pos + 2;
            if (strc.Length - 1 < end) end = strc.Length - 1;

            var orgS = new StringBuilder();
            for(var i = start; i <= end; i++) {
                orgS.Append(strc[i]);
            }
            var orgCnt = CountString(orgS.ToString().ToArray());

            strc[pos] = newc;
            var newS = new StringBuilder();
            for(var i = start; i <= end; i++) {
                newS.Append(strc[i]);
            }
            var newCnt = CountString(newS.ToString().ToArray());
            return newCnt - orgCnt;
        }
    }
}
