using System.Collections.Generic;

namespace r6_1116_assingment_A {
    internal class Program {
        /// <summary>
        /// A - 123233
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc380/tasks/abc380_a</remarks>
        static void Main() {
            var line = Console.ReadLine();
            if (string.IsNullOrEmpty(line)) return;
            var charCounts = new Dictionary<char, int>();
            foreach (var c in line) {
                if (!charCounts.ContainsKey(c)) charCounts.Add(c, 0);
                charCounts[c]++;
            }
            var result = charCounts.ContainsKey('1') && charCounts.ContainsKey('2') && charCounts.ContainsKey('3');
            if (result) {
                result = charCounts['1'] == 1 && charCounts['2'] == 2 && charCounts['3'] == 3;
            }
            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
