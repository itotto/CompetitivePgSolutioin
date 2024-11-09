using System.Collections.Generic;

namespace r6_1109_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Strawberries
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc379/tasks/abc379_b</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var k = Convert.ToInt32(conditions1[1]);

            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            var goodToothCounts = new List<int>();
            var cnt = 0;
            foreach (var c in s) {
                if (c == 'O') cnt++;
                else {
                    if (cnt > 0) {
                        goodToothCounts.Add(cnt);
                        cnt = 0;
                    }
                }
            }

            if (cnt > 0) {
                goodToothCounts.Add(cnt);
            }

            var berryCount = 0;
            foreach (var tc in goodToothCounts) {
                berryCount += tc / k;
            }

            Console.WriteLine(berryCount);
        }
    }
}
