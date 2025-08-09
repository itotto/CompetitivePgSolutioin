using System.Collections.Generic;

namespace r7_0809_assingment_B {
    internal class Program {
        /// <summary>
        /// B - You're a teapot
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc418/tasks/abc418_b</remarks>
        static void Main() {
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            var tPos = new List<int> { -1 }; // 1個目は使わない(offset)
            for (var i = 0; i < s.Length; i++) {
                if (s[i] == 't') tPos.Add(i + 1);
            }

            double max = double.MinValue ;
            for (var i = 1; i < tPos.Count - 1; i++) {
                var t_i = tPos[i];
                for (var j = i + 1; j < tPos.Count; j++) {
                    var t_j = tPos[j];
                    var t_length = t_j - t_i + 1;
                    if (t_length < 3) continue;

                    var ratio = (j - i - 1.0) / (t_length - 2.0);
                    if (max < ratio) max = ratio;
                }
            }
            Console.WriteLine(max < 0.0 ? "0" : max.ToString());
        }
    }
}
