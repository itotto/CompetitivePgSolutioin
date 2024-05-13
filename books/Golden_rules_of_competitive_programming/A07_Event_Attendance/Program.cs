using System.Collections.Generic;

namespace A07_Event_Attendance {
    internal class Program {
        /// <summary>
        /// A07 - Event Attendance
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/tessoku-book/tasks/tessoku_book_g</remarks>
        static void Main() {
            // イベント日数
            var dayCount = Convert.ToInt32(Console.ReadLine());

            // ユーザー数
            var countOfUsers = Convert.ToInt32(Console.ReadLine());

            // 初期化
            var days = new int[dayCount];
            for (var i = 0; i < dayCount; i++) days[i] = 0;

            for (var i = 0; i < countOfUsers; i++) {
                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) return;
                var fromDay = Convert.ToInt32(conditions[0]);
                var toDay = Convert.ToInt32(conditions[1]);
                days[fromDay - 1]++;
                if (toDay < dayCount) days[toDay]--;
            }

            for (var i = 1; i < dayCount; i++) {
                days[i] += days[i - 1];
            }

            foreach (var d in days) Console.WriteLine(d);
        }
    }
}
