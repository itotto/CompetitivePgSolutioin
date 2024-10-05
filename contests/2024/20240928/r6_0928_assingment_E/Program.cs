using System.Collections.Generic;

namespace r6_0928_assingment_E {
    internal class Program {
        /// <summary>
        /// E - How to Win the Election
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc373/tasks/abc373_e</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var m = Convert.ToInt32(conditions1[1]);
            var k = Convert.ToInt32(conditions1[2]);

            // 投票状況を取得
            long openedCount = 0;
            var a_i = new List<long>();
            var conditions2 = Console.ReadLine()?.Split(' ');
            if (conditions2 == null) return;
            foreach (var c in conditions2) {
                var a_cnt = Convert.ToInt64(c);
                openedCount += a_cnt;
                a_i.Add(a_cnt);
            }

            // 未開票数
            long leftCount = k - openedCount;

            //Console.WriteLine($"N:{n}\tM:{m}\tK:{k}");
            //Console.WriteLine($"a_i.Count:{a_i.Count}\topenedCount:{openedCount}");
        }
    }
}
