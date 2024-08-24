using System.Collections.Generic;

namespace r6_0824_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Cut
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc368/tasks/abc368_a</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var k = Convert.ToInt32(conditions1[1]);

            var cards = Console.ReadLine()?.Split(' ');
            if (cards == null) return;
            for (var i = n - k; i < cards.Length; i++) {
                Console.Write($"{(i == n - k ? "" : " ")}{cards[i]}");
            }

            for (var i = 0; i < n - k; i++) {
                //Console.Write($"{(i == 0 ? "" : " ")}{cards[i]}");
                Console.Write($" {cards[i]}");
            }
            Console.WriteLine();
        }
    }
}
