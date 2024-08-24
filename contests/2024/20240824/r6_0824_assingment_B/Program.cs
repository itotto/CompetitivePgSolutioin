using System.Collections.Generic;

namespace r6_0824_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Decrease 2 max elements
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc368/tasks/abc368_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var data = new List<int>();
            foreach (var c in conditions) {
                data.Add(Convert.ToInt32(c));
            }

            var loopCnt = 0;
            while (true) {
                data.Sort((x,y) => y - x);
                data[0]--;
                data[1]--;
                loopCnt++;

                var cnt = 0;
                foreach (var d in data) {
                    if (d >= 1) cnt++;
                    if (cnt > 2) break;
                }
                if (cnt <= 1) break;
            }
            Console.WriteLine(loopCnt);
        }
    }
}
