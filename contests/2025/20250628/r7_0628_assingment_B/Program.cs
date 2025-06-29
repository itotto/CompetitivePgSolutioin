using System.Collections.Generic;

namespace r7_0628_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Precondition 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc412/tasks/abc412_b</remarks>
        static void Main() {
            var s = Console.ReadLine();
            var t = Console.ReadLine();
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return;

            var targetChars = new Dictionary<char, bool>();
            for (var i = 1; i < s.Length; i++) {
                if (s[i] <= 'Z') {
                    var c_before = s[i - 1];
                    if (!targetChars.ContainsKey(c_before)) targetChars.Add(c_before, true);
                }
            }

            var result = true;
            foreach (var c in targetChars.Keys) {
                if (t.IndexOf(c) == -1) {
                    result = false;
                    continue;
                }
            }
            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
