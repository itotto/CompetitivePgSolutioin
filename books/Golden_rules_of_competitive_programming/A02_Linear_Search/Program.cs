using System.Collections.Generic;

namespace A02_Linear_Search {
    internal class Program {
        /// <summary>
        /// A02 - Linear Search
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/tessoku-book/tasks/tessoku_book_b</remarks>
        static void Main() {
            var c = Console.ReadLine()?.Split(' ');
            if (c == null) return;

            var data = Console.ReadLine()?.Split(' ');
            if (data == null) return;
            var r = false;
            foreach (var d in data) {
                if (d == c[1]) {
                    r = true;
                    break;
                }
            }
            Console.WriteLine(r ? "Yes" : "No");
        }
    }
}
