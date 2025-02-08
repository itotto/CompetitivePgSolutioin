using System.Collections.Generic;

namespace r7_0201_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Lucky Direction
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc391/tasks/abc391_a</remarks>
        static void Main() {
            var line = Console.ReadLine();
            if (string.IsNullOrEmpty(line)) return;
            Console.WriteLine(_oppositeDirections[line]);
        }

        static Dictionary<string, string> _oppositeDirections = new Dictionary<string, string> {
            {"N", "S" }, {"S", "N" }, {"E", "W" }, {"W", "E" }, {"NE", "SW" }, {"SW", "NE" }, {"NW", "SE" }, {"SE", "NW" },
        };
    }
}
