using System.Text;
using System.Collections.Generic;

namespace r8_0228_assingment_B {
    internal class Program {
        /// <summary>
        /// B - mpp
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc447/tasks/abc447_b</remarks>
        static void Main() {
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            var countOfChars = new Dictionary<char, int>();
            var maxCount = 0;

            foreach (var c in s) {
                if (countOfChars.TryGetValue(c, out var v)) {
                    countOfChars[c] = ++v;
                } else {
                    v = 1;
                    countOfChars.Add(c, v);
                }
                if (v > maxCount) maxCount = v;
            }

            var result = new StringBuilder();

            foreach (var c in s) {
                if (countOfChars[c] != maxCount) result.Append(c);
            }
            Console.WriteLine(result);
        }
    }
}
