using System.Collections.Generic;

namespace r7_0412_assingment_D {
    internal class Program {
        /// <summary>
        /// D - Logical Filling
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc401/tasks/abc401_d</remarks>
        static void Main() {
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            var n = Convert.ToInt32(inputs[0]);
            var k = Convert.ToInt32(inputs[1]);

            var line = Console.ReadLine();
            if (string.IsNullOrEmpty(line)) return;

            var totalOCount = 0;
            foreach (var c in line) {
                if (c == 'o') totalOCount++;
            }
        }
    }
}
