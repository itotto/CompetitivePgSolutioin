using System.Collections.Generic;

namespace r6_0921_assingment_D {
    internal class Program {
        /// <summary>
        /// D - Buildings
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc372/tasks/abc372_d</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            // ビルの高さ
            var heights = new List<int>(n);
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            foreach (var d in inputs) {
                heights.Add(Convert.ToInt32(d));
            }

        }
    }
}
