using System.Collections.Generic;

namespace r6_0413_assignment_A {
    internal class Program {
        /// <summary>
        /// A - Zero Sum Game 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc349/tasks/abc349_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var points = Console.ReadLine()?.Split(' ');
            if (points == null) return;

            var sum = 0;
            //for (int i = 0; i < points.Length; i++) {
            foreach (var p in points ) {
                sum += Convert.ToInt32(p);
            }
            Console.WriteLine(sum * (-1));
        }
    }
}
