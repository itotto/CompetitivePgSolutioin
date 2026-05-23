using System.Text;
using System.Collections.Generic;

namespace r8_0523_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Drop Blocks
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc459/tasks/abc459_c</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var q = Convert.ToInt32(conditions1[1]);

            var result = new StringBuilder();
            var squares = new Dictionary<int, int>();
            for (var i = 1; i <= q; i++) {
                var conditions2 = Console.ReadLine()?.Split(' ');
                if (conditions2 == null) return;
                var queryNo = Convert.ToInt32(conditions2[0]);
                var v = Convert.ToInt32(conditions2[1]);

                switch (queryNo) {
                    case 1:
                        if (squares.ContainsKey(v)) {
                            squares[v]++;
                        } else {
                            squares.Add(v, 1);

                            if (squares.Count == n) {
                                for(var j = 1; j <= n; j++) {
                                    squares[j]--;
                                    if (squares[j] == 0) squares.Remove(j);
                                }
                            }
                        }
                        break;

                    case 2:
                        var cnt = 0;
                        foreach (var s in squares.Values) {
                            if (s >= v) cnt++;
                        }
                        result.AppendLine(cnt.ToString());
                        break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
