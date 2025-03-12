using System.Collections.Generic;
using System.Text;

namespace r7_0308_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Card Pile
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc396/tasks/abc396_b</remarks>
        static void Main() {
            var q = Convert.ToInt32(Console.ReadLine());

            var cards = new Stack<int>();
            var r = new StringBuilder();

            for (var i = 0; i < q; i++) {
                var cs = Console.ReadLine()?.Split(' ');
                if (cs == null) return;
                switch (cs.Length) {
                    case 1:
                        r.AppendLine(cards.Count == 0 ? "0" : cards.Pop().ToString());
                        break;

                    case 2:
                        var data = Convert.ToInt32(cs[1]);
                        cards.Push(data);
                        break;
                }
            }
            Console.WriteLine(r.ToString());
        }
    }
}
