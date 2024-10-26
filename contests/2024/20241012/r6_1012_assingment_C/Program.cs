using System.Collections.Generic;

namespace r6_1012_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Spiral Rotation
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc375/tasks/abc375_c</remarks>
        static void Main() {
            var countOfGrids = Convert.ToInt32(Console.ReadLine());

            var grid = new char[countOfGrids, countOfGrids];

            for (var i = 0; i < countOfGrids; i++) {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) continue;
                for (var j = 0; j < line.Length; j++) {
                    grid[j, i] = line[j];
                }
            }

        }
    }
}
