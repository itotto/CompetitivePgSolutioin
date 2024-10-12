using System.Collections.Generic;

namespace r6_1005_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Separated Lunch
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc374/tasks/abc374_c</remarks>
        static void Main() {
            var countOfGroups = Convert.ToInt32(Console.ReadLine());

            // グループの人数を取得
            var workList = new List<int>();
            long totalCount = 0;
            var cs = Console.ReadLine()?.Split(' ');
            if (cs == null) return;

            foreach (var c in cs) {
                var cnt = Convert.ToInt32(c);
                workList.Add(cnt);
                totalCount += cnt;
            }

            var target = totalCount / 2;
            if (totalCount % 2 == 1) target++;
            var minCount = target; // 最小値(これよりは小さくならない)

            // 結果
            long result = -1;
            var members = new List<int>();
            foreach (var w in workList) {
                if (w == target) {
                    result = target;
                    break;
                } else if (w < target) {
                    members.Add(w);
                }
            }

            if (result == 1) {
                // 先頭から確認していく
                for (var i = 0; i < members.Count; i++) {
                }
            }

            Console.WriteLine(result);
        }
    }
}
