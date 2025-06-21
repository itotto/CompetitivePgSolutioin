using System.Collections.Generic;
using System.Text;

namespace r7_0614_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Reverse Proxy
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc410/tasks/abc410_b</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var q = Convert.ToInt32(conditions1[1]);

            var boxies = new Dictionary<int, int>();
            for (var i = 1; i <= n; i++) { boxies.Add(i, 0); }

            var answers = new int[q];

            var conditions2 = Console.ReadLine()?.Split(' ');
            if (conditions2 == null) return;

            for (var i = 0; i < q; i++) {
                var x_i = Convert.ToInt32(conditions2[i]);
                if (x_i == 0) {
                    var minV = boxies[1];
                    var minPos = 1;
                    for (var j = 2; j <= n; j++) {
                        if (boxies[j] < minV) {
                            minV = boxies[j];
                            minPos = j;
                        }
                    }
                    answers[i] = minPos;
                    boxies[minPos]++;
                } else if (x_i >= 1) {
                    boxies[x_i]++;
                    answers[i] = x_i;
                }
            }


            var result = new StringBuilder();
            for (var i = 0; i < q; i++) {
                result.Append($"{answers[i]} ");
            }
            result.Remove(result.Length - 1, 1);
            Console.WriteLine(result.ToString());
        }
    }
}
