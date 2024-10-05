using System.Collections.Generic;

namespace r6_0928_assingment_B {
    internal class Program {
        /// <summary>
        /// B - 1D Keyboard
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc373/tasks/abc373_b</remarks>
        static void Main() {
            const string ALLCHAR = "BCDEFGHIJKLMNOPQRSTUVWXYZ";

            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            // 場所を覚える
            var charPos = new Dictionary<char, int>();
            for (var i = 0; i < s.Length; i++) {
                charPos.Add(s[i], i);
            }

            var totalLen = 0;
            var currentPos = charPos['A'];
            foreach (var c in ALLCHAR) {
                var nextPos = charPos[c];
                totalLen += currentPos > nextPos ? currentPos - nextPos : nextPos - currentPos;
                currentPos = nextPos;
            }
            Console.WriteLine(totalLen);
        }
    }
}
