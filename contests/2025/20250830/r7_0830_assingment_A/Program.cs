using System.Collections.Generic;

namespace r7_0830_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Misdelivery
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc421/tasks/abc421_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var residents_room = new Dictionary<int, string>();

            for (var i = 1; i <= n; i++) {
                var s = Console.ReadLine();
                if (string.IsNullOrEmpty(s)) continue;
                residents_room.Add(i, s);
            }

            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var x = Convert.ToInt32(conditions[0]);
            var y = conditions[1];
            if (string.IsNullOrEmpty(y)) return;

            Console.WriteLine(residents_room.ContainsKey(x) ? (residents_room[x] == y ? "Yes" : "No") : "No");
        }
    }
}
