using System.Collections.Generic;

namespace _5_Magic3 {
    internal class Program {
        /// <summary>
        /// B - Magic 3
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc190/tasks/abc190_b</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var s = Convert.ToInt32(conditions[1]);
            var d = Convert.ToInt32(conditions[2]);

            var result = false;

            for (var i = 0; i < n; i++) {
                var myTurn = Console.ReadLine()?.Split(' ');
                if (myTurn == null) return;
                var x = Convert.ToInt32(myTurn[0]);
                var y = Convert.ToInt32(myTurn[1]);
                if (x < s && y > d) result = true;
            }
            Console.WriteLine($"{(result ? "Yes" : "No")}");
        }
    }
}
