using System.Collections.Generic;
using System.Text;

namespace r7_0927_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Rotate and Sum Query
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc425/tasks/abc425_c</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var q = Convert.ToInt32(conditions1[1]);

            var data = new List<int>(capacity: n);
            var sumData = new List<long>(capacity: n);

            var conditions2 = Console.ReadLine()?.Split(' ');
            if (conditions2 == null) return;

            var d_1 = Convert.ToInt32(conditions2[0]);
            data.Add(d_1);
            sumData.Add(d_1);

            for (var i = 1; i < conditions2.Length; i++) {
                var d = Convert.ToInt32(conditions2[i]);
                data.Add(d);
                sumData.Add(sumData[i - 1] + d);
            }

            var currentPos = 0;
            long sumOffset = 0;

            var result = new StringBuilder();

            for (var i = 0; i < q; i++) {
                var conditions3 = Console.ReadLine()?.Split(' ');
                if (conditions3 == null) return;
                if (conditions3.Length == 2) {
                    currentPos += Convert.ToInt32(conditions3[1]);
                    if (currentPos >= n) currentPos -= n;
                    sumOffset = currentPos == 0 ? 0 : sumData[currentPos - 1];
                } else {
                    var l = Convert.ToInt32(conditions3[1]) - 1 + currentPos;
                    var r = Convert.ToInt32(conditions3[2]) - 1 + currentPos;

                    long answer = 0;

                    if (l < n && r < n) {
                        answer = sumData[r] - (l == 0 ? 0 : sumData[l - 1]);
                    } else if (l >= n && r >= n) {
                        l -= n;
                        r -= n;
                        var diff2 = l == 0 ? 0 : sumData[l - 1];
                        answer = sumData[r] - (l == 0 ? 0 : sumData[l - 1]);
                    } else { // lはnより小さくてrはn以上
                        // l -> n までの和と 0 -> rまでの和を足す
                        r -= n;
                        answer = sumData[n - 1] - (l == 0 ? 0 : sumData[l - 1]);
                        answer += r == 0 ? 0 : sumData[r - 1];
                    }
                    result.AppendLine(answer.ToString());
                }
            }
            Console.WriteLine(result);
        }
    }
}
