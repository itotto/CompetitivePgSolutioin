using System.Collections.Generic;

namespace A06_How_Many_Guests {
    internal class Program {
        /// <summary>
        /// A06 - How Many Guests
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/tessoku-book/tasks/math_and_algorithm_ai</remarks>
        static void Main() {
            // 条件入力
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var dayCountOfEvents = Convert.ToInt32(conditions1[0]);
            var qCounts = Convert.ToInt32(conditions1[1]);

            // 入場者数の合計を計算
            var totalVisitors = new int[dayCountOfEvents];
            var visitors = Console.ReadLine()?.Split(' ');
            if (visitors == null) return;
            totalVisitors[0] = Convert.ToInt32(visitors[0]);
            for (int i = 1; i < visitors.Length; i++) {
                totalVisitors[i] = totalVisitors[i - 1] + Convert.ToInt32(visitors[i]);
            }

            var answers = new List<int>(qCounts);
            for(var i = 0; i < qCounts; i++) {
                var conditions2 = Console.ReadLine()?.Split(' ');
                if (conditions2 == null) return;
                var fromDay = Convert.ToInt32(conditions2[0]);
                var toDay = Convert.ToInt32(conditions2[1]);

                if (fromDay == 1) {
                    answers.Add(totalVisitors[toDay - 1]);
                } else {
                    answers.Add(totalVisitors[toDay - 1] - totalVisitors[fromDay - 2]);
                }
            }

            // 結果の表示
            foreach (var a in answers) Console.WriteLine(a);
        }
    }
}
