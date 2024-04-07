using System.Collections.Generic;
using System.Text;

namespace A04_BinaryRepresentation1 {
    internal class Program {
        /// <summary>
        /// A04 - Binary Representation 1
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/tessoku-book/tasks/tessoku_book_d</remarks>
        static void Main() {
            var nthPower = new List<int> {512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };
            var n = Convert.ToInt32(Console.ReadLine());

            var r = new StringBuilder();
            foreach (var p in nthPower) {
                if (n >= p) {
                    r.Append("1");
                    n -= p;
                } else {
                    r.Append("0");
                }
            }
            Console.WriteLine(r.ToString());
        }
    }
}
