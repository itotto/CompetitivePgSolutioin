using System.Collections.Generic;

namespace A05_Three_Cards {
    internal class Program {
        /// <summary>
        /// A05 - Three Cards
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/tessoku-book/tasks/tessoku_book_e</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var k = Convert.ToInt32(conditions[1]);

            var cnt = 0;
            for (var i = 1; i <= n; i++) { // Red
                for ( var j = 1; j <= n; j++) { // Blue
                    var x = k - i - j;
                    if (1 <= x && x <= n) cnt++;
                    //Console.WriteLine($"{k} - {i} - {j} = {x}");
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
