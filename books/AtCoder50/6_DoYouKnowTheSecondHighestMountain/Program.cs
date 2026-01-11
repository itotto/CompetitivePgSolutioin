using System.Collections.Generic;

namespace _6_DoYouKnowTheSecondHighestMountain {
    internal class Program {
        /// <summary>
        /// B - Do you know the second highest mountain?
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc201/tasks/abc201_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var mountains = new Dictionary<int, string>();
            var mountainsHeights = new List<int>();

            for (var i = 1 ; i <= n; i++) {
                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) return;
                var h = Convert.ToInt32(conditions[1]);
                mountains.Add(h, conditions[0]);
                mountainsHeights.Add(h);
            }

            mountainsHeights.Sort();
            Console.WriteLine(mountains[mountainsHeights[mountainsHeights.Count - 2]]);
        }
    }
}
